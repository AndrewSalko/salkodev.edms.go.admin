using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Newtonsoft.Json;
using salkodev.edms.admin.BaseWeb;
using salkodev.edms.admin.Login;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace salkodev.edms.admin.Orgs
{
	class OrganizationsManager
	{
		const string _URL_CREATE = "orgs/create";
		const string _URL_DELETE = "orgs/delete";
		const string _URL_MODIFY = "orgs/modify";
		const string _URL_READ_PATTERN = "orgs/{0}";

		IHttpClientHub _HttpClientHub;

		public OrganizationsManager(IHttpClientHub httpClientHub)
		{
			_HttpClientHub = httpClientHub ?? throw new ArgumentNullException(nameof(httpClientHub));
		}

		/// <summary>
		/// Створити організацію
		/// </summary>
		/// <param name="uid">Можна передати null (або uid у разі необхідності)</param>
		/// <param name="name"></param>
		/// <param name="description"></param>
		/// <param name="ownerUID"></param>
		/// <returns></returns>
		/// <exception cref="ApplicationException"></exception>
		public string Create(string uid, string name, string description, string ownerUID)
		{
			var req = new OrgCreateRequest();
			req.UID = uid;
			req.Name = name;
			req.Description = description;
			req.OwnerUID = ownerUID;

			string reqJson = req.Serialize();

			string url = WebRequestHelper.GetURL(_HttpClientHub.BaseURL, _URL_CREATE);
			string jsonResult = WebRequestHelper.MakePostRequest(_HttpClientHub.Client, url, reqJson, null, out HttpStatusCode resultCode);

			if (resultCode != HttpStatusCode.OK)
			{
				throw new ApplicationException(jsonResult);
			}

			var resp = ResultUID.Deserialize(jsonResult);

			return resp.UID;
		}//Create

		public OrgModifyRequest Read(string uid)
		{
			string urlRead = string.Format(_URL_READ_PATTERN, uid);

			string url = WebRequestHelper.GetURL(_HttpClientHub.BaseURL, urlRead);
			string jsonOrg = WebRequestHelper.MakeGetRequest(_HttpClientHub.Client, url, out HttpStatusCode resultCode);

			if (resultCode != HttpStatusCode.OK)
			{
				throw new ApplicationException(jsonOrg);
			}

			var org = JsonConvert.DeserializeObject<OrgModifyRequest>(jsonOrg);

			return org;
		}


		public string Modify(string uid, OrgModifyFields fields, string orgName, string description, string ownerUID)
		{
			var req = new OrgModifyRequest();
			req.UID = uid;  //required
			req.ModifyFields = (int)fields;

			req.Name = orgName;
			req.Description = description;
			req.OwnerUID = ownerUID;

			string reqJson = req.Serialize();

			string url = WebRequestHelper.GetURL(_HttpClientHub.BaseURL, _URL_MODIFY);
			string jsonResult = WebRequestHelper.MakePostRequest(_HttpClientHub.Client, url, reqJson, null, out HttpStatusCode resultCode);

			if (resultCode != HttpStatusCode.OK)
			{
				throw new ApplicationException(jsonResult);
			}

			return jsonResult;
		}

		public string Delete(string uid)
		{
			var req = new UIDRequest();
			req.UID = uid;

			string reqJson = req.Serialize();

			string url = WebRequestHelper.GetURL(_HttpClientHub.BaseURL, _URL_DELETE);
			string jsonResult = WebRequestHelper.MakeDelRequest(_HttpClientHub.Client, url, reqJson, null, out HttpStatusCode resultCode);

			if (resultCode != HttpStatusCode.OK)
			{
				throw new ApplicationException(jsonResult);
			}

			return jsonResult;
		}

	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using salkodev.edms.admin.BaseWeb;
using salkodev.edms.admin.Login;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace salkodev.edms.admin.Orgs
{
	class OrganizationsManager
	{
		const string _URL = "orgs/create";

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

			string url = WebRequestHelper.GetURL(_HttpClientHub.BaseURL, _URL);
			string jsonResult = WebRequestHelper.MakeRequest(_HttpClientHub.Client, url, reqJson, null, out HttpStatusCode resultCode);

			if (resultCode != HttpStatusCode.OK)
			{
				throw new ApplicationException(jsonResult);
			}

			var resp = ResultUID.Deserialize(jsonResult);

			return resp.UID;
		}

	}
}

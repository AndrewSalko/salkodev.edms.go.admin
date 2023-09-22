using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using salkodev.edms.admin.Departments;

namespace salkodev.edms.admin.BaseWeb
{
	abstract class BaseManager
	{
		protected IHttpClientHub _HttpClientHub;

		public BaseManager(IHttpClientHub httpClientHub)
		{
			_HttpClientHub = httpClientHub ?? throw new ArgumentNullException(nameof(httpClientHub));
		}

		protected virtual string _URLCreate
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		protected virtual string _URLReadPattern
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		protected virtual string _URLModify
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		protected virtual string _URLDelete
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		protected string _Create(string reqJson)
		{
			string url = WebRequestHelper.GetURL(_HttpClientHub.BaseURL, _URLCreate);
			string jsonResult = WebRequestHelper.MakePostRequest(_HttpClientHub.Client, url, reqJson, null, out HttpStatusCode resultCode);

			if (resultCode != HttpStatusCode.OK)
			{
				throw new ApplicationException(jsonResult);
			}

			var resp = ResultUID.Deserialize(jsonResult);

			return resp.UID;
		}

		protected string _Modify(string reqJson)
		{
			string url = WebRequestHelper.GetURL(_HttpClientHub.BaseURL, _URLModify);
			string jsonResult = WebRequestHelper.MakePostRequest(_HttpClientHub.Client, url, reqJson, null, out HttpStatusCode resultCode);

			if (resultCode != HttpStatusCode.OK)
			{
				throw new ApplicationException(jsonResult);
			}

			return jsonResult;
		}

		/// <summary>
		/// Зчитати інфо про об'єкт по uid (привести до вказаного типу)
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="uid"></param>
		/// <returns></returns>
		/// <exception cref="ApplicationException"></exception>
		public T Read<T>(string uid)
		{
			string urlRead = string.Format(_URLReadPattern, uid);

			string url = WebRequestHelper.GetURL(_HttpClientHub.BaseURL, urlRead);
			string jsonOrg = WebRequestHelper.MakeGetRequest(_HttpClientHub.Client, url, out HttpStatusCode resultCode);

			if (resultCode != HttpStatusCode.OK)
			{
				throw new ApplicationException(jsonOrg);
			}

			var obj = JsonConvert.DeserializeObject<T>(jsonOrg);

			return obj;
		}

		/// <summary>
		/// Видалити об'єкт по uid
		/// </summary>
		/// <param name="uid"></param>
		/// <returns></returns>
		/// <exception cref="ApplicationException"></exception>
		public string Delete(string uid)
		{
			var req = new UIDRequest
			{
				UID = uid
			};

			string reqJson = req.Serialize();

			string url = WebRequestHelper.GetURL(_HttpClientHub.BaseURL, _URLDelete);
			string jsonResult = WebRequestHelper.MakeDelRequest(_HttpClientHub.Client, url, reqJson, null, out HttpStatusCode resultCode);

			if (resultCode != HttpStatusCode.OK)
			{
				throw new ApplicationException(jsonResult);
			}

			return jsonResult;
		}



	}
}

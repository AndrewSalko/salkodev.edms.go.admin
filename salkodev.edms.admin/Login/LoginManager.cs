using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using salkodev.edms.admin.BaseWeb;

namespace salkodev.edms.admin.Login
{
	class LoginManager
	{
		const string _URL = "users/login";

		IHttpClientHub _HttpClientHub;

		public LoginManager(IHttpClientHub httpClientHub)
		{
			_HttpClientHub = httpClientHub ?? throw new ArgumentNullException(nameof(httpClientHub));
		}

		public string Login(string username, string password)
		{
			LoginRequest req = new LoginRequest();
			req.Email = username;
			req.Password = password;

			string reqJson = req.Serialize();

			string url = WebRequestHelper.GetURL(_HttpClientHub.BaseURL, _URL);
			string jsonResult = WebRequestHelper.MakeRequest(_HttpClientHub.Client, url, reqJson, null, out HttpStatusCode resultCode);

			if (resultCode != HttpStatusCode.OK)
			{
				throw new ApplicationException(jsonResult);
			}

			var resp = LoginResponse.Deserialize(jsonResult);

			return resp.Token;
		}

	}
}

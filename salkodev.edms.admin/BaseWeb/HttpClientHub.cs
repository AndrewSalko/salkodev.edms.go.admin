using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace salkodev.edms.admin.BaseWeb
{
	class HttpClientHub: IHttpClientHub
	{
		HttpClient _HttpClient = new HttpClient();

		public HttpClientHub(string baseURL)
		{
			if (string.IsNullOrWhiteSpace(baseURL))
				throw new ArgumentNullException(nameof(baseURL));

			BaseURL = baseURL;
		}

		public HttpClient Client
		{
			get
			{
				return _HttpClient;
			}
		}

		/// <summary>
		/// Base API URL
		/// </summary>
		public string BaseURL
		{
			get;
			private set;
		}

		/// <summary>
		/// Налаштує HttpClient на роботу з JWT-токеном
		/// </summary>
		public void AuthJWT(string authToken)
		{
			ServicePointManager.ServerCertificateValidationCallback = delegate
			{
				return true;
			};

			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
				| SecurityProtocolType.Tls11
				| SecurityProtocolType.Tls12;

			if (!string.IsNullOrEmpty(authToken))
			{
				_HttpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", authToken);
			}
		}


	}
}

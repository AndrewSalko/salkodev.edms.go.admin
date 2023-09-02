using System;
using System.Collections.Generic;
using System.Linq;
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


	}
}

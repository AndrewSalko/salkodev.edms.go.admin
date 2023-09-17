using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salkodev.edms.admin.BaseWeb
{
	interface IHttpClientHub
	{
		HttpClient Client
		{
			get;
		}

		/// <summary>
		/// Base API URL
		/// </summary>
		string BaseURL
		{
			get;
		}

		/// <summary>
		/// Налаштує HttpClient на роботу з JWT-токеном
		/// </summary>
		void AuthJWT(string authToken);

	}
}

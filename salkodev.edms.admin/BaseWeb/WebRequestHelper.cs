using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace salkodev.edms.admin.BaseWeb
{
	class WebRequestHelper
	{
		public static string GetURL(string baseURL, string url)
		{
			Uri baseUri = new Uri(baseURL);
			Uri resultUri = new Uri(baseUri, url);
			return resultUri.AbsoluteUri;
		}

		public static void PrepareClient(HttpClient httpClient, string token)
		{
			ServicePointManager.ServerCertificateValidationCallback = delegate
			{
				return true;
			};

			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

			if (!string.IsNullOrEmpty(token))
			{
				httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
			}
		}

		public static string MakePostRequest(HttpClient httpClient, string url, string requestParameters, string token, out HttpStatusCode resultCode)
		{
			return MakeRequest(httpClient, HttpMethod.Post, url, requestParameters, token, out resultCode);
		}

		public static string MakeDelRequest(HttpClient httpClient, string url, string requestParameters, string token, out HttpStatusCode resultCode)
		{
			return MakeRequest(httpClient, HttpMethod.Delete, url, requestParameters, token, out resultCode);
		}


		public static string MakeRequest(HttpClient httpClient, HttpMethod method, string url, string requestParameters, string token, out HttpStatusCode resultCode)
		{
			HttpResponseMessage responseMessage = null;

			var uri = new UriBuilder(url);

			PrepareClient(httpClient, token);

			var request = new HttpRequestMessage(method, uri.Uri);
			request.Content = new StringContent(requestParameters, Encoding.UTF8, "application/json");

			responseMessage = httpClient.SendAsync(request).Result;
			resultCode = responseMessage.StatusCode;

			return responseMessage.Content.ReadAsStringAsync().Result;
		}

	}
}

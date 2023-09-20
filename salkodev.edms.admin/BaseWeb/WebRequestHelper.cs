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

		public static string MakeGetRequest(HttpClient httpClient, string url, out HttpStatusCode resultCode)
		{
			return MakeRequest(httpClient, HttpMethod.Get, url, null, out resultCode);
		}

		public static string MakePostRequest(HttpClient httpClient, string url, string requestParameters, string token, out HttpStatusCode resultCode)
		{
			return MakeRequest(httpClient, HttpMethod.Post, url, requestParameters, out resultCode);
		}

		public static string MakeDelRequest(HttpClient httpClient, string url, string requestParameters, string token, out HttpStatusCode resultCode)
		{
			return MakeRequest(httpClient, HttpMethod.Delete, url, requestParameters, out resultCode);
		}


		public static string MakeRequest(HttpClient httpClient, HttpMethod method, string url, string requestParameters, out HttpStatusCode resultCode)
		{
			var uri = new UriBuilder(url);

			var request = new HttpRequestMessage(method, uri.Uri);

			if (!string.IsNullOrEmpty(requestParameters))
			{
				request.Content = new StringContent(requestParameters, Encoding.UTF8, "application/json");
			}

			HttpResponseMessage responseMessage = httpClient.SendAsync(request).Result;
			resultCode = responseMessage.StatusCode;

			return responseMessage.Content.ReadAsStringAsync().Result;
		}

	}
}

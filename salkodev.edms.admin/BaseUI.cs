using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using salkodev.edms.admin.BaseWeb;

namespace salkodev.edms.admin
{
	abstract class BaseUI
	{
		protected ILogger _Logger;
		protected IWin32Window _ParentWindow;
		protected IHttpClientHub _HttpClientHub;
		protected string _Token;

		public BaseUI(ILogger logger, IWin32Window parentWindow, IHttpClientHub httpClientHub, string token)
		{
			_Logger = logger ?? throw new ArgumentNullException(nameof(logger));
			_ParentWindow = parentWindow ?? throw new ArgumentNullException(nameof(parentWindow));
			_HttpClientHub = httpClientHub ?? throw new ArgumentNullException(nameof(httpClientHub));
			_Token = token;
		}

		protected virtual void _Perform()
		{
		}


		public void Perform()
		{
			try
			{
				_Perform();
			}
			catch (Exception ex)
			{
				ErrorUI.ShowException(_ParentWindow, ex);
			}
		}

	}
}

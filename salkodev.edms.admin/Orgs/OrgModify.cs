using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using salkodev.edms.admin.BaseWeb;

namespace salkodev.edms.admin.Orgs
{
	class OrgModify: BaseUI
	{
		public OrgModify(ILogger logger, IWin32Window parentWindow, IHttpClientHub httpClientHub, string token) : base(logger, parentWindow, httpClientHub, token)
		{
		}

		protected override void _Perform()
		{

		}
	}
}

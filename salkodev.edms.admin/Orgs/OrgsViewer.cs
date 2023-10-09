using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using salkodev.edms.admin.BaseWeb;

namespace salkodev.edms.admin.Orgs
{
	class OrgsViewer: BaseUI
	{
		public OrgsViewer(ILogger logger, IWin32Window parentWindow, IHttpClientHub httpClientHub, string token) : base(logger, parentWindow, httpClientHub, token)
		{
		}

		protected override void _Perform()
		{
			_HttpClientHub.AuthJWT(_Token);

			var orgManager = new Orgs.OrganizationsManager(_HttpClientHub);

			int page = 1;
			int perPage = 20;

			var orgViewForm = new OrgsViewForm();
			orgViewForm.Page = page;
			orgViewForm.PerPage = perPage;
			orgViewForm.OrgManager= orgManager;

			orgViewForm.ShowDialog(_ParentWindow);
		}

	}
}

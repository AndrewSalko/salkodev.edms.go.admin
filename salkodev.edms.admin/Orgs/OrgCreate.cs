using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using salkodev.edms.admin.BaseWeb;

namespace salkodev.edms.admin.Orgs
{
	class OrgCreate: BaseUI
	{
		public OrgCreate(ILogger logger, IWin32Window parentWindow, IHttpClientHub httpClientHub, string token) : base(logger, parentWindow, httpClientHub, token)
		{
		}

		protected override void _Perform()
		{
			var orgCreateForm = new Orgs.CreateOrgForm();

			if (orgCreateForm.ShowDialog(_ParentWindow) != DialogResult.OK)
			{
				return;
			}

			_HttpClientHub.AuthJWT(_Token);

			var orgManager = new Orgs.OrganizationsManager(_HttpClientHub);
			string uid = orgManager.Create(orgCreateForm.UID, orgCreateForm.OrgName, orgCreateForm.Description, orgCreateForm.OwnerUID);

			_Logger.Log($"Org created - uid:{uid}");
		}

	}
}

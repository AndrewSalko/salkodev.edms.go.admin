using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using salkodev.edms.admin.BaseWeb;

namespace salkodev.edms.admin.Orgs
{
	class OrgDelete: BaseUI
	{
		public OrgDelete(ILogger logger, IWin32Window parentWindow, IHttpClientHub httpClientHub, string token) : base(logger, parentWindow, httpClientHub, token)
		{
		}

		protected override void _Perform()
		{
			var uidForm = new UIDForm();
			uidForm.MainCaption = "Organization delete";

			if (uidForm.ShowDialog(_ParentWindow) != DialogResult.OK)
			{
				return;
			}

			try
			{
				_HttpClientHub.AuthJWT(_Token);

				var orgManager = new Orgs.OrganizationsManager(_HttpClientHub);
				string respJson = orgManager.Delete(uidForm.UID);

				_Logger.Log($"Org deleted: {respJson}");
			}
			catch (Exception ex)
			{
				ErrorUI.ShowException(_ParentWindow, ex);
			}
		}


	}
}

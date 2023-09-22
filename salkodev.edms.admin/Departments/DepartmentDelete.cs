using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using salkodev.edms.admin.BaseWeb;

namespace salkodev.edms.admin.Departments
{
	class DepartmentDelete : BaseUI
	{
		public DepartmentDelete(ILogger logger, IWin32Window parentWindow, IHttpClientHub httpClientHub, string token) : base(logger, parentWindow, httpClientHub, token)
		{
		}

		protected override void _Perform()
		{
			var uidForm = new UIDForm();
			uidForm.MainCaption = "Department delete";

			if (uidForm.ShowDialog(_ParentWindow) != DialogResult.OK)
			{
				return;
			}

			try
			{
				_HttpClientHub.AuthJWT(_Token);

				var depManager = new Departments.DepartmentsManager(_HttpClientHub);
				string respJson = depManager.Delete(uidForm.UID);

				_Logger.Log($"Department deleted: {respJson}");
			}
			catch (Exception ex)
			{
				ErrorUI.ShowException(_ParentWindow, ex);
			}
		}


	}
}

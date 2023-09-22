using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using salkodev.edms.admin.BaseWeb;

namespace salkodev.edms.admin.Departments
{
	class DepartmentCreate : BaseUI
	{
		public DepartmentCreate(ILogger logger, IWin32Window parentWindow, IHttpClientHub httpClientHub, string token) : base(logger, parentWindow, httpClientHub, token)
		{
		}

		protected override void _Perform()
		{
			var depCreateForm = new Departments.CreateDepartmentForm();

			if (depCreateForm.ShowDialog(_ParentWindow) != DialogResult.OK)
			{
				return;
			}

			_HttpClientHub.AuthJWT(_Token);

			var orgManager = new Departments.DepartmentsManager(_HttpClientHub);
			string uid = orgManager.Create(depCreateForm.UID, depCreateForm.DepartmentName, depCreateForm.Description, depCreateForm.OrganizationUID);

			_Logger.Log($"Department created - uid:{uid}");
		}

	}
}

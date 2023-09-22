using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using salkodev.edms.admin.BaseWeb;
using salkodev.edms.admin.Orgs;

namespace salkodev.edms.admin.Departments
{
	class DepartmentModify : BaseUI
	{
		public DepartmentModify(ILogger logger, IWin32Window parentWindow, IHttpClientHub httpClientHub, string token) : base(logger, parentWindow, httpClientHub, token)
		{
		}

		protected override void _Perform()
		{
			//показати запит щодо uid
			var uidForm = new UIDForm();
			uidForm.MainCaption = "Enter department uid for modification";
			if (uidForm.ShowDialog(_ParentWindow) != DialogResult.OK)
			{
				return;
			}

			string uid = uidForm.UID;

			_HttpClientHub.AuthJWT(_Token);
			var depManager = new DepartmentsManager(_HttpClientHub);

			//завантажимо наявні дані
			var dep = depManager.Read<DepartmentModifyRequest>(uid);

			var depCreateForm = new CreateDepartmentForm();
			depCreateForm.ModifyMode = true;
			depCreateForm.DepartmentName = dep.Name;
			depCreateForm.Description = dep.Description;
			depCreateForm.OrganizationUID = dep.OrganizationUID;
			depCreateForm.UID = uid;

			if (depCreateForm.ShowDialog(_ParentWindow) != DialogResult.OK)
			{
				return;
			}

			DepartmentModifyFields fields = DepartmentModifyFields.None;

			if (dep.Name != depCreateForm.DepartmentName)
			{
				fields |= DepartmentModifyFields.Name;
			}

			if (dep.Description != depCreateForm.Description)
			{
				fields |= DepartmentModifyFields.Description;
			}

			if (dep.OrganizationUID != depCreateForm.OrganizationUID)
			{
				fields |= DepartmentModifyFields.OrganizationUID;
			}

			depManager.Modify(dep.UID, fields, depCreateForm.DepartmentName, depCreateForm.Description, depCreateForm.OrganizationUID);

			_Logger.Log($"Department modified - uid:{uid}");
		}
	}
}

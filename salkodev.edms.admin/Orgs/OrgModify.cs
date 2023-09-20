using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
			//показати запит щодо uid
			var uidForm = new UIDForm();
			uidForm.MainCaption = "Enter organization uid for modification";
			if (uidForm.ShowDialog(_ParentWindow) != DialogResult.OK)
			{
				return;
			}

			string uid = uidForm.UID;

			_HttpClientHub.AuthJWT(_Token);
			var orgManager = new Orgs.OrganizationsManager(_HttpClientHub);

			//завантажимо наявні дані про організацію...
			var org = orgManager.Read(uid);

			var orgCreateForm = new Orgs.CreateOrgForm();
			orgCreateForm.ModifyMode = true;
			orgCreateForm.OrgName = org.Name;
			orgCreateForm.Description = org.Description;
			orgCreateForm.OwnerUID = org.OwnerUID;
			orgCreateForm.UID = uid;

			if (orgCreateForm.ShowDialog(_ParentWindow) != DialogResult.OK)
			{
				return;
			}

			OrgModifyFields fields = OrgModifyFields.None;

			if (org.Name != orgCreateForm.OrgName)
			{
				fields |= OrgModifyFields.OrganizationInfoName;
			}

			if (org.Description != orgCreateForm.Description)
			{
				fields |= OrgModifyFields.OrganizationInfoDescription;
			}

			if (org.OwnerUID != orgCreateForm.OwnerUID)
			{
				fields |= OrgModifyFields.OrganizationInfoOwnerUID;
			}

			orgManager.Modify(org.UID, fields, orgCreateForm.OrgName, orgCreateForm.Description, orgCreateForm.OwnerUID);

			_Logger.Log($"Org modified - uid:{uid}");
		}
	}
}

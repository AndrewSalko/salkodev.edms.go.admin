using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salkodev.edms.admin.Orgs
{
	/// <summary>
	/// See database_orgs orgs.go for declaration
	/// </summary>
	[Flags]
	enum OrgModifyFields: int 
	{
		None = 0,

		/// <summary>
		/// flag for modification Org Name
		/// </summary>
		OrganizationInfoName = 1,

		/// <summary>
		/// flag for modification Org Description
		/// </summary>
		OrganizationInfoDescription = 2,

		/// <summary>
		/// flag for modification Org OwnerUID (change owner user) 
		/// </summary>
		OrganizationInfoOwnerUID = 4
	}
}

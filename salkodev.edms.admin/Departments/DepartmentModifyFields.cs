using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salkodev.edms.admin.Departments
{
	/// <summary>
	/// See departments_.go for declaration
	/// </summary>
	[Flags]
	enum DepartmentModifyFields : int
	{
		None = 0,

		/// <summary>
		/// flag for modification org_uid
		/// </summary>
		OrganizationUID = 1,

		/// <summary>
		/// flag for modification Name
		/// </summary>
		Name = 2,

		/// <summary>
		/// flag for modification Description
		/// </summary>
		Description = 4
	}

}

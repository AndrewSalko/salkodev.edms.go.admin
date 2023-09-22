using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace salkodev.edms.admin.Departments
{
	public partial class CreateDepartmentForm : Form
	{
		public CreateDepartmentForm()
		{
			InitializeComponent();
		}

		public string DepartmentName
		{
			get
			{
				return _UidNameDescrControl.DisplayName;
			}
			set
			{
				_UidNameDescrControl.DisplayName = value;
			}
		}

		public string Description
		{
			get
			{
				return _UidNameDescrControl.Description;
			}
			set
			{
				_UidNameDescrControl.Description = value;
			}
		}

		public string UID
		{
			get
			{
				return _UidNameDescrControl.UID;
			}
			set
			{
				_UidNameDescrControl.UID = value;
			}
		}

		public string OrganizationUID
		{
			get
			{
				return _OrgUIDControl.OrganizationUID;
			}
			set
			{
				_OrgUIDControl.OrganizationUID = value;
			}
		}

		/// <summary>
		/// Встановіть true якщо режим "модифікації"
		/// </summary>
		public bool ModifyMode
		{
			get;
			set;
		}

		private void _CreateDepartmentForm_Load(object sender, EventArgs e)
		{
			if (ModifyMode)
			{
				Text = "Department Modification";
				_UidNameDescrControl.UIDReadOnly = true;
			}
		}

	}
}

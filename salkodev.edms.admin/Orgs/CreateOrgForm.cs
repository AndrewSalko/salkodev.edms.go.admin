using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace salkodev.edms.admin.Orgs
{
	public partial class CreateOrgForm : Form
	{
		public CreateOrgForm()
		{
			InitializeComponent();
		}

		public string OrgName
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

		public string OwnerUID
		{
			get
			{
				return _OwnerUIDControl.Text;
			}
			set
			{
				_OwnerUIDControl.Text = value;
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

		void _CreateOrgForm_Load(object sender, EventArgs e)
		{
			if (ModifyMode)
			{
				Text = "Modification";
				_UidNameDescrControl.UIDReadOnly = true;
			}

		}
	}
}

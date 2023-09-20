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
				return _TextBoxName.Text;
			}
			set
			{
				_TextBoxName.Text = value;
			}
		}

		public string Description
		{
			get
			{
				return _TextBoxDescr.Text;
			}
			set
			{
				_TextBoxDescr.Text = value;
			}
		}

		public string UID
		{
			get
			{
				return _TextBoxUID.Text;
			}
			set
			{
				_TextBoxUID.Text = value;
			}
		}

		public string OwnerUID
		{
			get
			{
				return _TextBoxOwnerUID.Text;
			}
			set
			{
				_TextBoxOwnerUID.Text = value;
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

		void CreateOrgForm_Load(object sender, EventArgs e)
		{
			if (ModifyMode)
			{
				Text = "Modification";
				_TextBoxUID.ReadOnly = true;
			}

		}
	}
}

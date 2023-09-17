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

		public string OrgName => _TextBoxName.Text;

		public string Description => _TextBoxDescr.Text;

		public string UID => _TextBoxUID.Text;

		public string OwnerUID => _TextBoxOwnerUID.Text;


	}
}

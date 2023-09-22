using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace salkodev.edms.admin
{
	public partial class OrgUIDControl : UserControl
	{
		public OrgUIDControl()
		{
			InitializeComponent();
		}

		public string OrganizationUID
		{
			get
			{
				return _TextBoxOrganizationUID.Text;
			}
			set
			{
				_TextBoxOrganizationUID.Text = value;
			}
		}
	}
}

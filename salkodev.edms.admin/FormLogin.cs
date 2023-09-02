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
	public partial class FormLogin : Form
	{
		public FormLogin()
		{
			InitializeComponent();
		}

		public string Login
		{
			get
			{
				return _TextBoxLogin.Text.Trim();
			}
			set
			{
				_TextBoxLogin.Text = value.Trim();
			}
		}

		public string Password => _TextBoxPass.Text;
	}
}

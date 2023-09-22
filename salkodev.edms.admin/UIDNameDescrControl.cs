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
	public partial class UIDNameDescrControl : UserControl
	{
		public UIDNameDescrControl()
		{
			InitializeComponent();
		}

		public string DisplayName
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

		public bool UIDReadOnly
		{
			get
			{
				return _TextBoxUID.ReadOnly;
			}
			set
			{
				_TextBoxUID.ReadOnly = value;
			}
		}

	}
}

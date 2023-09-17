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
	public partial class UIDForm : Form
	{
		public UIDForm()
		{
			InitializeComponent();
		}

		public string MainCaption
		{
			get
			{
				return _LabelCaption.Text;
			}
			set
			{
				_LabelCaption.Text = value;
			}
		}

		public string UID => _TextBoxUID.Text;

	}
}

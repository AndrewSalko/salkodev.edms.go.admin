using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salkodev.edms.admin
{
	class ErrorUI
	{

		public static void ShowException(IWin32Window parent, Exception ex)
		{
			if (ex== null)
				throw new ArgumentNullException(nameof(ex));

			FormError errForm = new FormError(ex);
			errForm.ShowDialog(parent);
		}
	}
}

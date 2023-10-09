using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salkodev.edms.admin.Pagination
{
	class ListViewInitializer
	{
		public ListViewInitializer()
		{
		}

		public void InitColumns(ListView listView, ObjectPropertyColumn[] columns)
		{
			if (columns == null || columns.Length == 0)
				throw new ArgumentNullException(nameof(columns));

			listView.Columns.Clear();

			foreach (var propColumn in columns)
			{
				ColumnHeader col= new ColumnHeader();
				col.Text = propColumn.Title;
				col.Width = propColumn.Width;
				col.Tag = propColumn;

				listView.Columns.Add(col);
			}


		}

	}
}

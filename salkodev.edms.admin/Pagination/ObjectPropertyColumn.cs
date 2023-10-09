using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salkodev.edms.admin.Pagination
{
	class ObjectPropertyColumn
	{
		public ObjectPropertyColumn(string name, string title, int width)
		{
			Name = name;
			Title = title;
			Width = width;
		}

		/// <summary>
		/// Name (as returned in result json)
		/// </summary>
		public string Name
		{
			get;
			set;
		}

		/// <summary>
		/// Title for display
		/// </summary>
		public string Title
		{
			get;
			set;
		}

		public int Width
		{
			get;
			set;
		}

	}
}

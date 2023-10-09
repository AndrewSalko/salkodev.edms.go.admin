using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace salkodev.edms.admin.Pagination
{
	/// <summary>
	/// pagination object (json response)
	/// </summary>
	class PaginationInfo
	{

		[JsonProperty("total_records")]
		public int TotalRecords
		{
			get;
			set;
		}

		[JsonProperty("current_page")]
		public int CurrentPage
		{
			get;
			set;
		}

		[JsonProperty("next_page")]
		public int NextPage
		{
			get;
			set;
		}

		[JsonProperty("prev_page")]
		public int PrevPage
		{
			get;
			set;
		}

	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using salkodev.edms.admin.Pagination;

namespace salkodev.edms.admin.Orgs
{
	class OrgPaginationResponse: Pagination.PaginationResponse
	{
		[JsonProperty("data")]
		public OrgPaginationItem[] Data
		{
			get;
			set;
		}
	}
}

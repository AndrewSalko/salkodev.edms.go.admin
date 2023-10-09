using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace salkodev.edms.admin.Pagination
{
	class PaginationResponse
	{
		[JsonProperty("pagination")]
		public PaginationInfo Pagination
		{
			get;
			set;
		}
	}
}

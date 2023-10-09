using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace salkodev.edms.admin.Orgs
{
	class OrgPaginationItem
	{
		[JsonProperty("id")]
		public string Id
		{
			get;
			set;
		}

		[JsonProperty("uid")]
		public string UID
		{
			get;
			set;
		}

		[JsonProperty("name")]
		public string Name
		{
			get;
			set;
		}

		[JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
		public string Description
		{
			get;
			set;
		}

		[JsonProperty("owner_uid")]
		public string OwnerUID
		{
			get;
			set;
		}

		[JsonProperty("creation_time")]
		public DateTime CreationTime
		{
			get;
			set;
		}

	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace salkodev.edms.admin.Orgs
{
	/// <summary>
	///
	///	Go:	CreateOrganizationRequest
	/// </summary>
	class OrgCreateRequest
	{
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


		public virtual string Serialize()
		{
			var json = JsonConvert.SerializeObject(this);
			return json;
		}


	}

}

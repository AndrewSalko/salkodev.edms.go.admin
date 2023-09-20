using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace salkodev.edms.admin.Orgs
{
	class OrgModifyRequest: OrgCreateRequest
	{

		[JsonProperty("modify_fields")]

		public int ModifyFields
		{
			get;
			set;
		}

		public override string Serialize()
		{
			var json = JsonConvert.SerializeObject(this);
			return json;
		}


	}
}

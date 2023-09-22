using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace salkodev.edms.admin.Departments
{
	class DepartmentCreateRequest
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

		[JsonProperty("org_uid")]
		public string OrganizationUID
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

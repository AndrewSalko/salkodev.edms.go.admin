using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using salkodev.edms.admin.Login;

namespace salkodev.edms.admin
{
	class ResultUID
	{
		public ResultUID()
		{
		}

		[JsonProperty("uid")]
		public string UID
		{
			get;
			set;
		}

		public static ResultUID Deserialize(string json)
		{
			var resp = JsonConvert.DeserializeObject<ResultUID>(json);
			return resp;
		}


	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace salkodev.edms.admin
{
	class UIDRequest
	{

		public UIDRequest()
		{
		}

		[JsonProperty("uid")]
		public string UID
		{
			get;
			set;
		}

		public string Serialize()
		{
			var json = JsonConvert.SerializeObject(this);
			return json;
		}


	}
}

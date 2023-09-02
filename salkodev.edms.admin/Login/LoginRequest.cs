using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace salkodev.edms.admin.Login
{
	class LoginRequest
	{
		public LoginRequest()
		{
		}

		[JsonProperty("email")]
		public string Email
		{
			get;
			set;
		}

		[JsonProperty("password")]
		public string Password
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

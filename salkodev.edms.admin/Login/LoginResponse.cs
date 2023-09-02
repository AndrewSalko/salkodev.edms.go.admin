using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace salkodev.edms.admin.Login
{
	class LoginResponse
	{
		[JsonProperty("token")]
		public string Token
		{
			get;
			set;
		}

		public static LoginResponse Deserialize(string json)
		{
			var resp = JsonConvert.DeserializeObject<LoginResponse>(json);
			return resp;
		}


}
}

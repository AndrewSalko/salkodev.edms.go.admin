using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Newtonsoft.Json;
using salkodev.edms.admin.BaseWeb;

namespace salkodev.edms.admin.Orgs
{
	class OrganizationsManager: BaseWeb.BaseManager
	{
		public OrganizationsManager(IHttpClientHub httpClientHub) : base(httpClientHub)
		{
		}

		protected override string _URLCreate => "orgs/create";
		protected override string _URLDelete => "orgs/delete";
		protected override string _URLModify => "orgs/modify";
		protected override string _URLReadPattern => "orgs/{0}";

		/// <summary>
		/// Створити організацію
		/// </summary>
		/// <param name="uid">Можна передати null (або uid у разі необхідності)</param>
		/// <param name="name"></param>
		/// <param name="description"></param>
		/// <param name="ownerUID"></param>
		/// <returns></returns>
		/// <exception cref="ApplicationException"></exception>
		public string Create(string uid, string name, string description, string ownerUID)
		{
			var req = new OrgCreateRequest
			{
				UID = uid,
				Name = name,
				Description = description,
				OwnerUID = ownerUID
			};

			string reqJson = req.Serialize();
			return _Create(reqJson);
		}//Create

		public string Modify(string uid, OrgModifyFields fields, string orgName, string description, string ownerUID)
		{
			var req = new OrgModifyRequest
			{
				UID = uid,  //required
				ModifyFields = (int)fields,

				Name = orgName,
				Description = description,
				OwnerUID = ownerUID
			};

			string reqJson = req.Serialize();
			return _Modify(reqJson);
		}
	}
}

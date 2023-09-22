using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using salkodev.edms.admin.BaseWeb;
using salkodev.edms.admin.Orgs;

namespace salkodev.edms.admin.Departments
{
	class DepartmentsManager: BaseWeb.BaseManager
	{
		public DepartmentsManager(IHttpClientHub httpClientHub) : base(httpClientHub)
		{
		}

		protected override string _URLCreate => "departments/create";
		protected override string _URLDelete => "departments/delete";
		protected override string _URLReadPattern => "departments/{0}";
		protected override string _URLModify => "departments/modify";


		/// <summary>
		/// Створити підрозділ
		/// </summary>
		/// <param name="uid">Можна передати null (або uid у разі необхідності)</param>
		/// <param name="name"></param>
		/// <param name="description"></param>
		/// <param name="orgUID">Організація, до якої належить підрозділ (обов'язкове)</param>
		/// <returns></returns>
		/// <exception cref="ApplicationException"></exception>
		public string Create(string uid, string name, string description, string orgUID)
		{
			var req = new DepartmentCreateRequest
			{
				UID = uid,
				Name = name,
				Description = description,
				OrganizationUID = orgUID
			};

			string reqJson = req.Serialize();

			return _Create(reqJson);
		}//Create


		public string Modify(string uid, DepartmentModifyFields fields, string name, string description, string orgUID)
		{
			var req = new DepartmentModifyRequest
			{
				UID = uid,  //required
				ModifyFields = (int)fields,

				Name = name,
				Description = description,
				OrganizationUID = orgUID
			};

			string reqJson = req.Serialize();

			return _Modify(reqJson);
		}

	}
}

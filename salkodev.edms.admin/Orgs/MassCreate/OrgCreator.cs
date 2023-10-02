using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using salkodev.edms.admin.BaseWeb;

namespace salkodev.edms.admin.Orgs.MassCreate
{
	/// <summary>
	/// Для масового створення тест-організацій
	/// </summary>
	class OrgCreator: BaseUI
	{
		public OrgCreator(ILogger logger, IWin32Window parentWindow, IHttpClientHub httpClientHub, string token) : base(logger, parentWindow, httpClientHub, token)
		{
		}

		protected override void _Perform()
		{
			_HttpClientHub.AuthJWT(_Token);

			var orgManager = new Orgs.OrganizationsManager(_HttpClientHub);

			int orgCount = 127;

			var now = DateTime.Now;
			string datePart = string.Format("{0:yyyy.MM.dd_HH_mm_ss}", now);

			int tick = Environment.TickCount;

			for(int i = 0; i < orgCount; i++)
			{
				string orgName = $"Test organization {i} - {datePart}";
				string orgDescr = "Test description " + Guid.NewGuid().ToString();

				string uid = orgManager.Create(null, orgName, orgDescr, null); 

				//_Logger.Log($"Org created - uid:{uid} name: {orgName}");
			}

			tick = Environment.TickCount - tick;

			_Logger.Log($"Created {orgCount} organizations for {tick} ms");
		}


	}
}

using Newtonsoft.Json.Linq;
using salkodev.edms.admin.BaseWeb;
using salkodev.edms.admin.Login;

namespace salkodev.edms.admin
{
	public partial class FormMain : Form, ILogger
	{
		IHttpClientHub _HttpClientHub;

		public FormMain()
		{
			InitializeComponent();
		}

		void _FormMain_Load(object sender, EventArgs e)
		{
			_HttpClientHub = new HttpClientHub(@"http://localhost:8080");
		}

		string _Token;

		void _ButtonLogin_Click(object sender, EventArgs e)
		{
			var loginForm = new FormLogin();
			loginForm.Login = "admin@system";

			if (loginForm.ShowDialog(this) != DialogResult.OK)
			{
				return;
			}

			try
			{
				var loginManager = new LoginManager(_HttpClientHub);
				string token = loginManager.Login(loginForm.Login, loginForm.Password);

				_TextBoxToken.Text = token;
				_Token = token;
				_LabelLoggedStatus.Text = $"Logged in: {DateTime.Now}";
			}
			catch (Exception ex)
			{
				ErrorUI.ShowException(this, ex);
			}
		}

		void _ButtonCopyToClipboard_Click(object sender, EventArgs e)
		{
			try
			{
				Clipboard.SetText(_TextBoxToken.Text);
			}
			catch (Exception ex)
			{
				ErrorUI.ShowException(this, ex);
			}
		}

		void _ButtonCreateOrganization_Click(object sender, EventArgs e)
		{
			var orgCreate = new Orgs.OrgCreate(this, this, _HttpClientHub, _Token);
			orgCreate.Perform();
		}

		void _ButtonDeleteOrganization_Click(object sender, EventArgs e)
		{
			var orgDel = new Orgs.OrgDelete(this, this, _HttpClientHub, _Token);
			orgDel.Perform();
		}

		void _ButtonModifyOrganization_Click(object sender, EventArgs e)
		{
			var orgModify = new Orgs.OrgModify(this, this, _HttpClientHub, _Token);
			orgModify.Perform();
		}

		public void Log(string msg)
		{
			if (!string.IsNullOrEmpty(_TextBoxLog.Text))
			{
				_TextBoxLog.AppendText(Environment.NewLine);
			}

			_TextBoxLog.AppendText(msg);
		}

		private void _ButtonCreateDepartment_Click(object sender, EventArgs e)
		{
			var depCreate = new Departments.DepartmentCreate(this, this, _HttpClientHub, _Token);
			depCreate.Perform();
		}

		private void _ButtonDeleteDepartment_Click(object sender, EventArgs e)
		{
			var depDel = new Departments.DepartmentDelete(this, this, _HttpClientHub, _Token);
			depDel.Perform();
		}

		private void _ButtonModifyDepartment_Click(object sender, EventArgs e)
		{
			var depModify = new Departments.DepartmentModify(this, this, _HttpClientHub, _Token);
			depModify.Perform();
		}

		private void _ExitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void _CreateTestOrgsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var massOrgsCreator = new Orgs.MassCreate.OrgCreator(this, this, _HttpClientHub, _Token);
			massOrgsCreator.Perform();
		}
	}
}
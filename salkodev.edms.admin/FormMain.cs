using Newtonsoft.Json.Linq;
using salkodev.edms.admin.BaseWeb;
using salkodev.edms.admin.Login;

namespace salkodev.edms.admin
{
	public partial class FormMain : Form
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
			var orgCreateForm = new Orgs.CreateOrgForm();

			if (orgCreateForm.ShowDialog(this) != DialogResult.OK)
			{
				return;
			}

			try
			{
				_HttpClientHub.AuthJWT(_Token);

				var orgManager = new Orgs.OrganizationsManager(_HttpClientHub);
				string uid = orgManager.Create(orgCreateForm.UID, orgCreateForm.OrgName, orgCreateForm.Description, orgCreateForm.OwnerUID);

				_Log($"Org created - uid:{uid}");
			}
			catch (Exception ex)
			{
				ErrorUI.ShowException(this, ex);
			}
		}


		void _Log(string msg)
		{
			if (!string.IsNullOrEmpty(_TextBoxLog.Text))
			{
				_TextBoxLog.AppendText(Environment.NewLine);
			}

			_TextBoxLog.AppendText(msg);
		}

	}
}
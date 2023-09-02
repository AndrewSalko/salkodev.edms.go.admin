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

		private void _ButtonLogin_Click(object sender, EventArgs e)
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
				_LabelLoggedStatus.Text = $"Logged in: {DateTime.Now}";
			}
			catch (Exception ex)
			{
				ErrorUI.ShowException(this, ex);
			}
		}

		private void _ButtonCopyToClipboard_Click(object sender, EventArgs e)
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
	}
}
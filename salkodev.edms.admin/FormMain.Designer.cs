namespace salkodev.edms.admin
{
	partial class FormMain
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			_ButtonLogin = new Button();
			_LabelLoggedStatus = new Label();
			_TextBoxToken = new TextBox();
			_ButtonCopyToClipboard = new Button();
			_ButtonCreateOrganization = new Button();
			_TextBoxLog = new TextBox();
			SuspendLayout();
			// 
			// _ButtonLogin
			// 
			_ButtonLogin.Location = new Point(12, 12);
			_ButtonLogin.Name = "_ButtonLogin";
			_ButtonLogin.Size = new Size(75, 23);
			_ButtonLogin.TabIndex = 0;
			_ButtonLogin.Text = "Login";
			_ButtonLogin.UseVisualStyleBackColor = true;
			_ButtonLogin.Click += _ButtonLogin_Click;
			// 
			// _LabelLoggedStatus
			// 
			_LabelLoggedStatus.AutoSize = true;
			_LabelLoggedStatus.Location = new Point(117, 39);
			_LabelLoggedStatus.Name = "_LabelLoggedStatus";
			_LabelLoggedStatus.Size = new Size(50, 15);
			_LabelLoggedStatus.TabIndex = 4;
			_LabelLoggedStatus.Text = "Logged:";
			// 
			// _TextBoxToken
			// 
			_TextBoxToken.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			_TextBoxToken.Location = new Point(117, 13);
			_TextBoxToken.Name = "_TextBoxToken";
			_TextBoxToken.Size = new Size(409, 23);
			_TextBoxToken.TabIndex = 2;
			// 
			// _ButtonCopyToClipboard
			// 
			_ButtonCopyToClipboard.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			_ButtonCopyToClipboard.Location = new Point(532, 13);
			_ButtonCopyToClipboard.Name = "_ButtonCopyToClipboard";
			_ButtonCopyToClipboard.Size = new Size(75, 23);
			_ButtonCopyToClipboard.TabIndex = 5;
			_ButtonCopyToClipboard.Text = "Copy";
			_ButtonCopyToClipboard.UseVisualStyleBackColor = true;
			_ButtonCopyToClipboard.Click += _ButtonCopyToClipboard_Click;
			// 
			// _ButtonCreateOrganization
			// 
			_ButtonCreateOrganization.Location = new Point(12, 96);
			_ButtonCreateOrganization.Name = "_ButtonCreateOrganization";
			_ButtonCreateOrganization.Size = new Size(158, 23);
			_ButtonCreateOrganization.TabIndex = 6;
			_ButtonCreateOrganization.Text = "Create Organization";
			_ButtonCreateOrganization.UseVisualStyleBackColor = true;
			_ButtonCreateOrganization.Click += _ButtonCreateOrganization_Click;
			// 
			// _TextBoxLog
			// 
			_TextBoxLog.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			_TextBoxLog.Location = new Point(12, 209);
			_TextBoxLog.Multiline = true;
			_TextBoxLog.Name = "_TextBoxLog";
			_TextBoxLog.Size = new Size(595, 152);
			_TextBoxLog.TabIndex = 7;
			// 
			// FormMain
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(619, 402);
			Controls.Add(_TextBoxLog);
			Controls.Add(_ButtonCreateOrganization);
			Controls.Add(_ButtonCopyToClipboard);
			Controls.Add(_TextBoxToken);
			Controls.Add(_LabelLoggedStatus);
			Controls.Add(_ButtonLogin);
			Name = "FormMain";
			Text = "SalkoDev.EDMS Administrator";
			Load += _FormMain_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button _ButtonLogin;
		private Label _LabelLoggedStatus;
		private TextBox _TextBoxToken;
		private Button _ButtonCopyToClipboard;
		private Button _ButtonCreateOrganization;
		private TextBox _TextBoxLog;
	}
}
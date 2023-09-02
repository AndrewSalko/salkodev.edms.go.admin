namespace salkodev.edms.admin
{
	partial class FormLogin
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			_TextBoxLogin = new TextBox();
			_TextBoxPass = new TextBox();
			_LabelLogin = new Label();
			_LabelPass = new Label();
			_ButtonOK = new Button();
			_ButtonCancel = new Button();
			SuspendLayout();
			// 
			// _TextBoxLogin
			// 
			_TextBoxLogin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			_TextBoxLogin.Location = new Point(79, 20);
			_TextBoxLogin.Name = "_TextBoxLogin";
			_TextBoxLogin.Size = new Size(330, 23);
			_TextBoxLogin.TabIndex = 5;
			// 
			// _TextBoxPass
			// 
			_TextBoxPass.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			_TextBoxPass.Location = new Point(79, 49);
			_TextBoxPass.Name = "_TextBoxPass";
			_TextBoxPass.Size = new Size(330, 23);
			_TextBoxPass.TabIndex = 10;
			// 
			// _LabelLogin
			// 
			_LabelLogin.AutoSize = true;
			_LabelLogin.Location = new Point(13, 23);
			_LabelLogin.Name = "_LabelLogin";
			_LabelLogin.Size = new Size(40, 15);
			_LabelLogin.TabIndex = 2;
			_LabelLogin.Text = "Login:";
			// 
			// _LabelPass
			// 
			_LabelPass.AutoSize = true;
			_LabelPass.Location = new Point(13, 53);
			_LabelPass.Name = "_LabelPass";
			_LabelPass.Size = new Size(60, 15);
			_LabelPass.TabIndex = 9;
			_LabelPass.Text = "Password:";
			// 
			// _ButtonOK
			// 
			_ButtonOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			_ButtonOK.DialogResult = DialogResult.OK;
			_ButtonOK.Location = new Point(253, 95);
			_ButtonOK.Name = "_ButtonOK";
			_ButtonOK.Size = new Size(75, 23);
			_ButtonOK.TabIndex = 15;
			_ButtonOK.Text = "OK";
			_ButtonOK.UseVisualStyleBackColor = true;
			// 
			// _ButtonCancel
			// 
			_ButtonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			_ButtonCancel.DialogResult = DialogResult.Cancel;
			_ButtonCancel.Location = new Point(334, 95);
			_ButtonCancel.Name = "_ButtonCancel";
			_ButtonCancel.Size = new Size(75, 23);
			_ButtonCancel.TabIndex = 20;
			_ButtonCancel.Text = "Cancel";
			_ButtonCancel.UseVisualStyleBackColor = true;
			// 
			// FormLogin
			// 
			AcceptButton = _ButtonOK;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			CancelButton = _ButtonCancel;
			ClientSize = new Size(426, 130);
			Controls.Add(_ButtonCancel);
			Controls.Add(_ButtonOK);
			Controls.Add(_LabelPass);
			Controls.Add(_LabelLogin);
			Controls.Add(_TextBoxPass);
			Controls.Add(_TextBoxLogin);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "FormLogin";
			StartPosition = FormStartPosition.CenterParent;
			Text = "Login to system";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox _TextBoxLogin;
		private TextBox _TextBoxPass;
		private Label _LabelLogin;
		private Label _LabelPass;
		private Button _ButtonOK;
		private Button _ButtonCancel;
	}
}
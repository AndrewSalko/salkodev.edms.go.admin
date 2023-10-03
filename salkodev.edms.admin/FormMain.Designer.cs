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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
			_ButtonLogin = new Button();
			_LabelLoggedStatus = new Label();
			_TextBoxToken = new TextBox();
			_ButtonCopyToClipboard = new Button();
			_ButtonCreateOrganization = new Button();
			_TextBoxLog = new TextBox();
			_ButtonDeleteOrganization = new Button();
			_GroupBoxOrgs = new GroupBox();
			_ButtonModifyOrganization = new Button();
			_GroupBoxDepartments = new GroupBox();
			_ButtonModifyDepartment = new Button();
			_ButtonDeleteDepartment = new Button();
			_ButtonCreateDepartment = new Button();
			_MenuStrip = new MenuStrip();
			_FileToolStripMenuItem = new ToolStripMenuItem();
			_ExitToolStripMenuItem = new ToolStripMenuItem();
			organizationsToolStripMenuItem = new ToolStripMenuItem();
			_CreateTestOrgsToolStripMenuItem = new ToolStripMenuItem();
			_GroupBoxOrgs.SuspendLayout();
			_GroupBoxDepartments.SuspendLayout();
			_MenuStrip.SuspendLayout();
			SuspendLayout();
			// 
			// _ButtonLogin
			// 
			_ButtonLogin.Location = new Point(12, 31);
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
			_LabelLoggedStatus.Location = new Point(117, 58);
			_LabelLoggedStatus.Name = "_LabelLoggedStatus";
			_LabelLoggedStatus.Size = new Size(50, 15);
			_LabelLoggedStatus.TabIndex = 4;
			_LabelLoggedStatus.Text = "Logged:";
			// 
			// _TextBoxToken
			// 
			_TextBoxToken.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			_TextBoxToken.Location = new Point(117, 32);
			_TextBoxToken.Name = "_TextBoxToken";
			_TextBoxToken.Size = new Size(696, 23);
			_TextBoxToken.TabIndex = 2;
			// 
			// _ButtonCopyToClipboard
			// 
			_ButtonCopyToClipboard.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			_ButtonCopyToClipboard.Location = new Point(819, 32);
			_ButtonCopyToClipboard.Name = "_ButtonCopyToClipboard";
			_ButtonCopyToClipboard.Size = new Size(75, 23);
			_ButtonCopyToClipboard.TabIndex = 5;
			_ButtonCopyToClipboard.Text = "Copy";
			_ButtonCopyToClipboard.UseVisualStyleBackColor = true;
			_ButtonCopyToClipboard.Click += _ButtonCopyToClipboard_Click;
			// 
			// _ButtonCreateOrganization
			// 
			_ButtonCreateOrganization.Location = new Point(15, 32);
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
			_TextBoxLog.Location = new Point(12, 436);
			_TextBoxLog.Multiline = true;
			_TextBoxLog.Name = "_TextBoxLog";
			_TextBoxLog.Size = new Size(882, 152);
			_TextBoxLog.TabIndex = 7;
			// 
			// _ButtonDeleteOrganization
			// 
			_ButtonDeleteOrganization.Location = new Point(179, 32);
			_ButtonDeleteOrganization.Name = "_ButtonDeleteOrganization";
			_ButtonDeleteOrganization.Size = new Size(71, 23);
			_ButtonDeleteOrganization.TabIndex = 8;
			_ButtonDeleteOrganization.Text = "Delete";
			_ButtonDeleteOrganization.UseVisualStyleBackColor = true;
			_ButtonDeleteOrganization.Click += _ButtonDeleteOrganization_Click;
			// 
			// _GroupBoxOrgs
			// 
			_GroupBoxOrgs.Controls.Add(_ButtonModifyOrganization);
			_GroupBoxOrgs.Controls.Add(_ButtonCreateOrganization);
			_GroupBoxOrgs.Controls.Add(_ButtonDeleteOrganization);
			_GroupBoxOrgs.Location = new Point(12, 81);
			_GroupBoxOrgs.Name = "_GroupBoxOrgs";
			_GroupBoxOrgs.Size = new Size(352, 88);
			_GroupBoxOrgs.TabIndex = 9;
			_GroupBoxOrgs.TabStop = false;
			_GroupBoxOrgs.Text = "Organizations";
			// 
			// _ButtonModifyOrganization
			// 
			_ButtonModifyOrganization.Location = new Point(256, 32);
			_ButtonModifyOrganization.Name = "_ButtonModifyOrganization";
			_ButtonModifyOrganization.Size = new Size(75, 23);
			_ButtonModifyOrganization.TabIndex = 9;
			_ButtonModifyOrganization.Text = "Modify";
			_ButtonModifyOrganization.UseVisualStyleBackColor = true;
			_ButtonModifyOrganization.Click += _ButtonModifyOrganization_Click;
			// 
			// _GroupBoxDepartments
			// 
			_GroupBoxDepartments.Controls.Add(_ButtonModifyDepartment);
			_GroupBoxDepartments.Controls.Add(_ButtonDeleteDepartment);
			_GroupBoxDepartments.Controls.Add(_ButtonCreateDepartment);
			_GroupBoxDepartments.Location = new Point(380, 81);
			_GroupBoxDepartments.Name = "_GroupBoxDepartments";
			_GroupBoxDepartments.Size = new Size(330, 88);
			_GroupBoxDepartments.TabIndex = 10;
			_GroupBoxDepartments.TabStop = false;
			_GroupBoxDepartments.Text = "Departments";
			// 
			// _ButtonModifyDepartment
			// 
			_ButtonModifyDepartment.Location = new Point(233, 21);
			_ButtonModifyDepartment.Name = "_ButtonModifyDepartment";
			_ButtonModifyDepartment.Size = new Size(75, 23);
			_ButtonModifyDepartment.TabIndex = 2;
			_ButtonModifyDepartment.Text = "Modify";
			_ButtonModifyDepartment.UseVisualStyleBackColor = true;
			_ButtonModifyDepartment.Click += _ButtonModifyDepartment_Click;
			// 
			// _ButtonDeleteDepartment
			// 
			_ButtonDeleteDepartment.Location = new Point(152, 22);
			_ButtonDeleteDepartment.Name = "_ButtonDeleteDepartment";
			_ButtonDeleteDepartment.Size = new Size(75, 23);
			_ButtonDeleteDepartment.TabIndex = 1;
			_ButtonDeleteDepartment.Text = "Delete";
			_ButtonDeleteDepartment.UseVisualStyleBackColor = true;
			_ButtonDeleteDepartment.Click += _ButtonDeleteDepartment_Click;
			// 
			// _ButtonCreateDepartment
			// 
			_ButtonCreateDepartment.Location = new Point(6, 22);
			_ButtonCreateDepartment.Name = "_ButtonCreateDepartment";
			_ButtonCreateDepartment.Size = new Size(137, 23);
			_ButtonCreateDepartment.TabIndex = 0;
			_ButtonCreateDepartment.Text = "Create department";
			_ButtonCreateDepartment.UseVisualStyleBackColor = true;
			_ButtonCreateDepartment.Click += _ButtonCreateDepartment_Click;
			// 
			// _MenuStrip
			// 
			_MenuStrip.Items.AddRange(new ToolStripItem[] { _FileToolStripMenuItem, organizationsToolStripMenuItem });
			_MenuStrip.Location = new Point(0, 0);
			_MenuStrip.Name = "_MenuStrip";
			_MenuStrip.Size = new Size(906, 24);
			_MenuStrip.TabIndex = 11;
			_MenuStrip.Text = "menuStrip1";
			// 
			// _FileToolStripMenuItem
			// 
			_FileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { _ExitToolStripMenuItem });
			_FileToolStripMenuItem.Name = "_FileToolStripMenuItem";
			_FileToolStripMenuItem.Size = new Size(37, 20);
			_FileToolStripMenuItem.Text = "File";
			// 
			// _ExitToolStripMenuItem
			// 
			_ExitToolStripMenuItem.Name = "_ExitToolStripMenuItem";
			_ExitToolStripMenuItem.Size = new Size(93, 22);
			_ExitToolStripMenuItem.Text = "Exit";
			_ExitToolStripMenuItem.Click += _ExitToolStripMenuItem_Click;
			// 
			// organizationsToolStripMenuItem
			// 
			organizationsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { _CreateTestOrgsToolStripMenuItem });
			organizationsToolStripMenuItem.Name = "organizationsToolStripMenuItem";
			organizationsToolStripMenuItem.Size = new Size(92, 20);
			organizationsToolStripMenuItem.Text = "Organizations";
			// 
			// _CreateTestOrgsToolStripMenuItem
			// 
			_CreateTestOrgsToolStripMenuItem.Name = "_CreateTestOrgsToolStripMenuItem";
			_CreateTestOrgsToolStripMenuItem.Size = new Size(165, 22);
			_CreateTestOrgsToolStripMenuItem.Text = "Create test orgs...";
			_CreateTestOrgsToolStripMenuItem.Click += _CreateTestOrgsToolStripMenuItem_Click;
			// 
			// FormMain
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(906, 629);
			Controls.Add(_GroupBoxDepartments);
			Controls.Add(_GroupBoxOrgs);
			Controls.Add(_TextBoxLog);
			Controls.Add(_ButtonCopyToClipboard);
			Controls.Add(_TextBoxToken);
			Controls.Add(_LabelLoggedStatus);
			Controls.Add(_ButtonLogin);
			Controls.Add(_MenuStrip);
			Icon = (Icon)resources.GetObject("$this.Icon");
			MainMenuStrip = _MenuStrip;
			Name = "FormMain";
			Text = "SalkoDev.EDMS Administrator";
			Load += _FormMain_Load;
			_GroupBoxOrgs.ResumeLayout(false);
			_GroupBoxDepartments.ResumeLayout(false);
			_MenuStrip.ResumeLayout(false);
			_MenuStrip.PerformLayout();
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
		private Button _ButtonDeleteOrganization;
		private GroupBox _GroupBoxOrgs;
		private Button _ButtonModifyOrganization;
		private GroupBox _GroupBoxDepartments;
		private Button _ButtonDeleteDepartment;
		private Button _ButtonCreateDepartment;
		private Button _ButtonModifyDepartment;
		private MenuStrip _MenuStrip;
		private ToolStripMenuItem _FileToolStripMenuItem;
		private ToolStripMenuItem _ExitToolStripMenuItem;
		private ToolStripMenuItem organizationsToolStripMenuItem;
		private ToolStripMenuItem _CreateTestOrgsToolStripMenuItem;
	}
}
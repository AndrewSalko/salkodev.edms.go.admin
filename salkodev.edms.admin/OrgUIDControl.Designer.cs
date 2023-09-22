namespace salkodev.edms.admin
{
	partial class OrgUIDControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			_LabelOwnerUID = new Label();
			_TextBoxOrganizationUID = new TextBox();
			SuspendLayout();
			// 
			// _LabelOwnerUID
			// 
			_LabelOwnerUID.AutoSize = true;
			_LabelOwnerUID.Location = new Point(10, 7);
			_LabelOwnerUID.Name = "_LabelOwnerUID";
			_LabelOwnerUID.Size = new Size(100, 15);
			_LabelOwnerUID.TabIndex = 25;
			_LabelOwnerUID.Text = "Organization UID:";
			// 
			// _TextBoxOrganizationUID
			// 
			_TextBoxOrganizationUID.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			_TextBoxOrganizationUID.Location = new Point(116, 3);
			_TextBoxOrganizationUID.Name = "_TextBoxOrganizationUID";
			_TextBoxOrganizationUID.Size = new Size(336, 23);
			_TextBoxOrganizationUID.TabIndex = 26;
			// 
			// OrgUIDControl
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(_LabelOwnerUID);
			Controls.Add(_TextBoxOrganizationUID);
			Name = "OrgUIDControl";
			Size = new Size(455, 32);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label _LabelOwnerUID;
		private TextBox _TextBoxOrganizationUID;
	}
}

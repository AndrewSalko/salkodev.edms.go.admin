namespace salkodev.edms.admin.Orgs
{
	partial class CreateOrgForm
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
			_ButtonCancel = new Button();
			_ButtonOK = new Button();
			_LabelDescription = new Label();
			_LabelName = new Label();
			_TextBoxDescr = new TextBox();
			_TextBoxName = new TextBox();
			_LabelUID = new Label();
			_TextBoxUID = new TextBox();
			_LabelOwnerUID = new Label();
			_TextBoxOwnerUID = new TextBox();
			SuspendLayout();
			// 
			// _ButtonCancel
			// 
			_ButtonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			_ButtonCancel.DialogResult = DialogResult.Cancel;
			_ButtonCancel.Location = new Point(401, 192);
			_ButtonCancel.Name = "_ButtonCancel";
			_ButtonCancel.Size = new Size(75, 23);
			_ButtonCancel.TabIndex = 27;
			_ButtonCancel.Text = "Cancel";
			_ButtonCancel.UseVisualStyleBackColor = true;
			// 
			// _ButtonOK
			// 
			_ButtonOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			_ButtonOK.DialogResult = DialogResult.OK;
			_ButtonOK.Location = new Point(320, 192);
			_ButtonOK.Name = "_ButtonOK";
			_ButtonOK.Size = new Size(75, 23);
			_ButtonOK.TabIndex = 25;
			_ButtonOK.Text = "OK";
			_ButtonOK.UseVisualStyleBackColor = true;
			// 
			// _LabelDescription
			// 
			_LabelDescription.AutoSize = true;
			_LabelDescription.Location = new Point(21, 57);
			_LabelDescription.Name = "_LabelDescription";
			_LabelDescription.Size = new Size(70, 15);
			_LabelDescription.TabIndex = 6;
			_LabelDescription.Text = "Description:";
			// 
			// _LabelName
			// 
			_LabelName.AutoSize = true;
			_LabelName.Location = new Point(21, 28);
			_LabelName.Name = "_LabelName";
			_LabelName.Size = new Size(42, 15);
			_LabelName.TabIndex = 1;
			_LabelName.Text = "Name:";
			// 
			// _TextBoxDescr
			// 
			_TextBoxDescr.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			_TextBoxDescr.Location = new Point(97, 54);
			_TextBoxDescr.Name = "_TextBoxDescr";
			_TextBoxDescr.Size = new Size(379, 23);
			_TextBoxDescr.TabIndex = 10;
			// 
			// _TextBoxName
			// 
			_TextBoxName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			_TextBoxName.Location = new Point(97, 25);
			_TextBoxName.Name = "_TextBoxName";
			_TextBoxName.Size = new Size(379, 23);
			_TextBoxName.TabIndex = 4;
			// 
			// _LabelUID
			// 
			_LabelUID.AutoSize = true;
			_LabelUID.Location = new Point(21, 86);
			_LabelUID.Name = "_LabelUID";
			_LabelUID.Size = new Size(29, 15);
			_LabelUID.TabIndex = 12;
			_LabelUID.Text = "UID:";
			// 
			// _TextBoxUID
			// 
			_TextBoxUID.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			_TextBoxUID.Location = new Point(97, 83);
			_TextBoxUID.Name = "_TextBoxUID";
			_TextBoxUID.Size = new Size(379, 23);
			_TextBoxUID.TabIndex = 15;
			// 
			// _LabelOwnerUID
			// 
			_LabelOwnerUID.AutoSize = true;
			_LabelOwnerUID.Location = new Point(21, 115);
			_LabelOwnerUID.Name = "_LabelOwnerUID";
			_LabelOwnerUID.Size = new Size(67, 15);
			_LabelOwnerUID.TabIndex = 18;
			_LabelOwnerUID.Text = "Owner UID:";
			// 
			// _TextBoxOwnerUID
			// 
			_TextBoxOwnerUID.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			_TextBoxOwnerUID.Location = new Point(97, 112);
			_TextBoxOwnerUID.Name = "_TextBoxOwnerUID";
			_TextBoxOwnerUID.Size = new Size(379, 23);
			_TextBoxOwnerUID.TabIndex = 22;
			// 
			// CreateOrgForm
			// 
			AcceptButton = _ButtonOK;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			CancelButton = _ButtonCancel;
			ClientSize = new Size(488, 227);
			Controls.Add(_LabelOwnerUID);
			Controls.Add(_TextBoxOwnerUID);
			Controls.Add(_LabelUID);
			Controls.Add(_TextBoxUID);
			Controls.Add(_ButtonCancel);
			Controls.Add(_ButtonOK);
			Controls.Add(_LabelDescription);
			Controls.Add(_LabelName);
			Controls.Add(_TextBoxDescr);
			Controls.Add(_TextBoxName);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "CreateOrgForm";
			StartPosition = FormStartPosition.CenterParent;
			Text = "Create Organization";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button _ButtonCancel;
		private Button _ButtonOK;
		private Label _LabelDescription;
		private Label _LabelName;
		private TextBox _TextBoxDescr;
		private TextBox _TextBoxName;
		private Label _LabelUID;
		private TextBox _TextBoxUID;
		private Label _LabelOwnerUID;
		private TextBox _TextBoxOwnerUID;
	}
}
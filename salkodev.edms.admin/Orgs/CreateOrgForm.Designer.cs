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
			_UidNameDescrControl = new UIDNameDescrControl();
			_OwnerUIDControl = new OwnerUIDControl();
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
			// _UidNameDescrControl
			// 
			_UidNameDescrControl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			_UidNameDescrControl.Description = "";
			_UidNameDescrControl.DisplayName = "";
			_UidNameDescrControl.Location = new Point(12, 12);
			_UidNameDescrControl.Name = "_UidNameDescrControl";
			_UidNameDescrControl.Size = new Size(464, 93);
			_UidNameDescrControl.TabIndex = 28;
			_UidNameDescrControl.UID = "";
			_UidNameDescrControl.UIDReadOnly = false;
			// 
			// _OwnerUIDControl
			// 
			_OwnerUIDControl.Location = new Point(12, 105);
			_OwnerUIDControl.Name = "_OwnerUIDControl";
			_OwnerUIDControl.OwnerUID = "";
			_OwnerUIDControl.Size = new Size(464, 31);
			_OwnerUIDControl.TabIndex = 29;
			// 
			// CreateOrgForm
			// 
			AcceptButton = _ButtonOK;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			CancelButton = _ButtonCancel;
			ClientSize = new Size(488, 227);
			Controls.Add(_OwnerUIDControl);
			Controls.Add(_UidNameDescrControl);
			Controls.Add(_ButtonCancel);
			Controls.Add(_ButtonOK);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "CreateOrgForm";
			StartPosition = FormStartPosition.CenterParent;
			Text = "Create Organization";
			Load += _CreateOrgForm_Load;
			ResumeLayout(false);
		}

		#endregion

		private Button _ButtonCancel;
		private Button _ButtonOK;
		private UIDNameDescrControl _UidNameDescrControl;
		private OwnerUIDControl _OwnerUIDControl;
	}
}
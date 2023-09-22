namespace salkodev.edms.admin.Departments
{
	partial class CreateDepartmentForm
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
			_OrgUIDControl = new OrgUIDControl();
			SuspendLayout();
			// 
			// _ButtonCancel
			// 
			_ButtonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			_ButtonCancel.DialogResult = DialogResult.Cancel;
			_ButtonCancel.Location = new Point(426, 163);
			_ButtonCancel.Name = "_ButtonCancel";
			_ButtonCancel.Size = new Size(75, 23);
			_ButtonCancel.TabIndex = 29;
			_ButtonCancel.Text = "Cancel";
			_ButtonCancel.UseVisualStyleBackColor = true;
			// 
			// _ButtonOK
			// 
			_ButtonOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			_ButtonOK.DialogResult = DialogResult.OK;
			_ButtonOK.Location = new Point(345, 163);
			_ButtonOK.Name = "_ButtonOK";
			_ButtonOK.Size = new Size(75, 23);
			_ButtonOK.TabIndex = 28;
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
			_UidNameDescrControl.Size = new Size(489, 93);
			_UidNameDescrControl.TabIndex = 30;
			_UidNameDescrControl.UID = "";
			_UidNameDescrControl.UIDReadOnly = false;
			// 
			// _OrgUIDControl
			// 
			_OrgUIDControl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			_OrgUIDControl.Location = new Point(12, 111);
			_OrgUIDControl.Name = "_OrgUIDControl";
			_OrgUIDControl.OrganizationUID = "";
			_OrgUIDControl.Size = new Size(489, 32);
			_OrgUIDControl.TabIndex = 31;
			// 
			// CreateDepartmentForm
			// 
			AcceptButton = _ButtonOK;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			CancelButton = _ButtonCancel;
			ClientSize = new Size(513, 198);
			Controls.Add(_OrgUIDControl);
			Controls.Add(_UidNameDescrControl);
			Controls.Add(_ButtonCancel);
			Controls.Add(_ButtonOK);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "CreateDepartmentForm";
			StartPosition = FormStartPosition.CenterParent;
			Text = "Create Department";
			Load += _CreateDepartmentForm_Load;
			ResumeLayout(false);
		}

		#endregion

		private Button _ButtonCancel;
		private Button _ButtonOK;
		private UIDNameDescrControl _UidNameDescrControl;
		private OrgUIDControl _OrgUIDControl;
	}
}
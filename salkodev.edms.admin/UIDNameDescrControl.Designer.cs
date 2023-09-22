namespace salkodev.edms.admin
{
	partial class UIDNameDescrControl
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
			_LabelUID = new Label();
			_TextBoxUID = new TextBox();
			_LabelDescription = new Label();
			_LabelName = new Label();
			_TextBoxDescr = new TextBox();
			_TextBoxName = new TextBox();
			SuspendLayout();
			// 
			// _LabelUID
			// 
			_LabelUID.AutoSize = true;
			_LabelUID.Location = new Point(6, 64);
			_LabelUID.Name = "_LabelUID";
			_LabelUID.Size = new Size(29, 15);
			_LabelUID.TabIndex = 20;
			_LabelUID.Text = "UID:";
			// 
			// _TextBoxUID
			// 
			_TextBoxUID.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			_TextBoxUID.Location = new Point(82, 61);
			_TextBoxUID.Name = "_TextBoxUID";
			_TextBoxUID.Size = new Size(341, 23);
			_TextBoxUID.TabIndex = 21;
			// 
			// _LabelDescription
			// 
			_LabelDescription.AutoSize = true;
			_LabelDescription.Location = new Point(6, 35);
			_LabelDescription.Name = "_LabelDescription";
			_LabelDescription.Size = new Size(70, 15);
			_LabelDescription.TabIndex = 18;
			_LabelDescription.Text = "Description:";
			// 
			// _LabelName
			// 
			_LabelName.AutoSize = true;
			_LabelName.Location = new Point(6, 6);
			_LabelName.Name = "_LabelName";
			_LabelName.Size = new Size(42, 15);
			_LabelName.TabIndex = 16;
			_LabelName.Text = "Name:";
			// 
			// _TextBoxDescr
			// 
			_TextBoxDescr.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			_TextBoxDescr.Location = new Point(82, 32);
			_TextBoxDescr.Name = "_TextBoxDescr";
			_TextBoxDescr.Size = new Size(341, 23);
			_TextBoxDescr.TabIndex = 19;
			// 
			// _TextBoxName
			// 
			_TextBoxName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			_TextBoxName.Location = new Point(82, 3);
			_TextBoxName.Name = "_TextBoxName";
			_TextBoxName.Size = new Size(341, 23);
			_TextBoxName.TabIndex = 17;
			// 
			// UIDNameDescrControl
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(_LabelUID);
			Controls.Add(_TextBoxUID);
			Controls.Add(_LabelDescription);
			Controls.Add(_LabelName);
			Controls.Add(_TextBoxDescr);
			Controls.Add(_TextBoxName);
			Name = "UIDNameDescrControl";
			Size = new Size(426, 93);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label _LabelUID;
		private TextBox _TextBoxUID;
		private Label _LabelDescription;
		private Label _LabelName;
		private TextBox _TextBoxDescr;
		private TextBox _TextBoxName;
	}
}

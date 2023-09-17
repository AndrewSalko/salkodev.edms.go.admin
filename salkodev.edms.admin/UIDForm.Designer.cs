namespace salkodev.edms.admin
{
	partial class UIDForm
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
			_LabelUID = new Label();
			_TextBoxUID = new TextBox();
			_LabelCaption = new Label();
			SuspendLayout();
			// 
			// _ButtonCancel
			// 
			_ButtonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			_ButtonCancel.DialogResult = DialogResult.Cancel;
			_ButtonCancel.Location = new Point(356, 84);
			_ButtonCancel.Name = "_ButtonCancel";
			_ButtonCancel.Size = new Size(75, 23);
			_ButtonCancel.TabIndex = 26;
			_ButtonCancel.Text = "Cancel";
			_ButtonCancel.UseVisualStyleBackColor = true;
			// 
			// _ButtonOK
			// 
			_ButtonOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			_ButtonOK.DialogResult = DialogResult.OK;
			_ButtonOK.Location = new Point(275, 84);
			_ButtonOK.Name = "_ButtonOK";
			_ButtonOK.Size = new Size(75, 23);
			_ButtonOK.TabIndex = 25;
			_ButtonOK.Text = "OK";
			_ButtonOK.UseVisualStyleBackColor = true;
			// 
			// _LabelUID
			// 
			_LabelUID.AutoSize = true;
			_LabelUID.Location = new Point(12, 38);
			_LabelUID.Name = "_LabelUID";
			_LabelUID.Size = new Size(29, 15);
			_LabelUID.TabIndex = 21;
			_LabelUID.Text = "UID:";
			// 
			// _TextBoxUID
			// 
			_TextBoxUID.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			_TextBoxUID.Location = new Point(47, 35);
			_TextBoxUID.Name = "_TextBoxUID";
			_TextBoxUID.Size = new Size(384, 23);
			_TextBoxUID.TabIndex = 22;
			// 
			// _LabelCaption
			// 
			_LabelCaption.AutoSize = true;
			_LabelCaption.Location = new Point(12, 9);
			_LabelCaption.Name = "_LabelCaption";
			_LabelCaption.Size = new Size(57, 15);
			_LabelCaption.TabIndex = 27;
			_LabelCaption.Text = "(Caption)";
			// 
			// UIDForm
			// 
			AcceptButton = _ButtonOK;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			CancelButton = _ButtonCancel;
			ClientSize = new Size(443, 119);
			Controls.Add(_LabelCaption);
			Controls.Add(_ButtonCancel);
			Controls.Add(_ButtonOK);
			Controls.Add(_LabelUID);
			Controls.Add(_TextBoxUID);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "UIDForm";
			StartPosition = FormStartPosition.CenterParent;
			Text = "Enter object UID";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button _ButtonCancel;
		private Button _ButtonOK;
		private Label _LabelUID;
		private TextBox _TextBoxUID;
		private Label _LabelCaption;
	}
}
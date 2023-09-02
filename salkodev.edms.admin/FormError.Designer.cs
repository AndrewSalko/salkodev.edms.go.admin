namespace salkodev.edms.admin
{
	partial class FormError
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
			_LabelHeader = new Label();
			_TextBoxDetails = new TextBox();
			_ButtonClose = new Button();
			SuspendLayout();
			// 
			// _LabelHeader
			// 
			_LabelHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			_LabelHeader.AutoEllipsis = true;
			_LabelHeader.Location = new Point(12, 9);
			_LabelHeader.Name = "_LabelHeader";
			_LabelHeader.Size = new Size(664, 23);
			_LabelHeader.TabIndex = 0;
			_LabelHeader.Text = "(Error:)";
			// 
			// _TextBoxDetails
			// 
			_TextBoxDetails.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			_TextBoxDetails.Location = new Point(12, 40);
			_TextBoxDetails.Multiline = true;
			_TextBoxDetails.Name = "_TextBoxDetails";
			_TextBoxDetails.ReadOnly = true;
			_TextBoxDetails.Size = new Size(664, 343);
			_TextBoxDetails.TabIndex = 1;
			// 
			// _ButtonClose
			// 
			_ButtonClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			_ButtonClose.DialogResult = DialogResult.Cancel;
			_ButtonClose.Location = new Point(601, 389);
			_ButtonClose.Name = "_ButtonClose";
			_ButtonClose.Size = new Size(75, 23);
			_ButtonClose.TabIndex = 2;
			_ButtonClose.Text = "Close";
			_ButtonClose.UseVisualStyleBackColor = true;
			// 
			// FormError
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			CancelButton = _ButtonClose;
			ClientSize = new Size(688, 422);
			Controls.Add(_ButtonClose);
			Controls.Add(_TextBoxDetails);
			Controls.Add(_LabelHeader);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "FormError";
			StartPosition = FormStartPosition.CenterParent;
			Text = "Error";
			Load += FormError_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label _LabelHeader;
		private TextBox _TextBoxDetails;
		private Button _ButtonClose;
	}
}
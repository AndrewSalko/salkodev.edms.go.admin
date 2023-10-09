namespace salkodev.edms.admin.Orgs
{
	partial class OrgsViewForm
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
			_ListViewBrowseObjects = new ListView();
			_ButtonPrevPage = new Button();
			_ButtonNextPage = new Button();
			_TextBoxPage = new TextBox();
			_LabelPage = new Label();
			_ButtonJumpToPage = new Button();
			SuspendLayout();
			// 
			// _ListViewBrowseObjects
			// 
			_ListViewBrowseObjects.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			_ListViewBrowseObjects.FullRowSelect = true;
			_ListViewBrowseObjects.Location = new Point(12, 43);
			_ListViewBrowseObjects.Name = "_ListViewBrowseObjects";
			_ListViewBrowseObjects.Size = new Size(997, 353);
			_ListViewBrowseObjects.TabIndex = 0;
			_ListViewBrowseObjects.UseCompatibleStateImageBehavior = false;
			_ListViewBrowseObjects.View = View.Details;
			// 
			// _ButtonPrevPage
			// 
			_ButtonPrevPage.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			_ButtonPrevPage.Location = new Point(753, 415);
			_ButtonPrevPage.Name = "_ButtonPrevPage";
			_ButtonPrevPage.Size = new Size(125, 23);
			_ButtonPrevPage.TabIndex = 1;
			_ButtonPrevPage.Text = "<< Prev page";
			_ButtonPrevPage.UseVisualStyleBackColor = true;
			_ButtonPrevPage.Click += _ButtonPrevPage_Click;
			// 
			// _ButtonNextPage
			// 
			_ButtonNextPage.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			_ButtonNextPage.Location = new Point(884, 415);
			_ButtonNextPage.Name = "_ButtonNextPage";
			_ButtonNextPage.Size = new Size(125, 23);
			_ButtonNextPage.TabIndex = 2;
			_ButtonNextPage.Text = "Next page >>";
			_ButtonNextPage.UseVisualStyleBackColor = true;
			_ButtonNextPage.Click += _ButtonNextPage_Click;
			// 
			// _TextBoxPage
			// 
			_TextBoxPage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			_TextBoxPage.Location = new Point(62, 415);
			_TextBoxPage.Name = "_TextBoxPage";
			_TextBoxPage.Size = new Size(61, 23);
			_TextBoxPage.TabIndex = 3;
			// 
			// _LabelPage
			// 
			_LabelPage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			_LabelPage.AutoSize = true;
			_LabelPage.Location = new Point(20, 419);
			_LabelPage.Name = "_LabelPage";
			_LabelPage.Size = new Size(36, 15);
			_LabelPage.TabIndex = 4;
			_LabelPage.Text = "Page:";
			// 
			// _ButtonJumpToPage
			// 
			_ButtonJumpToPage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			_ButtonJumpToPage.Location = new Point(129, 415);
			_ButtonJumpToPage.Name = "_ButtonJumpToPage";
			_ButtonJumpToPage.Size = new Size(59, 23);
			_ButtonJumpToPage.TabIndex = 5;
			_ButtonJumpToPage.Text = "Go";
			_ButtonJumpToPage.UseVisualStyleBackColor = true;
			_ButtonJumpToPage.Click += _ButtonJumpToPage_Click;
			// 
			// OrgsViewForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1021, 450);
			Controls.Add(_ButtonJumpToPage);
			Controls.Add(_LabelPage);
			Controls.Add(_TextBoxPage);
			Controls.Add(_ButtonNextPage);
			Controls.Add(_ButtonPrevPage);
			Controls.Add(_ListViewBrowseObjects);
			MinimizeBox = false;
			Name = "OrgsViewForm";
			StartPosition = FormStartPosition.CenterParent;
			Text = "Organizations";
			Load += OrgsViewForm_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ListView _ListViewBrowseObjects;
		private Button _ButtonPrevPage;
		private Button _ButtonNextPage;
		private TextBox _TextBoxPage;
		private Label _LabelPage;
		private Button _ButtonJumpToPage;
	}
}
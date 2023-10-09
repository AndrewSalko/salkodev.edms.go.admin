using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using salkodev.edms.admin.Pagination;

namespace salkodev.edms.admin.Orgs
{
	public partial class OrgsViewForm : Form
	{
		public OrgsViewForm()
		{
			InitializeComponent();
		}

		public int Page
		{
			get;
			set;
		}

		public int PerPage
		{
			get;
			set;
		}

		internal OrganizationsManager OrgManager
		{
			get;
			set;
		}

		OrgPaginationResponse _CurrentPage;

		private void OrgsViewForm_Load(object sender, EventArgs e)
		{
			var listViewInitializer = new Pagination.ListViewInitializer();

			//prepare columns
			ObjectPropertyColumn[] cols =
			{
				new ObjectPropertyColumn("uid","uid", 200),
				new ObjectPropertyColumn("name","Name", 250),
				new ObjectPropertyColumn("description","Description",200),
				new ObjectPropertyColumn("owner_uid","Owner UID",200),
				new ObjectPropertyColumn("creation_time","Сreated",130)
			};

			listViewInitializer.InitColumns(_ListViewBrowseObjects, cols);

			_TextBoxPage.Text = Page.ToString();

			_UpdateCurrentPage();

			try
			{
				_LoadPage(Page);
				_LoadPageToView();
			}
			catch (Exception ex)
			{
				ErrorUI.ShowException(this, ex);
			}
		}

		void _LoadPageToView()
		{
			_ListViewBrowseObjects.Items.Clear();

			if (_CurrentPage == null)
				return;

			var data = _CurrentPage.Data;
			if (data == null)
				return;

			foreach (var item in data)
			{
				if (item == null)
					continue;

				ListViewItem li = new ListViewItem();
				li.Tag = item;

				li.Text = item.UID;
				li.SubItems.Add(item.Name);
				li.SubItems.Add(item.Description);
				li.SubItems.Add(item.OwnerUID);
				li.SubItems.Add($"{item.CreationTime}");

				_ListViewBrowseObjects.Items.Add(li);
			}
		}

		void _LoadPage(int page)
		{
			OrgPaginationResponse pg = OrgManager.GetPage<OrgPaginationResponse>(page, PerPage);

			_CurrentPage = pg;
			_LoadPageToView();
		}

		void _UpdateCurrentPage()
		{
			_TextBoxPage.Text = Page.ToString();
		}

		void _ApplyPage(int page)
		{
			_LoadPage(page);
			Page = page;
			_TextBoxPage.Text = Page.ToString();
		}

		void _ButtonNextPage_Click(object sender, EventArgs e)
		{
			try
			{
				//TODO: how many pages?
				int page = Page + 1;
				_ApplyPage(page);
			}
			catch (Exception ex)
			{
				ErrorUI.ShowException(this, ex);
			}
		}

		void _ButtonPrevPage_Click(object sender, EventArgs e)
		{
			try
			{
				if (Page > 1)
				{
					int page = Page - 1;
					_ApplyPage(page);
				}
			}
			catch (Exception ex)
			{
				ErrorUI.ShowException(this, ex);
			}
		}

		void _ButtonJumpToPage_Click(object sender, EventArgs e)
		{
			try
			{
				string pageStr = _TextBoxPage.Text;
				if (string.IsNullOrWhiteSpace(pageStr))
					return;

				int page = int.Parse(pageStr);
				_ApplyPage(page);
			}
			catch (Exception ex)
			{
				ErrorUI.ShowException(this, ex);
			}
		}
	}
}

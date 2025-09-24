
using System;
using System.Linq;
using System.Windows.Forms;

namespace HostelManagementSystem
{
    public partial class StaffForm : Form
    {
        public StaffForm(){ InitializeComponent(); RefreshList(); }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text) || string.IsNullOrWhiteSpace(txtName.Text)) { MessageBox.Show("Provide ID and Name."); return; }
            if (DataStore.Data.Staffs.Any(x => x.Id == txtId.Text.Trim())) { MessageBox.Show("ID exists."); return; }
            DataStore.Data.Staffs.Add(new Staff { Id=txtId.Text.Trim(), Name=txtName.Text.Trim(), Role=txtRole.Text.Trim(), Contact=txtContact.Text.Trim() });
            DataStore.Save(); RefreshList();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lst.SelectedIndex<0) { MessageBox.Show("Select staff."); return; }
            var id = lst.SelectedItem.ToString().Split('|')[0].Trim();
            var s = DataStore.Data.Staffs.FirstOrDefault(x => x.Id == id);
            if (s!=null) { DataStore.Data.Staffs.Remove(s); DataStore.Save(); RefreshList(); }
        }

        private void RefreshList() { lst.Items.Clear(); foreach(var s in DataStore.Data.Staffs) lst.Items.Add($"{s.Id} | {s.Name} | {s.Role} | {s.Contact}"); }
    }
}

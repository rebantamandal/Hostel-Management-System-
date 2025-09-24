
using System;
using System.Linq;
using System.Windows.Forms;

namespace HostelManagementSystem
{
    public partial class FineForm : Form
    {
        public FineForm(){ InitializeComponent(); RefreshList(); }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbStudents.SelectedIndex < 0 || !decimal.TryParse(txtAmount.Text.Trim(), out decimal amt)) { MessageBox.Show("Select student and valid amount."); return; }
            var sid = DataStore.Data.Students[cmbStudents.SelectedIndex].Id;
            DataStore.Data.Fines.Add(new FineRecord { Id = Guid.NewGuid().ToString(), StudentId = sid, Reason = txtReason.Text.Trim(), Amount = amt, Date = DateTime.Now, Paid = false });
            DataStore.Save(); RefreshList();
        }

        private void btnMarkPaid_Click(object sender, EventArgs e)
        {
            if (lst.SelectedIndex<0) { MessageBox.Show("Select fine."); return; }
            var id = lst.SelectedItem.ToString().Split('|')[0].Trim();
            var f = DataStore.Data.Fines.FirstOrDefault(x => x.Id == id);
            if (f!=null) { f.Paid = true; DataStore.Save(); RefreshList(); }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lst.SelectedIndex<0) { MessageBox.Show("Select fine."); return; }
            var id = lst.SelectedItem.ToString().Split('|')[0].Trim();
            var f = DataStore.Data.Fines.FirstOrDefault(x => x.Id == id);
            if (f!=null) { DataStore.Data.Fines.Remove(f); DataStore.Save(); RefreshList(); }
        }

        private void RefreshList()
        {
            lst.Items.Clear();
            cmbStudents.Items.Clear();
            foreach(var f in DataStore.Data.Fines.OrderByDescending(x=>x.Date)) lst.Items.Add($"{f.Id} | Student: {f.StudentId} | {f.Reason} | ₹{f.Amount} | {f.Date:yyyy-MM-dd} | Paid: {f.Paid}");
            foreach(var s in DataStore.Data.Students) cmbStudents.Items.Add($"{s.Id} - {s.Name}");
        }
    }
}

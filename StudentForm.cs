
using System;
using System.Linq;
using System.Windows.Forms;

namespace HostelManagementSystem
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
            RefreshLists();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text) || string.IsNullOrWhiteSpace(txtName.Text)) { MessageBox.Show("Provide ID and Name."); return; }
            if (DataStore.Data.Students.Any(x => x.Id == txtId.Text.Trim())) { MessageBox.Show("ID exists."); return; }
            DataStore.Data.Students.Add(new Student { Id=txtId.Text.Trim(), Name=txtName.Text.Trim(), Contact=txtContact.Text.Trim(), RoomNumber = "" });
            DataStore.Save(); RefreshLists();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lst.SelectedIndex < 0) { MessageBox.Show("Select student."); return; }
            var id = lst.SelectedItem.ToString().Split('|')[0].Trim();
            var s = DataStore.Data.Students.FirstOrDefault(x => x.Id == id);
            if (s!=null)
            {
                if(!string.IsNullOrEmpty(s.RoomNumber))
                {
                    var r = DataStore.Data.Rooms.FirstOrDefault(x => x.RoomNumber == s.RoomNumber);
                    r?.Occupants.Remove(s.Id);
                }
                DataStore.Data.Students.Remove(s); DataStore.Save(); RefreshLists();
            }
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            if (lst.SelectedIndex < 0 || cmbRooms.SelectedIndex < 0) { MessageBox.Show("Select student and room."); return; }
            var id = lst.SelectedItem.ToString().Split('|')[0].Trim();
            var s = DataStore.Data.Students.FirstOrDefault(x => x.Id == id);
            var roomNum = DataStore.Data.Rooms[cmbRooms.SelectedIndex].RoomNumber;
            var room = DataStore.Data.Rooms.FirstOrDefault(x => x.RoomNumber == roomNum);
            if (room.Occupants.Count >= room.Capacity) { MessageBox.Show("Room full."); return; }
            if (!string.IsNullOrEmpty(s.RoomNumber))
            {
                var prev = DataStore.Data.Rooms.FirstOrDefault(x => x.RoomNumber == s.RoomNumber);
                prev?.Occupants.Remove(s.Id);
            }
            room.Occupants.Add(s.Id); s.RoomNumber = room.RoomNumber; DataStore.Save(); RefreshLists();
        }

        private void RefreshLists()
        {
            lst.Items.Clear();
            foreach(var s in DataStore.Data.Students) lst.Items.Add($"{s.Id} | {s.Name} | Room: {(string.IsNullOrEmpty(s.RoomNumber)?"Unassigned":s.RoomNumber)} | {s.Contact}");
            cmbRooms.Items.Clear();
            foreach(var r in DataStore.Data.Rooms) cmbRooms.Items.Add($"{r.RoomNumber} (free {r.Capacity - r.Occupants.Count})");
        }
    }
}

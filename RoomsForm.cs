
using System;
using System.Linq;
using System.Windows.Forms;

namespace HostelManagementSystem
{
    public partial class RoomsForm : Form
    {
        public RoomsForm(){ InitializeComponent(); RefreshList(); }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRoom.Text) || !int.TryParse(txtCapacity.Text.Trim(), out int cap)) { MessageBox.Show("Provide room and capacity."); return; }
            if (DataStore.Data.Rooms.Any(x => x.RoomNumber == txtRoom.Text.Trim())) { MessageBox.Show("Room exists."); return; }
            DataStore.Data.Rooms.Add(new Room { RoomNumber = txtRoom.Text.Trim(), Capacity = cap });
            DataStore.Save(); RefreshList();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lst.SelectedIndex<0) { MessageBox.Show("Select room."); return; }
            var roomNum = lst.SelectedItem.ToString().Split('|')[0].Trim();
            var r = DataStore.Data.Rooms.FirstOrDefault(x => x.RoomNumber == roomNum);
            if (r != null)
            {
                if (r.Occupants.Any()) { MessageBox.Show("Cannot remove occupied room."); return; }
                DataStore.Data.Rooms.Remove(r); DataStore.Save(); RefreshList();
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (lst.SelectedIndex<0) { MessageBox.Show("Select room."); return; }
            var roomNum = lst.SelectedItem.ToString().Split('|')[0].Trim();
            var r = DataStore.Data.Rooms.FirstOrDefault(x => x.RoomNumber == roomNum);
            MessageBox.Show($"Room {r.RoomNumber}\nCapacity: {r.Capacity}\nOccupants: {(r.Occupants.Any()?string.Join(",", r.Occupants):"None")}");
        }

        private void RefreshList()
        {
            lst.Items.Clear();
            foreach(var r in DataStore.Data.Rooms) lst.Items.Add($"{r.RoomNumber} | Capacity: {r.Capacity} | Occupied: {r.Occupants.Count} | Free: {r.Capacity - r.Occupants.Count}");
        }
    }
}


using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HostelManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            RefreshSummary();
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            var f = new StudentForm(); f.ShowDialog();
            RefreshSummary();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            var f = new StaffForm(); f.ShowDialog();
            RefreshSummary();
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            var f = new RoomsForm(); f.ShowDialog();
            RefreshSummary();
        }

        private void btnFines_Click(object sender, EventArgs e)
        {
            var f = new FineForm(); f.ShowDialog();
            RefreshSummary();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            using (var dlg = new SaveFileDialog() { Filter = "CSV files|*.csv", FileName = "students.csv" })
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    Utilities.ExportStudentsCsv(dlg.FileName);
                    MessageBox.Show("Exported students to CSV.");
                }
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog() { Filter = "CSV files|*.csv" })
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    Utilities.ImportStudentsCsv(dlg.FileName);
                    MessageBox.Show("Imported students from CSV.");
                    RefreshSummary();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataStore.Save();
            MessageBox.Show("Data saved.");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void RefreshSummary()
        {
            var d = DataStore.Data;
            int students = d.Students.Count;
            int staff = d.Staffs.Count;
            int rooms = d.Rooms.Count;
            int occupied = d.Rooms.Sum(r => r.Occupants.Count);
            int finesOpen = d.Fines.Count(f => !f.Paid);
            txtSummary.Text = $"Students: {students}\r\nStaff: {staff}\r\nRooms: {rooms}\r\nOccupants: {occupied}\r\nOpen fines: {finesOpen}\r\n\r\n" +
                string.Join("\r\n", d.Rooms.Select(r => $"{r.RoomNumber} (Cap {r.Capacity}) - Occupied: {r.Occupants.Count}"));
        }
    }
}

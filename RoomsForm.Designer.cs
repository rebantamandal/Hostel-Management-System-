
namespace HostelManagementSystem
{
    partial class RoomsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox lst;
        private System.Windows.Forms.TextBox txtRoom, txtCapacity;
        private System.Windows.Forms.Button btnAdd, btnRemove, btnView;

        protected override void Dispose(bool disposing) { if (disposing && (components!=null)) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.lst = new System.Windows.Forms.ListBox();
            this.txtRoom = new System.Windows.Forms.TextBox();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.SuspendLayout();
            this.lst.Location = new System.Drawing.Point(12,12); this.lst.Size = new System.Drawing.Size(420,360);
            this.txtRoom.Location = new System.Drawing.Point(450,40); this.txtRoom.Width = 220;
            this.txtCapacity.Location = new System.Drawing.Point(450,100); this.txtCapacity.Width = 220;
            this.btnAdd.Location = new System.Drawing.Point(450,140); this.btnAdd.Text = "Add Room"; this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnRemove.Location = new System.Drawing.Point(450,180); this.btnRemove.Text = "Remove Room"; this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            this.btnView.Location = new System.Drawing.Point(450,220); this.btnView.Text = "View Occupants"; this.btnView.Click += new System.EventHandler(this.btnView_Click);
            this.ClientSize = new System.Drawing.Size(700,420);
            this.Controls.AddRange(new System.Windows.Forms.Control[] { this.lst, this.txtRoom, this.txtCapacity, this.btnAdd, this.btnRemove, this.btnView });
            this.Name = "RoomsForm"; this.Text = "Rooms Management"; this.ResumeLayout(false);
        }
    }
}

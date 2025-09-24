
namespace HostelManagementSystem
{
    partial class StudentForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox lst;
        private System.Windows.Forms.TextBox txtId, txtName, txtContact;
        private System.Windows.Forms.ComboBox cmbRooms;
        private System.Windows.Forms.Button btnAdd, btnRemove, btnAssign;

        protected override void Dispose(bool disposing) { if (disposing && (components!=null)) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.lst = new System.Windows.Forms.ListBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.cmbRooms = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAssign = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // lst
            this.lst.Location = new System.Drawing.Point(12,12); this.lst.Size = new System.Drawing.Size(420,360);
            // txtId
            this.txtId.Location = new System.Drawing.Point(450,40); this.txtId.Width = 220;
            // txtName
            this.txtName.Location = new System.Drawing.Point(450,100); this.txtName.Width = 220;
            // txtContact
            this.txtContact.Location = new System.Drawing.Point(450,160); this.txtContact.Width = 220;
            // cmbRooms
            this.cmbRooms.Location = new System.Drawing.Point(450,220); this.cmbRooms.Width = 220;
            // btnAdd
            this.btnAdd.Location = new System.Drawing.Point(450,260); this.btnAdd.Text = "Add Student"; this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // btnRemove
            this.btnRemove.Location = new System.Drawing.Point(450,300); this.btnRemove.Text = "Remove Selected"; this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // btnAssign
            this.btnAssign.Location = new System.Drawing.Point(450,340); this.btnAssign.Text = "Assign to Room"; this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // Form
            this.ClientSize = new System.Drawing.Size(700,420);
            this.Controls.AddRange(new System.Windows.Forms.Control[] { this.lst, this.txtId, this.txtName, this.txtContact, this.cmbRooms, this.btnAdd, this.btnRemove, this.btnAssign });
            this.Name = "StudentForm"; this.Text = "Student Management"; this.ResumeLayout(false);
        }
    }
}

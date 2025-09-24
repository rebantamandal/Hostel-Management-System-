
namespace HostelManagementSystem
{
    partial class StaffForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox lst;
        private System.Windows.Forms.TextBox txtId, txtName, txtRole, txtContact;
        private System.Windows.Forms.Button btnAdd, btnRemove;

        protected override void Dispose(bool disposing) { if (disposing && (components!=null)) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.lst = new System.Windows.Forms.ListBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            this.lst.Location = new System.Drawing.Point(12,12); this.lst.Size = new System.Drawing.Size(420,360);
            this.txtId.Location = new System.Drawing.Point(450,40); this.txtId.Width = 220;
            this.txtName.Location = new System.Drawing.Point(450,100); this.txtName.Width = 220;
            this.txtRole.Location = new System.Drawing.Point(450,160); this.txtRole.Width = 220;
            this.txtContact.Location = new System.Drawing.Point(450,220); this.txtContact.Width = 220;
            this.btnAdd.Location = new System.Drawing.Point(450,260); this.btnAdd.Text = "Add Staff"; this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnRemove.Location = new System.Drawing.Point(450,300); this.btnRemove.Text = "Remove Selected"; this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            this.ClientSize = new System.Drawing.Size(700,420);
            this.Controls.AddRange(new System.Windows.Forms.Control[] { this.lst, this.txtId, this.txtName, this.txtRole, this.txtContact, this.btnAdd, this.btnRemove });
            this.Name = "StaffForm"; this.Text = "Staff Management"; this.ResumeLayout(false);
        }
    }
}

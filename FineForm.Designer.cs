
namespace HostelManagementSystem
{
    partial class FineForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox lst;
        private System.Windows.Forms.ComboBox cmbStudents;
        private System.Windows.Forms.TextBox txtReason, txtAmount;
        private System.Windows.Forms.Button btnAdd, btnMarkPaid, btnRemove;

        protected override void Dispose(bool disposing) { if (disposing && (components!=null)) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.lst = new System.Windows.Forms.ListBox();
            this.cmbStudents = new System.Windows.Forms.ComboBox();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnMarkPaid = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            this.lst.Location = new System.Drawing.Point(12,12); this.lst.Size = new System.Drawing.Size(520,400);
            this.cmbStudents.Location = new System.Drawing.Point(550,40); this.cmbStudents.Width = 200;
            this.txtReason.Location = new System.Drawing.Point(550,100); this.txtReason.Width = 200;
            this.txtAmount.Location = new System.Drawing.Point(550,160); this.txtAmount.Width = 200;
            this.btnAdd.Location = new System.Drawing.Point(550,200); this.btnAdd.Text = "Add Fine"; this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnMarkPaid.Location = new System.Drawing.Point(550,240); this.btnMarkPaid.Text = "Mark Paid"; this.btnMarkPaid.Click += new System.EventHandler(this.btnMarkPaid_Click);
            this.btnRemove.Location = new System.Drawing.Point(550,280); this.btnRemove.Text = "Remove Fine"; this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            this.ClientSize = new System.Drawing.Size(780,430);
            this.Controls.AddRange(new System.Windows.Forms.Control[] { this.lst, this.cmbStudents, this.txtReason, this.txtAmount, this.btnAdd, this.btnMarkPaid, this.btnRemove });
            this.Name = "FineForm"; this.Text = "Fine Management"; this.ResumeLayout(false);
        }
    }
}

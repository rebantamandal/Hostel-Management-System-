
namespace HostelManagementSystem
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Button btnRooms;
        private System.Windows.Forms.Button btnFines;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TextBox txtSummary;
        private System.Windows.Forms.Label lblTitle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnStudents = new System.Windows.Forms.Button();
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnRooms = new System.Windows.Forms.Button();
            this.btnFines = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.txtSummary = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStudents
            // 
            this.btnStudents.Location = new System.Drawing.Point(24, 80);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(160, 40);
            this.btnStudents.TabIndex = 0;
            this.btnStudents.Text = "Students";
            this.btnStudents.UseVisualStyleBackColor = true;
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.Location = new System.Drawing.Point(24, 130);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(160, 40);
            this.btnStaff.TabIndex = 1;
            this.btnStaff.Text = "Staff";
            this.btnStaff.UseVisualStyleBackColor = true;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnRooms
            // 
            this.btnRooms.Location = new System.Drawing.Point(24, 180);
            this.btnRooms.Name = "btnRooms";
            this.btnRooms.Size = new System.Drawing.Size(160, 40);
            this.btnRooms.TabIndex = 2;
            this.btnRooms.Text = "Rooms";
            this.btnRooms.UseVisualStyleBackColor = true;
            this.btnRooms.Click += new System.EventHandler(this.btnRooms_Click);
            // 
            // btnFines
            // 
            this.btnFines.Location = new System.Drawing.Point(24, 230);
            this.btnFines.Name = "btnFines";
            this.btnFines.Size = new System.Drawing.Size(160, 40);
            this.btnFines.TabIndex = 3;
            this.btnFines.Text = "Fines";
            this.btnFines.UseVisualStyleBackColor = true;
            this.btnFines.Click += new System.EventHandler(this.btnFines_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(24, 290);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(160, 30);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "Export Students CSV";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(24, 330);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(160, 30);
            this.btnImport.TabIndex = 5;
            this.btnImport.Text = "Import Students CSV";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(24, 380);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(160, 30);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save Data";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(24, 420);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(160, 30);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Exit";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // txtSummary
            // 
            this.txtSummary.Location = new System.Drawing.Point(210, 80);
            this.txtSummary.Multiline = true;
            this.txtSummary.Name = "txtSummary";
            this.txtSummary.ReadOnly = true;
            this.txtSummary.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSummary.Size = new System.Drawing.Size(540, 370);
            this.txtSummary.TabIndex = 8;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(292, 25);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Hostel Management System - Admin";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(780, 480);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtSummary);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnFines);
            this.Controls.Add(this.btnRooms);
            this.Controls.Add(this.btnStaff);
            this.Controls.Add(this.btnStudents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

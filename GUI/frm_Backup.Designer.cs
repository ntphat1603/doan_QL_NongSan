
namespace GUI
{
    partial class frm_Backup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_sever = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btn_backup = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_data = new System.Windows.Forms.TextBox();
            this.lab_phantram = new System.Windows.Forms.Label();
            this.lab_status = new System.Windows.Forms.Label();
            this.btn_restore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sever:";
            // 
            // txt_sever
            // 
            this.txt_sever.Location = new System.Drawing.Point(114, 26);
            this.txt_sever.Name = "txt_sever";
            this.txt_sever.Size = new System.Drawing.Size(207, 26);
            this.txt_sever.TabIndex = 1;
            this.txt_sever.Text = "DESKTOP-CPB5GE8";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(43, 99);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(278, 31);
            this.progressBar.TabIndex = 2;
            // 
            // btn_backup
            // 
            this.btn_backup.Location = new System.Drawing.Point(342, 99);
            this.btn_backup.Name = "btn_backup";
            this.btn_backup.Size = new System.Drawing.Size(75, 31);
            this.btn_backup.TabIndex = 3;
            this.btn_backup.Text = "Backup";
            this.btn_backup.UseVisualStyleBackColor = true;
            this.btn_backup.Click += new System.EventHandler(this.btn_backup_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Database:";
            // 
            // txt_data
            // 
            this.txt_data.Location = new System.Drawing.Point(114, 58);
            this.txt_data.Name = "txt_data";
            this.txt_data.Size = new System.Drawing.Size(207, 26);
            this.txt_data.TabIndex = 1;
            this.txt_data.Text = "QL_NONG_SAN";
            // 
            // lab_phantram
            // 
            this.lab_phantram.AutoSize = true;
            this.lab_phantram.Location = new System.Drawing.Point(156, 133);
            this.lab_phantram.Name = "lab_phantram";
            this.lab_phantram.Size = new System.Drawing.Size(34, 19);
            this.lab_phantram.TabIndex = 0;
            this.lab_phantram.Text = "0 %";
            // 
            // lab_status
            // 
            this.lab_status.AutoSize = true;
            this.lab_status.Location = new System.Drawing.Point(12, 164);
            this.lab_status.Name = "lab_status";
            this.lab_status.Size = new System.Drawing.Size(49, 19);
            this.lab_status.TabIndex = 0;
            this.lab_status.Text = "Status:";
            // 
            // btn_restore
            // 
            this.btn_restore.Location = new System.Drawing.Point(423, 99);
            this.btn_restore.Name = "btn_restore";
            this.btn_restore.Size = new System.Drawing.Size(75, 31);
            this.btn_restore.TabIndex = 3;
            this.btn_restore.Text = "Restore";
            this.btn_restore.UseVisualStyleBackColor = true;
            this.btn_restore.Click += new System.EventHandler(this.btn_restore_Click);
            // 
            // frm_Backup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 203);
            this.Controls.Add(this.btn_restore);
            this.Controls.Add(this.btn_backup);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.txt_data);
            this.Controls.Add(this.lab_status);
            this.Controls.Add(this.lab_phantram);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_sever);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_Backup";
            this.Text = "Khôi phục và sao lưu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_sever;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btn_backup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_data;
        private System.Windows.Forms.Label lab_phantram;
        private System.Windows.Forms.Label lab_status;
        private System.Windows.Forms.Button btn_restore;
    }
}
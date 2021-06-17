using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace GUI
{
    public partial class frm_Backup : Form
    {
        public frm_Backup()
        {
            InitializeComponent();
        }

        private void btn_backup_Click(object sender, EventArgs e)
        {
            progressBar.Value = 0;
            try
            {
                Server dbServer = new Server(new ServerConnection(txt_sever.Text));
                Backup dbBackup = new Backup() { Action = BackupActionType.Database, Database = txt_data.Text };
                dbBackup.Devices.AddDevice(@"D:\123\QL_NS.bak", DeviceType.File);
                dbBackup.Initialize = true;
                dbBackup.PercentComplete += DbBackup_PercentComplete; ;
                dbBackup.Complete += DbBackup_Complete; ;
                dbBackup.SqlBackupAsync(dbServer);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DbBackup_Complete(object sender, ServerMessageEventArgs e)
        {
            if (e.Error != null)
            {
                lab_status.Invoke((MethodInvoker)delegate
                {
                    lab_status.Text = e.Error.Message;
                });

            }
        }

        private void DbBackup_PercentComplete(object sender, PercentCompleteEventArgs e)
        {
            progressBar.Invoke((MethodInvoker)delegate
            {
                progressBar.Value = e.Percent;
                progressBar.Update();
            });
            lab_phantram.Invoke((MethodInvoker)delegate
            {
                lab_phantram.Text = $"{e.Percent}%";
            });
        }

        private void btn_restore_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("YÊU CẦU ĐỐNG TÁT CẢ CÁC CHƯƠNG TRÌNH ĐỂ KHI KHÔI PHỤC DỮ LIỆU TRÁNH BỊ LỖI", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (r == DialogResult.Yes)
            {

                OpenFileDialog phuchoiFile = new OpenFileDialog();
                phuchoiFile.Filter = "*.bak|*.bak";
                phuchoiFile.Title = "Chọn tập tin phục hồi (.bak)";
                if (phuchoiFile.ShowDialog() == DialogResult.OK &&
                phuchoiFile.CheckFileExists == true)
                {
                    string sDuongDan = phuchoiFile.FileName;
                    if (NS_SaoLuuPhucHoi_BUS.PhuchoiSaoLuu(sDuongDan) == true)
                        MessageBox.Show("Thành công", "Congratulations",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Thất bại");
                }
            }

            /*progressBar.Value = 0;
            try
            {
                Server dbServer = new Server(new ServerConnection(txt_sever.Text));
                Restore dbRestore = new Restore() { Database = txt_data.Text, Action = RestoreActionType.Database, ReplaceDatabase = true, NoRecovery = false };
                dbRestore.Devices.AddDevice(@"D:\123\QL_NS.bak", DeviceType.File);
                dbRestore.PercentComplete += DbRestore_PercentComplete; ;
                dbRestore.Complete += DbRestore_Complete;
                dbRestore.SqlRestoreAsync(dbServer);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        private void DbRestore_Complete(object sender, ServerMessageEventArgs e)
        {
            if (e.Error != null)
            {
                lab_status.Invoke((MethodInvoker)delegate
                {
                    lab_status.Text = e.Error.Message;
                });

            }
        }

        private void DbRestore_PercentComplete(object sender, PercentCompleteEventArgs e)
        {
            progressBar.Invoke((MethodInvoker)delegate
            {
                progressBar.Value = e.Percent;
                progressBar.Update();
            });
            lab_phantram.Invoke((MethodInvoker)delegate
            {
                lab_phantram.Text = $"{e.Percent}%";
            });
        }
    }
}

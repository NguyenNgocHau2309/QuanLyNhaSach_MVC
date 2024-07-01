using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaSach
{
    public partial class Login : Form
    {
        private DataProvider dataProvider = new DataProvider();
        public Login()
        {
            InitializeComponent();
        }
        int count = 0;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtuser.Text;
            string password = txtpassword.Text;

            if (login(username, password))
            {
                NhaSach f = new NhaSach(txtuser.Text);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                count++;
                if (count <= 3)
                    MessageBox.Show("SAI TÊN ĐĂNG NHẬP HOẶC MẬT KHẨU!", "THÔNG BÁO");
                else
                {
                    DialogResult d;
                    d = MessageBox.Show("BẠN ĐÃ NHẬP SAI 3 LẦN LIÊN TIẾP. THOÁT CHƯƠNG TRÌNH ?", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (d == DialogResult.OK)
                    {
                        Application.ExitThread();
                    }
                    count = 0;
                }
            }
            txtuser.Text = "";
            txtpassword.Text = "";
        }
        private bool login(string username, string password)
        {
            DataTable dt = new DataTable();
            dt = dataProvider.execQuery("USP_Login @userName = '" + username + "' , @password = '" + password + "'");
            return dt.Rows.Count > 0;
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("BẠN THẬT SỰ MUỐN THOÁT CHƯƠNG TRÌNH?", "THÔNG BÁO", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LJ_AM450_New
{
    public partial class Login : Form
    {
        //用于工程师界面的布尔值
        public bool admin = false;
        public Login()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "450" && txtPwd.Text == "450")
            {
                admin = true;
                this.DialogResult = DialogResult.OK;
                this.Close();
                //this.Hide();
                //MainForm mainForm = new MainForm(admin);
                //mainForm.Show();
            }
            else 
            {
                MessageBox.Show("账号或密码错误");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}

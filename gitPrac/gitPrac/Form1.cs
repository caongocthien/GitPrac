using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gitPrac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtPassword.Text == "admin" && txtUserName.Text == "admin")
            {
                MessageBox.Show("Dang nhap thanh cong");
            } else
            {
                MessageBox.Show("Dang nhap that bai");
            }
        }
    }
}

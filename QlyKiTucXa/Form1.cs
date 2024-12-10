using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QlyKiTucXa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Sign_In_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) && string.IsNullOrWhiteSpace(maskedTextBox1.Text))
            {
                MessageBox.Show("Tên đăng nhập và Mật khẩu không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Tên đăng nhập không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrWhiteSpace(maskedTextBox1.Text))
            {
                MessageBox.Show("Mật khẩu không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (textBox1.Text == "admin" && maskedTextBox1.Text == "admin")
                {
                    btnManageRoom qLyKiTucXa = new btnManageRoom();
                    qLyKiTucXa.FormClosed += (s, args) => this.Show();
                    this.Hide();
                    qLyKiTucXa.Show();
                }
                else if (textBox1.Text == "admin" && maskedTextBox1.Text == "1")
                {
                    Home home = new Home();
                    home.FormClosed += (s, args) => this.Show();
                    this.Hide();
                    home.Show();
                }
                else
                {
                    MessageBox.Show("Tên người dùng hoặc mật khẩu không đúng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Sign_Up_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangKy dangKy = new DangKy();
            dangKy.FormClosed += (s, args) => this.Show();
            this.Hide();
            dangKy.Show();
        }

        private void ForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QuenMatKhau qmk = new QuenMatKhau();
            qmk.FormClosed += (s, args) => this.Show();
            this.Hide();
            qmk.Show();
        }
    }
}

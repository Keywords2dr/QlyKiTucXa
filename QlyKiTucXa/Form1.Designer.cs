namespace QlyKiTucXa
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.Sign_In = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.ForgotPassword = new System.Windows.Forms.LinkLabel();
            this.Sign_Up = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(332, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đăng nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(213, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên đăng nhập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(222, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mật khẩu";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(315, 130);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 22);
            this.textBox1.TabIndex = 4;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(315, 178);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.PasswordChar = '*';
            this.maskedTextBox1.Size = new System.Drawing.Size(189, 22);
            this.maskedTextBox1.TabIndex = 5;
            // 
            // Sign_In
            // 
            this.Sign_In.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sign_In.Location = new System.Drawing.Point(266, 235);
            this.Sign_In.Name = "Sign_In";
            this.Sign_In.Size = new System.Drawing.Size(109, 30);
            this.Sign_In.TabIndex = 8;
            this.Sign_In.Text = "Đăng nhập";
            this.Sign_In.UseVisualStyleBackColor = true;
            this.Sign_In.Click += new System.EventHandler(this.Sign_In_Click);
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.Location = new System.Drawing.Point(424, 235);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(109, 30);
            this.Cancel.TabIndex = 9;
            this.Cancel.Text = "Hủy";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // ForgotPassword
            // 
            this.ForgotPassword.AutoSize = true;
            this.ForgotPassword.Location = new System.Drawing.Point(461, 213);
            this.ForgotPassword.Name = "ForgotPassword";
            this.ForgotPassword.Size = new System.Drawing.Size(96, 16);
            this.ForgotPassword.TabIndex = 10;
            this.ForgotPassword.TabStop = true;
            this.ForgotPassword.Text = "Quên mật khẩu";
            this.ForgotPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ForgotPassword_LinkClicked);
            // 
            // Sign_Up
            // 
            this.Sign_Up.AutoSize = true;
            this.Sign_Up.Location = new System.Drawing.Point(461, 292);
            this.Sign_Up.Name = "Sign_Up";
            this.Sign_Up.Size = new System.Drawing.Size(56, 16);
            this.Sign_Up.TabIndex = 11;
            this.Sign_Up.TabStop = true;
            this.Sign_Up.Text = "Đăng ký";
            this.Sign_Up.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Sign_Up_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Bạn chưa có tài khoản?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sign_Up);
            this.Controls.Add(this.ForgotPassword);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Sign_In);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Dormi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button Sign_In;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.LinkLabel ForgotPassword;
        private System.Windows.Forms.LinkLabel Sign_Up;
        private System.Windows.Forms.Label label1;
    }
}


﻿namespace Quan_ly_san_the_thao
{
    partial class SportListForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_PersonalInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_ChangePW = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_LogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.lb_Greeting = new System.Windows.Forms.Label();
            this.lb_ChooseSport = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thoátToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 4, 0, 4);
            this.menuStrip.Size = new System.Drawing.Size(1200, 44);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.BackColor = System.Drawing.Color.LightGray;
            this.thoátToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_PersonalInfo,
            this.tsmi_ChangePW,
            this.tsmi_LogOut});
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(135, 38);
            this.thoátToolStripMenuItem.Text = "Tài khoản";
            // 
            // tsmi_PersonalInfo
            // 
            this.tsmi_PersonalInfo.BackColor = System.Drawing.Color.LightGray;
            this.tsmi_PersonalInfo.Name = "tsmi_PersonalInfo";
            this.tsmi_PersonalInfo.Size = new System.Drawing.Size(359, 44);
            this.tsmi_PersonalInfo.Text = "Thông tin cá nhân";
            this.tsmi_PersonalInfo.Click += new System.EventHandler(this.tsmi_PersonalInfo_Click);
            // 
            // tsmi_ChangePW
            // 
            this.tsmi_ChangePW.BackColor = System.Drawing.Color.LightGray;
            this.tsmi_ChangePW.Name = "tsmi_ChangePW";
            this.tsmi_ChangePW.Size = new System.Drawing.Size(359, 44);
            this.tsmi_ChangePW.Text = "Đổi mật khẩu";
            this.tsmi_ChangePW.Click += new System.EventHandler(this.tsmi_ChangePW_Click);
            // 
            // tsmi_LogOut
            // 
            this.tsmi_LogOut.BackColor = System.Drawing.Color.LightGray;
            this.tsmi_LogOut.Name = "tsmi_LogOut";
            this.tsmi_LogOut.Size = new System.Drawing.Size(359, 44);
            this.tsmi_LogOut.Text = "Đăng xuất";
            this.tsmi_LogOut.Click += new System.EventHandler(this.tsmi_LogOut_Click);
            // 
            // lb_Greeting
            // 
            this.lb_Greeting.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_Greeting.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lb_Greeting.Location = new System.Drawing.Point(4, 67);
            this.lb_Greeting.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Greeting.Name = "lb_Greeting";
            this.lb_Greeting.Size = new System.Drawing.Size(1194, 138);
            this.lb_Greeting.TabIndex = 2;
            this.lb_Greeting.Text = "CHÀO MỪNG [TÊN KHÁCH HÀNG]";
            this.lb_Greeting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_Greeting.TextChanged += new System.EventHandler(this.lb_Greeting_TextChanged);
            this.lb_Greeting.Resize += new System.EventHandler(this.lb_Greeting_Resize);
            // 
            // lb_ChooseSport
            // 
            this.lb_ChooseSport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_ChooseSport.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lb_ChooseSport.Location = new System.Drawing.Point(4, 321);
            this.lb_ChooseSport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_ChooseSport.Name = "lb_ChooseSport";
            this.lb_ChooseSport.Size = new System.Drawing.Size(1194, 85);
            this.lb_ChooseSport.TabIndex = 3;
            this.lb_ChooseSport.Text = "Xin vui lòng chọn môn";
            this.lb_ChooseSport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(18, 452);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(262, 98);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cầu lông";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(326, 452);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(262, 98);
            this.button2.TabIndex = 5;
            this.button2.Text = "Bóng rổ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(920, 452);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(262, 98);
            this.button4.TabIndex = 7;
            this.button4.Text = "Bóng đá";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(622, 452);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(262, 98);
            this.button3.TabIndex = 6;
            this.button3.Text = "Bóng chuyền";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // SportListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 704);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_ChooseSport);
            this.Controls.Add(this.lb_Greeting);
            this.Controls.Add(this.menuStrip);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "SportListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SportListForm_FormClosing);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.Label lb_Greeting;
        private System.Windows.Forms.Label lb_ChooseSport;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem tsmi_LogOut;
        private System.Windows.Forms.ToolStripMenuItem tsmi_ChangePW;
        private System.Windows.Forms.ToolStripMenuItem tsmi_PersonalInfo;
    }
}
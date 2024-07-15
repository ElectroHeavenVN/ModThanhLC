using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace DragonBoyManager
{
    public partial class MainController
    {
        private IContainer components = null;

        private TabPage tabPage1;

        private TabPage tabPage2;

        private TabPage tabPage3;

        private System.Windows.Forms.Timer update;

        private System.Windows.Forms.TabControl mainTab;

        public GroupBox groupBox1;

        private TabControl tabControl1;

        private TabSetting tabSetting1;

        private ContextMenuStrip contextMenuStrip1;

        private ToolStripMenuItem đăngNhậpToolStripMenuItem;

        private ToolStripMenuItem sửaKíchThướcToolStripMenuItem;

        private TabData tabData1;

        private TabPage tabPage4;

        private GroupBox groupBox2;

        private GroupBox groupBox3;

        public Label label5;

        public Label label3;

        public Label label1;

        public CheckBox checkBox3;

        public CheckBox checkBox4;

        public CheckBox checkBox2;

        public CheckBox checkBox1;

        private ToolStripMenuItem sửaGhiChúToolStripMenuItem;

        private ToolStripMenuItem toolStripMenuItem_3;

        private ToolStripMenuItem toolStripMenuItem_4;

        private TextBox textBox1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainController));
            this.mainTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabData1 = new DragonBoyManager.TabData();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.đăngNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaKíchThướcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaGhiChúToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_4 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new DragonBoyManager.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabSetting1 = new DragonBoyManager.TabSetting();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.update = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mainTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTab
            // 
            this.mainTab.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.mainTab.Controls.Add(this.tabPage1);
            this.mainTab.Controls.Add(this.tabPage2);
            this.mainTab.Controls.Add(this.tabPage3);
            this.mainTab.Controls.Add(this.tabPage4);
            this.mainTab.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold);
            this.mainTab.Location = new System.Drawing.Point(0, 14);
            this.mainTab.Margin = new System.Windows.Forms.Padding(4);
            this.mainTab.Name = "mainTab";
            this.mainTab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mainTab.SelectedIndex = 0;
            this.mainTab.Size = new System.Drawing.Size(1340, 587);
            this.mainTab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.mainTab.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage1.Controls.Add(this.tabData1);
            this.tabPage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(64)))), ((int)(((byte)(51)))));
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage1.Size = new System.Drawing.Size(1332, 552);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "TÀI KHOẢN";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabData1
            // 
            this.tabData1.AutoSize = true;
            this.tabData1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.tabData1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabData1.CausesValidation = false;
            this.tabData1.ContextMenuStrip = this.contextMenuStrip1;
            this.tabData1.Location = new System.Drawing.Point(3, 2);
            this.tabData1.Margin = new System.Windows.Forms.Padding(4);
            this.tabData1.Name = "tabData1";
            this.tabData1.Size = new System.Drawing.Size(1325, 546);
            this.tabData1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngNhậpToolStripMenuItem,
            this.sửaKíchThướcToolStripMenuItem,
            this.sửaGhiChúToolStripMenuItem,
            this.toolStripMenuItem_3,
            this.toolStripMenuItem_4});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(187, 124);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // toolStripMenuItem_0
            // 
            this.đăngNhậpToolStripMenuItem.Name = "toolStripMenuItem_0";
            this.đăngNhậpToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.đăngNhậpToolStripMenuItem.Text = "Đăng nhập";
            this.đăngNhậpToolStripMenuItem.Click += new System.EventHandler(this.đăngNhậpToolStripMenuItem_Click);
            // 
            // toolStripMenuItem_1
            // 
            this.sửaKíchThướcToolStripMenuItem.Name = "toolStripMenuItem_1";
            this.sửaKíchThướcToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.sửaKíchThướcToolStripMenuItem.Text = "Sửa kích thước";
            this.sửaKíchThướcToolStripMenuItem.Click += new System.EventHandler(this.sửaKíchThướcToolStripMenuItem_Click);
            // 
            // toolStripMenuItem_2
            // 
            this.sửaGhiChúToolStripMenuItem.Name = "toolStripMenuItem_2";
            this.sửaGhiChúToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.sửaGhiChúToolStripMenuItem.Text = "Sửa ghi chú";
            this.sửaGhiChúToolStripMenuItem.Click += new System.EventHandler(this.sửaGhiChúToolStripMenuItem_Click);
            // 
            // toolStripMenuItem_3
            // 
            this.toolStripMenuItem_3.Name = "toolStripMenuItem_3";
            this.toolStripMenuItem_3.Size = new System.Drawing.Size(186, 24);
            this.toolStripMenuItem_3.Text = "☑ Dùng Proxy";
            this.toolStripMenuItem_3.Click += new System.EventHandler(this.toolStripMenuItem_3_Click);
            // 
            // toolStripMenuItem_4
            // 
            this.toolStripMenuItem_4.Name = "toolStripMenuItem_4";
            this.toolStripMenuItem_4.Size = new System.Drawing.Size(186, 24);
            this.toolStripMenuItem_4.Text = "❎ Không Proxy";
            this.toolStripMenuItem_4.Click += new System.EventHandler(this.toolStripMenuItem_4_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tabControl1);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1332, 552);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ĐIỀU KHIỂN";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Size = new System.Drawing.Size(1329, 543);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tabSetting1);
            this.tabPage3.Location = new System.Drawing.Point(4, 31);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1332, 552);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "CÀI ĐẶT";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabSetting1
            // 
            this.tabSetting1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.tabSetting1.Location = new System.Drawing.Point(0, 0);
            this.tabSetting1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabSetting1.Name = "tabSetting1";
            this.tabSetting1.Size = new System.Drawing.Size(1329, 543);
            this.tabSetting1.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.tabPage4.Controls.Add(this.groupBox3);
            this.tabPage4.Controls.Add(this.groupBox2);
            this.tabPage4.Location = new System.Drawing.Point(4, 31);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage4.Size = new System.Drawing.Size(1332, 552);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "THÔNG TIN";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(9, 177);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(1312, 185);
            this.groupBox3.TabIndex = 75;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin sản phẩm";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 122);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(293, 29);
            this.textBox1.TabIndex = 76;
            this.textBox1.UseSystemPasswordChar = true;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 10.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(8, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 75;
            this.label3.Text = "Phiên bản:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 10.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(8, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 74;
            this.label1.Text = "Phiên bản:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 10.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Snow;
            this.label5.Location = new System.Drawing.Point(8, 26);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 25);
            this.label5.TabIndex = 73;
            this.label5.Text = "Phiên bản:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.checkBox4);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(9, 7);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1312, 162);
            this.groupBox2.TabIndex = 74;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Các option đã kích hoạt";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(9, 97);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(153, 27);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "OPTION: LOGO";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(9, 130);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(289, 27);
            this.checkBox4.TabIndex = 2;
            this.checkBox4.Text = "OPTION: NGỌC RỒNG SAO ĐEN";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(9, 64);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(221, 27);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "OPTION: CUSTOME KEY";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(9, 31);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(161, 27);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "OPTION: PROXY";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // timer_0
            // 
            this.update.Enabled = true;
            this.update.Interval = 500;
            this.update.Tick += new System.EventHandler(this.update_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mainTab);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(1, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1335, 601);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // MainController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 596);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainController";
            this.Text = "MainController";
            this.Load += new System.EventHandler(this.MainController_Load);
            this.mainTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}

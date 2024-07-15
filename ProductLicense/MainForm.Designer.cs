using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

partial class MainForm
{
    private IContainer components = null;

    private GroupBox groupBox_0;

    private Label label_0;

    private Label label_1;

    private Label label_2;

    private Button button_0;

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

    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        this.groupBox_0 = new System.Windows.Forms.GroupBox();
        this.button_0 = new System.Windows.Forms.Button();
        this.label_2 = new System.Windows.Forms.Label();
        this.label_0 = new System.Windows.Forms.Label();
        this.label_1 = new System.Windows.Forms.Label();
        this.groupBox_0.SuspendLayout();
        this.SuspendLayout();
        // 
        // groupBox_0
        // 
        this.groupBox_0.BackColor = System.Drawing.Color.DimGray;
        this.groupBox_0.Controls.Add(this.button_0);
        this.groupBox_0.Controls.Add(this.label_2);
        this.groupBox_0.Controls.Add(this.label_0);
        this.groupBox_0.Controls.Add(this.label_1);
        this.groupBox_0.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
        this.groupBox_0.ForeColor = System.Drawing.SystemColors.ButtonFace;
        this.groupBox_0.Location = new System.Drawing.Point(4, 0);
        this.groupBox_0.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
        this.groupBox_0.Name = "groupBox_0";
        this.groupBox_0.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
        this.groupBox_0.Size = new System.Drawing.Size(440, 122);
        this.groupBox_0.TabIndex = 0;
        this.groupBox_0.TabStop = false;
        this.groupBox_0.Text = "Thông tin sản phẩm";
        // 
        // button_0
        // 
        this.button_0.ForeColor = System.Drawing.Color.Orange;
        this.button_0.Location = new System.Drawing.Point(12, 82);
        this.button_0.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
        this.button_0.Name = "button_0";
        this.button_0.Size = new System.Drawing.Size(415, 32);
        this.button_0.TabIndex = 10;
        this.button_0.Text = "Copy License Key";
        this.button_0.UseVisualStyleBackColor = true;
        this.button_0.Click += new System.EventHandler(this.button_0_Click);
        // 
        // label_2
        // 
        this.label_2.AutoSize = true;
        this.label_2.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label_2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
        this.label_2.Location = new System.Drawing.Point(117, 58);
        this.label_2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        this.label_2.Name = "label_2";
        this.label_2.Size = new System.Drawing.Size(43, 20);
        this.label_2.TabIndex = 9;
        this.label_2.Text = "DISK";
        // 
        // label_0
        // 
        this.label_0.AutoSize = true;
        this.label_0.ForeColor = System.Drawing.Color.Gold;
        this.label_0.Location = new System.Drawing.Point(9, 54);
        this.label_0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        this.label_0.Name = "label_0";
        this.label_0.Size = new System.Drawing.Size(113, 23);
        this.label_0.TabIndex = 1;
        this.label_0.Text = "License Key:";
        // 
        // label_1
        // 
        this.label_1.AutoSize = true;
        this.label_1.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
        this.label_1.ForeColor = System.Drawing.SystemColors.ButtonFace;
        this.label_1.Location = new System.Drawing.Point(9, 27);
        this.label_1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        this.label_1.Name = "label_1";
        this.label_1.Size = new System.Drawing.Size(282, 23);
        this.label_1.TabIndex = 0;
        this.label_1.Text = "Sản phẩm: Dragon Ball Pro 2.3.7";
        // 
        // MainForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.AutoSize = true;
        this.BackColor = System.Drawing.SystemColors.ControlLight;
        this.ClientSize = new System.Drawing.Size(447, 124);
        this.Controls.Add(this.groupBox_0);
        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
        this.Name = "MainForm";
        this.Text = "Product Information";
        this.Load += new System.EventHandler(this.MainForm_Load);
        this.groupBox_0.ResumeLayout(false);
        this.groupBox_0.PerformLayout();
        this.ResumeLayout(false);

    }
}
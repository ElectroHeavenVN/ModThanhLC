using System;
using System.IO;
using System.Windows.Forms;

partial class MainForm : Form
{
    static readonly string PRODUCT_NAME = "DRAGONBALL237";

    public MainForm()
    {
        InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        string key = DeviceInformation.GenerateLicense(PRODUCT_NAME);
        if (File.Exists("Data/QLTK/key.ini"))
        {
            if (File.ReadAllText("Data/QLTK/key.ini") != key)
                File.WriteAllText("Data/QLTK/key.ini", key);
        }
        else
            File.WriteAllText("Data/QLTK/key.ini", key);
        label_2.Text = key;
    }

    private void button_0_Click(object sender, EventArgs e)
    {
        Clipboard.SetText(label_2.Text);
    }
}
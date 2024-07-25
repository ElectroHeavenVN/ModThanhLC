using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace DragonBoyManager
{
    public partial class TabSetting : UserControl
    {
        public string PathCaptcha = "Data/QLTK/tokenCaptcha.ini";

        public string PathGraphic = "Data/QLTK/GraphicSetting.ini";

        public string PathSetting = "Data/QLTK/FunctionSetting.ini";

        public string PathHotKey = "Data/QLTK/HotKey.ini";

        public string PathLanguage = "Data/QLTK/language.ini";

        public static TabSetting instance;

        public TabSetting()
        {
            InitializeComponent();
            instance = this;
        }

        public void LoadGraphicSetting()
        {
            if (File.Exists(PathLanguage))
            {
                int index = int.Parse(File.ReadAllText(PathLanguage));
                comboBox1.Text = comboBox1.Items[index].ToString();
            }
            if (!File.Exists(PathGraphic))
                return;
            string[] array = File.ReadAllText(PathGraphic).Split('|');
            if (!string.IsNullOrEmpty(array[0]))
                checkBox1.Checked = array[0].Contains("True");
            if (!string.IsNullOrEmpty(array[1]))
                checkBox2.Checked = array[1].Contains("True");
            if (!string.IsNullOrEmpty(array[2]))
                checkBox3.Checked = array[2].Contains("True");
            if (!string.IsNullOrEmpty(array[3]))
                checkBox4.Checked = array[3].Contains("True");
            if (!string.IsNullOrEmpty(array[4]))
                checkBox5.Checked = array[4].Contains("True");
            if (!string.IsNullOrEmpty(array[5]))
                checkBox6.Checked = array[5].Contains("True");
            if (!string.IsNullOrEmpty(array[6]))
                checkBox7.Checked = array[6].Contains("True");
            if (!string.IsNullOrEmpty(array[7]))
                checkBox8.Checked = array[7].Contains("True");
            if (!string.IsNullOrEmpty(array[8]))
                checkBox9.Checked = array[8].Contains("True");
            if (!string.IsNullOrEmpty(array[9]))
                checkBox16.Checked = array[9].Contains("True");
            if (!string.IsNullOrEmpty(array[10]))
                checkBox10.Checked = array[10].Contains("True");
            if (!string.IsNullOrEmpty(array[11]))
                checkBox11.Checked = array[11].Contains("True");
            if (!string.IsNullOrEmpty(array[12]))
                checkBox12.Checked = array[12].Contains("True");
            if (!string.IsNullOrEmpty(array[13]))
                checkBox13.Checked = array[13].Contains("True");
            if (!string.IsNullOrEmpty(array[14]))
                checkBox14.Checked = array[14].Contains("True");
            if (!string.IsNullOrEmpty(array[15]))
                checkBox15.Checked = array[15].Contains("True");
            if (!string.IsNullOrEmpty(array[16]))
                checkBox17.Checked = array[16].Contains("True");
            if (!string.IsNullOrEmpty(array[17]))
                textBox1.Text = array[17];
            if (!string.IsNullOrEmpty(array[18]))
                checkBox21.Checked = array[18].Contains("True");
            if (!string.IsNullOrEmpty(array[19]))
                checkBox35.Checked = array[19].Contains("True");
        }

        public void SaveGraphicSetting()
        {
            File.WriteAllText(PathGraphic, checkBox1.Checked + "|" + checkBox2.Checked + "|" + checkBox3.Checked + "|" + checkBox4.Checked + "|" + checkBox5.Checked + "|" + checkBox6.Checked + "|" + checkBox7.Checked + "|" + checkBox8.Checked + "|" + checkBox9.Checked + "|" + checkBox16.Checked + "|" + checkBox10.Checked + "|" + checkBox11.Checked + "|" + checkBox12.Checked + "|" + checkBox13.Checked + "|" + checkBox14.Checked + "|" + checkBox15.Checked + "|" + checkBox17.Checked + "|" + textBox1.Text + "|" + checkBox21.Checked + "|" + checkBox35.Checked);
        }


        public void LoadFunctionSetting()
        {
            if (!File.Exists(PathSetting))
                return;
            string[] array = File.ReadAllText(PathSetting).Split('|');
            if (!string.IsNullOrEmpty(array[0]))
                checkBox34.Checked = array[0].Contains("True");
            if (!string.IsNullOrEmpty(array[1]))
                checkBox33.Checked = array[1].Contains("True");
            if (!string.IsNullOrEmpty(array[2]))
                checkBox31.Checked = array[2].Contains("True");
            if (!string.IsNullOrEmpty(array[3]))
                checkBox32.Checked = array[3].Contains("True");
            if (!string.IsNullOrEmpty(array[4]))
                checkBox29.Checked = array[4].Contains("True");
            if (!string.IsNullOrEmpty(array[5]))
                checkBox24.Checked = array[5].Contains("True");
            if (!string.IsNullOrEmpty(array[6]))
                checkBox30.Checked = array[6].Contains("True");
            if (!string.IsNullOrEmpty(array[7]))
                checkBox27.Checked = array[7].Contains("True");
            if (!string.IsNullOrEmpty(array[8]))
                checkBox28.Checked = array[8].Contains("True");
            if (!string.IsNullOrEmpty(array[9]))
                checkBox26.Checked = array[9].Contains("True");
            if (!string.IsNullOrEmpty(array[10]))
                checkBox23.Checked = array[10].Contains("True");
            if (!string.IsNullOrEmpty(array[11]))
                checkBox25.Checked = array[11].Contains("True");
            if (!string.IsNullOrEmpty(array[12]))
                checkBox22.Checked = array[12].Contains("True");
            if (!string.IsNullOrEmpty(array[13]))
                checkBox18.Checked = array[13].Contains("True");
            if (!string.IsNullOrEmpty(array[14]))
                checkBox19.Checked = array[14].Contains("True");
            if (!string.IsNullOrEmpty(array[15]))
                textBox2.Text = array[15];
            if (!string.IsNullOrEmpty(array[16]))
                textBox3.Text = array[16];
            if (!string.IsNullOrEmpty(array[17]))
                checkBox20.Checked = array[17].Contains("True");
            if (!string.IsNullOrEmpty(array[18]))
                comboBox5.Text = ((MainController.language == 0) ? comboBox5.Items[int.Parse(array[18]) - 1].ToString() : ((int.Parse(array[18]) == 1) ? "1.Flag Color" : ((int.Parse(array[18]) == 2) ? "2.Clan Name" : "3.Default")));
            if (!string.IsNullOrEmpty(array[19]))
                checkBox36.Checked = array[19].Contains("True");
        }

        public void SaveFunctionSetting()
        {
            if (comboBox5.Text == null || comboBox5.Text == "")
                return;
            File.WriteAllText(PathSetting, checkBox34.Checked + "|" + checkBox33.Checked + "|" + checkBox31.Checked + "|" + checkBox32.Checked + "|" + checkBox29.Checked + "|" + checkBox24.Checked + "|" + checkBox30.Checked + "|" + checkBox27.Checked + "|" + checkBox28.Checked + "|" + checkBox26.Checked + "|" + checkBox23.Checked + "|" + checkBox25.Checked + "|" + checkBox22.Checked + "|" + checkBox18.Checked + "|" + checkBox19.Checked + "|" + textBox2.Text + "|" + textBox3.Text + "|" + checkBox20.Checked + "|" + comboBox5.Text.Split('.')[0] + "|" + checkBox36.Checked);
        }

        public void LoadCaptcha()
        {
            if (File.Exists(PathCaptcha))
                textBox4.Text = File.ReadAllText(PathCaptcha);
        }

        public void SaveCaptcha()
        {
            File.WriteAllText(PathCaptcha, textBox4.Text);
        }

        public void loadLanguage()
        {
            if (MainController.language != 1)
                return;
            groupBox1.Text = "Graphic Setting";
            label2.Text = "Color:";
            checkBox16.Text = "Freeze Mob";
            checkBox15.Text = "Special UI";
            checkBox17.Text = "Use Color BG";
            checkBox14.Text = "Use Image BG";
            checkBox13.Text = "Optimize Terrain";
            checkBox11.Text = "Hide Image";
            checkBox12.Text = "Hide Detail";
            checkBox9.Text = "Hide Server Notification";
            checkBox10.Text = "Hide UI";
            checkBox7.Text = "Hide TileMap";
            checkBox8.Text = "Hide Backpack";
            checkBox5.Text = "Hide NPC";
            checkBox6.Text = "Hide Effects";
            checkBox3.Text = "Hide Item";
            checkBox4.Text = "Hide Terrain";
            checkBox2.Text = "Hide Mob";
            checkBox1.Text = "Hide Char";
            groupBox2.Text = "Activated functions when login game";
            checkBox20.Text = "Auto let disciple go home";
            checkBox19.Text = "Solve Capcha";
            button2.Text = "Detele Game Data";
            checkBox18.Text = "Fusion";
            label4.Text = "Run speed";
            label3.Text = "Game speed";
            checkBox22.Text = "Custome Key";
            checkBox23.Text = "Cross Terrain";
            checkBox24.Text = "Only pick chicken";
            checkBox25.Text = "Only pick myItem";
            checkBox26.Text = "Hold Tied on object";
            checkBox27.Text = "Auto connect to manager";
            checkBox28.Text = "Auto Opm CPU";
            checkBox29.Text = "Auto jump";
            checkBox30.Text = "Auto Pick";
            checkBox31.Text = "Show Obj Detail";
            checkBox32.Text = "Show Disciple Details";
            checkBox33.Text = "Show List.Boss.Nofi..";
            checkBox34.Text = "Show List Character";
            checkBox21.Text = "Hide World's chat";
            checkBox35.Text = "Hide Mount";
            checkBox36.Text = "VietKey";
            label5.Text = "Language:";
            label8.Text = "Mode Sort List Character: ";
            comboBox5.Items.Clear();
            comboBox5.Items.AddRange(new object[3] { "1.Flag Color", "2.Clan Name", "3.Default" });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileInfo[] files = new DirectoryInfo("Data/GameData/RMS2/").GetFiles();
            FileInfo[] files2 = new DirectoryInfo("Data/GameData/RMS1/").GetFiles();
            FileInfo[] array = files;
            for (int i = 0; i < array.Length; i++)
                array[i].Delete();
            FileInfo[] array2 = files2;
            for (int j = 0; j < array2.Length; j++)
                array2[j].Delete();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text.Split('.')[0] != File.ReadAllText(PathLanguage))
            {
                MessageBox.Show((MainController.language == 0) ? "Vui lòng mở lại QLTK để thay đổi ngôn ngữ!" : "Please reopen Game Manager to change language");
                File.WriteAllText(PathLanguage, comboBox1.Text.Split('.')[0]);
                Application.Exit();
            }
        }

        private void saveGraphicSetting_EventFired(object sender, EventArgs e)
        {
            SaveGraphicSetting();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            SaveCaptcha();
        }

        private void saveFunctionSetting_EventFired(object sender, EventArgs e)
        {
            SaveFunctionSetting();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox22.Checked)
                new HotKey().ShowDialog();
        }
    }
}

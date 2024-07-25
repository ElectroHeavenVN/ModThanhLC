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
            if (File.Exists(PathGraphic))
            {
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
        }

        public void SaveGraphicSetting()
        {
            File.WriteAllText(PathGraphic, checkBox1.Checked + "|" + checkBox2.Checked + "|" + checkBox3.Checked + "|" + checkBox4.Checked + "|" + checkBox5.Checked + "|" + checkBox6.Checked + "|" + checkBox7.Checked + "|" + checkBox8.Checked + "|" + checkBox9.Checked + "|" + checkBox16.Checked + "|" + checkBox10.Checked + "|" + checkBox11.Checked + "|" + checkBox12.Checked + "|" + checkBox13.Checked + "|" + checkBox14.Checked + "|" + checkBox15.Checked + "|" + checkBox17.Checked + "|" + textBox1.Text + "|" + checkBox21.Checked + "|" + checkBox35.Checked);
        }


        public void LoadFunctionSetting()
        {
            if (File.Exists(PathSetting))
            {
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
        }

        public void SaveFunctionSetting()
        {
            if (comboBox5.Text != null && !(comboBox5.Text == string.Empty))
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
            if (MainController.language == 1)
            {
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
                checkBox19.Text = "Solve Captcha";
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
                button5.Text = "Delete";
                button4.Text = "Edit";
                button3.Text = "Add";
                label7.Text = "Use at";
                label6.Text = "Key";
                label1.Text = "Function";
                checkBox21.Text = "Hide World's chat";
                comboBox2.Items.Clear();
                checkBox35.Text = "Hide Mount";
                checkBox36.Text = "VietKey";
                comboBox2.Items.AddRange(new object[54]
                {
                    "[0].Turn on/off auto attack", "[1].Turn on/off show object details", "[2].Open menu Xmap", "[3].Open menu function", "[4].Open tab zone", "[5].Open tab friend", "[6].Open tab capsule", "[7].Open tab chest", "[8].Change left map (Teleport to the left)", "[9].Change middle map (Teleport to the middle)",
                    "[10].Change right map (Teleport to the right)", "[11].Change focus and go to BOSS location in map", "[12].Change focus and go to NPC location in map", "[13].Teleport to Char, NPC, Mob focus", "[14].Teleport to char have BlackStarDB or Ball", "[15].Use porata/porata 2", "[16].Wear SET 1 for MASTER", "[17].Wear SET 2 for MASTER", "[18].Turn on/off Vietkey", "[19].Turn on/off Murdering Mob",
                    "[20].Turn on/off Lock Object", "[21].Turn on/off Freeze skill", "[22].Turn on/off auto get effect x7 HP", "[23].Turn on/off auto use Sattelite HP", "[24].Turn on/off auto pick up item", "[25].Turn on/off Auto Train", "[26].Send trade to character focus", "[27].Turn on/off auto recovering skills", "[28].Turn on/off optimize CPU", "[29].Turn on/off show details on screen",
                    "[30].Giảm khu auto vào", "[31].Tăng khu auto vào", "[32].Turn on/off show list character in map", "[33].Turn on/off show list boss information appear", "[34].Turn on/off auto use item", "[35].Turn on/off auto use porata when HP < 50%", "[36].Turn on/off auto change object", "[37].Turn on/off auto revive", "[38].Turn on/off auto request bean", "[39].Turn on/off auto collect and storage bean to chest",
                    "[40].Turn on/off auto give bean", "[41].Turn on/off auto let pet go home when unfusion", "[42].Wear SET 1 for DISCIPLE", "[43].Wear SET 2 for DISCIPLE", "[44].Open menu Murdering Character", "[45].Turn on/off Murdering Boss", "[46].Add/Remove Char focus to List Char-Murdering", "[47].Add/Remove Clan of char focus to List Clan-Murdering", "[48].Add/Remove Boss focus to list Boss-Murdering", "[49].Open menu lucky spin ball",
                    "[50].Capsule to previous map", "[51].Turn on/off auto train special skill (Skill 9)", "[52].Turn on/off auto open Treasure Dungeon", "[53].Turn on/off auto open One Eye Dungeon"
                });
                function.HeaderText = "Function";
                HotKey.HeaderText = "Key";
                enviroment.HeaderText = "Use at";
                comboBox4.Items.Clear();
                comboBox4.Items.AddRange(new object[2] { "[0] - Normal Map", "[1] - BlackStarDB Map" });
                label5.Text = "Language:";
                label8.Text = "Mode Sort List Character: ";
                comboBox5.Items.Clear();
                comboBox5.Items.AddRange(new object[3] { "1.Flag Color", "2.Clan Name", "3.Default" });
            }
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

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add(comboBox2.Text, comboBox3.Text, comboBox4.Text);
            SaveHotKey();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int index = dataGridView2.CurrentRow.Index;
            dataGridView2.Rows[index].Cells[0].Value = comboBox2.Text;
            dataGridView2.Rows[index].Cells[1].Value = comboBox3.Text;
            dataGridView2.Rows[index].Cells[2].Value = comboBox4.Text;
            SaveHotKey();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count > 0)
            {
                dataGridView2.Rows.RemoveAt(dataGridView2.CurrentCell.RowIndex);
                SaveHotKey();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SaveHotKey();
        }

        public void SaveHotKey()
        {
            FileStream fileStream = new FileStream("Data/QLTK/HotKey.ini", FileMode.Create, FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(fileStream);
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                string text = "Key:" + TabControl.instance.convertToKeyCode(dataGridView2.Rows[i].Cells[1].Value.ToString());
                string text2 = "Func:" + dataGridView2.Rows[i].Cells[0].Value.ToString().Split(']')[0].Split('[')[1];
                string text3 = "MapType:" + dataGridView2.Rows[i].Cells[2].Value.ToString().Substring(1, 1);
                streamWriter.Write(text + "|" + text2 + "|" + text3);
                streamWriter.WriteLine();
            }
            streamWriter.Close();
            fileStream.Close();
        }

        public void LoadHotKey()
        {
            if (File.Exists(PathHotKey))
            {
                FileStream fileStream = new FileStream("Data/QLTK/HotKey.ini", FileMode.Open, FileAccess.Read);
                StreamReader streamReader = new StreamReader(fileStream);
                for (string text = streamReader.ReadLine(); text != null; text = streamReader.ReadLine())
                {
                    string[] array = text.Split('|');
                    string text2 = ReturnKey(array[0]);
                    string text3 = ReturnFunction(array[1]);
                    string text4 = ReturnMapType(array[2]);
                    dataGridView2.Rows.Add(text3, text2, text4);
                }
                streamReader.Close();
                fileStream.Close();
            }
        }

        public string ReturnFunction(string text)
        {
            List<string> list = new List<string>();
            foreach (object item in comboBox2.Items)
            {
                list.Add(item.ToString());
            }
            foreach (string item2 in list)
            {
                if (item2.Split(']')[0].Split('[')[1] == text.Split(':')[1])
                    return item2.ToString();
            }
            return string.Empty;
        }

        public string ReturnKey(string text)
        {
            List<string> list = new List<string>();
            foreach (object item in comboBox3.Items)
            {
                list.Add(item.ToString());
            }
            foreach (string item2 in list)
            {
                if (TabControl.instance.convertToKeyCode(item2) == int.Parse(text.Split(':')[1]))
                    return item2.ToString();
            }
            return string.Empty;
        }

        public string ReturnMapType(string text)
        {
            List<string> list = new List<string>();
            foreach (object item in comboBox4.Items)
            {
                list.Add(item.ToString());
            }
            foreach (string item2 in list)
            {
                if (item2.Substring(1, 1) == text.Split(':')[1])
                    return item2.ToString();
            }
            return string.Empty;
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SaveGraphicSetting();
        }

        private void functionSetting_CheckedChanged(object sender, EventArgs e)
        {
            groupBox3.Enabled = checkBox22.Checked;
            SaveFunctionSetting();
        }

        private void graphicSetting_CheckedChanged(object sender, EventArgs e)
        {
            SaveGraphicSetting();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            SaveFunctionSetting();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            SaveCaptcha();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveFunctionSetting();
        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            SaveGraphicSetting();
        }

        private void checkBox35_CheckedChanged(object sender, EventArgs e)
        {
            SaveGraphicSetting();
        }

        private void checkBox36_CheckedChanged(object sender, EventArgs e)
        {
            SaveFunctionSetting();
        }

    }
}

using System;
using System.IO;
using System.Windows.Forms;

namespace DragonBoyManager
{
    public partial class HotKey : Form
    {
        public string pathNormalMapKeys = "Data/QLTK/NormalKey.ini";

        public string pathNRSDMapKeys = "Data/QLTK/NRSDKey.ini";

        public bool isLoad = false;

        public HotKey()
        {
            InitializeComponent();
        }

        public void AddComboBox(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            comboBox.Items.AddRange(new object[56]
            {
                "[0].Turn on/off auto attack", "[1].Turn on/off show object details", "[2].Open menu Xmap", "[3].Open menu function", "[4].Open tab zone", "[5].Open tab friend", "[6].Open tab capsule", "[7].Open tab chest", "[8].Change left map (Teleport to the left)", "[9].Change middle map (Teleport to the middle)",
                "[10].Change right map (Teleport to the right)", "[11].Change focus and go to BOSS location in map", "[12].Change focus and go to NPC location in map", "[13].Teleport to Char, NPC, Mob focus", "[14].Teleport to char have BlackStarDB or Ball", "[15].Use porata/porata 2", "[16].Wear SET 1 for MASTER", "[17].Wear SET 2 for MASTER", "[18].Turn on/off Vietkey", "[19].Turn on/off Murdering Mob",
                "[20].Turn on/off Lock Object", "[21].Turn on/off Freeze skill", "[22].Turn on/off auto get effect x7 HP", "[23].Turn on/off auto use Sattelite HP", "[24].Turn on/off auto pick up item", "[25].Turn on/off Auto Train", "[26].Send trade to character focus", "[27].Turn on/off auto recovering skills", "[28].Turn on/off optimize CPU", "[29].Turn on/off show details on screen",
                "[30].Decrease zone auto change ", "[31].Increase zone auto change", "[32].Turn on/off show list character in map", "[33].Turn on/off show list boss information appear", "[34].Turn on/off auto use item", "[35].Turn on/off auto use porata when HP < 50%", "[36].Turn on/off auto change object", "[37].Turn on/off auto revive", "[38].Turn on/off auto request bean", "[39].Turn on/off auto collect and storage bean to chest",
                "[40].Turn on/off auto give bean", "[41].Turn on/off auto let pet go home when unfusion", "[42].Wear SET 1 for DISCIPLE", "[43].Wear SET 2 for DISCIPLE", "[44].Turn on/off Murdering Character", "[45].Turn on/off Murdering Boss", "[46].Add/Remove Char focus to List Char-Murdering", "[47].Add/Remove Clan of char focus to List Clan-Murdering", "[48].Add/Remove Boss focus to list Boss-Murdering", "[49].Open menu lucky spin ball",
                "[50].Capsule to previous map", "[51].Turn on/off auto train special skill (Skill 9)", "[52].Drop blackstar DragonBall", "[53].Auto Shield", "[54].Gohome After get x7 HP effect", "[55].Auto challenge Whis"
            });
        }

        public void LoadLanguage()
        {
            if (MainController.language != 1)
                return;
            groupBox2.Text = "Setting in normal map";
            groupBox3.Text = "Setting in Black Star Dragon Ball map";
            groupBox1.Text = "Setting Custome Key <Please select all hotkey's function";
            AddComboBox(comboBox1);
            AddComboBox(comboBox2);
            AddComboBox(comboBox3);
            AddComboBox(comboBox4);
            AddComboBox(comboBox5);
            AddComboBox(comboBox6);
            AddComboBox(comboBox7);
            AddComboBox(comboBox8);
            AddComboBox(comboBox9);
            AddComboBox(comboBox10);
            AddComboBox(comboBox11);
            AddComboBox(comboBox12);
            AddComboBox(comboBox13);
            AddComboBox(comboBox14);
            AddComboBox(comboBox15);
            AddComboBox(comboBox16);
            AddComboBox(comboBox17);
            AddComboBox(comboBox18);
            AddComboBox(comboBox19);
            AddComboBox(comboBox20);
            AddComboBox(comboBox21);
            AddComboBox(comboBox22);
            AddComboBox(comboBox23);
            AddComboBox(comboBox24);
            AddComboBox(comboBox25);
            AddComboBox(comboBox26);
            AddComboBox(comboBox27);
            AddComboBox(comboBox28);
            AddComboBox(comboBox29);
            AddComboBox(comboBox30);
            AddComboBox(comboBox31);
            AddComboBox(comboBox32);
            AddComboBox(comboBox33);
            AddComboBox(comboBox34);
            AddComboBox(comboBox35);
            AddComboBox(comboBox36);
            AddComboBox(comboBox37);
            AddComboBox(comboBox38);
            AddComboBox(comboBox39);
            AddComboBox(comboBox40);
            AddComboBox(comboBox41);
            AddComboBox(comboBox42);
            AddComboBox(comboBox43);
            AddComboBox(comboBox44);
            AddComboBox(comboBox45);
            AddComboBox(comboBox46);
            AddComboBox(comboBox47);
            AddComboBox(comboBox48);
            AddComboBox(comboBox49);
            AddComboBox(comboBox50);
            AddComboBox(comboBox51);
            AddComboBox(comboBox52);
            AddComboBox(comboBox53);
            AddComboBox(comboBox54);
            AddComboBox(comboBox55);
            AddComboBox(comboBox56);
            AddComboBox(comboBox57);
            AddComboBox(comboBox58);
            AddComboBox(comboBox59);
            AddComboBox(comboBox60);
        }

        public void SaveCustomeKeySetting()
        {
            if (!isLoad)
                return;
            string contents = button1.Text.ToLower() + "|" + comboBox1.Text + "\n" + button2.Text.ToLower() + "|" + comboBox2.Text + "\n" + button3.Text.ToLower() + "|" + comboBox3.Text + "\n" + button4.Text.ToLower() + "|" + comboBox4.Text + "\n" + button5.Text.ToLower() + "|" + comboBox5.Text + "\n" + button6.Text.ToLower() + "|" + comboBox6.Text + "\n" + button7.Text.ToLower() + "|" + comboBox7.Text + "\n" + button8.Text.ToLower() + "|" + comboBox8.Text + "\n" + button9.Text.ToLower() + "|" + comboBox9.Text + "\n" + button10.Text.ToLower() + "|" + comboBox10.Text + "\n" + button11.Text.ToLower() + "|" + comboBox11.Text + "\n" + button12.Text.ToLower() + "|" + comboBox12.Text + "\n" + button13.Text.ToLower() + "|" + comboBox13.Text + "\n" + button14.Text.ToLower() + "|" + comboBox14.Text + "\n" + button15.Text.ToLower() + "|" + comboBox15.Text + "\n" + button16.Text.ToLower() + "|" + comboBox16.Text + "\n" + button17.Text.ToLower() + "|" + comboBox17.Text + "\n" + button18.Text.ToLower() + "|" + comboBox18.Text + "\n" + button19.Text.ToLower() + "|" + comboBox19.Text + "\n" + button20.Text.ToLower() + "|" + comboBox20.Text + "\n" + button21.Text.ToLower() + "|" + comboBox21.Text + "\n" + button22.Text.ToLower() + "|" + comboBox22.Text + "\n" + button23.Text.ToLower() + "|" + comboBox23.Text + "\n" + button24.Text.ToLower() + "|" + comboBox24.Text + "\n" + button25.Text.ToLower() + "|" + comboBox25.Text + "\n" + button26.Text.ToLower() + "|" + comboBox26.Text + "\n" + button27.Text.ToLower() + "|" + comboBox27.Text + "\n" + button28.Text.ToLower() + "|" + comboBox28.Text + "\n" + button29.Text.ToLower() + "|" + comboBox29.Text + "\n" + button30.Text.ToLower() + "|" + comboBox30.Text;
            File.WriteAllText(pathNormalMapKeys, contents);
            string contents2 = button31.Text.ToLower() + "|" + comboBox31.Text + "\n" + button32.Text.ToLower() + "|" + comboBox32.Text + "\n" + button33.Text.ToLower() + "|" + comboBox33.Text + "\n" + button34.Text.ToLower() + "|" + comboBox34.Text + "\n" + button35.Text.ToLower() + "|" + comboBox35.Text + "\n" + button36.Text.ToLower() + "|" + comboBox36.Text + "\n" + button37.Text.ToLower() + "|" + comboBox37.Text + "\n" + button38.Text.ToLower() + "|" + comboBox38.Text + "\n" + button39.Text.ToLower() + "|" + comboBox39.Text + "\n" + button40.Text.ToLower() + "|" + comboBox40.Text + "\n" + button41.Text.ToLower() + "|" + comboBox41.Text + "\n" + button42.Text.ToLower() + "|" + comboBox42.Text + "\n" + button43.Text.ToLower() + "|" + comboBox43.Text + "\n" + button44.Text.ToLower() + "|" + comboBox44.Text + "\n" + button45.Text.ToLower() + "|" + comboBox45.Text + "\n" + button46.Text.ToLower() + "|" + comboBox46.Text + "\n" + button47.Text.ToLower() + "|" + comboBox47.Text + "\n" + button48.Text.ToLower() + "|" + comboBox48.Text + "\n" + button49.Text.ToLower() + "|" + comboBox49.Text + "\n" + button50.Text.ToLower() + "|" + comboBox50.Text + "\n" + button51.Text.ToLower() + "|" + comboBox51.Text + "\n" + button52.Text.ToLower() + "|" + comboBox52.Text + "\n" + button53.Text.ToLower() + "|" + comboBox53.Text + "\n" + button54.Text.ToLower() + "|" + comboBox54.Text + "\n" + button55.Text.ToLower() + "|" + comboBox55.Text + "\n" + button56.Text.ToLower() + "|" + comboBox56.Text + "\n" + button57.Text.ToLower() + "|" + comboBox57.Text + "\n" + button58.Text.ToLower() + "|" + comboBox58.Text + "\n" + button59.Text.ToLower() + "|" + comboBox59.Text + "\n" + button60.Text.ToLower() + "|" + comboBox60.Text;
            File.WriteAllText(pathNRSDMapKeys, contents2);
        }

        public void LoadNormalSetting()
        {
            try
            {
                if (!File.Exists(pathNormalMapKeys))
                    return;
                string[] array = File.ReadAllLines(pathNormalMapKeys);
                comboBox1.Text = array[0].Split('|')[1];
                comboBox2.Text = array[1].Split('|')[1];
                comboBox3.Text = array[2].Split('|')[1];
                comboBox4.Text = array[3].Split('|')[1];
                comboBox5.Text = array[4].Split('|')[1];
                comboBox6.Text = array[5].Split('|')[1];
                comboBox7.Text = array[6].Split('|')[1];
                comboBox8.Text = array[7].Split('|')[1];
                comboBox9.Text = array[8].Split('|')[1];
                comboBox10.Text = array[9].Split('|')[1];
                comboBox11.Text = array[10].Split('|')[1];
                comboBox12.Text = array[11].Split('|')[1];
                comboBox13.Text = array[12].Split('|')[1];
                comboBox14.Text = array[13].Split('|')[1];
                comboBox15.Text = array[14].Split('|')[1];
                comboBox16.Text = array[15].Split('|')[1];
                comboBox17.Text = array[16].Split('|')[1];
                comboBox18.Text = array[17].Split('|')[1];
                comboBox19.Text = array[18].Split('|')[1];
                comboBox20.Text = array[19].Split('|')[1];
                comboBox21.Text = array[20].Split('|')[1];
                comboBox22.Text = array[21].Split('|')[1];
                comboBox23.Text = array[22].Split('|')[1];
                comboBox24.Text = array[23].Split('|')[1];
                comboBox25.Text = array[24].Split('|')[1];
                comboBox26.Text = array[25].Split('|')[1];
                comboBox27.Text = array[26].Split('|')[1];
                comboBox28.Text = array[27].Split('|')[1];
                comboBox29.Text = array[28].Split('|')[1];
                comboBox30.Text = array[29].Split('|')[1];
            }
            catch { }
        }

        public void LoadNRSDSetting()
        {
            try
            {
                if (!File.Exists(pathNRSDMapKeys))
                    return;
                string[] array = File.ReadAllLines(pathNRSDMapKeys);
                comboBox31.Text = array[0].Split('|')[1];
                comboBox32.Text = array[1].Split('|')[1];
                comboBox33.Text = array[2].Split('|')[1];
                comboBox34.Text = array[3].Split('|')[1];
                comboBox35.Text = array[4].Split('|')[1];
                comboBox36.Text = array[5].Split('|')[1];
                comboBox37.Text = array[6].Split('|')[1];
                comboBox38.Text = array[7].Split('|')[1];
                comboBox39.Text = array[8].Split('|')[1];
                comboBox40.Text = array[9].Split('|')[1];
                comboBox41.Text = array[10].Split('|')[1];
                comboBox42.Text = array[11].Split('|')[1];
                comboBox43.Text = array[12].Split('|')[1];
                comboBox44.Text = array[13].Split('|')[1];
                comboBox45.Text = array[14].Split('|')[1];
                comboBox46.Text = array[15].Split('|')[1];
                comboBox47.Text = array[16].Split('|')[1];
                comboBox48.Text = array[17].Split('|')[1];
                comboBox49.Text = array[18].Split('|')[1];
                comboBox50.Text = array[19].Split('|')[1];
                comboBox51.Text = array[20].Split('|')[1];
                comboBox52.Text = array[21].Split('|')[1];
                comboBox53.Text = array[22].Split('|')[1];
                comboBox54.Text = array[23].Split('|')[1];
                comboBox55.Text = array[24].Split('|')[1];
                comboBox56.Text = array[25].Split('|')[1];
                comboBox57.Text = array[26].Split('|')[1];
                comboBox58.Text = array[27].Split('|')[1];
                comboBox59.Text = array[28].Split('|')[1];
                comboBox60.Text = array[29].Split('|')[1];
            }
            catch { }
        }

        private void HotKey_Load(object sender, EventArgs e)
        {
            if (!isLoad)
            {
                Text = (MainController.language == 0) ? "Cài đặt Custome Key" : "Custome Key Setting";
                LoadLanguage();
                LoadNRSDSetting();
                LoadNormalSetting();
                isLoad = true;
            }
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveCustomeKeySetting();
        }
    }
}
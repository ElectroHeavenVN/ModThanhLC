using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DragonBoyManager
{
	public partial class TabControl : UserControl
	{
		public static TabControl instance;

		public TabControl()
		{
			InitializeComponent();
			instance = this;
		}

		private void TabControl_Load(object sender, EventArgs e)
		{
		}

		public void loadLanguage()
		{
			if (MainController.language == 1)
			{
				button156.Text = "Chat/Press Key";
				groupBox1.Text = "Control [Map] - [Zone]";
				button111.Text = "To location";
				checkBox1.Text = "Au.change zone";
				button110.Text = "Ch.zone";
				tabPage1.Text = "Earth";
				button11.Text = "140.Potaufeu Cave";
				button10.Text = "139.Potaufeu Planet";
				button25.Text = "166.Prison Planet";
				button26.Text = "155.Prison Planet";
				button27.Text = "154.Beerus Planet";
				button28.Text = "112.Baba Tournament";
				button29.Text = "50.The Sacred World of t.Kais";
				button30.Text = "48.Kaio Planet";
				button17.Text = "45.Sama Place";
				button18.Text = "46.Karin Tower";
				button19.Text = "47.Karin Forest";
				button20.Text = "24.Spaceship station";
				button12.Text = "111.East South Karin";
				button13.Text = "30.Bulong Island";
				button14.Text = "29.South Kame";
				button15.Text = "29.Fern Forest";
				button16.Text = "27.Bamboo Forest";
				button5.Text = "6.East Karin";
				button6.Text = "5.Kame Island";
				button7.Text = "4.Bone Forest";
				button8.Text = "3.Mushroom Forest";
				button4.Text = "2.Bamboo Valley";
				button3.Text = "1.Chrysanthemum Hill";
				button2.Text = "0.Aru Village";
				button1.Text = "42.Aru Cliff";
				tabPage2.Text = "Namek";
				button39.Text = "25.Spaceship Station";
				button41.Text = "31.Yellow Flower Mountain";
				button42.Text = "34.East South Guru";
				button43.Text = "33.South Guru";
				button44.Text = "32.Purple Flower Mountain";
				button45.Text = "10.Namek Valley";
				button46.Text = "13.Guru Island";
				button47.Text = "12.Maima Deep";
				button48.Text = "11.Maima Valley";
				button49.Text = "9.Moori Town";
				button50.Text = "8.Purple Mushroom Hill";
				button51.Text = "7.Moori Village";
				button52.Text = "43.Moori Cliff";
				tabPage3.Text = "Sayda";
				button9.Text = "52.W.M.A Tournament";
				button36.Text = "104.Backyard Super Market";
				button37.Text = "26.Spaceship Station";
				button38.Text = "19.Vegeta City";
				button40.Text = "20.Black Cliff";
				button53.Text = "84.Super Market";
				button54.Text = "35.Palm Forest";
				button55.Text = "38.Black Deep";
				button56.Text = "37.Black Valley";
				button57.Text = "36.Stone Forest";
				button58.Text = "18.Sayda Pine Forest";
				button59.Text = "17.Primary Forest";
				button60.Text = "16.Plant Village";
				button61.Text = "15.Abadon Hill";
				button62.Text = "14.Kakarot Village";
				button63.Text = "44.Kakarot Cliff";
				button64.Text = "129.W.M.A Tournament";
				button65.Text = "113.Super Rank Tournament";
				tabPage4.Text = "Fide";
				button23.Text = "133.Yardart Planet 3";
				button31.Text = "132.Yardart Planet 2";
				button32.Text = "131.Yardart Planet";
				button33.Text = "80.Yellow Monkey Mountain";
				button34.Text = "79.Red Monkey Mountain";
				button35.Text = "83.Black Monkey Cave";
				button66.Text = "82.Black Monkey Mountain";
				button67.Text = "77.Stone Forest";
				button68.Text = "76.Stone Mountain";
				button69.Text = "75.Dead Cliff";
				button70.Text = "81.Devil Bird Cave";
				button71.Text = "66.Old Evil Camp";
				button72.Text = "74.Frieza Trees Hill";
				button73.Text = "73.Dead Hill";
				button74.Text = "67.Dead Deep";
				button75.Text = "63.Frieza Camp";
				button76.Text = "65.Evil Trees Mountain";
				button77.Text = "64.Vines Mountain";
				button78.Text = "72.Rapsberry Valley";
				button79.Text = "71.Rapssberry Base";
				button80.Text = "70.Appule Mountain";
				button81.Text = "69.Forbidden Deep";
				button82.Text = "68.Nappa Valley";
				tabPage5.Text = "Future";
				button21.Text = "100.Ginder Town";
				button22.Text = "103.Cell Tournament";
				button24.Text = "99.North Valley";
				button83.Text = "98.North Mountain";
				button84.Text = "97.North City";
				button85.Text = "96.Highlands";
				button86.Text = "94.Sasebo Islands";
				button87.Text = "93.South City";
				button88.Text = "92.East City";
				button89.Text = "102.Bulma Home";
				tabPage6.Text = "Cold";
				button90.Text = "105.Snow Field";
				button91.Text = "106.Snow Forest";
				button92.Text = "110.Frozen Cave";
				button93.Text = "107.Snow Mountain";
				button94.Text = "108.Frozen River";
				button95.Text = "109.Frozen Forest";
				tabPage7.Text = "Gas.Dungeon";
				button96.Text = "148.Evil Castle";
				button97.Text = "151.Dark Planet";
				button98.Text = "152.Land of Ice";
				button99.Text = "147.Desert";
				button100.Text = "149.Santa City";
				tabPage8.Text = "ClanArea&Trea.Dungeon";
				button101.Text = "137.Treasure Cave";
				button102.Text = "136.Octopus Cave";
				button103.Text = "138.Priave Port";
				button104.Text = "135.Pirate Cave";
				button105.Text = "159.South Kai's Sacred World";
				button106.Text = "158.North Kai's Sacred World";
				button107.Text = "157.East Kai's Sacred World";
				button108.Text = "156.West Kai's Sacred World";
				button109.Text = "153.Clan Area";
				tabPage9.Text = "BlackStarDBs";
				button112.Text = "91.Planet Tigere";
				button113.Text = "90.Planet Gelbo";
				button114.Text = "89.Planet Rudeeze";
				button115.Text = "88.Planet Monmaasu";
				button116.Text = "87.Planet Cretaceous";
				button117.Text = "86.Planet Polaris";
				button118.Text = "85.Planet M-2";
				groupBox2.Text = "Control functions";
				checkBox10.Text = "Fusion";
				checkBox9.Text = "Auto Tele ID:";
				checkBox8.Text = "A.Train";
				checkBox6.Text = "LockMap";
				checkBox7.Text = "LockZone";
				checkBox5.Text = "GreyFlag";
				checkBox4.Text = "OtmCPU";
				checkBox3.Text = "AutoJump";
				checkBox2.Text = "Req.Bean";
				button147.Text = "TELE";
				button164.Text = "To Boss Appear";
				button161.Text = "FOCUS NPC";
				button162.Text = "FOCUS BOSS";
				button163.Text = "Capsule.to last.map";
				button160.Text = "Revive";
				button141.Text = "Go Home";
				button157.Text = "Food";
				button155.Text = "DOn.Trainsuit";
				button152.Text = "DOff.Trainsuit";
				button150.Text = "Normal";
				button129.Text = "Anti.Cold";
				button128.Text = "Use.Item ID:";
				button127.Text = "F.Mask";
				button125.Text = "CA2";
				button126.Text = "CA";
				button123.Text = "RP2";
				button124.Text = "RP";
				button121.Text = "EKI2";
				button122.Text = "EKI";
				button120.Text = "EHP2";
				button119.Text = "EHP";
				button139.Text = "Recov.Skill";
				tabPage10.Text = "Plant Planet";
				button158.Text = "163.Ancestral Plant Village";
				button159.Text = "162.Primitive Forest";
				button165.Text = "161.T.Edge of T.Primitive Forest";
				button166.Text = "160.Cave Area";
			}
		}

		public void sendMessage(int cmdIndex, object sender, string type)
		{
			if (type != "mapID")
            {
                if (type == "keyIndex")
                {
                    HotKeys(cmdIndex, sender.ToString());
                    return;
                }
                byte[] bytes = Encoding.ASCII.GetBytes(sender.ToString());
                {
                    foreach (Account account in TabData._instance.GetAccounts())
                    {
                        if (account.status == ((MainController.language == 0) ? "Đã kết nối" : "Connected"))
                            account.sendMessage(new SocketServer.vMessage
                            {
                                cmd = cmdIndex,
                                data = bytes
                            });
                    }
                    return;
                }
            }
            List<Account> accounts = TabData._instance.GetAccounts();
			byte[] bytes2 = Encoding.ASCII.GetBytes(sender.ToString().Split('.')[0]);
			foreach (Account item in accounts)
			{
				if (item.status == ((MainController.language == 0) ? "Đã kết nối" : "Connected"))
					item.sendMessage(new SocketServer.vMessage
					{
						cmd = cmdIndex,
						data = bytes2
					});
			}
		}

		public void HotKeys(int cmd, string InputCharacter)
		{
			if (InputCharacter == null)
				return;
			byte[] bytes = Encoding.ASCII.GetBytes(InputCharacter);
			foreach (Account account in TabData._instance.GetAccounts())
			{
				if (account.status == ((MainController.language == 0) ? "Đã kết nối" : "Connected"))
					account.sendMessage(new SocketServer.vMessage
					{
						cmd = cmd,
						data = bytes
					});
			}
		}

		public int convertToKeyCode(string text)
		{
			return char.Parse(text);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button26_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button27_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button28_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button29_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button30_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button17_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button18_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button19_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button20_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button9_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button10_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button11_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button12_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button13_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button14_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button15_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button16_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button5_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button6_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button7_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button8_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button4_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button3_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button2_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button25_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button52_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button41_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button42_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button43_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button44_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button45_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button46_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button47_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button48_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button49_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button50_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button51_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button39_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button65_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button37_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button38_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button40_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button53_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button54_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button55_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button56_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button57_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button58_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button59_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button60_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button61_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button62_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button63_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button64_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button36_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button82_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button31_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button32_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button33_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button34_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button35_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button66_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button67_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button68_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button69_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button70_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button71_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button72_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button73_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button74_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button75_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button76_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button77_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button78_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button79_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button80_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button81_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button23_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button89_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button22_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button24_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button83_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button84_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button85_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button86_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button87_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button88_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button21_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button95_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button91_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button92_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button93_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button94_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button90_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button100_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button97_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button98_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button99_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button96_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button109_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button102_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button103_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button104_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button105_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button106_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button107_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button108_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button101_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button118_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button113_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button114_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button115_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button116_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button117_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button112_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button143_Click(object sender, EventArgs e)
		{
			sendMessage(7, "f1", "keyIndex");
		}

		private void button142_Click(object sender, EventArgs e)
		{
			sendMessage(7, "f2", "keyIndex");
		}

		private void button140_Click(object sender, EventArgs e)
		{
			sendMessage(7, "enter", "keyIndex");
		}

		private void button161_Click(object sender, EventArgs e)
		{
			sendMessage(7, "w", "keyIndex");
		}

		private void button162_Click(object sender, EventArgs e)
		{
			sendMessage(7, "e", "keyIndex");
		}

		private void button151_Click(object sender, EventArgs e)
		{
			sendMessage(7, "j", "keyIndex");
		}

		private void button153_Click(object sender, EventArgs e)
		{
			sendMessage(7, "k", "keyIndex");
		}

		private void button154_Click(object sender, EventArgs e)
		{
			sendMessage(7, "l", "keyIndex");
		}

		private void button144_Click(object sender, EventArgs e)
		{
			sendMessage(7, "up", "keyIndex");
		}

		private void button146_Click(object sender, EventArgs e)
		{
			sendMessage(7, "left", "keyIndex");
		}

		private void button148_Click(object sender, EventArgs e)
		{
			sendMessage(7, "down", "keyIndex");
		}

		private void button149_Click(object sender, EventArgs e)
		{
			sendMessage(7, "right", "keyIndex");
		}

		private void button110_Click(object sender, EventArgs e)
		{
			sendMessage(2, numericUpDown1.Value.ToString(), "zoneID");
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			sendMessage(20, checkBox1.Checked.ToString().ToLower() + "|" + numericUpDown2.Value, "AutoZone");
		}

		private void button111_Click(object sender, EventArgs e)
		{
			sendMessage(9, numericUpDown3.Value + "|" + numericUpDown4.Value, "GoToPosition");
		}

		private void button160_Click(object sender, EventArgs e)
		{
			sendMessage(17, "hoisinh", "recovering");
		}

		private void button164_Click(object sender, EventArgs e)
		{
			sendMessage(8, "boss", "goToMapBossFirstAppearance");
		}

		private void button163_Click(object sender, EventArgs e)
		{
			sendMessage(25, "true", "capsuleToBackwardMap");
		}

		private void button156_Click(object sender, EventArgs e)
		{
			new ChatTable().Show();
		}

		private void button147_Click(object sender, EventArgs e)
		{
			sendMessage(4, textBox4.Text, "Teleport");
		}

		private void checkBox9_CheckedChanged(object sender, EventArgs e)
		{
			sendMessage(5, checkBox9.Checked.ToString().ToLower() + "|" + textBox5.Text, "AutoTeleport");
		}

		private void button132_Click(object sender, EventArgs e)
		{
			sendMessage(6, ((Button)sender).Text, "useSkill");
		}

		private void button131_Click(object sender, EventArgs e)
		{
			sendMessage(6, ((Button)sender).Text, "useSkill");
		}

		private void button130_Click(object sender, EventArgs e)
		{
			sendMessage(6, ((Button)sender).Text, "useSkill");
		}

		private void button134_Click(object sender, EventArgs e)
		{
			sendMessage(6, ((Button)sender).Text, "useSkill");
		}

		private void button135_Click(object sender, EventArgs e)
		{
			sendMessage(6, ((Button)sender).Text, "useSkill");
		}

		private void button133_Click(object sender, EventArgs e)
		{
			sendMessage(6, ((Button)sender).Text, "useSkill");
		}

		private void button137_Click(object sender, EventArgs e)
		{
			sendMessage(6, ((Button)sender).Text, "useSkill");
		}

		private void button138_Click(object sender, EventArgs e)
		{
			sendMessage(6, ((Button)sender).Text, "useSkill");
		}

		private void button136_Click(object sender, EventArgs e)
		{
			sendMessage(6, ((Button)sender).Text, "useSkill");
		}

		private void button141_Click(object sender, EventArgs e)
		{
			sendMessage(16, "", "goHome");
		}

		private void button139_Click(object sender, EventArgs e)
		{
			sendMessage(3, "/rcvs", "chat");
		}

		private void button119_Click(object sender, EventArgs e)
		{
			sendMessage(19, 382, "useItem");
		}

		private void button122_Click(object sender, EventArgs e)
		{
			sendMessage(19, 383, "useItem");
		}

		private void button124_Click(object sender, EventArgs e)
		{
			sendMessage(19, 381, "useItem");
		}

		private void button126_Click(object sender, EventArgs e)
		{
			sendMessage(19, 384, "useItem");
		}

		private void button127_Click(object sender, EventArgs e)
		{
			sendMessage(19, 764, "useItem");
		}

		private void button120_Click(object sender, EventArgs e)
		{
			sendMessage(19, 1152, "useItem");
		}

		private void button121_Click(object sender, EventArgs e)
		{
			sendMessage(19, 1151, "useItem");
		}

		private void button123_Click(object sender, EventArgs e)
		{
			sendMessage(19, 1150, "useItem");
		}

		private void button125_Click(object sender, EventArgs e)
		{
			sendMessage(19, 1153, "useItem");
		}

		private void button129_Click(object sender, EventArgs e)
		{
			sendMessage(27, "null", "khanglanh");
		}

		private void button128_Click(object sender, EventArgs e)
		{
			sendMessage(19, textBox1.Text, "useItem");
		}

		private void button167_Click(object sender, EventArgs e)
		{
			sendMessage(24, "true", "capsuleBom");
		}

		private void button168_Click(object sender, EventArgs e)
		{
			sendMessage(23, textBox6.Text, "teleportBom");
		}

		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{
			sendMessage(10, ((CheckBox)sender).Checked.ToString(), "xindau");
		}

		private void checkBox5_CheckedChanged(object sender, EventArgs e)
		{
			sendMessage(13, ((CheckBox)sender).Checked.ToString(), "coxam");
		}

		private void checkBox3_CheckedChanged(object sender, EventArgs e)
		{
			sendMessage(14, ((CheckBox)sender).Checked.ToString(), "autojump");
		}

		private void checkBox4_CheckedChanged(object sender, EventArgs e)
		{
			sendMessage(15, ((CheckBox)sender).Checked.ToString(), "Toiuucpu");
		}

		private void checkBox8_CheckedChanged(object sender, EventArgs e)
		{
			sendMessage(18, ((CheckBox)sender).Checked.ToString(), "useTDLT");
		}

		private void checkBox6_CheckedChanged(object sender, EventArgs e)
		{
			sendMessage(21, ((CheckBox)sender).Checked.ToString(), "khoaMap");
		}

		private void checkBox7_CheckedChanged(object sender, EventArgs e)
		{
			sendMessage(22, ((CheckBox)sender).Checked.ToString(), "khoaKhu");
		}

		private void checkBox10_CheckedChanged(object sender, EventArgs e)
		{
			sendMessage(26, ((CheckBox)sender).Checked.ToString(), "hopthe");
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{
		}

		private void button9_Click_1(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button10_Click_1(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button11_Click_1(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button155_Click(object sender, EventArgs e)
		{
			sendMessage(28, "null", "macglt");
		}

		private void button152_Click(object sender, EventArgs e)
		{
			sendMessage(29, "null", "thaoglt");
		}

		private void button150_Click(object sender, EventArgs e)
		{
			sendMessage(30, "null", "binhthuong");
		}

		private void button157_Click(object sender, EventArgs e)
		{
			sendMessage(31, "null", "dungthucan");
		}

		private void button158_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button165_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button159_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button166_Click(object sender, EventArgs e)
		{
			sendMessage(1, ((Button)sender).Text, "mapID");
		}

		private void button169_Click(object sender, EventArgs e)
		{
			sendMessage(1, textBox2.Text, "mapID");
		}

	}
}

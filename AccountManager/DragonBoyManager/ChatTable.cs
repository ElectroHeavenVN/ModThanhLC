using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragonBoyManager
{
    public partial class ChatTable : Form
    {
        public static string ChatContent = string.Empty;

        public static string PressContent;

        public ChatTable()
        {
            InitializeComponent();
        }

        public void loadLanguage()
        {
            if (MainController.language == 1)
            {
                Text = "Chat/Key window";
                groupBox1.Text = "Fill command to the Textbox";
                label1.Text = "Note: To chat multiple commands, separate each command by \"|\".";
                label2.Text = "Example: /xd|/td|/cd";
                label3.Text = "Example: a|b|c|d";
                label4.Text = "Note: To press multiple Key, separate each ascii Key by |";
                button2.Text = "Press Keys";
            }
        }

        private void ChatTable_Load(object sender, EventArgs e)
        {
            textBox1.Text = ChatContent;
            loadLanguage();
        }

        async void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show((MainController.language == 0) ? "Chưa nhập nội dung chat!" : "Chat content is empty!");
                return;
            }

            if (textBox1.Text.Contains("|"))
            {
                string[] contents = textBox1.Text.Split('|');
                for (int i = 0; i < contents.Length; i++)
                {
                    TabControl.instance.sendMessage(3, contents[i], "chat");
                    await Task.Delay(1000);
                }
            }
            else
                TabControl.instance.sendMessage(3, textBox1.Text, "chat");
            ChatContent = textBox1.Text;
        }

        async void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show((MainController.language == 0) ? "Chưa nhập nội dung bấm!" : "KeyPress content is empty!");
                return;
            }

            if (textBox2.Text.Contains("|"))
            {
                string[] contents = textBox2.Text.Split('|');
                for (int i = 0; i < contents.Length; i++)
                {
                    TabControl.instance.sendMessage(7, contents[i], "keyIndex");
                    await Task.Delay(1000);
                }
            }
            else
                TabControl.instance.sendMessage(7, textBox2.Text, "keyIndex");
            PressContent = textBox2.Text;
        }
    }
}

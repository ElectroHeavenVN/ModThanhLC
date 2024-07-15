using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DragonBoyManager
{
    public partial class SetTitle : Form
	{
		public List<Account> currentList;

		public SetTitle(List<Account> currentList)
		{
			InitializeComponent();
			this.currentList = currentList;
		}

		private void SetTitle_Load(object sender, EventArgs e)
		{
			loadLanguage();
			Text = $"Note {currentList.Count} TK";
		}

		public void loadLanguage()
		{
			if (MainController.language == 1)
			{
				groupBox1.Text = "Edit Note";
				button1.Text = "Save";
				label1.Text = "Note";
			}
		}

		public void saveData()
		{
			foreach (Account current in currentList)
			{
				current.Note = textBox1.Text;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			saveData();
			TabData._instance.SaveData();
			TabData._instance.Refresh();
			Close();
		}
	}
}

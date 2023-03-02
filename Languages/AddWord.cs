using LanguageApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Languages
{
    public partial class AddWord : Form
    {
		private WordList _wordList;
		private List<TextBox> textBoxes = new();
		public AddWord(WordList wordList)
		{
			InitializeComponent();
			_wordList = wordList;
		}


        private void dataGridEnglish_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void AddRows_Click(object sender, EventArgs e)
        {
			List<string> translations = new();
			foreach (var textbox in textBoxes)
			{
				translations.Add(textbox.Text);
			}
			_wordList.Add(translations.ToArray());
			Close();
		}

        private void RemoveRows_Click(object sender, EventArgs e)
        {
            
        }

		private void English_Load(object sender, EventArgs e)
		{
			int height = 30;

			for (int i = 0; i < _wordList.Languages.Length; i++)
			{
				Label languageLabel = new Label();
				languageLabel.Text = _wordList.Languages[i];
				TextBox newWordTextBox = new TextBox();
				newWordTextBox.Size = new Size(130, 25);
				newWordTextBox.Location = new Point(180, height * i + 30);
				languageLabel.Location = new Point(10, height * i + 30);
				AddWords.Controls.Add(languageLabel);
				AddWords.Controls.Add(newWordTextBox);
				textBoxes.Add(newWordTextBox);
			}

		}

		private void AddWords_Enter(object sender, EventArgs e)
		{

		}
	}
}

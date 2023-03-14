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
	public partial class Practice : Form
	{
		private WordList wordList;
		private Word practiceWord;
		private List<Word> wordsList;
		private Word currentWord;
		private Random random = new Random();
		private int correctCount = 0;
		private int incorrectCount = 0;
		private int selectedLanguage;

		public Practice(WordList wordlist)
		{
			InitializeComponent();
			wordList = wordlist;
		}

		private void Practice_Load(object sender, EventArgs e)
		{

			ShowNextWord();
		}

		private void ShowNextWord()
		{
			try
			{
				practiceWord = wordList.GetWordToPractice();
				labelFromLanguage.Text = wordList.Languages[practiceWord.FromLanguage];
				labelToLanguage.Text = wordList.Languages[practiceWord.ToLanguage];
				labelWord.Text = practiceWord.Translations[practiceWord.FromLanguage];
				textBoxTranslation.Text = "";
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				Close();
			}
		}

		private void labelFromLanguage_Click(object sender, EventArgs e)
		{

		}

		private void buttonCheck_Click(object sender, EventArgs e)
		{
			if (textBoxTranslation.Text.ToLower() == practiceWord.Translations[practiceWord.ToLanguage].ToLower())
			{
				correctCount++;
				labelResult.Text = "Correct!";
				labelResult.ForeColor = Color.Green;
			}
			else
			{
				incorrectCount++;
				labelResult.Text = "Incorrect!";
				labelResult.ForeColor = Color.Red;
			}
			ShowNextWord();

		}

		private void buttonFinish_Click(object sender, EventArgs e)
		{
			MessageBox.Show($"You got {correctCount} out of {correctCount + incorrectCount} correct!");
			Close();
		}

		private void Practice_Load_1(object sender, EventArgs e)
		{
			ShowNextWord();
		}

		private void labelWord_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}

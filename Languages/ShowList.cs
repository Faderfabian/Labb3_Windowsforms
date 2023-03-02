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
	public partial class ShowList : Form
	{
		private WordList selectedList;

		public ShowList(WordList wordlist)
		{
			selectedList = wordlist;
			InitializeComponent();

		}

		private void ShowList_Load(object sender, EventArgs e)
		{
			foreach (string lang in selectedList.Languages)
			{
				dgvWords.Columns.Add(lang, lang);
			}
			selectedList.List(0, (string[] translations) => dgvWords.Rows.Add(translations));
		}

		private void ListWord(string[] translatations)
		{
			dgvWords.Rows.Add(translatations);
		}

		private void dgvWords_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}

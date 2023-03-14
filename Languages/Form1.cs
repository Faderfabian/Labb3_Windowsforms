using LanguageApp;

namespace Languages
{
    public partial class Form1 : Form
    {
		private string[] lists;
		private WordList loadedList;
		private int selectedLanguage;

		public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(text: $"About", "About", MessageBoxButtons.OKCancel);
        }

        private void EnglishButton_Click(object sender, EventArgs e)
        {
            AddWord eng = new AddWord(loadedList);
            eng.ShowDialog();
        }



        private void Loadlists()
        {
			lists = WordList.GetLists();
			languageList.Items.Clear();
			foreach (var list in lists)
			{
				languageList.Items.Add(list);
			}
		}

		private void Form1_load(object sender, EventArgs e)
		{
			Loadlists();
		}

		private void languageList_SelectedIndexChanged(object sender, EventArgs e)
		{
          string name = languageList.SelectedItem.ToString();
            loadedList = WordList.LoadList(name);
            languages.Items.Clear();
            foreach (string lang in loadedList.Languages)
            {
                languages.Items.Add(lang);
            }
        }

		private void languages_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void SwedishButton_Click(object sender, EventArgs e)
		{
            ShowList showlist = new ShowList(loadedList);
            showlist.ShowDialog();
		}

		private void SpanishButton_Click(object sender, EventArgs e)
		{
			Practice practiceForm = new Practice(loadedList);
			practiceForm.Show();

		}
	}
}
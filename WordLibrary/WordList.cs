using System.Xml.Linq;

namespace LanguageApp
{
    public class WordList
    {
        private List<Word> words = new List<Word>();
        public string Name { get; }

        public string[] Languages { get; }

        public WordList(string name, params string[] languages)
        {
            Name = name;
            Languages = languages;
        }
        public static string[] GetLists()
        {
			string basePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
			string path = Path.Combine(basePath, "Labb3");
            DirectoryInfo DI = new DirectoryInfo(path);
            return DI.EnumerateFiles("*.dat")
                .Select(file => Path.GetFileNameWithoutExtension(file.FullName))
                .ToArray();


		}


        public static WordList LoadList(string name)
        {
            string basePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string path = Path.Combine(basePath, "Labb3", $"{name}.dat");
            using StreamReader reader = new StreamReader(path);
            string languageRow = reader.ReadLine();
            WordList wordList = new WordList(name, languageRow.Split(';', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries));
            while (!reader.EndOfStream)
            {
                string wordRow = reader.ReadLine();
                wordList.Add(wordRow.Split(';', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries));
            }
            return wordList;
        }


        public void Save()
        {
            string basePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string path = Path.Combine(basePath, "Labb3");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            string filePath = Path.Combine(path, $"{Name}.dat");
            using StreamWriter writer = new StreamWriter(filePath);

            writer.WriteLine(string.Join(';', Languages));
            foreach (Word word in words)
            {
                writer.WriteLine(string.Join(';', word.Translations));
            }

        }

        public void Add(params string[] translations)
        {
            Word addWord = new Word(translations);
            words.Add(addWord);

            if (translations.Length != Languages.Length)
                throw new ArgumentException($"Wrong number of translations, this WordList has {Languages.Length} languages");

            

            //ArgumentException
        }



        public bool Remove(int translation, string word)
        {
            if (translation < 0 || translation >= Languages.Length)
                throw new ArgumentException("Language does not exists");

            Word? findWord = words.Find(w => w.Translations[translation] == word.ToLower());

            return findWord != null && words.Remove(findWord);

        }

        public int Count()
        {
            return 0;
        }

        public void List(int sortByTranslation, Action<string[]> showTranslations)
        {
            if (sortByTranslation < 0 || sortByTranslation >= Languages.Length)
                throw new ArgumentException("Language does not exists");

            var sorted = words.OrderBy(word => word.Translations[sortByTranslation]);

            foreach (Word word in sorted)
            {
                showTranslations(word.Translations);
            }
            //  sortByTranslation = Vilket språk listan ska sorteras på.
            //   showTranslations = Callback som anropas för varje ord i listan. 


        }

        public Word GetWordToPractice()
        {
            if (Languages.Length < 2)
                throw new($"List {Name} does not contain enough languages");

            if (words.Count <= 0)
                throw new($"List {Name} does not contain any words");

            var rand = new Random();
            var randomTal = rand.Next(0,words.Count);
            var randomOrd = words[randomTal];
            var fromLanguage = rand.Next(0, Languages.Length);
            var toLanguage = 0;
            while (true)
            {
                toLanguage = rand.Next(0, Languages.Length);
                if (toLanguage != fromLanguage)
                {
                    break;
                }
            }
            var practiceWord = new Word(fromLanguage, toLanguage, randomOrd.Translations);
            
            return practiceWord;
            // Returnerar slumpmässigt Word från listan, med slumpmässigt valda
            //FromLanguage och ToLanguage(dock inte samma). 

        }



    }
}

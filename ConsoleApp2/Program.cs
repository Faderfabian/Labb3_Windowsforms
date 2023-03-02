using LanguageApp;

Console.WriteLine(args.Length);
foreach (var item in args)
{
	Console.WriteLine(item);
}

WordList myWordList = new("Fruits", "English", "Swedish", "Spanish");
//WordList myWordList = WordList.LoadList("Test");

myWordList.Add("Apple", "Äpple", "Manzana");
myWordList.Add("Banana", "Banan", "Platano");
myWordList.Add("Pear", "Päron", "Pera");
myWordList.Add("Peach", "Persika", "Melocoton");
myWordList.Add("Mango", "Mango", "Mango");
myWordList.Save();


myWordList.List(1, x => Console.WriteLine($"{x[0]} {x[1]} {x[2]}"));
Word training = myWordList.GetWordToPractice();
Console.WriteLine();
Console.WriteLine(String.Join(' ', training.Translations));
//Console.WriteLine($"Antal ord i listan: {myWordList.Count()}");
//Console.WriteLine(myWordList.Remove(0, "Apple"));


//foreach (string name in WordList.Getlists())
//{
//	Console.WriteLine(name);
//}

//Console.WriteLine($"Antal ord i listan: {myWordList.Count()}");

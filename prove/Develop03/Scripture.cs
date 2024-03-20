public class Scripture {
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text){
        _reference = reference;
        _words = new List<Word>();
        string[] words = text.Split(' ');

        foreach (string sub in words)
        {
            _words.Add(new Word(sub));
        }
    }

    public Scripture(){
        
    }


    public void HideRandomWords(int numberToHide){
        int count = 0;
        Random rnd = new Random();

       while (count < numberToHide ) {
            int index = rnd.Next(_words.Count);
            if (!_words[index].IsHidden()) {
                _words[index].Hide(); 
                count++;
            }
            if (IsCompletelyHidden()) break;
       }
    }

    public string GetDisplayText(){
        string newtext = "";
        foreach (Word word in _words) {
            newtext +=  word.GetDisplayText() + " ";

        }

        return _reference.GetDisplayText() + " " + newtext;
    }

    public bool IsCompletelyHidden(){
        foreach (Word word in _words) {
            if (!word.IsHidden()) {
                return false;
            }
        }
        return true;
    }

    public Scripture GenerateRandom(string filename) {
        string[] scriptures = File.ReadAllLines(filename);
        Random rnd = new Random();
        int index = rnd.Next(scriptures.Length);
        string randomScripture = scriptures[index];
        string[] parts = randomScripture.Split(':');
            string book = parts[0].Trim();
            string chapter = parts[1].Trim();
            string verse = parts[2].Trim();
            string text = parts[3].Trim();

            if (verse.Contains('–')) {
                string[] partsVerse = verse.Split('–');
                string start = partsVerse[0];
                string end = partsVerse[1];
                Reference reference = new Reference(book, int.Parse(chapter), int.Parse(start), int.Parse(end));
                Scripture randomS = new (reference , text);
                return randomS;
            } else{
                Reference reference = new Reference(book, int.Parse(chapter), int.Parse(verse));
                Scripture randomS = new (reference , text);
                return randomS;

            }
   
    }

}

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


}

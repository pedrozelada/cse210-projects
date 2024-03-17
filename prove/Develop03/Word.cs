public class Word {
    private string _text;
    private bool _isHidden;

    public Word(string text){
        _text = text;
        _isHidden = false;
    }

    public void Hide(){
        string hidden = "";
        for (int i = 0; i < _text.Length; i++){
            hidden = hidden + "_";
        }
        _isHidden = true;
        _text = hidden;
    }

    public void Show(){
        Console.WriteLine(_text);
    }

    public bool IsHidden(){
        return _isHidden;
    }

    public string GetDisplayText(){
        return _text;
    } 

}
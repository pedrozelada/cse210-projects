 public class Entry {
            public string _prompt;
            public string _answer;
            public DateTime _logTime;
 
            public void Display() {
                Console.WriteLine($"Date: {_logTime} - Prompt: {_prompt} ");
                Console.WriteLine(_answer);
                Console.WriteLine();
            }
 
    }
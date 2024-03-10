using System;
using System.Globalization;
using System.IO;
 
 public class Journal {
        public List<Entry> _enteries;
 
        public Journal() {
            this._enteries = new List<Entry>();
            
        }
        public PromptGenerator _generator = new PromptGenerator();
 public void WriteLog() {

            _generator.DisplayRandomPrompt();
            string user_answer = Console.ReadLine();
            DateTime time = DateTime.Now;
 
            
            Entry userLog = new Entry();
            userLog._prompt = _generator._randomPrompt;
            userLog._answer = user_answer;
            userLog._logTime = time;
           
            _enteries.Add(userLog);
        }
   
        public void DisplayAll() {
            _enteries.ForEach(entery => {
                entery.Display();
            });
        }
   
        public void Load(string filename) {
            _enteries.Clear();
            string[] lines = File.ReadAllLines(filename);
            Entry log = new Entry();
            CultureInfo info = new CultureInfo("en-Us");
            for (int i = 0; i < lines.Length; i++) {
                if (lines[i] != "") {                          
                    log = new Entry();
                    string[] array = lines[i].Split(": ");
                    log._logTime = DateTime.Parse(array[0], info);
                    log._prompt = array[1];
                    log._answer = array[2];
                    _enteries.Add(log);
                    }
        }
    }
 
        public void Save(string filename) {
            using (StreamWriter outPutFile = new StreamWriter(filename)) {
                foreach (Entry log in _enteries)
                {
                outPutFile.WriteLine($"{log._logTime}: {log._prompt}: {log._answer}");
                }       
        }
    }
 
}
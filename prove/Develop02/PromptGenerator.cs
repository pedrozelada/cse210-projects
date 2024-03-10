public class PromptGenerator {
        public string _randomPrompt;

       List<string> _prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "What challenged me today, and how did I overcome it?",
            "Is there something I learned about myself today?",
            "What am I grateful for today?",
            "Describe a moment that made me smile or laugh today.",
            "Did I achieve any of my goals today? If not, what can I do differently tomorrow?",
            "What is something new I discovered or experienced today?",
            "How did I take care of my physical and mental well-being today?",
            "What is a decision I made today, and what was the thought process behind it?",
            "What was the strongest emotion I felt today?",
            "Did I encounter any obstacles today, and how can I learn from them?",
            "What is something I can do to make tomorrow even better?",
            "What is a random act of kindness I witnessed or participated in today?",
            "Describe a moment of gratitude or appreciation from someone else that stood out to me.",
            "How did I manage stress today, and what coping strategies worked well?",
            "What would I share with my friends if I had the chance?"
        };



        public void DisplayRandomPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(_prompts.Count);
        _randomPrompt = _prompts[randomIndex];
        Console.WriteLine(_randomPrompt);
    }

}
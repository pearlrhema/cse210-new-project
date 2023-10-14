public class PromptsGenerator
{
    public String DisplayRandomPrompt()
    {
        string[] prompts = {"Who was the most interesting person I interacted with today?",
         "What was the best part of my day?",
          "How did I see the hand of the Lord in my life today?",
          "What was the strongest emotion I felt today?",
          "If I had one thing I could do over today, what would it be?"};
        int listLenght = prompts.Length;
        Random random = new Random();
        int randomNumber = random.Next(0, listLenght);
        string prompt = prompts[randomNumber];
        return prompt;

    }
}
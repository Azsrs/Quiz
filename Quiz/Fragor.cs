
public class Question //Klass för frågor
{   public string QuestionText;
    public string Answer;
    public bool Ask()
    {
        Console.WriteLine(QuestionText);
        string PAnswer = Console.ReadLine().ToLower();

        while (PAnswer != "a" && PAnswer != "b" && PAnswer != "c")
        {
            Console.WriteLine("Vänligen svara A, B eller C");
            PAnswer = Console.ReadLine().ToLower();
        }
        if (PAnswer == Answer)
        {
            Console.WriteLine("Rätt! Snyggt gjort!");
            return true;
        }
        else
        {
            Console.WriteLine("Fel svar!! Du är sämst!");
            return false;
        }

    }
}


public class Question //Klass för frågor
{   public string QuestionText;
    public string Answer;
    public bool Ask() //method som lämnar en bool för att kunna räkna poäng
    {
        Console.WriteLine(QuestionText);
        string PAnswer = Console.ReadLine().ToLower();

        while (PAnswer != "a" && PAnswer != "b" && PAnswer != "c") //om man inte svarar
        {
            Console.WriteLine("Vänligen svara A, B eller C");
            PAnswer = Console.ReadLine().ToLower();
        }
        if (PAnswer == Answer) //om rätt
        {
            Console.WriteLine("Rätt! Snyggt gjort!");
            return true;
        }
        else //om fel
        {
            Console.WriteLine("Fel svar!! Du är sämst!");
            return false;
        }

    }
}

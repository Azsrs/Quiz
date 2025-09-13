
public class Question
{
    int Points;
    public string QuestionText;
    public string Answer;
    public bool Ask()
    {
        Console.WriteLine(QuestionText);
        string PAnswer = Console.ReadLine().ToLower();

        while (PAnswer != "a" && PAnswer != "b" && PAnswer != "c")
        {
            Console.WriteLine("Please answer A, B or C");
            PAnswer = Console.ReadLine().ToLower();
        }
        if (PAnswer == Answer)
        {
            Console.WriteLine("Correct! Great job, +1 point");
            return true;
        }
        else
        {
            Console.WriteLine("YOU SUCK!! NO points for LOSERS");
            return false;
        }

    }
}

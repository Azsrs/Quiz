public class Question
{
    public int Points;
    public string QuestionText;
    public string Answer;
    public void Ask()
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
            Points++;
            Console.WriteLine("Correct! Great job, +1 point");
        }
        else
        {
            Console.WriteLine("YOU SUCK!! NO points for LOSERS");
        }
        Console.WriteLine($"You now have {Points} points!");
        Console.ReadLine();
    }
}

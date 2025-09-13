
int Points = 0;
Question q = new() { QuestionText = "Hur många invånare bor i Iran \nA.92 miljoner B.27 miljoner C.150 miljoner" };
q.Answer = "a";

Question q2 = new() { QuestionText = "placeholduh" };
q2.Answer = "a";


if (q.Ask())
{
    Points++;
}
if (q2.Ask())
{
    Points++;
}
Console.WriteLine(Points);


Console.ReadLine();
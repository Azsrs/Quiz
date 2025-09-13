
int Points = 0;

List<Question> questions = new List<Question>
{
new Question {
QuestionText = "Hur många invånare bor i Iran \nA.92 miljoner B.27 miljoner C.150 miljoner" ,
Answer = "a"
},
new Question{
QuestionText = "Vilket är världens största hav? \nA.Stilla havet B.Atlanten C.Nilen" ,
Answer = "a"
},
new Question {
QuestionText = "Vem är TE24Cs flitigaste, roligaste, snyggaste elev? \nA.Inte Frank B.Frank C.Nästan Frank",
Answer = "b"
},
};
foreach (Question q in questions)
{
    if (q.Ask())
    {
        Points++;
    }
    Console.WriteLine($"Du har nu {Points} poäng. \nTryck ENTER för att fortsätta");
    Console.ReadLine();
}
Console.WriteLine("Det var det! \nVi har räknat ihop dina poäng och kommit fram till en slutsats");
Console.ReadLine();
Console.WriteLine("loading..");
Thread.Sleep(300);
if (Points <= 2)
{
    Console.WriteLine("Du är sämst!");
    Console.ReadLine();
}
else if (Points == questions.Count)
{
    Console.WriteLine("Snyggt gjort! Alla rätt!!!");
    Console.ReadLine();

}

Console.ReadLine();
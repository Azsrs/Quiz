
int Points = 0;

//Lista med frågor efter klassen Question
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
new Question {
QuestionText = "Vilket år grundades YouTube \nA.2005 B.2010 C.2008",
Answer = "a"
},
new Question {
QuestionText = "Vilket stockholmsgymnasium har högst antagningspoäng? \nA.Kungsholmens Gymnasium B.Norra Real C.Södra Latin",
Answer = "b"
},
new Question {
QuestionText = "Vad är Tugsbayars efternamn \nA.Galdabrakh B.Galgabarkh C.Galbadrakh",
Answer = "C"
},
};

Console.WriteLine("Välkommen till FrankQuiz! Du kommer ställas inför unviersums svåraste frågor,\ndin intelligens och heder står på spel.. play if you dare\nPress ENTER to start");
Console.ReadLine();
//Ställer frågor
int questionnumber = 1; //räknevärde för frågesiffra
foreach (Question q in questions)
{
    Console.WriteLine($"Fråga {questionnumber}");
    if (q.Ask())
    {
        Points++;
    }
    questionnumber++;
    Console.WriteLine($"Du har nu {Points} poäng. \nTryck ENTER för att fortsätta"); //uppmanar om poängantal, förklarar hur man går vidare
    Console.ReadLine();
}

//Räkna ihop poäng
Console.WriteLine("Det var det! \nVi har räknat ihop dina poäng och kommit fram till en slutsats\nVänligen tryck ENTER för resultat");
Console.ReadLine();
if (Points == questions.Count) //alla rätt
{
    Console.WriteLine($"Wow, {Points} poäng! Snyggt gjort! Alla rätt!!!");
}
else if (Points >= questions.Count / 2)
{
    Console.WriteLine($"Eh, {Points} poäng.. Bra försökt! Testa igen om du törs!!");
}
else if (Points <= 2) //inte många poäng
{
    Console.WriteLine($"Wow! {Points} Du är otroligt dålig!");
}
Console.ReadLine();
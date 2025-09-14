
int Points = 0;

//Frågor efter klassen Question
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

//Ställer frågor
foreach (Question q in questions) 
{
    if (q.Ask())
    {
        Points++;
    }
    Console.WriteLine($"Du har nu {Points} poäng. \nTryck ENTER för att fortsätta"); //uppmanar om poängantal, förklarar hur man går vidare
    Console.ReadLine();
}

//Räkna ihop poäng
Console.WriteLine("Det var det! \nVi har räknat ihop dina poäng och kommit fram till en slutsats"); //fake loading screen för komisk effekt
Console.ReadLine();
Console.WriteLine("loading..");
Thread.Sleep(300);
if (Points == questions.Count) //alla rätt
{
    Console.WriteLine("Snyggt gjort! Alla rätt!!!");
}
else if (Points >= questions.Count / 2)
{
    Console.WriteLine("Bra försökt! Testa igen om du törs!!");
}
else if (Points <= 2) //inte många poäng
{
    Console.WriteLine("Wow! Du är otroligt dålig!");
}
Console.ReadLine();

Question q = new() { QuestionText = "Hur många invånare bor i Iran \nA.92 Miljoner B.27" };
q.Answer = "a";

Question q2 = new() { QuestionText = "placeholduh" };
q2.Answer = "a";


q.Ask();
q2.Ask();


Console.ReadLine();
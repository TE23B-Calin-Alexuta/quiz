
int points = 0;


Console.WriteLine("quiz om F1");

// -----------------------------------------------------------------------------

Console.WriteLine("1: Vilken motor hade Ayrton Sennas McLaren mp4/4?");
Console.WriteLine("a) V12  b) V8  c) Turbo V6");
string answer1 = Console.ReadLine();
if (answer1 == "c")
{
  points++;
  Console.WriteLine("Rätt");
}
else
{
  Console.WriteLine("Fel");
}

// -----------------------------------------------------------------------------

Console.WriteLine("2: Hur många vinster har Michael Schumacher?");
Console.WriteLine("a) 91   b) 6   c) 42 ");
string answer2 = Console.ReadLine();
if (answer2 == "a")
{
  points++;
  Console.WriteLine("Rätt");
}
else
{
  Console.WriteLine("Fel");
}

// -----------------------------------------------------------------------------

Console.WriteLine("3: Vem har fläst vinnster i F1?");
Console.WriteLine("a) Ayrton Senna  b) Lewis Hamilton  c) Michael Schumacher ");
string answer3 = Console.ReadLine();
if (answer3 == "b")
{
  points++;
  Console.WriteLine("Rätt");
}
else
{
  Console.WriteLine("Fel");
}

// -----------------------------------------------------------------------------

Console.WriteLine("4: Vilken förare är känd för att ha ett bränt ansikte?");
Console.WriteLine("a) Niki Lauda   b) Jim Clark  c) James Hunt");
string answer4 = Console.ReadLine();
if (answer4 == "a")
{
  points++;
  Console.WriteLine("Rätt");
}
else
{
  Console.WriteLine("Fel");
}

// -----------------------------------------------------------------------------

Console.WriteLine("5: Vad har F1 bilar för drift?");
Console.WriteLine("a) Fyrhjuls    b) Framhjuls  c) Bakhjuls");
string answer5 = Console.ReadLine();
if (answer5 == "c")
{
  points++;
  Console.WriteLine("Rätt");
}
else
{
  Console.WriteLine("Fel");
}

// -----------------------------------------------------------------------------

Console.WriteLine($"Du fick {points} poäng.");
if (points == 0)
{
  Console.WriteLine("Du kan ingenting du borde inte änns få köra!!!");
}
else if (points < 3)
{
  Console.WriteLine("Du har något att lära dig");
}
else if (points < 5)
{
  Console.WriteLine("Du har koll");
}
else 
{
  Console.WriteLine("Du är en F1 förare");
}


Console.WriteLine("Tryck på Enter för att avsluta.");
Console.ReadKey();

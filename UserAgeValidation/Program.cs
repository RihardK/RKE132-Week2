//rakendus määrab kasutaja soo ning nime ja tervitab korrektselt

Console.WriteLine("Please select your gender (m/f):");
char userGender = Char.Parse(Console.ReadLine());

Console.WriteLine("Please write your last name:");
string userName = Console.ReadLine();

if (userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr.{userName}!");
}
else if (userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms.{userName}!");
}
else
{
    Console.WriteLine($"Welcome {userName}!");
}



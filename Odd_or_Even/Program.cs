// küsime kasutajal sisestada numbri

Console.WriteLine("Please enter a number:");
int userNumber = Convert.ToInt32(Console.ReadLine());

// kontrollime, kas number on paaris voi paaritu

int result = userNumber % 2;

Console.WriteLine(result);

if (result != 0)    // != EI VORDU

{
    Console.WriteLine("Your number is Odd.");
}
else
{
    Console.WriteLine("Your number is Even."); 
}
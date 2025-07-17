Console.WriteLine("Wypisany tekst musi znajdować się w podwójnych cudzysłowach.");

Console.WriteLine("Podaj swój ulubiony kolor: ");
string color = Console.ReadLine();

//string color2 = Console.ReadLine();
//string Color2 = Console.ReadLine();
//string color_2 = Console.ReadLine();
//string Color_2 = Console.ReadLine();

// string 2Color = Console.ReadLine(); // Błąd: nazwa zmiennej nie może zaczynać się od cyfry

/* Komentarz
 wieloliniowy
*/


// Praca z typami pierwotnymi
int dailyIncome = 100;
int day = 12, month = 1;

bool isActive = true;

double price = 97.99;

// byte numberOfBooks = 400;

int distanceCovered;
distanceCovered = 1000; // Przypisanie wartości do zmiennej
distanceCovered = 300;


// Stałe
const double Pi = 3.14; // Stała, której wartość nie może być zmieniona
const decimal MaxValue = 1000000m; // Stała typu decimal
// MaxValue = 2000000m; // Błąd: nie można zmienić wartości stałej


// String
string name = "Zbyszek";

string color2 = "red";

string emptyString = "";
string emptyString2 = string.Empty;

Console.WriteLine("Podaj swoje imię: ");
name = Console.ReadLine();
Console.WriteLine($"Twoje imię to: {name}");



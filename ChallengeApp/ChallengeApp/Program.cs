string imie = "Alicja";
var wiek = 27;
bool kobieta = true;
if (wiek < 30 && kobieta == true)
    Console.WriteLine("Kobieta poniżej 30 lat");
else if (wiek == 33 && imie == "Ewa")
    Console.WriteLine("Ewa, lat 33");
else if (wiek >= 30 && kobieta == true)
    Console.WriteLine("Kobieta powyżej 30 lat");
else if (wiek >= 18 && kobieta == false)
    Console.WriteLine("Pełnoletni mężczyzna");
else
    Console.WriteLine("Niepełnoletni mężczyzna");

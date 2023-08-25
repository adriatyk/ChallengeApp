var IMIE = "EWA";
bool KOBIETA = true;
int WIEK = 20;

if (KOBIETA == true && WIEK < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else
{
    Console.WriteLine("Kobieta ma 30 lub więcej lat");
}
WIEK = WIEK + 13;
if (IMIE == "EWA" && WIEK == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
KOBIETA = false;
if (KOBIETA != true || WIEK < 18)
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}




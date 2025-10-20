// See https://aka.ms/new-console-template for more information

string kasutajanimi = "";
do
{
    Console.WriteLine("Palun sisesta oma kasutajanimi");
    kasutajanimi = Console.ReadLine();
}
while (kasutajanimi != "user1");
if (kasutajanimi == "user1")
{
    int ruuduSuurus = 0;

    do
    {
        Console.WriteLine("Kui suurt ruutu tahad?");
        ruuduSuurus = int.Parse(Console.ReadLine());
    } while (ruuduSuurus < 0 && ruuduSuurus > 20);
    char reaKujund = 'a';
    string üksRida = "";
    int tsükliMuutuja = ruuduSuurus;
    do
    {
        üksRida += 'a'+reaKujund;
        tsükliMuutuja -= 1;
    } while (tsükliMuutuja != 0);
    tsükliMuutuja = ruuduSuurus;
    do
    {
        Console.WriteLine(üksRida);
        tsükliMuutuja -= 1;
    } while (tsükliMuutuja != 0);
}


Console.WriteLine("Tere tulemast MobiFix parandusautomaati! Kuidas saan aidata?");
Console.WriteLine("0 - headaega\n1 - tahan telefoni parandada");
Console.WriteLine("Palun tee oma valik, kirjutades vastav arv");
int kasutajaTelefon = int.Parse(Console.ReadLine());
while (kasutajaTelefon < 1 && kasutajaTelefon > 4)
{
    kasutajaTelefon = int.Parse(Console.ReadLine());
    Console.WriteLine("Palun tee oma valik, kirjutades vastav arv");
}
switch (kasutajaTelefon)
{
    case 1:
        Console.WriteLine("Aitäh, oma iPhone saad tagasi 1 nädala pärast");
        break;
    case 2:
        Console.WriteLine("Aitäh, sinu Xiaomi on valmis 2 kuu pärast");
        break;
    case 3:
        Console.WriteLine("Kahjusk me huaweid ei teenunda");
        break;
    case 4:
        Console.WriteLine("Sinu samsung saav valmis 2 päeva pärast");
        break;
    default:
        break;
}
Console.WriteLine("Kas soovid mõnda muud mudelit parandada");
Console.WriteLine("o - jah\n1 - ei");
int kasutajaTeinevalik = 1;
while (kasutajaTeinevalik < 0 && kasutajaTeinevalik > 1)
{

}
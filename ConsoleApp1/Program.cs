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

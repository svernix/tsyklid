//Console.WriteLine("For tsükel");

//int kogus = 5;

//for (int i = 0;i < kogus; i++)
//{
//    Console.WriteLine("🍐");
//    Console.Beep();
//}

string[] objectArray = new string[5]; //array, massiv mitmest elemenist
int opjectCount = 0; //loend kui palju kordi küsida
string temp = "no name"; //muutuja mis hetkel on "tühi"
while (opjectCount < 5) //while tsükke mis küsib nimesid
{
    Console.WriteLine("Sisesta järgmine lemmikloomanimi"); 
    temp = Console.ReadLine(); // temp muutujasse väärtuse (mida me tahame) sisestamine
    objectArray[opjectCount] =temp; //masiivi, asukohal objectCount
    opjectCount++; //tsükli inkrementatsioon
}
Console.WriteLine("Oled sisetanud järgnevad objektid"); //sõnum
for (int i = 0; i < objectArray.Length; i++)
{
    Console.WriteLine($"{i+1}. element on: {objectArray[i]}");
    //kuvame välja reanumbri koos vastava elemendigam muutuja i abil
}
Console.ReadLine(); // peatame programmi klahvisiestuse taha

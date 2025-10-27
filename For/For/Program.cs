//Console.WriteLine("For tsükel");

//int kogus = 5;

//for (int i = 0;i < kogus; i++)
//{
//    Console.WriteLine("🍐");
//    Console.Beep();
//}

string[] objectArray = new string[5];
int opjectCount = 0;
string temp = "no name";
while (opjectCount < 5)
{
    Console.WriteLine("Sisesta järgmine lemmikloomanimi");
    temp = Console.ReadLine();
    objectArray[opjectCount] =temp;
    opjectCount++;
}
Console.WriteLine("Oled sisetanud järgnevad objektid");
for (int i = 0; i < objectArray.Length; i++)
{
    Console.WriteLine($"{i+1}. element on: {objectArray[i]}");
}
Console.ReadLine();

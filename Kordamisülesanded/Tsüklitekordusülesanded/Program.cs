/* dowhile
küsi kasutajalt tema eesnime, tsükkel peab toimima niikaua kuni kastaja on sisestanud midagi, et
sisestus tühi "ei oleeks"
*/

Console.WriteLine("Tere kasutaja, palun sisesta oma eesnimi");
string nimi = "";
int kuuPäev = 0;
do
{
    Console.WriteLine("Sinu nimi on:");
    nimi = Console.ReadLine();
} 
while (nimi == "");

Console.WriteLine("Sisesta oma sünnikuupäeva päev");
int sünnikuupäev = 0;
while (sünnikuupäev < 0 && sünnikuupäev > 31)
{
    Console.WriteLine("Sisesta kuupäev");
    sünnikuupäev = int.Parse(Console.ReadLine());
}

Console.WriteLine("Sisesta ka sünnikuupäeva kuu.");
string sünnikuu = "";
while (sünnikuu == "")
{
    Console.WriteLine("Sisesta kuu");
    sünnikuu = Console.ReadLine();
}
 


/* While
Siis küsi kasutajalt tema sünnikuupäeva kolme while tsükliga, kõigepealt päev, arvuna, siis kuu, nimega, ning 
siis aasta, arvuna päeva küsimise juures tuleb jälgida et kuupäev oleks vahemikus 1-31
kuupärva küsimise juures peab uuesti küsima, kui nimetus ei esine programmis (kas switch-case, if-elseif ,
nõi .Contains() abiga) aasta juures ei tohi olla sünniaasta 19ndas sajandis (18xx) ega tulevikus.(tekib ka 
vahemik)
*/

/* for küsi kasutajalt tema sünnipäevale küllatulijaid uude listi for tsükliga, 
 iga tsükkel sisestab uue inimesenime, kuni kasutaja ütleb "kõik" */
/* foreach küsi kasutajalt kas on mõni külaline keda ta siiski näha ei tahaks? ning võrdle foreach 
 tsüklis kõik külalised kasutaja sisestatuga. eemalda see külaline kui ta nimekirjas on, kui külalist
 nimekirjast ei leita, siis ütle "sellist inimest sa pole kutsunudki" 
*/ 

/* 2. Üldine ülesanne kirjuta programm mis küsib kasutajalt tema lemmikvärvi, ning joonistab 
 * talle tema lemmimkvärvi ruudu, mille sisse kirjutad vastava värvi ainult keskmisele reale. 
 * Kasutada võib vabalt valitud tsüklitüüpi 
 */
using System.Security.Cryptography;
using SC = System.Console;

//
// Slumpstiden V.1 som kommer bara vara på en linije!!
//

while /*MAIN*/ (true) {

void NAME() { /*Tar in spelarens namn*/
SC.WriteLine("Skriv dit namn:");
string name = SC.ReadLine();
while (name.Length < 3) {SC.Clear(); SC.WriteLine("Skriv dit namn:"); name = SC.ReadLine();}
SC.ReadLine();
}

void APONENT(){ /*Inehåller motståndare och ger ut värden för dem */



}


void FIGHT() {  /* Utför slump striden */
SC.WriteLine("Fight Begin!");


}

void WIN() {}
void LOSE(){}
void RESTART(){}



















} /* WHILE MAIN /*
















































/*
while (true){
int card = Random.Shared.Next(1, 53); // inclusivt golv, exlusivt tak. kommer ge 1 men kommer inte ge 53 utan en lägre
SC.WriteLine(card);
SC.ReadLine();


SC.WriteLine("Skriv dit namn:");    string name = SC.ReadLine();
while (name.Length < 3) {SC.Clear(); SC.WriteLine("skriv in dit namn namn sa jag dumhuvve"); name = SC.ReadLine();}
SC.ReadLine();
}
*/
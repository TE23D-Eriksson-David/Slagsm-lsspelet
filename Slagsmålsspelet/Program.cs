using System.Security.Cryptography;
using SC = System.Console;

//
// Slumpstiden V.1 som kommer bara vara på en linije!!
//
bool FirstTime = true;

bool ChosingAponent = true;
bool Aponent_Punch = false;
bool Aponent_kick = false;
bool Aponent_Block = false;
bool Aponent_Pary = false;

bool Fighting = true;

/* Vall under striden */
bool fight_Punch = false;
bool fight_kick = false;
bool fight_block = false;
bool fight_pary = false;
bool fight_Consed = false;
/* ------------------------ */

int Player_Helth;
int Aponent_Helth;
int Damage;


while /*MAIN*/ (true) {

START();
NAME();
APONENT();
FIGHT();
RESULT();
RESTART();

} /*WHILE MAIN*/




void START() /* Title screen */ 
{
    if (FirstTime) {
    SC.WriteLine("ASCII place holder");
    SC.WriteLine("Press Anything to start");
    SC.ReadLine();}
}


void NAME() { /*Tar in spelarens namn*/
SC.WriteLine("Skriv dit namn:");
string name = SC.ReadLine();
while (name.Length < 3) {SC.Clear(); SC.WriteLine("Skriv dit namn:"); name = SC.ReadLine();}
SC.ReadLine();
}

void APONENT() { /*Inehåller vall av motståndare och ger ut värden för dem */
while (ChosingAponent == true) {
SC.WriteLine("Chose your oponent:");
SC.WriteLine("Aponent List whit case sats");
string Aponent_id = SC.ReadLine();
switch ((string)(Aponent_id)) {
    case (string)("1"):
    ChosingAponent = false;
    SC.WriteLine("You have chosen aponent one.");
    SC.WriteLine("ASCI & Stats for aponetn Placeholder");
    SC.ReadLine();
    break;
    case (string)("2"):
    ChosingAponent = false;
    SC.WriteLine("You have chosen aponent two.");
    SC.WriteLine("ASCI & Stats for aponetn Placeholder");
    SC.ReadLine();
    break;
    case (string)("3"):
    ChosingAponent = false;
    SC.WriteLine("You have chosen aponent tre.");
    SC.WriteLine("ASCI & Stats for aponetn Placeholder");
    SC.ReadLine();
    break;
}
                                }
    SC.WriteLine("press any key to continue");
}


void FIGHT() {  /* Utför slump striden */
SC.WriteLine("Let the fight Begin!");
SC.WriteLine("ASCI");
SC.WriteLine("Trash talk");
SC.ReadLine();
SC.Clear();


while (Fighting) { // Lopar tills Slagsmålet är över
SC.WriteLine("ASCI");
SC.WriteLine("Fight Choices");
Damage = 0;
string Fight_Choice = SC.ReadLine();
switch ((string)(Fight_Choice)){
    case (string)("1"):
    fight_Punch = true;
    Damage = Random.Shared.Next(20, 44);
    SC.WriteLine("ASCI"); // You punch, normal conect
    if (Aponent_Block) {
        Damage = Random.Shared.Next(5, 17);
        SC.WriteLine("ASCI"); // You punch, aponent block
    } else if (Aponent_Pary) {
        Damage = Random.Shared.Next(3, 7);
        Player_Helth =- Random.Shared.Next(15, 33);
        SC.WriteLine("ASCI"); // You punch, aponent pary
    }
    Aponent_Helth =- Damage; 
    break;
    case (string)("2"):
    fight_kick = true;
        Damage = Random.Shared.Next(30, 50);
    if (Aponent_Block) {
        Damage = Random.Shared.Next(10, 30);
    } else if (Aponent_Pary) {
        Damage = Random.Shared.Next(1, 15);
        Player_Helth =- Random.Shared.Next(30, 45);
    }
    Aponent_Helth =- Damage; 
    break;
    case (string)("3"):
    fight_block = true;
    if (Aponent_Punch || Aponent_kick) {
       Player_Helth =- Random.Shared.Next(5, 30); 
    }
    break;
    case (string)("4"):
    fight_pary = true;
    if (Aponent_Punch || Aponent_kick) {
        Player_Helth =- Random.Shared.Next(5, 30);
        Damage = Random.Shared.Next(30, 45);
        Aponent_Helth =- Damage; 
    }
    break;
    case (string)("5"):
    fight_Consed = true;
    Fighting = false;
    break;
    case (string)("6"):
    Fight_TrashTalk();
    break;
} //End case

} /* While Fhigting*/

} 

void Fight_TrashTalk() {
    SC.WriteLine("Trash talk");
    SC.ReadLine();
}

void RESULT() {
if (fight_Consed) {
    SC.WriteLine("ASCII");
    SC.WriteLine("Placeholder Aponent mocking the player");
    SC.WriteLine("You Conced");
    SC.WriteLine("Press anything to go back to start");
    SC.ReadLine();
}


}

void RESTART() { /* Gör allting för att kunna köra igen (Tar en tillbacka till chosing Aponents) */
FirstTime = false;

ChosingAponent = true;
Aponent_Punch = false;
Aponent_kick = false;
Aponent_Block = false;
Aponent_Pary = false;

Fighting = true;

/* Vall under striden */
fight_Punch = false;
fight_kick = false;
fight_block = false;
fight_pary = false;
fight_Consed = false;
/* ------------------------ */
Player_Helth = 100;

}













































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
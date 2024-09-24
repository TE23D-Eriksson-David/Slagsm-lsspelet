using System.Security.Cryptography;
using SC = System.Console;

//
// Slumpstiden V.1 & Den utveklade verisionen V.2
//


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
bool fight_Draw = false;
bool fight_Win = false;
bool fight_Lose = false;
/* ------------------------ */

int Aponent_Choice=0;
int Player_Helth=100;
Player_Helth = Math.Max(0,100);
int Aponent_Helth=0;
int Damage=0;
int Coins=0;
int HitChance;

string name;
string Aponent_move = "";

while /*MAIN*/ (true) {

START();
NAME();
while (true) {
SUB_MENUE();
//SHOP();
APONENT();
FIGHT();
RESULT();
RESTART();
}

} /*WHILE MAIN*/




void START() /* Title screen */ 
{
    SC.WriteLine("ASCII place holder");
    SC.WriteLine("Press Enter to start");
    SC.ReadLine();
    SC.Clear();
}



void NAME() { /*Tar in spelarens namn*/
SC.WriteLine("Write your player name:");
name = SC.ReadLine();
while (name.Length < 3) {SC.Clear(); SC.WriteLine("Write your player name:"); name = SC.ReadLine();}
}

void SUB_MENUE(){}

void SHOP(){}

void APONENT() { /*Inehåller vall av motståndare och ger ut värden för dem */
while (ChosingAponent == true) {
SC.Clear();
SC.WriteLine($"Chose your oponent: ASCII    Your name: {name}   Coins:{Coins}");
SC.WriteLine("Aponent, List whit case sats (1) (2) (3)");
string Aponent_id = SC.ReadLine();
switch ((string)(Aponent_id)) {
    case (string)("1"):
    ChosingAponent = false;
    Aponent_Helth=70;
    SC.Clear();
    SC.WriteLine("You have chosen aponent one.");
    SC.WriteLine("ASCI & Stats for aponetn Placeholder");
    
    break;
    case (string)("2"):
    ChosingAponent = false;
    Aponent_Helth=100;
    SC.Clear();
    SC.WriteLine("You have chosen aponent two.");
    SC.WriteLine("ASCI & Stats for aponetn Placeholder");
    
    break;
    case (string)("3"):
    ChosingAponent = false;
    Aponent_Helth=130;
    SC.Clear();
    SC.WriteLine("You have chosen aponent tre.");
    SC.WriteLine("ASCI & Stats for aponetn Placeholder");
    break;
}
                                }
    Aponent_Helth = Math.Max(0,Aponent_Helth);
    SC.WriteLine("press any key to continue");
    SC.ReadLine();
}


void FIGHT() {  /* Utför slump striden */
SC.Clear();
SC.WriteLine("Let the fight Begin!");
SC.WriteLine("ASCI");
SC.WriteLine("Trash talk");
SC.ReadLine();
SC.Clear();


while (Fighting) { // Lopar tills Slagsmålet är över
SC.WriteLine($"ASCI Aponents helth:{Aponent_Helth} your helth: {Player_Helth} your damage: {Damage}");
SC.WriteLine("Fight Choices: (1) Punch  : (2) Kick  : (3) Block : (4) Pary  : (5) Consed  : (6) Trash Talk  :");
Damage = 0;

Aponent_Choice = Random.Shared.Next(0,4);
if (Aponent_Choice==1){Aponent_Block=true; Aponent_move ="Aponent block";}else if(Aponent_Choice==2){Aponent_Pary=true; Aponent_move ="Aponent Pary";}else if(Aponent_Choice==3){Aponent_Punch=true; Aponent_move ="Aponent punch";}else if(Aponent_Choice==4){Aponent_kick=true; Aponent_move ="Aponent kick";}
HitChance = Random.Shared.Next(1, 11);

string Fight_Choice = SC.ReadLine();
switch ((string)(Fight_Choice)){
    case (string)("1"):
    fight_Punch = true;
    Damage = Random.Shared.Next(20, 44);
    SC.Clear();
    SC.WriteLine("ASCI"); // You punch, normal conect
    if (Aponent_Block) {
        Damage = Random.Shared.Next(5, 17);
        SC.Clear();
        SC.WriteLine("ASCI"); // You punch, aponent block
    } else if (Aponent_Pary) {
        Damage = Random.Shared.Next(3, 7);
        Player_Helth =  Player_Helth - Random.Shared.Next(15, 33);
        SC.Clear();
        SC.WriteLine("ASCI"); // You punch, aponent pary
    }
    SC.WriteLine($"{Aponent_move}");
    SC.WriteLine($"{HitChance}");
    if (HitChance < 8) {
    Aponent_Helth = Aponent_Helth - Damage; 
    }
    break;
    case (string)("2"):
    fight_kick = true;
        Damage = Random.Shared.Next(30, 50);
    if (Aponent_Block) {
        Damage = Random.Shared.Next(10, 30);
    } else if (Aponent_Pary) {
        Damage = Random.Shared.Next(1, 15);
        Player_Helth =  Player_Helth - Random.Shared.Next(30, 45);
    }
    SC.WriteLine($"{Aponent_move}");
    SC.WriteLine($"{HitChance}");
    if (HitChance < 6) {
    Aponent_Helth =  Aponent_Helth - Damage; 
    }
    break;
    case (string)("3"):
    fight_block = true;
    if (Aponent_Punch || Aponent_kick) {
       Player_Helth =   Player_Helth - Random.Shared.Next(5, 30); 
    }
    SC.WriteLine($"{Aponent_move}");
    break;
    case (string)("4"):
    fight_pary = true;
    if (Aponent_Punch || Aponent_kick) {
        Player_Helth =  Player_Helth - Random.Shared.Next(5, 30);
        Damage = Random.Shared.Next(30, 45);
        Aponent_Helth =  Aponent_Helth - Damage; 
    }
    SC.WriteLine($"{Aponent_move}");
    break;
    case (string)("5"):
    fight_Consed = true;
    Fighting = false;
    break;
    case (string)("6"):
    Fight_TrashTalk();
    break;
} //End case
SC.ReadLine();
SC.Clear();

if (Aponent_Helth == 0 && Player_Helth == 0) {fight_Draw=true;    Fighting = false;}
else if (Aponent_Helth==0) {fight_Win=true;  Fighting = false;} else if (Player_Helth==0){fight_Lose=true;    Fighting = false;} 

} /* While Fhigting*/

} // Class FIGHT 

void Fight_TrashTalk() {
    SC.Clear();
    SC.WriteLine("Trash talk");
}

void RESULT() {
if (fight_Consed) {
    SC.WriteLine("ASCII");
    SC.WriteLine("Placeholder Aponent mocking the player");
    SC.WriteLine("You Conced");
    SC.WriteLine("Press anything to go back to start");
    SC.ReadLine();
    SC.Clear();
}
if (fight_Draw) {
   SC.WriteLine("ASCII");
   SC.WriteLine(@"
   Press anything to go back to start");
    SC.ReadLine();
    SC.Clear();
}
if (fight_Win) {
   SC.WriteLine("ASCII");
   Coins =+ 100;
   SC.WriteLine($"You get 100 Coins, well done!");
   SC.WriteLine("Press anything to go back to start");
    SC.ReadLine();
    SC.Clear();
}
if (fight_Lose) {
   SC.WriteLine("ASCII");
   SC.WriteLine($"You lose '-' Coins!");
   SC.WriteLine("Press anything to go back to start");
    SC.ReadLine();
    SC.Clear();
    }
}

void RESTART() { /* Gör allting för att kunna köra igen (Tar en tillbacka till chosing Aponents) */

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
fight_Lose = false;
fight_Win = false;
fight_Draw = false;
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
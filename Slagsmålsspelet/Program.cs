﻿using System.Diagnostics;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using SC = System.Console;
using Slagsmålsspelet;

//
// Slumpstiden V.1 & Den utveklade verisionen V.2
//

ASCII_art ART = new ASCII_art();

Console.Title = "Slagsmålsspelet";

bool ChosingAponent = true;
bool Aponent_Punch = false;
bool Aponent_kick = false;
bool Aponent_Block = false;
bool Aponent_Pary = false;

bool Fighting = true;
bool SubMenue = true;
bool Main_Menue = true;
bool Shop = false;
bool Bet = false;
bool TrashTalk = false;

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
int Aponent1Bet=0;
int Aponent2Bet=0;
int Aponent3Bet=0;
int i=0;
int T=0;
int Player_Helth=200;
//Player_Helth = Math.Max(100,0);
int Aponent_Helth=0;
int Damage=0;
int Coins=0;
int Bet_Coins=0;
int HitChance;

string name;
string Aponent_id = "0";
string Aponent_move = "";
string choice = "";

while /*MAIN*/ (true) {

START();
NAME();
while (true) {
    while (Main_Menue){
SUB_MENUE();
SHOP();
BET();
    }
APONENT();
FIGHT();
RESULT();
RESTART();
}

} /*WHILE MAIN*/




void START() /* Title screen */ 
{
    ART.Menue();    ART.ASCII = 101;
    SC.WriteLine("Press Enter to start");
    SC.ReadLine();
    SC.Clear();
}



void NAME() { /*Tar in spelarens namn*/
SC.WriteLine("Write your player name:");
name = SC.ReadLine();
while (name.Length < 3) {SC.Clear(); SC.WriteLine("Write your player name:"); name = SC.ReadLine();}
}

void SUB_MENUE(){
    while (SubMenue == true) {
        SC.Clear();
        ART.Menue();    ART.ASCII = 102;
        SC.WriteLine(@"Chose your next action by writing it's coresponding number and then pressing Enter
By chosing option 'Aponent' You will aoutomaticly be locked out of this menue, be aware!
");
        SC.WriteLine("(1) Chosce Aponent    (2) Shop    (3) Bet on Aponent");
        choice = SC.ReadLine();
if (choice == "1") {SubMenue = false; Main_Menue = false;} else if (choice == "2") {SubMenue = false; Shop = true;} else if (choice == "3") {SubMenue = false; Bet = true;}
    }
    SC.Clear();
}

void SHOP(){
    if (Shop == true) {
        while (Shop == true) {
            SC.Clear();
            ART.Shop();    ART.ASCII = 400;
        SC.WriteLine("Here you can buy things for your Carakter, Cosmetics, Buffs to his stats, and so on..");
SC.WriteLine($@"Shop    !!Unfinished, Work in progress!! (1) 10 coins  (2) 30 coins  (3) 50 coins        To Exit chose (4)"); 
choice = SC.ReadLine();
switch ((string)(choice)) {
case (string)("1"):
if (Coins == 10) {
ART.Shop();    ART.ASCII = 401;
SC.WriteLine("You have know recived the text color Cyan");
SC.ForegroundColor = ConsoleColor.Cyan;
Coins = Coins - 10;
SC.ReadLine();
Shop = false;
}
break; 
case (string)("2"):
if (Coins == 30) {
ART.Shop();    ART.ASCII = 402;
SC.WriteLine("two");
SC.ReadLine();
Shop = false;
}
break; 
case (string)("3"):
if (Coins == 50) {
ART.Shop();    ART.ASCII = 403;
SC.WriteLine("three");
SC.ReadLine();
Shop = false;
}
break; 
case (string)("4"):
Shop = false;
break;

}
        } // while
    } // if  
SubMenue = true;
} // SHOP


void BET(){
if (Bet == true) {
while (Bet == true) {
    choice = "";
    i = 1;
    SC.Clear();
    ART.Menue();    ART.ASCII = 103;
    SC.WriteLine(@"Here is the betting hall. You can bett against your aponent if you think you can bet them. 

Beting is done whit coins, you can earn coins affter every fight you win. If you bet on a aponent and succed
in wining agenst them, youl recive duble what you set in. Draws and Loses will forfit your bets making every thing a gamble
But you can Consede whitch will make it so you only lose half of what you bet. Know god luck and let the best gambler win!  
    ");
SC.WriteLine(@$"Aponents to bet on:    (1) Damon 'The Juggernaut' Steele  (2) Rico 'Thunderstrike' Alvarez (3) Mason 'Iron Will' Graves    ||  Avileble Coins {Coins} ||

Chosing (4) will exit the beting Hall
");

SC.WriteLine(@$"ASCII of art and stats so you know who youre schosing");

choice = SC.ReadLine();
SC.Clear();
switch ((string)(choice)){

    case (string)("1"):
    while (i == 1) {
        ART.Menue();    ART.ASCII = 104;
    SC.WriteLine(@"
    How mutch are you willing to risk?  (1) 10 coins   (2) 30 coins  (3) 50 coins");
    choice = SC.ReadLine();
    if (choice=="1" && Coins > 10){Coins = Coins - 10; Aponent1Bet = Aponent1Bet + 10;} else if (choice=="2" && Coins > 30){Coins = Coins - 30; Aponent2Bet = Aponent2Bet + 30; } else if (choice=="3" && Coins > 50){Coins = Coins - 50; Aponent3Bet = Aponent3Bet + 50; }
    i = 0;
    }
    break;

    case (string)("2"):
    while (i == 1) {
        ART.Menue();    ART.ASCII = 104;
    SC.WriteLine("How mutch are you willing to risk?  (1) 10 coins   (2) 30 coins  (3) 50 coins");
    choice = SC.ReadLine();
    if (choice=="1" && Coins < 10){Coins = Coins - 10; Aponent1Bet = Aponent1Bet + 10;} else if (choice=="2" && Coins < 30){Coins = Coins - 30; Aponent2Bet = Aponent2Bet + 30; } else if (choice=="3" && Coins < 50){Coins = Coins - 50; Aponent3Bet = Aponent3Bet + 50; }
    i = 0;
    }
    break;

    case (string)("3"):
    while (i == 1) {
        ART.Menue();    ART.ASCII = 104;
    SC.WriteLine("How mutch are you willing to risk?  (1) 10 coins   (2) 30 coins  (3) 50 coins");
    choice = SC.ReadLine();
    if (choice=="1" && Coins < 10){Coins = Coins - 10; Aponent1Bet = Aponent1Bet + 10;} else if (choice=="2" && Coins < 30){Coins = Coins - 30; Aponent2Bet = Aponent2Bet + 30; } else if (choice=="3" && Coins < 50){Coins = Coins - 50; Aponent3Bet = Aponent3Bet + 50; }
    i = 0;
    }
    break;

    case (string)("4"):
    Bet = false;
    break;
}
} //while
} //if
SubMenue = true;
} // BET

void APONENT() { /*Inehåller vall av motståndare och ger ut värden för dem */
while (ChosingAponent == true) {
SC.Clear();
SC.WriteLine(@"Here is where you chose your aponent, Rigt know theres only three Damon 'The Juggernaut' Steele, Rico 'Thunderstrike' Alvarez and Mason 'Iron Will' Graves.
They are difrently skilled, so I would advise you to chose well, Damon Steele has the lest experience in thre ring.
So I say you take a swing at him! 
 ");
 ART.Fighter();    ART.ASCII = 200;
SC.WriteLine(@$"Chose your oponent:            Your name: {name}   Coins: {Coins}
");
SC.WriteLine(@"Chose aponent by write the number to the coresponding fighter.

");
SC.WriteLine(@$"Here at the botom, you can se your bets, if you have made any ;D. 
Aponent 1; 'The Juggernaut' Bet: {Aponent1Bet}     Aponent 2; 'Thunderstrike' Bet: {Aponent2Bet}    Aponent 3; 'Iron Will' Bet: {Aponent3Bet}");

Aponent_id = SC.ReadLine();
switch ((string)(Aponent_id)) {
    case (string)("1"):
    ChosingAponent = false;
    Aponent_Helth=150;
    SC.Clear();
    SC.WriteLine("You have chosen aponent one.");
    ART.Fighter();    ART.ASCII = 201;
    SC.WriteLine("ASCI & Stats for aponetn Placeholder");
    
    break;
    case (string)("2"):
    ChosingAponent = false;
    Aponent_Helth=190;
    SC.Clear();
    SC.WriteLine("You have chosen aponent two.");
    ART.Fighter();    ART.ASCII = 202;
    SC.WriteLine("ASCI & Stats for aponetn Placeholder");
    
    break;
    case (string)("3"):
    ChosingAponent = false;
    Aponent_Helth=220;
    SC.Clear();
    SC.WriteLine("You have chosen aponent tre.");
    ART.Fighter();    ART.ASCII = 203;
    SC.WriteLine("ASCI & Stats for aponetn Placeholder");
    break;
}
                                }
    //Aponent_Helth = Math.Max(Aponent_Helth,0); 
    SC.WriteLine("press any key to continue");
    SC.ReadLine();
}


void FIGHT() {  /* Utför slump striden */
SC.Clear();

SC.WriteLine(@"DING DING! 
Let the fight BEGIN!");
ART.Fighter();    ART.ASCII = 204;
SC.WriteLine("ASCI");
Fight_TrashTalk();
SC.ReadLine();
SC.Clear();


while (Fighting) { // Lopar tills Slagsmålet är över
SC.WriteLine($"Aponents helth:{Aponent_Helth}  your helth:{Player_Helth}  your damage delt:{Damage}");
if(Aponent_id == "1") {ART.ASCII = 201;} else if(Aponent_id == "2") {ART.ASCII = 202;} else if(Aponent_id == "3") {ART.ASCII = 203;}
SC.WriteLine("Fight Choices: (1) Punch  : (2) Kick  : (3) Block : (4) Pary  : (5) Consed  : (6) Trash Talk  :");
Damage = 0;

Aponent_Block = false;
Aponent_kick = false;
Aponent_Pary = false;
Aponent_Punch = false;

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
    ART.Fighter();    ART.ASCII = 205;
    if (Aponent_Block) {
        Damage = Random.Shared.Next(5, 17);
        SC.Clear();
        SC.WriteLine("ASCI"); // You punch, aponent block
        ART.Fighter();    ART.ASCII = 206;
    } else if (Aponent_Pary) {
        Damage = Random.Shared.Next(3, 7);
        Player_Helth =  Player_Helth - Random.Shared.Next(15, 33);
        SC.Clear();
        SC.WriteLine("ASCI"); // You punch, aponent pary
        ART.Fighter();    ART.ASCII = 207;
    }
    if (Aponent_Punch) {Player_Helth =  Player_Helth - Random.Shared.Next(20, 40);}
    if (Aponent_kick) {Player_Helth =  Player_Helth - Random.Shared.Next(30, 50);}
    SC.WriteLine($"{Aponent_move}");
    SC.WriteLine($"{HitChance}");
    if (HitChance < 8) {
    Aponent_Helth = Aponent_Helth - Damage; 
    }
    SC.ReadLine();
    break;
    case (string)("2"):
    fight_kick = true;
        Damage = Random.Shared.Next(30, 50);
        ART.Fighter();    ART.ASCII = 208;
        SC.Clear();
    if (Aponent_Block) {
        Damage = Random.Shared.Next(10, 30);
        ART.Fighter();    ART.ASCII = 209;
    } else if (Aponent_Pary) {
        Damage = Random.Shared.Next(1, 15);
        Player_Helth =  Player_Helth - Random.Shared.Next(30, 45);
        ART.Fighter();    ART.ASCII = 210;
    }
    SC.WriteLine($"{Aponent_move}");
    SC.WriteLine($"{HitChance}");
    if (Aponent_Punch) {Player_Helth =  Player_Helth - Random.Shared.Next(20, 40);}
    if (Aponent_kick) {Player_Helth =  Player_Helth - Random.Shared.Next(30, 50);}
    if (HitChance < 6) {
    Aponent_Helth =  Aponent_Helth - Damage; 
    }
    SC.ReadLine();
    break;
    case (string)("3"):
    fight_block = true;
    SC.Clear();
    if (Aponent_Punch || Aponent_kick) {
       Player_Helth = Player_Helth - Random.Shared.Next(5, 30); 
       ART.Fighter();    ART.ASCII = 211;
    }
    SC.WriteLine($"{Aponent_move}");
    SC.ReadLine();
    break;
    case (string)("4"):
    fight_pary = true;
    SC.Clear();
    if (Aponent_Punch || Aponent_kick) {
        Player_Helth =  Player_Helth - Random.Shared.Next(5, 30);
        Damage = Random.Shared.Next(30, 45);
        Aponent_Helth =  Aponent_Helth - Damage; 
        ART.Fighter();    ART.ASCII = 212;
    }
    SC.WriteLine($"{Aponent_move}");
    SC.ReadLine();
    break;
    case (string)("5"):
    fight_Consed = true;
    Fighting = false;
    break;
    case (string)("6"):
    Fight_TrashTalk();
    SC.ReadLine();
    break;
} //End case

SC.Clear();

if (Aponent_Helth <= 0 && Player_Helth <= 0) {fight_Draw=true;    Fighting = false;}
else if (Aponent_Helth<=0) {fight_Win=true;  Fighting = false;} else if (Player_Helth<=0){fight_Lose=true;    Fighting = false;} 

} /* While Fhigting*/

} // Class FIGHT 

void Fight_TrashTalk() {
    SC.Clear();
T = Random.Shared.Next(1, 7);
switch ((int)(T)){
case (int)(1):
SC.WriteLine(@"*Fighter A steps forward, eyes locked on their opponent with a smirk.* You’re all hype, no bite! 
I’ve seen tougher competition in a mirror. You’re about to get dropped faster than your excuses after tonight. 
Better enjoy this moment, because it’s the closest you'll ever get to the top. I’m ending you in under three rounds.");
break;

case (int)(2):
SC.WriteLine(@"I can see the fear in your eyes—you know you don’t belong in here with me. You’ve got two left feet and a glass jaw, 
perfect combo for a quick nap. After I’m done with you, they’ll be scraping you off the mat. 
Hope your corner’s got an extra towel—because you’re gonna need it.");
break;

case (int)(3):
SC.WriteLine(@"Keep talking while you can, 'cause once that bell rings, your mouth’s staying shut. You’ve got a lot of heart, 
but I’m about to break it. When I hit you, you won’t just feel it—you’ll hear it. They’re calling this a fight, but for you? It’s just survival.");
break;

case (int)(4):
SC.WriteLine(@"Look at you, standing there like you’ve got a chance. You’re the underdog for a reason, pal—everyone knows you're just a warm-up for me. 
I’ll let you throw the first punch, just so you have something to remember before I end it. Don’t blink, or you’ll miss your own defeat.");
break;

case (int)(5):
SC.WriteLine(@"That belt you’re holding? It’s got my name written all over it, and you’re just keeping it warm. Your punches are softer than a pillow, 
and I’m about to tuck you in. When they raise my hand, you’ll realize you were out of your league the whole time. Get ready to kiss the canvas.");
break;

case (int)(6):
SC.WriteLine(@"You’ve been dodging real competition your whole career, but now you’re stuck in here with me. I’ve seen faster reflexes on a punching bag. 
I’m about to turn your lights out, and when you wake up, I’ll already be champion. You’re just one bad decision away from getting knocked out.");
break;

} // end switch

} // end FIGHT_TRASHTALK

void RESULT() {
    Main_Menue = true;
if (fight_Consed) {
    SC.WriteLine("ASCII");
    ART.Result();    ART.ASCII = 301;
    SC.WriteLine(@"What happened, champ? All that talk, and you still couldn’t back it up. You hit me with everything you had, 
    and I’m still standing—what’s your excuse? Maybe next time, train your mouth less and your fists more. You just made my highlight reel.");
    SC.WriteLine("You Conced");
    //SC.WriteLine($"You lose your bet on Aponent {} , - {Aponent1Bet},{Aponent2Bet},{Aponent1Bet} ");
    Aponent1Bet =0;
    Aponent2Bet =0;
    Aponent3Bet =0;
    SC.WriteLine("Press Enter to go back to menue");
    SC.ReadLine();
    SC.Clear();
}
if (fight_Draw) {
   SC.WriteLine("ASCII");
   ART.Fighter();    ART.ASCII = 302;
   SC.WriteLine(@"
   Press Enter to go back to menue");
   //SC.WriteLine($"You lose your bet on Aponent {} , - {Aponent1Bet},{Aponent2Bet},{Aponent1Bet} ");
   Aponent1Bet =0;
    Aponent2Bet =0;
    Aponent3Bet =0;
    SC.ReadLine();
    SC.Clear();
}
if (fight_Win) {
   SC.WriteLine("ASCII");
   ART.Fighter();    ART.ASCII = 303;
   Coins =+ 10;
   SC.WriteLine($"You get 10 Coins, Well Done!");
   Aponent1Bet = Aponent1Bet * 2;
    Aponent2Bet =  Aponent2Bet * 2;
    Aponent3Bet =  Aponent3Bet * 2;
   //SC.writeLine($"Your bet agains aponen { } suceded you get {Coins} ");
   SC.WriteLine("Press Enter to go back to menue");
    SC.ReadLine();
    SC.Clear();
}
if (fight_Lose) {
   SC.WriteLine("ASCII");
   ART.Fighter();    ART.ASCII = 304;
   SC.WriteLine(@"Look at you, flat on the ground where you belong! All that mouth, and this is how you end up? I told you I’d break you, and here you are—broken. 
   Next time, know your place before stepping in my ring. Now, stay down where it’s safe.");
   SC.WriteLine($"You lose 20 Coins!");
   //SC.WriteLine($"You lose your bet on Aponent {} , - {Aponent1Bet},{Aponent2Bet},{Aponent1Bet} ");
   Aponent1Bet =0;
    Aponent2Bet =0;
    Aponent3Bet =0;
   SC.WriteLine("Press Enter to go back to menue");
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
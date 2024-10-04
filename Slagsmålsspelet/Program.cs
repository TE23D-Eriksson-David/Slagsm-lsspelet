using System.Diagnostics;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using SC = System.Console;
using Slagsmålsspelet;


// Slumpstiden V.1 & Den utveklade verisionen V.2
//
// Shift Alt F (För att formatera syntaxen i dokumentet)
// Variabler namn    "string enemyName"

ASCII_art ART = new ASCII_art();

Console.Title = "Slagsmålsspelet";

bool chosingAponent = true;
bool aponentPunch = false;
bool aponentKick = false;
bool aponentBlock = false;
bool aponentPary = false;

bool Fighting = true;
bool subMenue = true;
bool mainMenue = true;
bool Shop = false;
bool Bet = false;
bool trashTalk = false;

/* Vall under striden */
bool fightPunch = false;
bool fightKick = false;
bool fightBlock = false;
bool fightPary = false;
bool fightConsed = false;
bool fightDraw = false;
bool fightWin = false;
bool fightLose = false;
/* ------------------------ */

int aponentChoice = 0;
int Aponent1bet = 0;
int Aponent2bet = 0;
int Aponent3bet = 0;
int i = 0;
int T = 0;
int O = 1;
int playerHelth = 200;
int aponentHelth = 0;
int Damage = 0;
int Coins = 0;
int Betcoins = 0;
int hitChance;

string name;
string aponentId = "0";
string aponentMove = "";
string Choice = "";
string stColor;

while /*MAIN*/ (true)
{

    START();
    NAME();
    while (true)
    {
        while (mainMenue)
        {
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
    ART.ASCII = 101; ART.Menue();
    SC.WriteLine("Press Enter to start");
    SC.ReadLine();
    SC.Clear();
}



void NAME()
{ /*Tar in spelarens namn*/
    SC.WriteLine("Write your player name:");
    name = SC.ReadLine();
    while (name.Length < 3) { SC.Clear(); SC.WriteLine("Write your player name:"); name = SC.ReadLine(); }
}

void SUB_MENUE()
{
    while (subMenue == true)
    {
        SC.Clear();
        ART.ASCII = 102; ART.Menue();
        SC.WriteLine(@"Chose your next action by writing it's coresponding number and then pressing Enter
By chosing option 'Aponent' You will aoutomaticly be locked out of this menue, be aware!
");
        SC.WriteLine("(1) Chosce Aponent    (2) Shop    (3) Bet on Aponent");
        Choice = SC.ReadLine();
        if (Choice == "1") { subMenue = false; mainMenue = false; } else if (Choice == "2") { subMenue = false; Shop = true; } else if (Choice == "3") { subMenue = false; Bet = true; }
    }
    SC.Clear();
}

void SHOP()
{
    if (Shop == true)
    {
        while (Shop == true)
        {
            SC.Clear();
            ART.ASCII = 400; ART.Shop();
            SC.WriteLine("Here you can buy things for your Carakter, Cosmetics, Buffs to his stats, and so on..");
            SC.WriteLine($@"Shop    !!Unfinished, Work in progress!! 
(1) 30 coins, Inverse Colors      (2) 50 coins, Pick Text Color     To Exit Shop (3)");
            Choice = SC.ReadLine();
            switch ((string)(Choice))
            {
                case (string)("1"):
                    if (Coins == 30)
                    {
                        ART.ASCII = 401; ART.Shop();
                        SC.WriteLine(@"You have know recived the switching of color, We unfortunetly have a strikt No return policy.
So I hope your happy whit your purches!");
                        SC.ForegroundColor = ConsoleColor.Black;
                        SC.BackgroundColor = ConsoleColor.White;
                        Coins = Coins - 30;
                        SC.ReadLine();
                        Shop = false;
                    }
                    break;
                case (string)("2"):
                    if (Coins == 50)
                    {
                        while (O == 1)
                        {
                            ART.ASCII = 402; ART.Shop();
                            SC.WriteLine(@"Pick your text color,  1-16 Black to White,  Good luck finding the color that you want!
We unfortunetly have a strikt No return policy. So I hope your happy whit your purches!");
                            SC.WriteLine("Write the number for your color.");
                            stColor = SC.ReadLine();
                            switch ((string)(stColor))
                            {
                                case (string)("1"):
                                    SC.ForegroundColor = ConsoleColor.Black;
                                    O = 0;
                                    break;
                                case (string)("2"):
                                    SC.ForegroundColor = ConsoleColor.DarkBlue;
                                    O = 0;
                                    break;
                                case (string)("3"):
                                    SC.ForegroundColor = ConsoleColor.DarkGreen;
                                    O = 0;
                                    break;
                                case (string)("4"):
                                    SC.ForegroundColor = ConsoleColor.DarkCyan;
                                    O = 0;
                                    break;
                                case (string)("5"):
                                    SC.ForegroundColor = ConsoleColor.DarkRed;
                                    O = 0;
                                    break;
                                case (string)("6"):
                                    SC.ForegroundColor = ConsoleColor.DarkMagenta;
                                    O = 0;
                                    break;
                                case (string)("7"):
                                    SC.ForegroundColor = ConsoleColor.DarkYellow;
                                    O = 0;
                                    break;
                                case (string)("8"):
                                    SC.ForegroundColor = ConsoleColor.Yellow;
                                    O = 0;
                                    break;
                                case (string)("9"):
                                    SC.ForegroundColor = ConsoleColor.DarkGray;
                                    O = 0;
                                    break;
                                case (string)("10"):
                                    SC.ForegroundColor = ConsoleColor.Blue;
                                    O = 0;
                                    break;
                                case (string)("11"):
                                    SC.ForegroundColor = ConsoleColor.Green;
                                    O = 0;
                                    break;
                                case (string)("12"):
                                    SC.ForegroundColor = ConsoleColor.Cyan;
                                    O = 0;
                                    break;
                                case (string)("13"):
                                    SC.ForegroundColor = ConsoleColor.Red;
                                    O = 0;
                                    break;
                                case (string)("14"):
                                    SC.ForegroundColor = ConsoleColor.Magenta;
                                    O = 0;
                                    break;
                                case (string)("15"):
                                    SC.ForegroundColor = ConsoleColor.Yellow;
                                    O = 0;
                                    break;
                                case (string)("16"):
                                    SC.ForegroundColor = ConsoleColor.White;
                                    O = 0;
                                    break;

                            }
                            Shop = false;
                        }
                    }
                    break;
                case (string)("3"):
                    Shop = false;
                    break;
            }
        } // while
    } // if  
    subMenue = true;
} // SHOP


void BET()
{
    if (Bet == true)
    {
        while (Bet == true)
        {
            Choice = "";
            i = 1;
            SC.Clear();
            ART.ASCII = 103; ART.Menue();
            SC.WriteLine(@"Here is the betting hall. You can bett against your aponent if you think you can bet them. 

Beting is done whit coins, you can earn coins affter every fight you win. If you bet on a aponent and succed
in wining agenst them, youl recive duble what you set in. Draws and Loses will forfit your bets making every thing a gamble
But you can Consede whitch will make it so you only lose half of what you bet. Know god luck and let the best gambler win!  
    ");
            SC.WriteLine(@$"Aponents to bet on:    (1) Damon 'The Juggernaut' Steele  (2) Rico 'Thunderstrike' Alvarez (3) Mason 'Iron Will' Graves    ||  Avileble Coins {Coins} ||

Chosing (4) will exit the beting Hall
");

            SC.WriteLine(@$"ASCII of art and stats so you know who youre schosing");

            Choice = SC.ReadLine();
            SC.Clear();
            switch ((string)(Choice))
            {

                case (string)("1"):
                    while (i == 1)
                    {
                        ART.ASCII = 104; ART.Menue();
                        SC.WriteLine(@"
    How mutch are you willing to risk?  (1) 10 coins   (2) 30 coins  (3) 50 coins");
                        Choice = SC.ReadLine();
                        if (Choice == "1" && Coins > 10) { Coins = Coins - 10; Aponent1bet = Aponent1bet + 10; SC.WriteLine("stupid"); } else if (Choice == "2" && Coins > 30) { Coins = Coins - 30; Aponent1bet = Aponent1bet + 30; } else if (Choice == "3" && Coins > 50) { Coins = Coins - 50; Aponent1bet = Aponent1bet + 50; }
                        i = 0;
                    }
                    break;

                case (string)("2"):
                    while (i == 1)
                    {
                        ART.ASCII = 104; ART.Menue();
                        SC.WriteLine("How mutch are you willing to risk?  (1) 10 coins   (2) 30 coins  (3) 50 coins");
                        Choice = SC.ReadLine();
                        if (Choice == "1" && Coins < 10) { Coins = Coins - 10; Aponent2bet = Aponent2bet + 10; } else if (Choice == "2" && Coins < 30) { Coins = Coins - 30; Aponent2bet = Aponent2bet + 30; } else if (Choice == "3" && Coins < 50) { Coins = Coins - 50; Aponent2bet = Aponent2bet + 50; }
                        i = 0;
                    }
                    break;

                case (string)("3"):
                    while (i == 1)
                    {
                        ART.ASCII = 104; ART.Menue();
                        SC.WriteLine("How mutch are you willing to risk?  (1) 10 coins   (2) 30 coins  (3) 50 coins");
                        Choice = SC.ReadLine();
                        if (Choice == "1" && Coins < 10) { Coins = Coins - 10; Aponent3bet = Aponent3bet + 10; } else if (Choice == "2" && Coins < 30) { Coins = Coins - 30; Aponent3bet = Aponent3bet + 30; } else if (Choice == "3" && Coins < 50) { Coins = Coins - 50; Aponent3bet = Aponent3bet + 50; }
                        i = 0;
                    }
                    break;

                case (string)("4"):
                    Bet = false;
                    break;
            }
        } //while
    } //if
    subMenue = true;
    //Choice = "0";
} // BET

void APONENT()
{ /*Inehåller vall av motståndare och ger ut värden för dem */
    while (chosingAponent == true)
    {
        SC.Clear();
        SC.WriteLine(@"Here is where you chose your aponent, Rigt know theres only three Damon 'The Juggernaut' Steele, Rico 'Thunderstrike' Alvarez and Mason 'Iron Will' Graves.
They are difrently skilled, so I would advise you to chose well, Damon Steele has the lest experience in thre ring.
So I say you take a swing at him! 
 ");
        ART.ASCII = 200; ART.Fighter();
        SC.WriteLine(@$"Chose your oponent:            Your name: {name}   Coins: {Coins}
");
        SC.WriteLine(@"Chose aponent by write the number to the coresponding fighter.

");
        SC.WriteLine(@$"Here at the botom, you can se your bets, if you have made any ;D. 
Aponent 1; 'The Juggernaut' Bet: {Aponent1bet}     Aponent 2; 'Thunderstrike' Bet: {Aponent2bet}    Aponent 3; 'Iron Will' Bet: {Aponent3bet}");

        aponentId = SC.ReadLine();
        switch ((string)(aponentId))
        {
            case (string)("1"):
                chosingAponent = false;
                aponentHelth = 150;
                SC.Clear();
                SC.WriteLine("You have chosen aponent one.");
                ART.ASCII = 201; ART.Fighter();
                SC.WriteLine("ASCI & Stats for aponetn Placeholder");

                break;
            case (string)("2"):
                chosingAponent = false;
                aponentHelth = 190;
                SC.Clear();
                SC.WriteLine("You have chosen aponent two.");
                ART.ASCII = 202; ART.Fighter();
                SC.WriteLine("ASCI & Stats for aponetn Placeholder");

                break;
            case (string)("3"):
                chosingAponent = false;
                aponentHelth = 220;
                SC.Clear();
                SC.WriteLine("You have chosen aponent tre.");
                ART.ASCII = 203; ART.Fighter();
                SC.WriteLine("ASCI & Stats for aponetn Placeholder");
                break;
        }
    }
    //aponentHelth = Math.Max(aponentHelth,0); 
    SC.WriteLine("press any key to continue");
    SC.ReadLine();
}


void FIGHT()
{  /* Utför slump striden */
    SC.Clear();

    SC.WriteLine(@"DING DING! 
Let the fight BEGIN!");
    ART.ASCII = 204; ART.Fighter();
    SC.WriteLine("ASCI");
    Fight_TrashTalk();
    SC.ReadLine();
    SC.Clear();


    while (Fighting)
    { // Lopar tills Slagsmålet är över
        SC.WriteLine($"Aponents helth:{aponentHelth}  your helth:{playerHelth}  your damage delt:{Damage}");
        if (aponentId == "1") { ART.ASCII = 201; } else if (aponentId == "2") { ART.ASCII = 202; } else if (aponentId == "3") { ART.ASCII = 203; }
        SC.WriteLine("Fight Choices: (1) Punch  : (2) Kick  : (3) Block : (4) Pary  : (5) Consed  : (6) Trash Talk  :");
        //Damage = 0;

        aponentBlock = false;
        aponentKick = false;
        aponentPary = false;
        aponentPunch = false;

        aponentChoice = Random.Shared.Next(0, 4);
        if (aponentChoice == 1) { aponentBlock = true; aponentMove = "Aponent block"; } else if (aponentChoice == 2) { aponentPary = true; aponentMove = "Aponent Pary"; } else if (aponentChoice == 3) { aponentPunch = true; aponentMove = "Aponent punch"; } else if (aponentChoice == 4) { aponentKick = true; aponentMove = "Aponent kick"; }
        hitChance = Random.Shared.Next(1, 11);

        string Fight_Choice = SC.ReadLine();
        switch ((string)(Fight_Choice))
        {
            case (string)("1"):
                fightPunch = true;
                Damage = Random.Shared.Next(20, 44);
                SC.Clear();
                SC.WriteLine("ASCI"); // You punch, normal conect
                ART.ASCII = 205; ART.Fighter();
                if (aponentBlock)
                {
                    Damage = Random.Shared.Next(5, 17);
                    SC.Clear();
                    SC.WriteLine("ASCI"); // You punch, aponent block
                    ART.ASCII = 206; ART.Fighter();
                }
                else if (aponentPary)
                {
                    Damage = Random.Shared.Next(3, 7);
                    playerHelth = playerHelth - Random.Shared.Next(15, 33);
                    SC.Clear();
                    SC.WriteLine("ASCI"); // You punch, aponent pary
                    ART.ASCII = 207; ART.Fighter();
                }
                if (aponentPunch) { playerHelth = playerHelth - Random.Shared.Next(20, 40); }
                if (aponentKick) { playerHelth = playerHelth - Random.Shared.Next(30, 50); }
                SC.WriteLine($"{aponentMove}");
                SC.WriteLine($"{hitChance}");
                if (hitChance < 8)
                {
                    aponentHelth = aponentHelth - Damage;
                }
                SC.ReadLine();
                break;
            case (string)("2"):
                fightKick = true;
                Damage = Random.Shared.Next(30, 50);
                ART.ASCII = 208; ART.Fighter();
                SC.Clear();
                if (aponentBlock)
                {
                    Damage = Random.Shared.Next(10, 30);
                    ART.ASCII = 209; ART.Fighter();
                }
                else if (aponentPary)
                {
                    Damage = Random.Shared.Next(1, 15);
                    playerHelth = playerHelth - Random.Shared.Next(30, 45);
                    ART.ASCII = 210; ART.Fighter();
                }
                SC.WriteLine($"{aponentMove}");
                SC.WriteLine($"{hitChance}");
                if (aponentPunch) { playerHelth = playerHelth - Random.Shared.Next(20, 40); }
                if (aponentKick) { playerHelth = playerHelth - Random.Shared.Next(30, 50); }
                if (hitChance < 6)
                {
                    aponentHelth = aponentHelth - Damage;
                }
                SC.ReadLine();
                break;
            case (string)("3"):
                fightBlock = true;
                SC.Clear();
                if (aponentPunch || aponentKick)
                {
                    playerHelth = playerHelth - Random.Shared.Next(5, 30);
                    ART.ASCII = 211; ART.Fighter();
                }
                SC.WriteLine($"{aponentMove}");
                SC.ReadLine();
                break;
            case (string)("4"):
                fightPary = true;
                SC.Clear();
                if (aponentPunch || aponentKick)
                {
                    playerHelth = playerHelth - Random.Shared.Next(5, 30);
                    Damage = Random.Shared.Next(30, 45);
                    aponentHelth = aponentHelth - Damage;
                    ART.ASCII = 212; ART.Fighter();
                }
                SC.WriteLine($"{aponentMove}");
                SC.ReadLine();
                break;
            case (string)("5"):
                fightConsed = true;
                Fighting = false;
                break;
            case (string)("6"):
                Fight_TrashTalk();
                SC.ReadLine();
                break;
        } //End case

        SC.Clear();

        if (aponentHelth <= 0 && playerHelth <= 0) { fightDraw = true; Fighting = false; }
        else if (aponentHelth <= 0) { fightWin = true; Fighting = false; } else if (playerHelth <= 0) { fightLose = true; Fighting = false; }

    } /* While Fhigting*/

} // Class FIGHT 

void Fight_TrashTalk()
{
    SC.Clear();
    T = Random.Shared.Next(1, 7);
    switch ((int)(T))
    {
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

void RESULT()
{
    mainMenue = true;
    if (fightConsed)
    {

        ART.ASCII = 301; ART.Result();
        SC.WriteLine(@"What happened, champ? All that talk, and you still couldn’t back it up. You hit me with everything you had, 
    and I’m still standing—what’s your excuse? Maybe next time, train your mouth less and your fists more. You just made my highlight reel.");
        SC.WriteLine("You Conced");
        //SC.WriteLine($"You lose your bet on Aponent {} , - {Aponent1bet},{Aponent2bet},{Aponent1bet} ");
        if (aponentId == "1") { Aponent1bet = 0; } else if (aponentId == "2") { Aponent2bet = 0; } else if (aponentId == "3") { Aponent3bet = 0; }

        SC.WriteLine("Press Enter to go back to menue");
        SC.ReadLine();
        SC.Clear();
    }
    if (fightDraw)
    {

        ART.ASCII = 302; ART.Result();
        SC.WriteLine(@"
   Press Enter to go back to menue");
        //SC.WriteLine($"You lose your bet on Aponent {} , - {Aponent1bet},{Aponent2bet},{Aponent1bet} ");
        if (aponentId == "1") { Aponent1bet = 0; } else if (aponentId == "2") { Aponent2bet = 0; } else if (aponentId == "3") { Aponent3bet = 0; }
        SC.ReadLine();
        SC.Clear();
    }
    if (fightWin)
    {

        ART.ASCII = 303; ART.Result();
        SC.WriteLine($"You get 10 Coins, Well Done!");
        Aponent1bet = Aponent1bet * 2;
        Aponent2bet = Aponent2bet * 2;
        Aponent3bet = Aponent3bet * 2;
        Betcoins = Aponent3bet + Aponent2bet + Aponent1bet;
        if (Aponent1bet > 9 || Aponent2bet > 9 || Aponent3bet > 9)
        {
            SC.WriteLine($"Your bet agains Aponent {aponentId} suceded, you get {Betcoins}");
        }
        Coins = +10;
        Coins = +Betcoins;

        SC.WriteLine("Press Enter to go back to menue");
        SC.ReadLine();
        SC.Clear();
    }
    if (fightLose)
    {

        ART.ASCII = 304; ART.Result();
        SC.WriteLine(@"Look at you, flat on the ground where you belong! All that mouth, and this is how you end up? I told you I’d break you, and here you are—broken. 
   Next time, know your place before stepping in my ring. Now, stay down where it’s safe.");
        SC.WriteLine($"You lose 20 Coins!");
        //SC.WriteLine($"You lose your bet on Aponent {} , - {Aponent1bet},{Aponent2bet},{Aponent1bet} ");
        if (aponentId == "1") { Aponent1bet = 0; } else if (aponentId == "2") { Aponent2bet = 0; } else if (aponentId == "3") { Aponent3bet = 0; }

        SC.WriteLine("Press Enter to go back to menue");
        SC.ReadLine();
        SC.Clear();
    }
}

void RESTART()
{ /* Gör allting för att kunna köra igen (Tar en tillbacka till chosing Aponents) */

    chosingAponent = true;
    aponentPunch = false;
    aponentKick = false;
    aponentBlock = false;
    aponentPary = false;

    Fighting = true;

    /* Vall under striden */
    fightPunch = false;
    fightKick = false;
    fightBlock = false;
    fightPary = false;
    fightConsed = false;
    fightLose = false;
    fightWin = false;
    fightDraw = false;
    /* ------------------------ */
    playerHelth = 200;
    Damage = 0;

}
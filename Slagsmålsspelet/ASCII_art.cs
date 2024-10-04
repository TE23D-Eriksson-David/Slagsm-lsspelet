using System;

namespace Slagsmålsspelet;

public class ASCII_art
{

public int ASCII = 0;

public void Fighter(){
    if (ASCII == 200){Console.WriteLine();} // Fighters on row
if (ASCII == 201){Console.WriteLine();} // fighter 1
if (ASCII == 202){Console.WriteLine();} // fighter 2
if (ASCII == 203){Console.WriteLine();} // fighter 3

if (ASCII == 204){Console.WriteLine();} // Fighter 1
if (ASCII == 205){Console.WriteLine();}
if (ASCII == 206){Console.WriteLine();}
if (ASCII == 207){Console.WriteLine();}
if (ASCII == 208){Console.WriteLine();}
if (ASCII == 209){Console.WriteLine();}
if (ASCII == 210){Console.WriteLine();}
if (ASCII == 211){Console.WriteLine();}
if (ASCII == 212){Console.WriteLine();}

if (ASCII == 213){Console.WriteLine();} // Fighter 2
if (ASCII == 214){Console.WriteLine();}
if (ASCII == 215){Console.WriteLine();}
if (ASCII == 216){Console.WriteLine();}
if (ASCII == 217){Console.WriteLine();}
if (ASCII == 218){Console.WriteLine();}
if (ASCII == 219){Console.WriteLine();}
if (ASCII == 220){Console.WriteLine();}
if (ASCII == 221){Console.WriteLine();}

if (ASCII == 222){Console.WriteLine();} // Fighter 3
if (ASCII == 223){Console.WriteLine();}
if (ASCII == 224){Console.WriteLine();}
if (ASCII == 225){Console.WriteLine();}
if (ASCII == 226){Console.WriteLine();}
if (ASCII == 227){Console.WriteLine();}
if (ASCII == 228){Console.WriteLine();}
if (ASCII == 229){Console.WriteLine();}
if (ASCII == 229){Console.WriteLine();}
}

public void Menue(){
if (ASCII == 101){Console.WriteLine("""
  _______ _ _   _                                     
 |__   __(_) | | |                                    
    | |   _| |_| | ___      ___  ___ _ __ ___  ___ _ __  
    | |  | | __| |/ _ \    / __|/ __| '__/ _ \/ _ \ '_ \ 
    | |  | | |_| |  __/    \__ \ (__| | |  __/  __/ | | |
    |_|  |_|\__|_|\___|    |___/\___|_|  \___|\___|_| |_|
                                                      
""");} // Title screen



if (ASCII == 102){Console.WriteLine(@"   
   _____ _    _ ____    __  __ ______ _   _ _    _ 
  / ____| |  | |  _ \  |  \/  |  ____| \ | | |  | |
 | (___ | |  | | |_) | | \  / | |__  |  \| | |  | |
  \___ \| |  | |  _ <  | |\/| |  __| | . ` | |  | |
  ____) | |__| | |_) | | |  | | |____| |\  | |__| |
 |_____/ \____/|____/  |_|  |_|______|_| \_|\____/ 
                                                   
                                                    ");} // Sub meny
if (ASCII == 103){Console.WriteLine(@"
  ____  ______ _______   __  __ ______ _   _ _    _ 
 |  _ \|  ____|__   __| |  \/  |  ____| \ | | |  | |
 | |_) | |__     | |    | \  / | |__  |  \| | |  | |
 |  _ <|  __|    | |    | |\/| |  __| | . ` | |  | |
 | |_) | |____   | |    | |  | | |____| |\  | |__| |
 |____/|______|  |_|    |_|  |_|______|_| \_|\____/ 
                                                    
                                                     ");} // Bet meny
if (ASCII == 104){Console.WriteLine(@"  
  ____  ______ _______ _____ _   _  _____ 
 |  _ \|  ____|__   __|_   _| \ | |/ ____|
 | |_) | |__     | |    | | |  \| | |  __ 
 |  _ <|  __|    | |    | | | . ` | | |_ |
 | |_) | |____   | |   _| |_| |\  | |__| |
 |____/|______|  |_|  |_____|_| \_|\_____|
                                          
                                          ");} // Betingen
}

public void Result(){
if (ASCII == 301){Console.WriteLine(@"
 __     ______  _    _    _____ ____  _   _  _____ ______ _____  
 \ \   / / __ \| |  | |  / ____/ __ \| \ | |/ ____|  ____|  __ \ 
  \ \_/ / |  | | |  | | | |   | |  | |  \| | (___ | |__  | |  | |
   \   /| |  | | |  | | | |   | |  | | . ` |\___ \|  __| | |  | |
    | | | |__| | |__| | | |___| |__| | |\  |____) | |____| |__| |
    |_|  \____/ \____/   \_____\____/|_| \_|_____/|______|_____/ 
                                                                 
                                                                 ");} // consed
if (ASCII == 302){Console.WriteLine(@"
 __     ______  _    _    _____  _____       __          __
 \ \   / / __ \| |  | |  |  __ \|  __ \     /\ \        / /
  \ \_/ / |  | | |  | |  | |  | | |__) |   /  \ \  /\  / / 
   \   /| |  | | |  | |  | |  | |  _  /   / /\ \ \/  \/ /  
    | | | |__| | |__| |  | |__| | | \ \  / ____ \  /\  /   
    |_|  \____/ \____/   |_____/|_|  \_\/_/    \_\/  \/    
                                                           
                                                           ");} // draw
if (ASCII == 303){Console.WriteLine(@"
 __     ______  _    _  __          _______ _   _ 
 \ \   / / __ \| |  | | \ \        / /_   _| \ | |
  \ \_/ / |  | | |  | |  \ \  /\  / /  | | |  \| |
   \   /| |  | | |  | |   \ \/  \/ /   | | | . ` |
    | | | |__| | |__| |    \  /\  /   _| |_| |\  |
    |_|  \____/ \____/      \/  \/   |_____|_| \_|
                                                  
                                                  ");} // win 
if (ASCII == 304){Console.WriteLine(@"
 __     ______  _    _   _      ____   _____ ______ 
 \ \   / / __ \| |  | | | |    / __ \ / ____|  ____|
  \ \_/ / |  | | |  | | | |   | |  | | (___ | |__   
   \   /| |  | | |  | | | |   | |  | |\___ \|  __|  
    | | | |__| | |__| | | |___| |__| |____) | |____ 
    |_|  \____/ \____/  |______\____/|_____/|______|
                                                    
                                                    ");} // lose
}

public void Shop(){ 
    if (ASCII == 400){Console.WriteLine(@"
  _____ _______ ______ __  __  _____      __       ___   __   ___         ___   ___    ___ 
 |_   _|__   __|  ____|  \/  |/ ____|    / /      |  _| /_ | |_  |       |  _| |__ \  |_  |
   | |    | |  | |__  | \  / | (___     / /       | |    | |   | |       | |      ) |   | |
   | |    | |  |  __| | |\/| |\___ \   < <        | |    | |   | |       | |     / /    | |
  _| |_   | |  | |____| |  | |____) |   \ \       | |    | |   | |       | |    / /_    | |
 |_____|  |_|  |______|_|  |_|_____/     \_\      | |_   |_|  _| |       | |_  |____|  _| |
                                                  |___|      |___|       |___|        |___|
                                                                                           ");} // Bild för shopen
    if (ASCII == 401){Console.WriteLine(@"
  ___   __   ___ 
 |  _| /_ | |_  |
 | |    | |   | |
 | |    | |   | |
 | |    | |   | |
 | |_   |_|  _| |
 |___|      |___|
                 ");} // bild för val 1 invert 
    if (ASCII == 402){Console.WriteLine(@"
  ___   ___    ___ 
 |  _| |__ \  |_  |
 | |      ) |   | |
 | |     / /    | |
 | |    / /_    | |
 | |_  |____|  _| |
 |___|        |___|
                   ");} // bild för välj färg
}





















































































































































































































































































































}

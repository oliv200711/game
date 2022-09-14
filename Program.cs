using System;
using System.Threading;
// for at statre programmet skal du skrive: dotnet run
namespace helloworld3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("velkommen til Olivers gætte spil");
            var tallet = new Random().Next(1,101);
            Console.WriteLine("jeg har nu et tal, du skal gætte det");
			var gættet =  "";
			var gætSomTal = 0;
            while(string.IsNullOrEmpty(gættet))
			{
				gættet = Console.ReadLine();
      			if(int.TryParse(gættet, out gætSomTal) == false)
      			{
          			Console.WriteLine("Du har indtastet en ugyldig tal! Prøv igen");
          			gættet = "";
      			}
			}
			var antalBrugteForsøg = 0;
			while(tallet != gætSomTal)
			{
				antalBrugteForsøg = antalBrugteForsøg +1;

				if(antalBrugteForsøg==10){
					Console.ForegroundColor = ConsoleColor.Green;
					Console.WriteLine($"du har forsøgt for mange gange det rigtige tal var {tallet}");
				Console.ForegroundColor = ConsoleColor.White;
				Console.Beep(5000,3000);
					Environment.Exit(0);
				};
Console.ForegroundColor = ConsoleColor.Red;
Console.Beep();
				Console.WriteLine("dit svare er detsvære forkeret, prøv igen, du har brugt " + antalBrugteForsøg + " forsøg.");
				Console.ForegroundColor = ConsoleColor.White;
				if(gætSomTal > tallet)
				{
					Console.WriteLine("Dit gæt var for højt!");
				}
				else
				{
					Console.WriteLine("Dit gæt var for lavt!");
				}


				 gættet = "";
			 	
            	while(string.IsNullOrEmpty(gættet))
				{
					gættet = Console.ReadLine();
      			if(int.TryParse(gættet, out gætSomTal) == false)
      			{
          			Console.WriteLine("Du har indtastet en ugyldig tal! Prøv igen");
          			gættet = "";
      			}
				}
			}
			antalBrugteForsøg = antalBrugteForsøg +1;

			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine($"tillyke du har gættet rigtigt,du brugte {antalBrugteForsøg}");
			Playhappy();
        }
		private static void Playhappy()
	{
		
		 Console.Beep(659, 125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(523, 125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(375); Console.Beep(392, 125); Thread.Sleep(375); Console.Beep(523, 125); Thread.Sleep(250); Console.Beep(392, 125); Thread.Sleep(250); Console.Beep(330, 125); Thread.Sleep(250); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(466, 125); Thread.Sleep(42); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(392, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(880, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(587, 125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(250); Console.Beep(392, 125); Thread.Sleep(250); Console.Beep(330, 125); Thread.Sleep(250); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(466, 125); Thread.Sleep(42); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(392, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(880, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(587, 125); Console.Beep(494, 125); Thread.Sleep(375); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(698, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(698, 125); Thread.Sleep(625); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(622, 125); Thread.Sleep(250); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(523, 125); Thread.Sleep(1125); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(698, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(698, 125); Thread.Sleep(625); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(622, 125); Thread.Sleep(250); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(523, 125);
Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine(@"██████████
█░░░░░░░░█
█░██░░██░█
█░░░██░░░█
█░░████░░█
█░░█░░█░░█
█░░░░░░░░█
██████████
──█░░░░█
──█░░░░█
──█░░░░█
──█░░░░█
──█░░░░█
──█░░░░█
██████████
█░░░██░░░█
█░░░██░░░█
█▄█▄██▄█▄█");
	}

    }	
}


using System;

namespace To1
{
	
	public static class Menu
	{
		
		public static void menu1()
		{
            //this class is responsible for creating the main menu of the game.

            int menu;
			
		
			Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$\n");
			Console.WriteLine("                  ZOSTAŃ MILIONEREM                    \n");
			Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$\n");
			Console.WriteLine("                        M E N U                        \n");
			Console.WriteLine("                  1. Rozpocznij grę                    \n");
			Console.WriteLine("                  2. Zakończ grę                       \n");
			Console.Write("                   Wybierz opcję: ");
			
			
			menu = Convert.ToInt32(Console.ReadLine());
			
			switch (menu){
				case 0:
					Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$\n");
			Console.WriteLine("                  ZOSTAŃ MILIONEREM                    \n");
			Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$\n");
			Console.WriteLine("                        M E N U                        \n");
			Console.WriteLine("                  1. Rozpocznij grę                    \n");
			Console.WriteLine("                  2. Zakończ grę                       \n");
			Console.Write("           BŁĄD. Wybierz jedną z dostępnych opcji: ");
			
			
			menu = Convert.ToInt32(Console.ReadLine());
			
			if (menu.Equals(1)){
			goto case 1;
			}
			if (menu.Equals(2)){
			goto case 2;
			}
			else {
			Console.Clear();
			goto case 0;
			}
			
				case 1:
					Console.Clear();
					Pytanie1.Pytanie_1();
					break;
				case 2:
					Console.Write("Dziękujemy za grę. Naciśniej dowolny klawisz...");
					Console.ReadKey();
					System.Environment.Exit(1);
					break;
				default:
					Console.Clear();
					goto case 0;
					
					
			}
			
		}
	}}


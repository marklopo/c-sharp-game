
using System;

namespace To1
{
	
	public static class  Pytanie1
	{
		public static int podpowiedz1;
		public static int poprawnaodpowiedz = 2;
		
		
		public static void  pytanie_1()
		{
            Podpowiedz.pod_0(); //the creation of lifebuoys
            Pytania.pytanie_1();

			Console.Write("\nJaka jest Twoja decyzja: A. Odpowiedź B. Podpowiedź C. Koniec gry? ");
			string decyzja = Console.ReadLine();
			if(decyzja.Equals("a")|| decyzja.Equals("A")){
				Console.Write("\nJaka jest Twoja odpowiedź? ");
				int pytanie1 = Convert.ToInt32(Console.ReadLine());
				if(pytanie1== poprawnaodpowiedz)
				{
					Pytania.pytanie_1_Wygrana();
					Console.WriteLine("\n---------------------------------------------------------------------");
					Pytanie2.pytanie_2();
				}
				else {
					Pytania.pytanie_1_ZlaOdpowiedz();
					Console.ReadKey();
					Console.Clear();
					Podpowiedz.pod_4();
					Menu.menu1();
					
					
				}
				
				
			}
			else if(decyzja.Equals("b")|| decyzja.Equals("B")){
                Podpowiedz.Pod();
                Console.Write("\nJaki jest Twój wybór? ");
				podpowiedz1 = Convert.ToInt32(Console.ReadLine());
				
				if (podpowiedz1 == 1){
					Podpowiedz.pod.Remove("1. 50 / 50");
					Console.WriteLine("+------------------------+");
					Console.WriteLine("KOŁO RATUNKOWE: 50 / 50");
					Console.WriteLine("+------------------------+");
					Pytania.pytanie_1_5050();
					Console.Write("\nJaka jest Twoja decyzja: A. Odpowiedź B. Podpowiedź C. Koniec gry? ");
					string decyzja1 = Console.ReadLine();
					if(decyzja1.Equals("a")|| decyzja1.Equals("A")){
						Console.Write("\nJaka jest Twoja odpowiedź? ");
						int pytanie1 = Convert.ToInt32(Console.ReadLine());
						if(pytanie1== poprawnaodpowiedz)
						{
							Pytania.pytanie_1_Wygrana();
							Console.WriteLine("\n---------------------------------------------------------------------");
							Pytanie2.pytanie_2();
						}
						else {
							Pytania.pytanie_1_ZlaOdpowiedz();
							Console.ReadKey();
							Console.Clear();
							Podpowiedz.pod_4();
							Menu.menu1();
						}
					}
					else if(decyzja1.Equals("b")|| decyzja1.Equals("B")){
						Podpowiedz.Pod2();
						Console.Write("\nJaki jest Twój wybór?");
						podpowiedz1 = Convert.ToInt32(Console.ReadLine());
						
						if (podpowiedz1 == 2){
							Podpowiedz.pod.Remove("2. TELEFON DO PRZYJACIELA");
							Console.WriteLine("+-------------------------------------+");
							Console.WriteLine("KOŁO RATUNKOWE: Telefon do przyjaciela");
							Console.WriteLine("+-------------------------------------+");
							Pytania.pytanie_1_5050_TelDoPrzyjaciela();
							Console.Write("\nJaka jest Twoja odpowiedź? ");
							int pytanie1 = Convert.ToInt32(Console.ReadLine());
							if(pytanie1== poprawnaodpowiedz)
							{
								Pytania.pytanie_1_Wygrana();
								Console.WriteLine("\n---------------------------------------------------------------------");
								Pytanie2.pytanie_2();
							}
							else {
								Pytania.pytanie_1_ZlaOdpowiedz();
								Console.ReadKey();
								Console.Clear();
								Menu.menu1();
							}
						}
						if (podpowiedz1 == 3){
							Podpowiedz.pod.Remove("3. PYTANIE DO PUBLICZNOŚCI");
							Console.WriteLine("+--------------------------------------+");
							Console.WriteLine("KOŁO RATUNKOWE: Pytanie do publiczności");
							Console.WriteLine("+--------------------------------------+");
							Pytania.pytanie_1_5050_pytDoPubl();
							Console.Write("\nJaka jest Twoja odpowiedź? ");
							int pytanie1 = Convert.ToInt32(Console.ReadLine());
							if(pytanie1== poprawnaodpowiedz)
							{
								Pytania.pytanie_1_Wygrana();
								Console.WriteLine("\n---------------------------------------------------------------------");
								Pytanie2.pytanie_2();
							}
							else {
								Pytania.pytanie_1_ZlaOdpowiedz();
								Console.ReadKey();
								Console.Clear();
								Podpowiedz.pod_4();
								Menu.menu1();
							}
						}
					}
					else {
						Pytania.pytanie_1_Wygrana_Koniec();
						Console.ReadKey();
						Podpowiedz.pod_4();
						Console.Clear();
						Menu.menu1();
					}
				}
				else if(podpowiedz1 == 2){
					Podpowiedz.pod.Remove("2. TELEFON DO PRZYJACIELA");
				Console.WriteLine("+--------------------------------------+");
				Console.WriteLine("KOŁO RATUNKOWE: Telefon do przyjacela");
				Console.WriteLine("+--------------------------------------+");
				Pytania.pytanie_1_TelDoPrzyjaciela();
				Console.Write("Jaka jest Twoja decyzja: A. Odpowiedź B. Podpowiedź C. Koniec gry? ");
				string decyzja1 = Console.ReadLine();
				if(decyzja1.Equals("a")|| decyzja1.Equals("A")){
					Console.WriteLine("Jaka jest Twoja odpowiedź?");
					int pytanie1 = Convert.ToInt32(Console.ReadLine());
					if(pytanie1== poprawnaodpowiedz)
					{
						Pytania.pytanie_1_Wygrana();
						Console.WriteLine("\n---------------------------------------------------------------------");
						Pytanie2.pytanie_2();
					}
					else {
						Pytania.pytanie_1_ZlaOdpowiedz();
						Console.ReadKey();
						Console.Clear();
						Podpowiedz.pod_4();
						Menu.menu1();
					}
				}
				else if(decyzja1.Equals("b")|| decyzja1.Equals("B")){
					Podpowiedz.Pod2();

					Console.Write("\nJaki jest Twój wybór? ");
					podpowiedz1 = Convert.ToInt32(Console.ReadLine());
					
					if (podpowiedz1 == 1){
						Podpowiedz.pod.Remove("1. 50 / 50");
						Console.WriteLine("+--------------------------------------+");
						Console.WriteLine("KOŁO RATUNKOWE: 50 / 50");
						Console.WriteLine("+--------------------------------------+");
						Pytania.pytanie_1_TelDoPrzyjaciela_5050();
						Console.Write("\nJaka jest Twoja odpowiedź? ");
						int pytanie1 = Convert.ToInt32(Console.ReadLine());
						if(pytanie1== poprawnaodpowiedz)
						{
							Pytania.pytanie_1_Wygrana();
							Console.WriteLine("\n---------------------------------------------------------------------");
							Pytanie2.pytanie_2();
						}
						else {
							Pytania.pytanie_1_ZlaOdpowiedz();
							Console.ReadKey();
							Console.Clear();
							Podpowiedz.pod_4();
							Menu.menu1();
						}
					}
					if (podpowiedz1 == 3){
						Podpowiedz.pod.Remove("3. PYTANIE DO PUBLICZNOŚCI");
						Console.WriteLine("+--------------------------------------+");
						Console.WriteLine("KOŁO RATUNKOWE: Pytanie do publiczności");
						Console.WriteLine("+--------------------------------------+");
						Pytania.pytanie_1_TelDoPrzyjaciela_pytDoPubl();
						Console.Write("\nJaka jest Twoja odpowiedź? ");
						int pytanie1 = Convert.ToInt32(Console.ReadLine());
						if(pytanie1== poprawnaodpowiedz)
						{
							Pytania.pytanie_1_Wygrana();
							Console.WriteLine("\n---------------------------------------------------------------------");
							Pytanie2.pytanie_2();
						}
						else {
							Pytania.pytanie_1_ZlaOdpowiedz();
							Console.ReadKey();
							Console.Clear();
							Podpowiedz.pod_4();
							Menu.menu1();
						}
					}
					
					
				}
				else {
					Pytania.pytanie_1_Wygrana_Koniec();
					Console.ReadKey();
					Console.Clear();
					Podpowiedz.pod_4();
					Menu.menu1();
				}
			}
				else if(podpowiedz1 == 3){
					Podpowiedz.pod.Remove("3. PYTANIE DO PUBLICZNOŚCI");
			Console.WriteLine("+--------------------------------------+");
			Console.WriteLine("KOŁO RATUNKOWE: Pytanie do publiczności");
			Console.WriteLine("+--------------------------------------+");
			Pytania.pytanie_1_pytDoPubl();
			Console.Write("Jaka jest Twoja decyzja: A. Odpowiedź B. Podpowiedź C. Koniec gry? ");
			string decyzja1 = Console.ReadLine();
			if(decyzja1.Equals("a")|| decyzja1.Equals("A")){
				Console.Write("\nJaka jest Twoja odpowiedź? ");
				int pytanie1 = Convert.ToInt32(Console.ReadLine());
				if(pytanie1== poprawnaodpowiedz)
				{
					Pytania.pytanie_1_Wygrana();
					Console.WriteLine("\n---------------------------------------------------------------------");
					Pytanie2.pytanie_2();
				}
				else {
					Pytania.pytanie_1_ZlaOdpowiedz();
					Console.ReadKey();
					Console.Clear();
					Podpowiedz.pod_4();
					Menu.menu1();
				}
			}
			else if(decyzja1.Equals("b")|| decyzja1.Equals("B")){
				Podpowiedz.Pod2();

				Console.WriteLine("Jaki jest Twój wybór?");
				podpowiedz1 = Convert.ToInt32(Console.ReadLine());
				
				if (podpowiedz1 == 1){
					Podpowiedz.pod.Remove("1. 50 / 50");
					Console.WriteLine("+--------------------------------------+");
					Console.WriteLine("KOŁO RATUNKOWE: 50 / 50");
					Console.WriteLine("+--------------------------------------+");
					Pytania.pytanie_1_pytDoPubl_5050();
					Console.Write("\nJaka jest Twoja odpowiedź? ");
					int pytanie1 = Convert.ToInt32(Console.ReadLine());
					if(pytanie1== poprawnaodpowiedz)
					{
						Pytania.pytanie_1_Wygrana();
						Console.WriteLine("\n---------------------------------------------------------------------");
						Pytanie2.pytanie_2();
					}
					else {
						Pytania.pytanie_1_ZlaOdpowiedz();
						Console.ReadKey();
						Console.Clear();
						Podpowiedz.pod_4();
						Menu.menu1();
					}
				}
				if (podpowiedz1 == 2){
					Podpowiedz.pod.Remove("2. TELEFON DO PRZYJACIELA");
					Console.WriteLine("+--------------------------------------+");
					Console.WriteLine("KOŁO RATUNKOWE: Telefon do przyjaciela");
					Console.WriteLine("+--------------------------------------+");
					Pytania.pytanie_1_pytDoPubl_TelDoPrzyjaciela();
					Console.Write("\nJaka jest Twoja odpowiedź? ");
					int pytanie1 = Convert.ToInt32(Console.ReadLine());
					if(pytanie1== poprawnaodpowiedz)
					{
						Pytania.pytanie_1_Wygrana();
						Console.WriteLine("\n---------------------------------------------------------------------");
						Pytanie2.pytanie_2();
					}
					else {
						Pytania.pytanie_1_ZlaOdpowiedz();
						Console.ReadKey();
						Console.Clear();
						Podpowiedz.pod_4();
						Menu.menu1();
					}
				}
			}
			else {
				Pytania.pytanie_1_Wygrana_Koniec();
				Console.ReadKey();
				Console.Clear();
				Podpowiedz.pod_4();
				Menu.menu1();
			}
		}
		}
			else {
			Pytania.pytanie_1_Wygrana_Koniec();
			Console.ReadKey();
			Console.Clear();
			Podpowiedz.pod_4();
			Menu.menu1();
			}
		}
			
	}}

			
		
		
		
		
		
		
		


using System;

namespace To1
{
	
	public class Pytania
	{
		public static double poziom0 = 0.00;
		public static int poziom1 = 1000;
		public static int poziom2 = 10000;
		public static int poziom3 = 500000;
		public static int poziom4 = 750000;
		
		public static string kwota1=  "1000";
		public static string kwota2 = "10.000";
		public static string kwota3 = "500.000";
		public static string kwota4 = "750.000";
		public static string kwota5 = "1.000.000";

        //question 1

        public static void pytanie_1()
		{
			
            Console.WriteLine("pyTANIE 1 z 5.\n\nWynik działania 11 mod 4 to: 1. Jeden 2. Trzy 3. Dwa 4. Cztery ");
		}
		public static void pytanie_1_5050() //
		{
			Console.WriteLine("1. Jeden 2. Trzy  ");
		}
		public static void pytanie_1_5050_TelDoPrzyjaciela() //
		{
			Console.WriteLine("1. Jeden (+) 2. Trzy (+++) ");
		}
		public static void pytanie_1_5050_pytDoPubl()
		{
			Console.WriteLine("1. Jeden (10%) 2. Trzy (90%) ");
		}
		public static void pytanie_1_TelDoPrzyjaciela()//
		{
			Console.WriteLine("1. Jeden (+) 2. Trzy (++) 3. Dwa (+) 4. Cztery  ");
		}
		public static void pytanie_1_TelDoPrzyjaciela_5050()
		{
			pytanie_1_5050_TelDoPrzyjaciela();
		}
		public static void pytanie_1_TelDoPrzyjaciela_pytDoPubl()
		{
			pytanie_1_pytDoPubl();
		}
		public static void pytanie_1_pytDoPubl()//
		{
			Console.WriteLine("1. Jeden (5%) 2. Trzy (70%) 3. Dwa (15%) 4. Cztery (10%)");
		}
		public static void pytanie_1_pytDoPubl_5050()
		{
			pytanie_1_5050();
		}
		public static void pytanie_1_pytDoPubl_TelDoPrzyjaciela()
		{
			pytanie_1_TelDoPrzyjaciela();
		}
		public static void pytanie_1_Wygrana()
		{
			Console.WriteLine("\nPoprawna odpowiedź. WYGRAŁEŚ "+kwota1+" zł. ");
		}
		public static void pytanie_1_Wygrana_Koniec()
		{
			Console.WriteLine("\nDziękuję wspaniałą za grę. Opuszczasz grę bez wygranej. Naciśnij dowolny klawisz...");
		}
		public static void pytanie_1_ZlaOdpowiedz()
		{
			Console.Write("\nZła odpowiedź. Twoja gra dobiegła końca. WYGRAŁEŚ "+ poziom0 +" zł. Aby wrócić do Menu naciśnij klawisz T");
		}
        //question 2
        public static void pytanie_2()
		{
			Console.WriteLine("pyTANIE 2 z 5.\n\nWynik dizałania 3! to 1. 3 2. 6 3. 9 4. 12 ");
		}
		public static void pytanie_2_5050() 
		{
			Console.WriteLine("1. 3 2. 6 ");
		}
		public static void pytanie_2_5050_TelDoPrzyjaciela() 
		{
			Console.WriteLine("1. 3 (+) 2. 6 (+++)");
		}
		public static void pytanie_2_5050_pytDoPubl()
		{
			Console.WriteLine("1. 3 (10%) 2. 6 (90%) ");
		}
		public static void pytanie_2_TelDoPrzyjaciela()
		{
			Console.WriteLine("1. 3  2. 6 (++++) 3. 9  4. 12 ");
		}
		public static void pytanie_2_TelDoPrzyjaciela_5050()
		{
			pytanie_2_5050_TelDoPrzyjaciela();
		}
		public static void pytanie_2_TelDoPrzyjaciela_pytDoPubl()
		{
			pytanie_2_pytDoPubl();
		}
		public static void pytanie_2_pytDoPubl()//
		{
			Console.WriteLine("1. 3 (20%) 2. 6 (50%) 3. 9 (10%) 4. 12 (20%) ");
		}
		public static void pytanie_2_pytDoPubl_5050()
		{
			pytanie_2_5050();
		}
		public static void pytanie_2_pytDoPubl_TelDoPrzyjaciela()
		{
			pytanie_2_TelDoPrzyjaciela();
		}
		public static void pytanie_2_Wygrana()
		{
			Console.WriteLine("\nPoprawna odpowiedź. WYGRAŁEŚ "+kwota2+" zł. ");
		}
		public static void pytanie_2_Wygrana_Koniec()
		{
			Console.WriteLine("\nDziękuję wspaniałą za grę. Opuszczasz grę bez wygranej. Naciśnij dowolny klawisz...");
		}
		public static void pytanie_2_ZlaOdpowiedz()
		{
			Console.Write("\nZła odpowiedź. Twoja gra dobiegła końca. WYGRAŁEŚ "+poziom1+" zł. Aby wrócić do Menu naciśnij klawisz T");
		}
        //question 3
        public static void pytanie_3()
		{
			Console.WriteLine("pyTANIE 3 z 5.\n\nKtóre państwo zdobyło od 1896 roku najwyższą liczbę złotych medali letnich igrzysk olimpijskich?");
			Console.WriteLine("1. Kanada 2. USA 3. Szwecja 4. Chiny");
		}
		public static void pytanie_3_5050() 
		{
			Console.WriteLine("1. Kanada 2. USA ");
		}
		public static void pytanie_3_5050_TelDoPrzyjaciela() 
		{
			Console.WriteLine("1. Kanada (+) 2. USA (+++)");
		}
		public static void pytanie_3_5050_pytDoPubl()
		{
			Console.WriteLine("1. Kanada (10%) 2. USA (90%) ");
		}
		public static void pytanie_3_TelDoPrzyjaciela()
		{
			Console.WriteLine("1. Kanada 2. USA (++++) 3. Szwecja 4. Chiny ");
		}
		public static void pytanie_3_TelDoPrzyjaciela_5050()
		{
			pytanie_2_5050_TelDoPrzyjaciela();
		}
		public static void pytanie_3_TelDoPrzyjaciela_pytDoPubl()
		{
			pytanie_3_pytDoPubl();
		}
		public static void pytanie_3_pytDoPubl()//
		{
			Console.WriteLine("1. Kanada (20%) 2. USA (50%) 3. Szwecja (10%) 4. Chiny (20%) ");
		}
		public static void pytanie_3_pytDoPubl_5050()
		{
			pytanie_3_5050();
		}
		public static void pytanie_3_pytDoPubl_TelDoPrzyjaciela()
		{
			pytanie_3_TelDoPrzyjaciela();
		}
		public static void pytanie_3_Wygrana()
		{
			Console.WriteLine("\nPoprawna odpowiedź. WYGRAŁEŚ "+kwota3+" zł. ");
		}
		public static void pytanie_3_Wygrana_Koniec()
		{
			Console.WriteLine("\nDziękuję wspaniałą za grę. Opuszczasz grę bez wygranej. Naciśnij dowolny klawisz...");
		}
		public static void pytanie_3_ZlaOdpowiedz()
		{
			Console.Write("\nZła odpowiedź. Twoja gra dobiegła końca. WYGRAŁEŚ "+poziom2+" zł. Aby wrócić do Menu naciśnij klawisz T");
		}
        //question 4
        public static void pytanie_4()
		{
			Console.WriteLine("pyTANIE 4 z 5.\n\n Ile galaktyk wchodzi w skład układu Arp 282 ? 1. trzy 2. dwie 3. cztery 4. pięć ");
		}
		public static void pytanie_4_5050() 
		{
			Console.WriteLine("1. trzy 2. dwie ");
		}
		public static void pytanie_4_5050_TelDoPrzyjaciela() 
		{
			Console.WriteLine("1. trzy (+) 2. dwie (+++)");
		}
		public static void pytanie_4_5050_pytDoPubl()
		{
			Console.WriteLine("1. trzy (10%) 2. dwie (90%) ");
		}
		public static void pytanie_4_TelDoPrzyjaciela()//
		{
			Console.WriteLine("1. trzy 2. dwie (++++) 3. cztery 4. pięć ");
		}
		public static void pytanie_4_TelDoPrzyjaciela_5050()
		{
			pytanie_4_5050_TelDoPrzyjaciela();
		}
		public static void pytanie_4_TelDoPrzyjaciela_pytDoPubl()
		{
			pytanie_4_pytDoPubl();
		}
		public static void pytanie_4_pytDoPubl()//
		{
			Console.WriteLine("1. trzy (20%) 2. dwie (50%) 3. cztery (10%) 4. pięć (20%) ");
		}
		public static void pytanie_4_pytDoPubl_5050()
		{
			pytanie_4_5050();
		}
		public static void pytanie_4_pytDoPubl_TelDoPrzyjaciela()
		{
			pytanie_4_TelDoPrzyjaciela();
		}
		public static void pytanie_4_Wygrana()
		{
			Console.WriteLine("\nPoprawna odpowiedź. WYGRAŁEŚ "+kwota4+" zł. ");
		}
		public static void pytanie_4_Wygrana_Koniec()
		{
			Console.WriteLine("\nDziękuję wspaniałą za grę. Opuszczasz grę bez wygranej. Naciśnij dowolny klawisz...");
		}
		public static void pytanie_4_ZlaOdpowiedz()
		{
			Console.Write("\nZła odpowiedź. Twoja gra dobiegła końca. WYGRAŁEŚ "+poziom3+" zł. Aby wrócić do Menu naciśnij klawisz T");
		}

        //question 5
        public static void pytanie_5()
		{
			Console.WriteLine("pyTANIE 5 z 5.\n\nTaekwondo to: 1. Rodzaj herbaty 2. Sztuka walki 3. Sposób malowania 4. Marka samochodu");
		}
		public static void pytanie_5_5050() 
		{
			Console.WriteLine("1. Rodzaj herbaty 2. Sztuka walki ");
		}
		public static void pytanie_5_5050_TelDoPrzyjaciela() 
		{
			Console.WriteLine("1. Rodzaj herbaty (+) 2. Sztuka walki (+++)");
		}
		public static void pytanie_5_5050_pytDoPubl()
		{
			Console.WriteLine("1. Rodzaj herbaty (10%) 2. Sztuka walki (90%) ");
		}
		public static void pytanie_5_TelDoPrzyjaciela()
		{
			Console.WriteLine("1. Rodzaj herbaty 2. Sztuka walki (++++) 3. Grze na gitarze 4. Karate");
		}
		public static void pytanie_5_TelDoPrzyjaciela_5050()
		{
			pytanie_5_5050_TelDoPrzyjaciela();
		}
		public static void pytanie_5_TelDoPrzyjaciela_pytDoPubl()
		{
			pytanie_5_pytDoPubl();
		}
		public static void pytanie_5_pytDoPubl()
		{
			Console.WriteLine("1. Rodzaj herbaty (20%) 2. Sztuka walki (50%) 3. Grze na gitarze (10%) 4. Karate (20%) ");
		}
		public static void pytanie_5_pytDoPubl_5050()
		{
			pytanie_5_5050();
		}
		public static void pytanie_5_pytDoPubl_TelDoPrzyjaciela()
		{
			pytanie_5_TelDoPrzyjaciela();
		}
		public static void pytanie_5_Wygrana()
		{
			Console.WriteLine("\nPoprawna odpowiedź. WYGRAŁEŚ "+kwota5+" zł. GRATULACJE. Koniec gry. Naciśnij dowolny klawisz, aby powrócić do MENU.");
		}
		public static void pytanie_5_Wygrana_Koniec()
		{
			Console.WriteLine("\nDziękuję wspaniałą za grę. Opuszczasz grę bez wygranej. Naciśnij dowolny klawisz...");
		}
		public static void pytanie_5_ZlaOdpowiedz()
		{
			Console.Write("\nZła odpowiedź. Twoja gra dobiegła końca. WYGRAŁEŚ "+poziom4+" zł. Aby wrócić do Menu naciśnij klawisz T");
		}
	}
}

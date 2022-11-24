using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U1_W1_D4
{
    internal class Utente
    {
        private static string _username;      
        private static string _password;      
        private static List<DateTime> accessi;
        private static bool loggato;
        private static DateTime ultimologin;
        public static void Menu()
        {
            int scelta = 0;
            try
            {
                do
                {
                    Console.WriteLine("===========OPERAZIONI===========");
                    Console.WriteLine("Scegli l'operazione da effettuare");
                    Console.WriteLine($"1.: Login");
                    Console.WriteLine($"2.: Logut");
                    Console.WriteLine($"3.: Verifica ora e data di login");
                    Console.WriteLine($"4.: Lista degli accessi");
                    Console.WriteLine($"5.: Esci");
                    scelta = int.Parse(Console.ReadLine());
                } while (scelta > 6);
                if (scelta == 1 ) 
                {
                    Login();
                    accessi.Add(DateTime.Now);
                    Utente.loggato = true;
                    Utente.ultimologin = DateTime.Now;
                    Menu();
                } 
                else if (scelta == 2 )
                {
                    
                    if (Utente.loggato == true) 
                    {
                        Logout();                       
                    }
                    else
                    {
                        Console.WriteLine("Mi dispiace non sei loggato");

                    }
                }
                else if (scelta == 3 ) 
                {
                    if (Utente.loggato == true) 
                    {
                        Console.WriteLine($"Verifica orario: {Utente.ultimologin} "); 
                        Menu();
                    } else
                    {
                        Console.WriteLine("Prova a loggarti per vedere l'ora ");
                        Menu();
                    }
                }
                else if (scelta == 4) 
                {
                    if (Utente.loggato == true)
                    {
                        for (int i = 0; i < Utente.accessi.Count; i++)
                        {
                            Console.WriteLine($"{Utente.ultimologin}");

                        }
                    }else
                    {
                        Console.WriteLine("Devi essere loggato");
                        Menu();
                    }

                    
                }
                else if (scelta == 5) 
                {
                    
                }
            } catch
            {
                Console.WriteLine("Non hai inserito un valore valido");
                Menu();
            }
        }
        private static void Login()
        {
            Console.WriteLine($"Username :");
            string username = Console.ReadLine();          
            Console.WriteLine($"Password :");
            string password = Console.ReadLine();
            Console.WriteLine($"Conferma password:");
            string confermapassword = Console.ReadLine();
            
            _username = username;
            _password = password;
            string _confermapassword = "";
            _confermapassword = confermapassword;
            Console.WriteLine($"Benvenuto: {username}");           
        }
        private static void Logout()
        {
            
            accessi.Remove(DateTime.Now);
        }
    }
}

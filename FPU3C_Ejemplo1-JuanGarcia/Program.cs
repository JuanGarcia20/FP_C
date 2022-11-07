using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace FPU3C_Ejemplo1_JuanGarcia
{
    class Program
    {
        static void Main(string[] args)
        {

            //manejo de estructuras selectivas
            string nameUser, lastName, contactNumber, city, FBProfile, Email;
            string user, password,passwordConfirm, codeAccess;
            byte age = 0;


            //asignacion de variables
            Console.WriteLine("ingresa tu nombre:");
            nameUser = Console.ReadLine();
            Console.WriteLine("ingresa tu apellido:");
            lastName = Console.ReadLine();

            Console.WriteLine("ingresa tu edad:");
            age = Convert.ToByte(Console.ReadLine());

            //if
            if (age >= 18)
            {
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Clear();
                Console.WriteLine("completa tu registro para pbtener tu codigo:");
                //codigo para completar perfil
                Console.WriteLine("ingresa tu numero de telefono de celular:");
                contactNumber = Console.ReadLine();
                Console.WriteLine("ingresa tu ciudad de residencia:");
                city = Console.ReadLine();
                Console.WriteLine("ingresa tu perfil de facebook:");
                FBProfile = Console.ReadLine();
                Console.WriteLine("ingresa tu correo de email:");
                Email = Console.ReadLine();

                //solicitar credenciales 
                Console.WriteLine("ingresa tu nombre de usuario:");
                user = Console.ReadLine();
                Console.WriteLine("ingresa tu contraseña:");
                password = Console.ReadLine();
                Console.WriteLine("vuelve a ingresar tu contaseña:");
                passwordConfirm = Console.ReadLine();

                if (password == passwordConfirm)
                {

                    //numeros aleatorios
                    Random rnd = new Random(); // sirve para genenrar codigos random (aleatorio) 
                    codeAccess = rnd.Next(1000, 9999).ToString(); // sirve para genenerar codigos de del 1000 al 9999
                                                                  // y se guarda el numero de codeaccess ya convertido en .Tostring
                    Console.WriteLine("tu codigo de acceso es: {0}", codeAccess);


                }


            }
            else
            {
                Console.WriteLine("solo pueden entrar mayores de edad");
                
         
            }

            Console.WriteLine("saliendo de sistema.");
            Thread.Sleep(1000);
            Console.WriteLine("saliendo de sistema..");
            Thread.Sleep(1000);
            Console.WriteLine("saliendo de sistema...");
            Thread.Sleep(1000);
            Console.WriteLine("saliendo de  sistema.....");
            Thread.Sleep(1000);
        }
    }
}

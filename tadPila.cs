using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace pila
{
    class tadPila
    {
        public static void Main(string[] args)
        {
            Stack Pila = new Stack();
            int opcion=0;
            while (opcion!=3)
            {
                    opcion = menu();
                    switch (opcion)
                    {
                        case 1:
                            agregar(ref Pila);
                            break;
                        case 2:
                            eliminar(ref Pila);
                            break;
                        case 3:  break;
                    }
            }
        }

        public static void agregar(ref Stack pila)
        {
            Console.WriteLine("Ingrese una valor a la pila");
            int valor = Convert.ToInt32(Console.ReadLine());

            pila.Push(valor);
            

        }
        
        public static void eliminar(ref Stack pila)
        {
            
            int valor = Convert.ToInt32(Console.ReadLine());
            pila.Clear();
            
        }

        
        static int menu()
        {
            
            Console.WriteLine("======Menú Principal======\n");
            Console.WriteLine(" 1.- Ingresar");
            Console.WriteLine(" 2.- Eliminar");
            Console.WriteLine(" 3.- Salir");
            try
            {
                int valor = Convert.ToInt32(Console.ReadLine());
                return valor;
            }
            catch
            {
                return 0;
            }
        }
    }
}

    
 
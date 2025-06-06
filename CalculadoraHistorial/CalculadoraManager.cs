using EspacioCalculadora;

namespace ManejoDeOperaciones
{
    public class CalculadoraManager
    {
        public void Iniciar()
        {
            bool seguir = true;

            Console.Write("Ingrese un número inicial: ");
            double.TryParse(Console.ReadLine(), out double num);
            Calculadora miCalculadora = new Calculadora(num);

            while (seguir)
            {
                string operacion = ElegirOperacion();

                switch (operacion)
                {
                    case "1":
                        miCalculadora.Sumar(PedirNumero());
                        break;
                    case "2":
                        miCalculadora.Restar(PedirNumero());
                        break;
                    case "3":
                        miCalculadora.Multiplicar(PedirNumero());
                        break;
                    case "4":
                        miCalculadora.Dividir(PedirNumero());
                        break;
                    case "5":
                        miCalculadora.Limpiar();
                        Console.WriteLine("\n✅ Calculadora reiniciada. Se le pedirá un nuevo valor inicial");
                        double nuevoInicio = PedirNumero();
                        miCalculadora = new Calculadora(nuevoInicio);
                        break;
                    case "6":
                        miCalculadora.MostrarHistorial();
                        break;
                    case "7":
                        Console.WriteLine("👋 Saliendo de la calculadora.");
                        seguir = false;
                        break;
                    default:
                        Console.WriteLine("Opción inválida");
                        break;
                }

                Console.WriteLine($"\nResultado actual: {miCalculadora.GetResultado()}");
            }
        }

        private string ElegirOperacion()
        {
            Console.WriteLine("\n----------- OPERACIONES -----------");
            Console.WriteLine("1 - Sumar");
            Console.WriteLine("2 - Restar");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            Console.WriteLine("5 - Limpiar calculadora");
            Console.WriteLine("6 - Ver historial de operaciones");
            Console.WriteLine("7 - Salir");

            Console.WriteLine("Elegir una opción: ");
            return Console.ReadLine();
        }

        private double PedirNumero()
        {
            Console.Write("Ingrese un valor: ");
            if (double.TryParse(Console.ReadLine(), out double numero))
            {
                return numero;
            }
            else
            {
                Console.WriteLine("Entrada inválida. Se usará 0.");
                return 0;
            }
        }
    }
}
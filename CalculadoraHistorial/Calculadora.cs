using Operaciones;

namespace EspacioCalculadora
{
    public class Calculadora
    {
        private List<Operacion> historial = new List<Operacion>();
        private double dato;

        // Objeto Constructor, cuando creo la clase en new, el valor que mando se manda aca, sino le mando un parametro lo igualo a 0.
        public Calculadora(double dato)
        {
            this.dato = dato;
            historial = new List<Operacion>();
        }

        private void AplicarOperacion(double termino, TipoOperacion tipo)
        {
            Operacion op = new Operacion();
            op.Resultado = dato;
            op.NuevoValor = termino;
            op.OperacionElegida = tipo;
            historial.Add(op); // historial es una lista de objetos de tipo Operacion


            switch (tipo)
            {
                case TipoOperacion.Suma:
                    dato += termino;
                    break;
                case TipoOperacion.Resta:
                    dato -= termino;
                    break;
                case TipoOperacion.Multiplicacion:
                    dato *= termino;
                    break;
                case TipoOperacion.Division:
                    if (termino == 0)
                        Console.WriteLine("No se puede dividir entre 0");
                    else
                        dato /= termino;
                    break;
            }
        }

        public void Sumar(double termino)
        {
            AplicarOperacion(termino, TipoOperacion.Suma);

        }

        public void Restar(double termino)
        {
            AplicarOperacion(termino, TipoOperacion.Resta);
        }

        public void Multiplicar(double termino)
        {
            AplicarOperacion(termino, TipoOperacion.Multiplicacion);
        }

        public void Dividir(double termino)
        {
            AplicarOperacion(termino, TipoOperacion.Division);
        }

        public void Limpiar()
        {
            dato = 0;
            Operacion op = new Operacion();
            op.Resultado = dato;
            op.NuevoValor = 0;
            op.OperacionElegida = TipoOperacion.Limpiar;
            historial.Add(op);
        }

        public double GetResultado()
        {
            return dato;
        }

        public void MostrarHistorial()
        {
            if (historial.Count == 0)
            {
                Console.WriteLine("\nNo hay operaciones en el historial.");
                return;
            }

            Console.WriteLine("\n====== Historial de operaciones ======");
            foreach (var op in historial)
            {
                string simbolo = "";
                double resultadoFinal = 0;

                switch (op.OperacionElegida)
                {
                    case TipoOperacion.Suma:
                        simbolo = "+";
                        resultadoFinal = op.Resultado + op.NuevoValor;
                        break;

                    case TipoOperacion.Resta:
                        simbolo = "-";
                        resultadoFinal = op.Resultado - op.NuevoValor;
                        break;

                    case TipoOperacion.Multiplicacion:
                        simbolo = "*";
                        resultadoFinal = op.Resultado * op.NuevoValor;
                        break;

                    case TipoOperacion.Division:
                        simbolo = "/";
                        resultadoFinal = op.NuevoValor != 0 ? op.Resultado / op.NuevoValor : 0;
                        break;

                    case TipoOperacion.Limpiar:
                        simbolo = "LIMPIAR";
                        break;

                    default:
                        simbolo = "?";
                        break;
                }

                if (op.OperacionElegida == TipoOperacion.Limpiar)
                {
                    Console.WriteLine("Se limpió la calculadora.");
                }
                else
                {
                    Console.WriteLine($"{op.Resultado} {simbolo} {op.NuevoValor} = {resultadoFinal}");
                }
            }
        }

    }
}


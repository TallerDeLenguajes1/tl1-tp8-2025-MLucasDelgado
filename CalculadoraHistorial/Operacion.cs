namespace Operaciones
{
    public enum TipoOperacion
    {
        Suma,
        Resta,
        Multiplicacion,
        Division,
        Limpiar // Representa la acción de borrar el resultado actual o el historial
    }

    public class Operacion
    {
        private double resultadoAnterior; // Almacena el resultado previo al cálculo actual
        private double nuevoValor; //El valor con el que se opera sobre el resultadoAnterior
        private TipoOperacion operacion;// El tipo de operación realizada


        public double Resultado { get => resultadoAnterior; set => resultadoAnterior = value; }

        public double NuevoValor { get => nuevoValor; set => nuevoValor = value; }

        public TipoOperacion OperacionElegida { get => operacion; set => operacion = value; }
    }
    
}


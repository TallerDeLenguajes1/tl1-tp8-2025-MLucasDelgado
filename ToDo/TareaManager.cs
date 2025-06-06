using Tareas;

namespace ManejoTareas
{
    public class TareaManager
    {
        private List<Tarea> tareasPendientes = new List<Tarea>();
        private List<Tarea> tareasRealizadas = new List<Tarea>();
        private int proximoID = 1;

        public void CrearTareas()
        {
            Console.Write("¿Cuántas tareas desea ingresar?: ");
            int cantidadTareas = int.Parse(Console.ReadLine());

            for (int i = 0; i < cantidadTareas; i++)
            {
                Tarea nuevaTarea = new Tarea();
                Console.WriteLine($"\nTarea N° {i + 1}");
                nuevaTarea.TareaID = proximoID++;

                Console.Write("Ingrese la descripción de la tarea: ");
                nuevaTarea.Description = Console.ReadLine().ToLower();

                Console.Write("Ingrese la duración de la tarea: ");
                nuevaTarea.Duracion = int.Parse(Console.ReadLine());

                while (nuevaTarea.Duracion < 10 || nuevaTarea.Duracion > 100)
                {
                    Console.Write("La duracion de la tarea debe estar entre un valor de 10 y 100. Ingrese de nuevo: ");
                    nuevaTarea.Duracion = int.Parse(Console.ReadLine());
                }

                tareasPendientes.Add(nuevaTarea);
                Console.WriteLine("-----------------------");
            }
        }

        public void MoverTareasRealizadas()
        {
            for (int i = 0; i < tareasPendientes.Count; i++)
            {
                var tarea = tareasPendientes[i];
                Console.WriteLine($"\nID: {tarea.TareaID}, Descripción: {tarea.Description}, Duración: {tarea.Duracion}");
                Console.Write("\n¿Desea marcar esta tarea como realizada? (s/n): ");
                char opcionElegida = Convert.ToChar(Console.ReadLine());

                if (opcionElegida == 's' || opcionElegida == 'S')
                {
                    tareasRealizadas.Insert(0, tarea);
                    tareasPendientes.RemoveAt(i);
                    i--;
                }
            }
        }

        public void BuscarTareaPendiente()
        {
            Console.Write("\nIngrese una descripción para buscar la tarea: ");
            string descripcionIngresada = Console.ReadLine().ToLower();
            // FindAll nos devuelve todas las tareas que coincidan con esa descripcion, dos da una lista.
            List<Tarea> tareaBuscada = tareasPendientes.FindAll((t) => t.Description.Contains(descripcionIngresada));

            if (tareaBuscada.Count > 0)
            {
                Console.WriteLine($"\nSe encontró {tareaBuscada.Count} tarea(s) con esa descripción:");
                foreach (var tarea in tareaBuscada)
                {
                    Console.WriteLine($"\nID: {tarea.TareaID}, Descripción: {tarea.Description}, Duración: {tarea.Duracion}");
                }
            }
            else
            {
                Console.WriteLine("No se encontró ninguna tarea con esa descripción.");
            }
        }

        public void MostrarTodasLasTareas()
        {
            Console.WriteLine("\n---------- Tareas Realizadas ----------\n");
            foreach (var tarea in tareasRealizadas)
            {
                Console.WriteLine($"ID: {tarea.TareaID}, Descripción: {tarea.Description}, Duración: {tarea.Duracion}");
            }

            Console.WriteLine("\n---------- Tareas Pendientes ----------\n");
            foreach (var tarea in tareasPendientes)
            {
                Console.WriteLine($"ID: {tarea.TareaID}, Descripción: {tarea.Description}, Duración: {tarea.Duracion}");
            }
        }

        public void EjecutarMenu()
        {
            bool seguir = true;
            while (seguir != false)
            {
                Console.WriteLine("\n==== MENÚ PRINCIPAL ====");
                Console.WriteLine("1 - Crear Tarea.");
                Console.WriteLine("2 - Marcar tarea como realizada.");
                Console.WriteLine("3 - Buscar una tarea por descripción.");
                Console.WriteLine("4 - Mostrar todas las tareas.");
                Console.WriteLine("5 - Salir.");
                Console.Write("Seleccion una opción válida: ");

                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        CrearTareas();
                        break;
                    case 2:
                        MoverTareasRealizadas();
                        break;
                    case 3:
                        BuscarTareaPendiente();
                        break;
                    case 4:
                        MostrarTodasLasTareas();
                        break;
                    case 5:
                        Console.WriteLine("¡Gracias por usar el gestor de tareas!");
                        seguir = false;
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Vuelva a elegir.");
                        break;
                }
            }
        }
    }
}



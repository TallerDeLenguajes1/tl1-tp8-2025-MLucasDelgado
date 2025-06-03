using System;
using System.Collections.Generic;
using Tareas;

    List<Tarea>tareasPendientes = new List<Tarea>();
    List<Tarea>tareasRealizadas = new List<Tarea>();

    Random rnd = new Random();
    int numeroAleatorio = rnd.Next(1, 10); // Numero aleatorio entre 1 y 9 

    for(int i = 0; i < numeroAleatorio; i++) {
        Tarea nuevaTarea = new Tarea();
        Console.WriteLine($"\nTarea N° {i + 1}");
        nuevaTarea.TareaID = i + 1;

        Console.Write("Ingrese la descripción de la tarea: ");
        nuevaTarea.Description = Console.ReadLine();

        Console.Write("Ingrese la duración de la tarea: ");
        nuevaTarea.Duracion = int.Parse(Console.ReadLine());

        while(nuevaTarea.Duracion < 10 || nuevaTarea.Duracion > 100) {
            Console.Write("La duracion de la tarea debe estar entre un valor de 10 y 100. Ingrese de nuevo: ");
            nuevaTarea.Duracion = int.Parse(Console.ReadLine());
        }

        tareasPendientes.Add(nuevaTarea);
        Console.WriteLine("-----------------------");
    }
    
    for(int i = 0; i < tareasPendientes.Count; i++) {
        var tarea = tareasPendientes[i];
        Console.WriteLine($"\nID: {tarea.TareaID}, Descripción: {tarea.Description}, Duración: {tarea.Duracion}");
        Console.Write("\n¿Desea marcar esta tarea como realizada? (s/n): ");
        char opcionElegida = Convert.ToChar(Console.ReadLine());

        if(opcionElegida == 's') {
            tareasRealizadas.Insert(0, tarea);
            tareasPendientes.RemoveAt(i);
            i--;
        }
    }

Console.WriteLine("\n---------- Tareas Realizadas ----------\n");
 foreach(var tarea in tareasRealizadas) {
    Console.WriteLine($"ID: {tarea.TareaID}, Descripción: {tarea.Description}, Duración: {tarea.Duracion}");
}

Console.WriteLine("\n---------- Tareas Pendientes ----------\n");
 foreach(var tarea in tareasRealizadas) {
    Console.WriteLine($"ID: {tarea.TareaID}, Descripción: {tarea.Description}, Duración: {tarea.Duracion}");
}
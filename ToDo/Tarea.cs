namespace Tareas {
    public class Tarea
    {
        public int TareaID;
        public string Description { get; set; }
        public int Duracion { get; set; }
    
    public int IDTarea { get => TareaID; set => TareaID = value; } // otra forma de hacerlo
}
}
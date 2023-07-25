namespace Personajes {

    public class Personaje {

        // Atributos

        //  - Datos

        private string? tipo;
        private string? nombre;
        private string? apellido;
        private DateTime fechaNacimiento;
        private int edad;   // 0 - 300

        //  - Características

        private int velocidad;  // 1 - 10
        private int destreza;   // 1 - 5
        private int fuerza; // 1 - 10
        private int nivel;  // 1 - 10
        private int armadura;   // 1 - 10
        private int salud;  // 100

        // Encapsulamiento - propiedades

        public string? Tipo { get => tipo; set => tipo = value; }
        public string? Nombre { get => nombre; set => nombre = value; }
        public string? Apellido { get => apellido; set => apellido = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public int Edad { get => edad; set => edad = value; }
        public int Velocidad { get => velocidad; set => velocidad = value; }
        public int Destreza { get => destreza; set => destreza = value; }
        public int Fuerza { get => fuerza; set => fuerza = value; }
        public int Nivel { get => nivel; set => nivel = value; }
        public int Armadura { get => armadura; set => armadura = value; }
        public int Salud { get => salud; set => salud = value; }
        
    }

}


namespace Personajes {

    public class Personaje {

        // CARACTERISTICAS

        private int velocidad; // 1 - 10
        private int destreza; // 1 - 5
        private int fuerza; // 1 - 10
        private int nivel; // 1 - 10
        private int armadura; // 1 - 10
        private int salud; // 100

        // DATOS

        private string? tipo;
        private string? nombre;
        private string? apodo;
        private DateTime fecha_nacimiento;
        private int edad; // 0 - 300

        // ENCAPSULAMIENTO

        public int Velocidad { get => velocidad; set => velocidad = value; }
        public int Destreza { get => destreza; set => destreza = value; }
        public int Fuerza { get => fuerza; set => fuerza = value; }
        public int Nivel { get => nivel; set => nivel = value; }
        public int Armadura { get => armadura; set => armadura = value; }
        public int Salud { get => salud; set => salud = value; }
        public string? Tipo { get => tipo; set => tipo = value; }
        public string? Nombre { get => nombre; set => nombre = value; }
        public string? Apodo { get => apodo; set => apodo = value; }
        public DateTime Fecha_Nacimiento { get => fecha_nacimiento; set => fecha_nacimiento = value; }
        public int Edad { get => edad; set => edad = value; }


    }

    public class FabricaDePersonajes {

        string[] tipos = {"Tipo1", "Tipo2", "Tipo3"};

        string[] nombres = {"JuanFrancisco23", "Pepe900", "Destructor de mundos", "Ututo3400", "Némesis"};

        int aleatorio(int inicio, int fin) {        // Función para generar números aleatorios

            Random random = new Random();

            int randomNumber = random.Next(inicio, fin);

            return randomNumber;

        }

        DateTime fechas() {

            int dia = aleatorio(1,32);
            int mes = aleatorio(1,13);
            int year = aleatorio(1900, 2101);

            DateTime fecha = new DateTime(year,mes,dia );

            return fecha;

        }

        public Personaje CrearPersonaje(){

            Personaje personajeX = new Personaje();     // Nueva instancia

            personajeX.Tipo = tipos[aleatorio(0, 3)];
            personajeX.Nombre = nombres[aleatorio(0, 5)];
            Console.Write(" > Ingrese el apodo del personaje: ");
            personajeX.Apodo = Console.ReadLine();
            personajeX.Fecha_Nacimiento = fechas();
            int fechaActual = DateTime.Now.Year;
            personajeX.Edad = fechaActual - personajeX.Fecha_Nacimiento.Year;
            personajeX.Velocidad = aleatorio(1, 11);
            personajeX.Destreza = aleatorio(1, 6);
            personajeX.Fuerza = aleatorio(1, 11);
            personajeX.Nivel = aleatorio(1, 11);
            personajeX.Armadura = aleatorio(1, 11);
            personajeX.Salud = 100;

            return personajeX;

        }

    }

    public class PersonajesJson {

        public void GuardarPersonajes(List<Personaje> listaPersonajes, string? file) {

            

        }

        public void 

    }

}
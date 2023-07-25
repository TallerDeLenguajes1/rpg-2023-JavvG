namespace Personajes {

    public class Personaje {

        // Atributos

        //  -- Datos

        private string? tipo;
        private string? nombre;
        private string? apodo;
        private DateTime fechaNacimiento;
        private int edad;   // 0 - 300

        //  -- Características

        private int velocidad;  // 1 - 10
        private int destreza;   // 1 - 5
        private int fuerza; // 1 - 10
        private int nivel;  // 1 - 10
        private int armadura;   // 1 - 10
        private int salud;  // 100

        // Encapsulamiento - propiedades

        public string? Tipo { get => tipo; set => tipo = value; }
        public string? Nombre { get => nombre; set => nombre = value; }
        public string? Apodo { get => apodo; set => apodo = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public int Edad { get => edad; set => edad = value; }
        public int Velocidad { get => velocidad; set => velocidad = value; }
        public int Destreza { get => destreza; set => destreza = value; }
        public int Fuerza { get => fuerza; set => fuerza = value; }
        public int Nivel { get => nivel; set => nivel = value; }
        public int Armadura { get => armadura; set => armadura = value; }
        public int Salud { get => salud; set => salud = value; }
        
    }

    public class FabricaDePersonajes {

        Random random = new Random();

        private DateTime GenerarFechaAleatoria() {     // Función que genera una fecha aleatoria

            int año = random.Next((DateTime.Now.Year - 300),(DateTime.Now.Year + 1));
            int mes = random.Next(1,13);
            int dia = mes == 2 ? random.Next(1,29) : random.Next(1,31);
            
            DateTime fecha = new DateTime(año, mes, dia);

            return fecha;

        }

        private string[] tipos = {"Autobot", "Decepticon"};
        private string[] nombresAutobots = {"Optimus Prime", "Bumblebee", "Arcee", "Ratchet", "Jazz", "Ironhide", "Wheeljack", "Prowl", "Hound", "Blaster", "Cliffjumper", "Hot Rod", "Mirage", "Stratosphere", "Jetfire"};
        private string[] nombresDecepticons = {"Megatron", "Starscream", "Barricade", "Shockwave","Devastator", "Soundwave", "Blackout", "Bonecrusher", "Scorponok", "Ravage", "Galvatron", "Scourge", "Onslaught", "Blitzwing", "Thundercracker"};

        private string ElegirNombreNoUsado(string[] listadoNombres, List<string> nombresUsados) {

            string nombreElegido = listadoNombres[random.Next(0, listadoNombres.Length)];

            while(nombresUsados.Contains(nombreElegido)) {
                nombreElegido = listadoNombres[random.Next(0, listadoNombres.Length)];
            }

            nombresUsados.Add(nombreElegido);

            return nombreElegido;

        }

        public Personaje CrearPersonaje() {     // Método que retorna un personaje con sus datos y características

            Personaje character = new Personaje();

            List<string> listaNombresUsados = new List<string>();

            // Carga de datos

            character.Tipo = tipos[random.Next(0,2)];

            character.Nombre = character.Tipo == "Autobot" ? ElegirNombreNoUsado(nombresAutobots, listaNombresUsados) : ElegirNombreNoUsado(nombresDecepticons, listaNombresUsados);

            Console.Write(" Ingresá el apodo de tu personaje: ");
            character.Apodo = Console.ReadLine();

            while(String.IsNullOrEmpty(character.Apodo)) {
                Console.Write(" (!) No ingresaste el apodo: ");
                character.Apodo = Console.ReadLine();
            }

            character.FechaNacimiento = GenerarFechaAleatoria();
            character.Edad = DateTime.Now.Year - character.FechaNacimiento.Year;

            // Carga de características

            character.Velocidad = random.Next(1,11);
            character.Destreza = random.Next(1,6);
            character.Fuerza = random.Next(1,11);
            character.Nivel = random.Next(1,11);
            character.Armadura = random.Next(1,11);
            character.Salud = 100;

            return character;

        }

    }

}
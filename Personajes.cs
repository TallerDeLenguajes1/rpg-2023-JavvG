using System.Text.Json;

namespace EspacioPersonajes {

    public class Personaje {

        // Atributos

        //  -- Datos

        private string? tipo;
        private string? nombre;
        private string? apodo;
        private string? modoAlterno;
        private DateTime fechaNacimiento;
        private int edad;   // 0 - 300

        //  -- Características

        private int velocidad;  // 1 - 10
        private int destreza;   // 1 - 5
        private int fuerza; // 1 - 10
        private int nivel;  // 1 - 10
        private int armadura;   // 1 - 10
        private int salud;  // 100

        // Propiedades de datos

        public string? Tipo { get => tipo; set => tipo = value; }
        public string? Nombre { get => nombre; set => nombre = value; }
        public string? Apodo { get => apodo; set => apodo = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string? ModoAlterno { get => modoAlterno; set => modoAlterno = value; }

        // Propiedades de características

        public int Edad { get => edad; set => edad = value; }
        public int Velocidad { get => velocidad; set => velocidad = value; }
        public int Destreza { get => destreza; set => destreza = value; }
        public int Fuerza { get => fuerza; set => fuerza = value; }
        public int Nivel { get => nivel; set => nivel = value; }
        public int Armadura { get => armadura; set => armadura = value; }
        public int Salud { get => salud; set => salud = value; }
        
        public void MostrarPersonaje(){

            Console.WriteLine("                     ╔══ DATOS ═════════════════════════════════╗\n");
            Console.WriteLine($"                     ║   ⁕ Tipo: {tipo}");
            Console.WriteLine($"                     ║   ⁕ Nombre: {nombre}");
            Console.WriteLine($"                     ║   ⁕ Apodo: {apodo}");
            Console.WriteLine($"                     ║   ⁕ Modo alterno: {modoAlterno}");
            Console.WriteLine($"                     ║   ⁕ Fecha de llegada a la Tierra: {fechaNacimiento.Day}/{fechaNacimiento.Month}/{fechaNacimiento.Year}");
            Console.WriteLine($"                     ║   ⁕ Tiempo en la tierra: {edad} años \n");
            Console.WriteLine("                     ╚══════════════════════════════════════════╝");

            Console.WriteLine("                     ╔══ CARACTERÍSTICAS ═══════════════════════╗\n");
            Console.WriteLine($"                     ║   ⁕ Velocidad: {velocidad}");       // La velocidad no debe modificarse, se considera constante en el personaje
            Console.WriteLine($"                     ║   ⁕ Destreza: {destreza}");         // La destreza no debe modificarse, se considera constante en el personaje
            Console.WriteLine($"                     ║   ⁕ Fuerza: {fuerza}");        // La fuerza no debe modificarse, se considera constante en el personaje
            Console.WriteLine($"                     ║   ⁕ Nivel: {nivel}");
            Console.WriteLine($"                     ║   ⁕ Armadura: {armadura}");         // La armadura no debe modificarse, se considera constante en el personaje
            Console.WriteLine($"                     ║   ⁕ Salud: {salud}\n");
            Console.WriteLine("                     ╚══════════════════════════════════════════╝");
           
        }

        public void MejorarCaracteristicas() {        // Beneficia al competidor ganador del turno con una modificación en sus características

            salud += 10;
            nivel += 1;

        }
        
    }

    public class FabricaDePersonajes {

        Random random = new Random();       // Se crea la instancia para poder generar valores enteros aleatorios

        private DateTime GenerarFechaAleatoria() {     // Función que genera una fecha aleatoria

            int año = random.Next((DateTime.Now.Year - 300),(DateTime.Now.Year + 1));
            int mes = random.Next(1,13);
            int dia = mes == 2 ? random.Next(1,29) : random.Next(1,31);
            
            DateTime fecha = new DateTime(año, mes, dia);

            return fecha;

        }

        private string[] tipos = {"Autobot", "Decepticon"};

        private string[] nombresAutobots = {
            "Optimus Prime", 
            "Bumblebee", 
            "Arcee", 
            "Ratchet", 
            "Jazz", 
            "Ironhide", 
            "Wheeljack", 
            "Crosshairs", 
            "Hound", 
            "Blaster", 
            "Cliffjumper", 
            "Hot Rod", 
            "Mirage",
            "Stratosphere", 
            "Jetfire"
        };

        private string[] modosAlternosAutobots = {
            "Western Star 4900 Custom",
            "Chevrolet Camaro SS",
            "Harley-Davidson XR1200",
            "GMC Topkick C4500",
            "GMC Topkick",
            "Hummer H2",
            "Pontiac Solstice GXP",
            "Chevrolet Corvette C7 Stingray",
            "Oshkosh Medium Tactical Vehicle (MTTV) 8x8",
            "Bugatti Veyron Grand Sport Vitesse",
            "Lamborghini Centenario LP770-4",
            "Bugatti Veyron Grand Sport Vitesse",
            "Subaru Impreza WRX STi",
            "Lockheed Martin F-35 Lightning II",
            "Lockheed Martin F-22 Raptor"
        };

        private string[] nombresDecepticons = {
            "Megatron", 
            "Starscream", 
            "Barricade", 
            "Shockwave",
            "Devastator", 
            "Soundwave", 
            "Blackout", 
            "Bonecrusher", 
            "Scorponok", 
            "Ravage", 
            "Galvatron", 
            "Scourge", 
            "Onslaught", 
            "Blitzwing", 
            "Thundercracker"
        };

        private string[] modosAlternosDecepticons = {
            "Mack Titan ",
            "Lockheed Martin F-22 Raptor",
            "Saleen S281 E Police Car",
            "Sikorsky MH-53 Pave Low",
            "Caterpillar 992G Front-end Loader",
            "Mercedes-Benz SLS AMG Satellite",
            "Sikorsky MH-53 Pave Low",
            "Buffalo Mine Protected Clearance Vehicle",
            "Sikorsky UH-60 Black Hawk",
            "Condor II UAV",
            "Freightliner Century Class Truck",
            "Junkion Motorcycle",
            "AK-47 Assault Rifle (Hightower)",
            "McDonnell Douglas F/A-18 Hornet",
            "Lockheed Martin F-22 Raptor"
        };



        private string[] apodosAutobots = {
            "\"El líder de los Autobots\"",
            "\"El soldado más valiente\"",
            "\"La valiente guerrera\"",
            "\"El médico experto\"",
            "\"El alma musical\"",
            "\"El protector veterano\"",
            "\"El genio inventor\"",
            "\"El francotirador\"",
            "\"El rastreador experto\"",
            "\"El amante de la música\"",
            "\"El pequeño valiente\"",
            "\"El corredor ardiente\"",
            "\"El ilusionista\"",
            "\"El gigante del cielo\"",
            "\"El defensor del cielo\""
        };

        private string[] apodosDecepticons = {
            "\"El líder de los Decepticons\"",
            "\"El traidor ambicioso\"",
            "\"El despiadado\"",
            "\"El científico malévolo\"",
            "\"El destructor masivo\"",
            "\"El maestro de la comunicación\"",
            "\"La sombra silenciosa\"",
            "\"El triturador de huesos\"",
            "\"El escorpión mortal\"",
            "\"El depredador sigiloso\"",
            "\"La reencarnación oscura\"",
            "\"El guerrero implacable\"",
            "\"El estratega poderoso\"",
            "\"El trueno temible\""
        };

        public Personaje CrearPersonaje(int tipoPersonaje) {     // Método que retorna un personaje con sus datos y características

            Personaje character = new Personaje();

            // Selección del nombre del personaje (no repetidos)

            List<int> indicesUsados = new List<int>();

            int indice = random.Next(0, nombresAutobots.Length);

            if(indicesUsados != null) {
                    
                while(indicesUsados.Contains(indice)) {
                    indicesUsados.Add(indice);
                    indice = random.Next(0, nombresAutobots.Length);
                }

            }

            // Carga de datos

            character.Tipo = tipos[tipoPersonaje];
            character.Nombre = character.Tipo == "Autobot" ? nombresAutobots[indice] : nombresDecepticons[indice];
            character.Apodo = character.Tipo == "Autobot" ? apodosAutobots[indice] : apodosDecepticons[indice];
            character.ModoAlterno = character.Tipo == "Autobot" ? modosAlternosAutobots[indice] : modosAlternosDecepticons[indice];
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

    public class PersonajesJson {

        // Guarda una lista de personajes en un archivo de extensión JSON

        public void GuardarPersonajes(List<Personaje> listaPersonajes, string filename) {

            string json = JsonSerializer.Serialize(listaPersonajes);

            File.WriteAllText(filename, json);

        }

        // Lee y guarda en una lista los personajes desde un archivo de extensión JSON

        public List<Personaje> LeerPersonajes(string filename) {

            string json = File.ReadAllText(filename);

            List<Personaje>? listaPersonajes = JsonSerializer.Deserialize<List<Personaje>>(json);

            if(listaPersonajes != null) {
                return listaPersonajes;
            }
            else {
                return new List<Personaje>();
            }

        }

        // Verifica si existe un archivo JSON, y si éste no está vacío

        public bool Existe(string filename) {

            if(File.Exists(filename)) {
                
                string datos = File.ReadAllText(filename);

                return !String.IsNullOrEmpty(datos);

            }
            else {
                return false;
            }

        }

    }

}
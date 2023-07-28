using EspacioPersonajes;
using GameplaySpace;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace InterfaceSpace {

    public class InterfazDelJuego {

        int cantidadDePersonajes = 4;

        Random random = new Random();

        string history = @"
                                           En un universo desgarrado por la contienda, los Autobots y Decepticons, 
                dos fuerzas rivales de robots con habilidades transformadoras sin igual, se enfrentan en una batalla épica por el control del poderoso Cetro, 
                                            una reliquia ancestral que otorga un poder inimaginable a su portador. 
                
                    Sin embargo, este objeto de inmenso poder ha sido oculto en la Tierra, protegido celosamente por los legendarios Caballeros de Cybertron.
        
                        La paz que alguna vez reinó en el planeta Cybertron fue devastada por la ambición desmedida de Megatron, líder de los Decepticons, 
                                        quien ansía el Cetro para obtener el dominio absoluto sobre todos los mundos. 
            Los Autobots, bajo el liderazgo de Optimus Prime, se alzan valientemente para proteger la galaxia y evitar que el malvado plan de los Decepticons se concrete.
                
                                            Vos te vas a sumergir en este conflicto como un intrépido comandante.
                El destino de la humanidad y del universo entero está en juego, y vos, como líder, vas a tener la misión de luchar con coraje y determinación 
                                        para asegurar un futuro en paz y desentrañar los misterios que rodean al Cetro.
                
                        La guerra por el Cetro te aguarda, y solo los más valientes y sabios podrán prevalecer en esta batalla sin cuartel.
                
                                ¡Que la chispa de la valentía y la sabiduría iluminen tu camino en esta emocionante aventura! 
                
                                        La Tierra es ahora el campo de batalla, y el Cetro aguarda su destino oculto.";

        

        public void MostrarBienvenida() {

            string asciiArt = @"
                                _______________________________________________________________________________________________

                                   ___________                              _____                                                               
                                   \__    ___/___________    ____   _______/ ____\___________  _____   ___________  ______                      
                                     |    |  \_  __ \__  \  /    \ /  ___/\   __\/  _ \_  __ \/     \_/ __ \_  __ \/  ___/                      
                                     |    |   |  | \// __ \|   |  \\___ \  |  | (  <_> )  | \/  Y Y  \  ___/|  | \/\___ \                       
                                     |____|   |__|  (____  /___|  /____  > |__|  \____/|__|  |__|_|  /\___  >__|  /____  >                      
                                                         \/     \/     \/                          \/     \/           \/                       
                                          ______                               _              _   _____      _             
                                          | ___ \                             | |            | | /  __ \    | |            
                                          | |_/ /_   _ ___  ___ __ _ _ __   __| | ___     ___| | | /  \/ ___| |_ _ __ ___  
                                          | ___ \ | | / __|/ __/ _` | '_ \ / _` |/ _ \   / _ \ | | |    / _ \ __| '__/ _ \ 
                                          | |_/ / |_| \__ \ (_| (_| | | | | (_| | (_) | |  __/ | | \__/\  __/ |_| | | (_) |
                                          \____/ \__,_|___/\___\__,_|_| |_|\__,_|\___/   \___|_|  \____/\___|\__|_|  \___/ 

                                ________________________________________________________________________________________________  
                                  ";

            Console.Clear();

            Console.WriteLine(asciiArt);

            foreach (char c in history) {       // Muestra el string caracter por caracter con una pausa entre estos. Tiempo total estimado: 40 segundos
                Console.Write(c);
                Thread.Sleep(10);       // Pausa entre cada carácter (en milisegundos)
            }

            Console.WriteLine("\n\n\n                                                                   » Presione ENTER para iniciar «");
            ConsoleKeyInfo teclaEnter;

            teclaEnter = Console.ReadKey();

            while(teclaEnter.Key != ConsoleKey.Enter) {     // Filtro de control para que el juego sólo avance cuando se presiona "ENTER"
                teclaEnter = Console.ReadKey();
            }
            Console.Clear();

            string[] welcomeMessage = {
                @"                     En un universo en guerra, dos facciones se enfrentan por el destino de la humanidad. Los Autobots luchan por la paz y la justicia, 
                                   mientras que los Decepticons ansían la dominación total. ¿Estás listo para liderar a tus valientes guerreros y enfrentar el desafío?",
                @"                          Un antiguo poder se oculta en la Tierra, protegido por los Caballeros de Cybertron. 
                                        Los Autobots y Decepticons se preparan para una batalla épica en la que solo el más valiente y astuto prevalecerá. 
                                                                        ¿Te animás a tomar el mando y guiarlos hacia la victoria?",
                @"                                       La leyenda del Cetro ha trascendido los confines del espacio. Ahora, en la Tierra, se desatará una lucha sin igual, 
                                            donde los Autobots y Decepticons se enfrentan en una batalla intergaláctica. ¿Estás preparado para convertirte en leyenda?",
                @"                                       El Cetro, fuente de poder inimaginable, está resguardado en la Tierra por los Caballeros de Cybertron. 
                                Los Autobots y Decepticons se enfrentan en una batalla épica por su posesión. Tu destino está en tus manos. ¿Qué camino elegirás?",
                @"                    Los Autobots y Decepticons se preparan para una confrontación decisiva. El Cetro, símbolo de un antiguo legado, espera ser descubierto. 
                                                                                        ¡Que comience la batalla!",
                @"                                       En las sombras de la Tierra, la guerra de los Autobots y Decepticons está por desatarse. 
                                                        El Cetro, poderoso y misterioso, aguarda su destino. ¿Listo para la batalla?"
            };

            Console.Write("\n\n\n " + welcomeMessage[random.Next(0, welcomeMessage.Length)]);

            Thread.Sleep(5000);     // Pausa de 1 segundo

            Console.Clear();

        }

        public void MenuOpciones(List<Personaje> listaDePersonajes) {

            // Diseño de un menú de opciones
            
            ConsoleKeyInfo tecla = new ConsoleKeyInfo('A', ConsoleKey.A, false, false, false);        // Describe la tecla de la consola que fue presionada, incluyendo el carácter representado por la tecla de la consola (los tres parámetros booleanos corresponden a los estados de las teclas modificadoras SHIFT, ALT y CTRL)
            
            int option = 1, output = 0;

            int flag = 1;
            
            while(output != 3 && flag == 1) {

                Console.WriteLine("\n\n\n\n\n\n");
                Console.WriteLine("                                              ╔═════════════════════════════════╗");
                Console.WriteLine("                                              ║                                 ║");
                Console.WriteLine("                                              ║         ╔════════════╗          ║");
                Console.WriteLine("                                              ║         ║    MENU    ║          ║");
                Console.WriteLine("                                              ║         ╚════════════╝          ║");
                Console.WriteLine("                                              ║     ┌─────────────────────┐     ║");

                if (option == 1) {
                    Console.WriteLine("                                              ║     ►        JUGAR        ◄     ║");
                }
                else {
                    Console.WriteLine("                                              ║     |        Jugar        |     ║");
                }
                Console.WriteLine("                                              ║     ├─────────────────────┤     ║");

                if (option == 2) {
                    Console.WriteLine("                                              ║     ►     PERSONAJES      ◄     ║");
                }
                else {
                    Console.WriteLine("                                              ║     |     Personajes      |     ║");
                }
                
                Console.WriteLine("                                              ║     ├─────────────────────┤     ║");

                if (option == 3) {
                    Console.WriteLine("                                              ║     ►        SALIR        ◄     ║");
                }
                else {
                    Console.WriteLine("                                              ║     |        Salir        |     ║");
                }

                Console.WriteLine("                                              ║     ├─────────────────────┤     ║");
                Console.WriteLine("                                              ║                                 ║");
                Console.WriteLine("                                              ╚═════════════════════════════════╝");


                tecla = Console.ReadKey();      // Se lee una tecla

                Console.Clear();

                if(tecla.Key == ConsoleKey.Enter) {     // Si se presionó "ENTER"

                    switch (option) {

                        case 1:

                            Console.Clear();
                            Start(listaDePersonajes);
                            flag = 0;

                        break;

                        case 2:
                            Console.Clear();
                            MostrarListaDePersonajes(listaDePersonajes);
                        break;

                        case 3:
                            Console.Clear();
                            output = 3;
                        break;

                    }

                    Console.Clear();
                    
                } else if(tecla.Key == ConsoleKey.DownArrow) {      //Si se presionó la tecla de dirección hacia abajo

                    option++;

                } else if(tecla.Key == ConsoleKey.UpArrow) {        //Si se presionó la tecla de dirección hacia arriba

                    option--;

                }

                if(option<1) {      //Controla la repetición de la pulsación de tecla de dirección hacia arriba

                    option = 1;

                } else if(option>3) {       //Controla la repetición de la pulsación de tecla de dirección hacia abajo

                    option = 3;

                }

                Console.Clear();

            };

        }

        public void MostrarMensajeJuegoTerminado() {

            string mensajeFinal = @"
                                                           ____.                                                 
                                                          |    |__ __   ____   ____   ____                       
                                                          |    |  |  \_/ __ \ / ___\ /  _ \                      
                                                      /\__|    |  |  /\  ___// /_/  >  <_> )                     
                                                      \________|____/  \___  >___  / \____/                      
                                                                           \/_____/                              
                                                    ___________                  .__                   .___      
                                                    \__    ___/__________  _____ |__| ____ _____     __| _/____  
                                                      |    |_/ __ \_  __ \/     \|  |/    \\__  \   / __ |/  _ \ 
                                                      |    |\  ___/|  | \/  Y Y  \  |   |  \/ __ \_/ /_/ (  <_> )
                                                      |____| \___  >__|  |__|_|  /__|___|  (____  /\____ |\____/ 
                                                                 \/            \/        \/     \/      \/       ";

            Console.Write(mensajeFinal);

        }

        public void MostrarPersonajeGanador(Personaje ganador) {

            Console.WriteLine("╔══════════════════════════════════════════╗");
            Console.WriteLine("║             ╔═════════════╗              ║");
            Console.WriteLine("║             ║   GANADOR   ║              ║");
            Console.WriteLine("║             ╚═════════════╝              ║");
            Console.WriteLine("╚══════════════════════════════════════════╝");
            Console.WriteLine("\n");
            ganador.MostrarPersonaje();

            Console.ReadLine();

        }

        public void MostrarListaDePersonajes(List<Personaje> listaDePersonajes) {
            
            Console.WriteLine("╔═════════════════════════════════════════════╗");
            Console.WriteLine("║             ╔════════════════╗              ║");
            Console.WriteLine("║             ║   PERSONAJES   ║              ║");
            Console.WriteLine("║             ╚════════════════╝              ║");
            Console.WriteLine("╚═════════════════════════════════════════════╝");

            int count = 1;

            foreach (var personaje in listaDePersonajes) {

                Console.Write($"\n\n PERSONAJE NRO. {count}\n");
                personaje.MostrarPersonaje();
                Console.Write("\n");
                count++;
                Console.ReadLine();         // Agrega una pausa para que el usuario pueda ver cada personaje antes de continuar

                Console.WriteLine("═══════════════════════════════════════════════");

            }

            Console.ReadLine();
        }

        public void Start(List<Personaje> listaDePersonajes) {

            Gameplay juego = new Gameplay();    // Se inicia una nueva instancia del juego

            juego.InicioDeJuego(listaDePersonajes);

        }

    }

}
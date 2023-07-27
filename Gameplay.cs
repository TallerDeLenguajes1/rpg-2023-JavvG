using EspacioPersonajes;

// En este archivo se establecen las directivas del juego, el modo de selección de los jugadores y el combate

public class Gameplay {

    // Métodos

    public void InicioDeJuego(List<Personaje> listaDePersonajes) {

        EleccionDeCompetidores(listaDePersonajes);

        listaDePersonajes.Clear();      // Elimina los personajes de la lista antes usada

    }

    public void EleccionDeCompetidores(List<Personaje> listaDePersonajes) {

        List<Personaje> autobots = new List<Personaje>();       // Se crean dos nuevas listas correspondientes a los bandos
        List<Personaje> decepticons = new List<Personaje>();

        foreach(var personaje in listaDePersonajes) {       // Se divide la lista de personajes en dos listas diferentes según su tipo (no se modifica la lista de personajes original)

           if (personaje.Tipo == "Autobot") {
                autobots.Add(personaje);
            } else {
                decepticons.Add(personaje);
            }

        }

        Random random = new Random();

        Personaje personaje1 = autobots[random.Next(0, autobots.Count)];        // Se elige un personaje aleatorio y se lo elimina de la lista (para evitar futuras repeticiones)
        autobots.Remove(personaje1);

        Personaje personaje2 = decepticons[random.Next(0, decepticons.Count)];      // Se elige un personaje aleatorio y se lo elimina de la lista (para evitar futuras repeticiones)
        decepticons.Remove(personaje2);

        // Avance del juego

        PresentacionDeCompetidores(personaje1, personaje2, autobots, decepticons);

    }

    

    public void PresentacionDeCompetidores(Personaje autobot, Personaje decepticon, List<Personaje> autobots, List<Personaje> decepticons) {

        // Frases basadas en el dialecto rioplatense del español

        string[] mensajesPresentacionAutobot = {
            "¡Acá viene un autobot de ley! Es {0}, conocido como {1}.",
            "{0} es el autobot que la rompe y está listo para la batalla. Su apodo es {1}.",
            "Mirá qué picante el autobot {0}, también conocido como {1}.",
            "¿Están listos? Porque acá viene el autobot {0}, más conocido como {1}.",
            "¡Se armó lío! Es {0}, {1}, y está listo para romperla.",
            "¡Dale que va! El autobot {0}, {1}, viene a dar pelea en la batalla.",
            "¡Aguanten los autobot! Llegó {0}, más conocido como {1}.",
            "¡Poné play! Es el autobot {0}, {1}, y está listo para la acción.",
            "¡Se armó la movida! Es {0}, también conocido como {1}, y viene a romperla en la batalla.",
            "¡Este autobot la pisa fuerte! {0}, el capo de la acción, mejor conocido como {1}.",
            "¡Ese autobot es puro flow! {0}, {1}, y llegó para ser el rey del campo de batalla.",
            "¡Atenti al autobot {0}! Es un genio del combate, apodado {1}.",
            "¿Listos para el reventón? Llega {0}, el autobot más duro, también conocido como {1}.",
            "¡Miren quién llegó! Es {0}, {1}, y viene a poner la fiesta en la batalla.",
            "¡El autobot más top del barrio! {0}, mejor conocido como {1}, está listo para arrasar.",
            "¡Atenti que se viene el autobot {0}! Conocido en el barrio como {1}, y va con todo.",
            "¡Ponele play al ritmo de {0}, conocido como {1}! ¡Este Autobot viene con todo el flow!",
            "¡Que tiemble el asfalto! Es {0}, también apodado {1}. ¡Prepárense para sentir la velocidad!",
            "¡Autobot en acción! {0}, el todoterreno, mejor conocido como {1} está listo para la batalla.",
            "¡Con ustedes, el intrépido {0}, más conocido como {1}. ¡Es un crack en el campo de batalla!",
            "¡Arranca la fiesta con {0}, apodado {1}. ¡La diversión está asegurada!"
        };

        string[] mensajesPresentacionDecepticon = {
            "¿Están preparados? ¡Acá viene un decepticon de miedo! Es {0}, conocido como {1}.",
            "¡Alto quilombo! Llega {0}, el decepticon que la descose, también conocido como {1}.",
            "¡Que se cuiden! El decepticon {0}, más conocido como {1}, está en la casa.",
            "¿Listos para lo peor? El decepticon {0}, apodado {1}, viene con todo.",
            "¡Aguanten los decepticon! Llegó {0}, el terror de la batalla, apodado {1}.",
            "¡Atenti! Es el decepticon {0}, {1}, y está dispuesto a hacer temblar el campo de batalla.",
            "¡Que se arme bardo! El decepticon {0}, también conocido como {1}, no viene a jugar.",
            "¡Al palo! Es el decepticon {0}, {1}, y viene con todo el poder destructivo.",
            "¡Este decepticon la rompe! {0}, más conocido como {1}, viene a hacer temblar todo.",
            "¿Listos para el descontrol? Llega {0}, el decepticon que la descose, también conocido como {1}.",
            "¡El rey de la maldad! Es {0}, {1}, y viene a sembrar el caos en la batalla.",
            "¿Preparados para el quilombo? {0}, el decepticon más pesado, apodado {1}.",
            "¡Este decepticon es pura potencia! {0}, también conocido como {1}, y viene con todo.",
            "¡Cuidado con el decepticon {0}! Es el as del mal, apodado {1}.",
            "¿Están listos para la noche de los decepticons? Llega {0}, {1}, y va a romperla.",
            "¡Atenti a este decepticon que viene con todo! {0}, más conocido como {1}, y está dispuesto a arrasar.",
            "¡Agárrense fuerte! Llegó {0}, el Decepticon que nunca falla, apodado {1}. ¡Prepárense para el caos!",
            "¡Atenti al temible {0}, más conocido como {1}. ¡Este Decepticon no tiene piedad!",
            "¡Que se preparen los rivales! Es el Decepticon {0}, también apodado {1}. ¡Es una máquina de destrucción!",
            "¡Con ustedes, el oscuro {0}, conocido como {1}. ¡Es el terror de los oponentes!",
            "¡Decepticon al acecho! {0}, el estratega poderoso, mejor conocido como {1}, está listo para el enfrentamiento."
        };

        // Diálogos de presentación de los personajes, basados en la película "Transformers: El Último Caballero" (2017)

        string[] frasesAutobots = {
            "La protección de El Cetro es nuestro deber sagrado. Como Autobot, no permitiré que caiga en manos equivocadas.",
            "Nuestra misión es clara: defender El Cetro a toda costa. Como Autobot, lo protegeré con mi vida.",
            "Ante la amenaza que se avecina, somos el escudo que protegerá El Cetro. Como Autobot, seré implacable en mi deber.",
            "La seguridad de El Cetro está en nuestras manos. Como Autobot, no dudaré en enfrentar cualquier peligro para mantenerlo a salvo.",
            "En esta lucha por El Cetro, solo conocemos una palabra: perseverancia. Como Autobot, no nos rendiremos ante la adversidad.",
            "El destino de la humanidad se juega con El Cetro en juego. Como Autobot, nos mantendremos firmes en nuestra defensa.",
            "El Cetro representa la esperanza de un futuro mejor. Como Autobot, defenderé ese futuro con todo mi ser.",
            "No hay margen para el error. Como Autobot, cumpliremos nuestra misión y protegeremos El Cetro a toda costa.",
            "El Cetro es el símbolo de la paz que debemos preservar. Como Autobot, lucharé sin descanso por esa paz.",
            "La confianza de la humanidad está depositada en nosotros. Como Autobot, no defraudaremos esa confianza y protegeremos El Cetro.",
            "Conozco la importancia de esta batalla por El Cetro, yo, como Autobot, no descansaré hasta asegurar nuestra victoria.",
            "La responsabilidad de defender El Cetro recae sobre mí, como Autobot, y no defraudaré a mi equipo.",
            "El honor y la lealtad son mis armas en esta lucha por El Cetro, y los defenderé con mi vida.",
            "La misión es clara: proteger El Cetro a toda costa. Como Autobot, no permitiré el fracaso.",
            "Como líder de los Autobots, guiaré a mi equipo hacia la victoria en esta peligrosa batalla.",
            "El destino nos ha llamado a defender El Cetro, y no dudaré en enfrentar cualquier adversidad.",
            "Mi compromiso con los Autobots y la protección de El Cetro es inquebrantable. Estamos listos.",
            "La paz y la justicia prevalecerán. Como Autobot, no permitiré que El Cetro caiga en malas manos.",
            "Esta batalla definirá nuestro futuro. Como Autobot, daré lo mejor de mí para asegurar nuestra victoria."
        };

        string[] frasesDecepticons = {
            "El Cetro es el poder que nos elevará sobre todos. No habrá compasión para aquellos que se interpongan en nuestro camino.",
            "La ambición de los Decepticons nos guiará hacia la conquista de El Cetro. No escatimaremos esfuerzos para obtenerlo.",
            "El Cetro es el instrumento que nos otorgará la supremacía. No habrá piedad para aquellos que desafíen nuestro dominio.",
            "La batalla por El Cetro será feroz y sin cuartel. Sembraremos el caos en nuestro camino hacia la victoria.",
            "El Cetro representa el poder absoluto que ansiamos. No dejaremos que nada se interponga entre nosotros y su posesión.",
            "El destino de los Decepticons está unido a El Cetro. Arrasaremos con todo obstáculo para obtenerlo.",
            "El Cetro es la llave que abrirá el camino hacia la grandeza. No habrá tregua en nuestra búsqueda por poseerlo.",
            "El poder de El Cetro nos hará invencibles. No habrá lugar para la duda o la debilidad en nuestra misión.",
            "En esta lucha por El Cetro, la crueldad será nuestra mejor arma. Sembraré el terror en nuestros enemigos.",
            "El Cetro es el legado que construiremos para la eternidad. No habrá límites en nuestra ambición por obtenerlo.",
            "La debilidad no tiene cabida en esta lucha por El Cetro. Seré implacable.",
            "El poder y la dominación son mi única meta en esta batalla por El Cetro. Nada me detendrá.",
            "El Cetro será nuestro, cueste lo que cueste. Y ningún obstáculo será insuperable.",
            "La ambición y la astucia son mis aliadas en esta búsqueda de El Cetro. No conoceré la derrota.",
            "No hay lugar para la compasión ni la misericordia en esta lucha por El Cetro. Seré despiadado.",
            "El dominio absoluto es nuestro destino. Como líder de los Decepticons, lo aseguraré sin vacilar.",
            "No descansaré hasta que El Cetro esté en nuestras manos. Los Decepticons prevalecerán.",
            "La victoria será nuestra, y el universo temblará ante nuestro poder. Así será.",
            "La conquista de El Cetro nos pertenece. Lo aseguraré con estrategia y fuerza bruta."
        };

        // Presentación de los competidores
        
        Random random = new Random();

        Console.WriteLine("\n\n ************************** ¡LOS DOS BANDOS ESTÁN LISTOS PARA LA BATALLA! ************************** \n");

        string mensaje1, mensaje2;

        // La presentación consiste en un mensaje nombrando al competidor (mensaje1), y un diálogo del personaje (mensaje2)

        Console.WriteLine("\n >>> BANDO AUTOBOT <<< \n");

        mensaje1 = mensajesPresentacionAutobot[random.Next(0, mensajesPresentacionAutobot.Length)];
        mensaje2 = frasesAutobots[random.Next(0, frasesAutobots.Length)];

        Console.WriteLine(mensaje1, autobot.Nombre, autobot.Apodo);

        if (autobot.Nombre == "Optimus Prime") {
            Console.WriteLine("Yo soy Optimus Prime, líder de los Autobots, y protegeré El Cetro a cualquier costo.");
        }
        else {
            Console.WriteLine($"\n\"{mensaje2}\"");
        }

        Console.WriteLine("\n >>> BANDO DECEPTICON <<< \n");

        mensaje1 = mensajesPresentacionDecepticon[random.Next(0, mensajesPresentacionDecepticon.Length)];
        mensaje2 = frasesDecepticons[random.Next(0, frasesDecepticons.Length)];

        Console.WriteLine(mensaje1, decepticon.Nombre, decepticon.Apodo);

        if (decepticon.Nombre == "Megatron") {
            Console.WriteLine("Yo soy Megatron, líder de los Decepticons, y obtendré El Cetro sin piedad ni remordimientos.");
        }
        else {
            Console.WriteLine($"\n\"{mensaje2}\"");
        }

        Console.ReadLine();

        // Avance del juego con la primera partida de combate entre competidores

        Combate(autobot, decepticon, autobots, decepticons);
        
    }

    public void Combate(Personaje autobot, Personaje decepticon, List<Personaje> autobots, List<Personaje> decepticons) {

        // Se inicia una partida de combate entre dos competidores

        Random random = new Random();

        bool turnoAutobot = true;       // Variable de control de turnos

        while(autobot.Salud > 0 && decepticon.Salud > 0) {      // El combate continúa hasta que alguno de los competidores pierda el total de su "Salud"

            Personaje atacante, defensor;       // Determinación de los roles según el turno

            if(turnoAutobot) {
                atacante = autobot;
                defensor = decepticon;
            }
            else {
                atacante = decepticon;
                defensor = autobot;
            }

            // Cálculo del daño provocado 

            int ataque = atacante.Destreza * atacante.Fuerza * atacante.Nivel;
            int efectividad = random.Next(1,101);
            int defensa = defensor.Armadura * defensor.Velocidad;

            int aux = (ataque * efectividad) - defensa;

            int constanteDeAjuste;

            if(aux <= 500) {
                constanteDeAjuste = 50;
            }
            else {
                constanteDeAjuste = 500;
            }

            int damage = Math.Max(aux / constanteDeAjuste, 0);    // Daño. Se usa "Math.Max(x,y)" para evitar que el número sea negativo

            defensor.Salud -= damage;       // Actualización de la salud del competidor defensor

            Console.ReadLine();

            // Se muestran los resultados del turno

            if (damage <= 0) {
                Console.WriteLine($"{atacante.Nombre} atacó a {defensor.Nombre}, pero el ataque no tuvo efecto.");
                Console.WriteLine($"{defensor.Nombre} continúa con {defensor.Salud} puntos de salud.");
            }
            else {
                
                if(defensor.Salud <= 0) {
                    Console.WriteLine($"{atacante.Nombre} atacó a {defensor.Nombre} y le causó {damage} puntos de daño, dejándolo fuera de esta batalla.");
                }
                else {
                    Console.WriteLine($"{atacante.Nombre} atacó a {defensor.Nombre} y le causó {damage} puntos de daño.");
                    Console.WriteLine($"{defensor.Nombre} tiene {defensor.Salud} puntos de salud restantes.");
                }

            }

            turnoAutobot = !turnoAutobot;       // Se invierte la variable de control de turnos (permite el avance del juego)

            Console.ReadLine();

        }

        // Presentación de los resultados finales, en caso de que alguno de los competidores haya perdido la partida. Se determina el competidor ganador de esta partida

        Personaje ganadorPartidaAnterior;       // Apunta a "null"

        if (autobot.Salud <= 0) {

            Console.WriteLine($"\n\n {autobot.Nombre} ha sido vencido y queda eliminado de la competencia.");
            autobot.MejorarCaracteristicas();
            Console.WriteLine($"{decepticon.Nombre} ha ganado la batalla y ha sido beneficiado con una mejora en sus habilidades.");

            ganadorPartidaAnterior = decepticon;

        }
        else {

            Console.WriteLine($"\n\n {decepticon.Nombre} ha sido vencido y queda eliminado de la competencia.");
            decepticon.MejorarCaracteristicas();
            Console.WriteLine($"{autobot.Nombre} ha ganado la batalla y ha sido beneficiado con una mejora en sus habilidades.");

            ganadorPartidaAnterior = autobot;

        }

        // Avance del juego con las demás partidas si es que quedan algunos competidores más en alguno de los bandos

        if (autobots.Count > 0 && decepticons.Count > 0) {

            if(ganadorPartidaAnterior.Tipo == "Autobot") {      // Ganó un Autobot, por lo que se usa al ganador anterior y se selecciona un Decepticon al azar

                autobot = ganadorPartidaAnterior;

                decepticon = decepticons[random.Next(0, decepticons.Count)];
                decepticons.Remove(decepticon);

            }
            else {      // Ganó un Decepticon, por lo que se selecciona un Autobot al azar y se usa al ganador anterior

                autobot = autobots[random.Next(0, autobots.Count)];
                autobots.Remove(autobot);

                decepticon = ganadorPartidaAnterior;

            }

            // Se inicia una nueva partida de combate, hasta que alguno de los bandos quede sin cometidores

            Console.WriteLine($"\n\n ----- ¡NUEVA BATALLA! ----- \n");

            PresentacionDeCompetidores(autobot, decepticon, autobots, decepticons);     // Este método también inicia el combate

        }
        else {

            // Presentación de los resultados finales

            Thread.Sleep(2000);     // Pausa de 2 segundos

            if (autobot.Salud <= 0 && decepticon.Salud <= 0) {
                Console.WriteLine("\n\n ¡LA GUERRA TERMINÓ EN EMPATE! \n");
            }
            else if (ganadorPartidaAnterior.Tipo == "Decepticon") {
                Console.WriteLine("\n\n ¡LOS DECEPTICONS HAN GANADO LA GUERRA! \n");
            }
            else {
                Console.WriteLine("\n\n ¡LOS AUTOBOTS HAN GANADO LA GUERRA! \n");
            }

            Console.ReadLine();

        }

        // Fin del juego

    }

}
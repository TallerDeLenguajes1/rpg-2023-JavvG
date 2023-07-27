using EspacioPersonajes;

int cantidadDePersonajes = 4;       // Debe ser un número par, pues son dos bandos de personajes

PersonajesJson characterJson = new PersonajesJson();

List<Personaje> listaPersonajes = new List<Personaje>();

if(characterJson.Existe("Personajes.json")) {

    listaPersonajes = characterJson.LeerPersonajes("Personajes.json");

}
else {

    FabricaDePersonajes characters = new FabricaDePersonajes();

    for(int i=0; i<cantidadDePersonajes/2; i++) {
        listaPersonajes.Add(characters.CrearPersonaje(0));
    }

    for(int i=0; i<cantidadDePersonajes/2; i++) {
        listaPersonajes.Add(characters.CrearPersonaje(1));
    }

    characterJson.GuardarPersonajes(listaPersonajes, "Personajes.json");

}

Console.Write("\n\n >> Estos son los personajes del juego: \n\n");

int count = 1;

foreach(var personaje in listaPersonajes) {

    Console.Write($"\n\n PERSONAJE NRO. {count}\n");
    personaje.mostrarPersonaje();
    Console.Write("\n");
    count++;

}

Console.ReadLine();

Gameplay juego = new Gameplay();    // Se inicia una nueva instancia del juego

juego.InicioDeJuego(listaPersonajes);

Console.WriteLine(" Juego finalizado");
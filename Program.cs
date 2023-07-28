using EspacioPersonajes;
using GameplaySpace;
using InterfaceSpace;

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

InterfazDelJuego interfazGrafica = new InterfazDelJuego();

Console.Write("\n\n\n");

interfazGrafica.MostrarBienvenida();

interfazGrafica.MenuOpciones(listaPersonajes);

interfazGrafica.JugarDeNuevo();          // Pregunta al usuario si desea jugar de nuevo

Thread.Sleep(3000);         // Pausa de 3 segundos

interfazGrafica.MostrarMensajeJuegoTerminado();
using Personajes;

Personaje nuevoPersonaje;

FabricaDePersonajes creacionPersonajes = new FabricaDePersonajes();

List<Personaje> listaPersonajes = new List<Personaje>();

for (int i=0; i<=10; i++) {

    nuevoPersonaje = creacionPersonajes.CrearPersonaje();
    listaPersonajes.Add(nuevoPersonaje);

}

using Applicacion.Interfaces;
using Domain.Entities;
using Infrastructure.Persistence;
using Infrastructure.Repositories;

while (true)
{
    //repositorio
    IMaquinaRepository repository = new MaquinaRepository(new TryOutContext());

    String? NumMaquina, Nombre, Descripcion;

    Console.Write("ingresa el numero de maquina: ");
    NumMaquina = Console.ReadLine();

    Console.Write("ingresa el nombre de la maquina: ");
    Nombre = Console.ReadLine();

    Console.Write("ingresa la descripcion: ");
    Descripcion = Console.ReadLine();

    Maquina nuevaMaquina = new Maquina
    {
        NumMaquina = NumMaquina,
        Nombre = Nombre,
        Descripcion = Descripcion,
        FechaCreacion = DateTime.Now
    };


    Maquina creada = await repository.InsertMaquina(nuevaMaquina);
    repository.Save();

    Console.WriteLine("---------------------------------");
    Console.WriteLine("se creo la siguiente maquina: ");
    Console.WriteLine("Modelo: M-" + creada.NumMaquina);
    Console.WriteLine("Nombre: " + creada.Nombre);
    Console.WriteLine("Descripcio: " + creada.Descripcion);
}




// See https://aka.ms/new-console-template for more information
using Shared;
using DataAccessLayer.DALs;
using DataAccessLayer.IDALs;

Persona persona = new Persona();
Console.WriteLine("Mi primera App");
IDAL_Personas _persona = new DAL_Personas();

do
{
    try
    {
        Console.WriteLine("Nueva Persona");
        Persona per = new Persona();
        Console.WriteLine("Nombre: ");
        per.nombre = Console.ReadLine();
        Console.WriteLine("Apellido: ");
        per.apellido = Console.ReadLine();
        Console.WriteLine("Documento: ");
        per.Documento = Console.ReadLine();
        Console.WriteLine("Fecha Nacimiento: ");
        per.FechaNacimiento = Console.ReadLine();
        per.Print();
        _persona.Insert(per);

    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
while (!Console.ReadLine().Equals("EXIT")) ;
List<Persona> personas = _persona.GetPersonasOrdenados();
Console.Clear();
Console.WriteLine("-----------LISTA DE PERSONAS ---------------");

foreach (var p in personas)
{
    Console.WriteLine("Persona: "+ p.nombre+" "+p.apellido);
    Console.WriteLine("Documento: " + p.Documento);
    Console.WriteLine("Fecha Nacimiento: " + p.FechaNacimiento);
    Console.WriteLine("--------------------------------------------------");

}




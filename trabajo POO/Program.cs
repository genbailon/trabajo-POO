// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
class Program
{
    static void Main(string[] args)
    {

        empleado empleado = new empleado("patricio", "estrella", 23, "despachador", 500);
        empleado.setnombre("bob");
        empleado.setapellido("esponja");
        empleado.setedad(21);
        empleado.setdepartamento("vendedor");
        empleado.imprimiendoempleado();
        Console.WriteLine(" nombre " + empleado.getnombre() + " apellido " + empleado.getapellido() + " edad " + empleado.getedad() + "departamento" + empleado.getdepartamento());

        empleadoporhoras empleadoporhoras = new empleadoporhoras("julio", "rodriguez", 35, "contador", 600);
        empleadoporhoras.setnombre("arenita");
        empleadoporhoras.setapellido("loor");
        empleadoporhoras.sethorasquetrabajo(15);
        empleadoporhoras.imprimirempleadoporhoras();
        empleadoporhoras.setdepartamento("contador");
        Console.WriteLine(" nombre " + empleadoporhoras.getnombre() + " apellido " + empleadoporhoras.getapellido() + " edad " + empleadoporhoras.getedad() + "departamento" + empleadoporhoras.getdepartamento());


        empleadofijo empleadofijo = new empleadofijo("tina", "zuares", 34, "conductor", 500);
        empleadofijo.imprimirdatosempleadofijo();
        empleadofijo.setdepartamento("conductor");
        Console.WriteLine(" departamento " + empleadofijo.getdepartamento());



        empleadotemporal empleadotemporal = new empleadotemporal("karla", "tomala", 18, "administradora", 500);
        empleadotemporal.setnombre("maria");
        empleadotemporal.setapellido("briones");
        empleadotemporal.setedad(22);
        Console.WriteLine(" sueldodetemporada " + empleadotemporal.getsueldo());

    }
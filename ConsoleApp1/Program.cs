// See https://aka.ms/new-console-template for more information
using System;

class Cliente
{
    public int id;
    public string nombre;
    public string apellido;    
    public string pasaporte;
    public string correo;
    public string nacimiento;
    public string telefono;
    public string direccion;
    public string paisregion;
}

class Vuelo
{
    public int id;
    public string destino;
    public string horario;
    public int capacidad;
    public int asientosDisponibles;
}

class usa
{
    public int id;
    public string escalas;
    public string salida;
    public string llegada;
    public string horario;
    public int capacidad;
    public int asientosDisponibles;
}

class mex
{
    public int id;
    public string escalas;
    public string salida;
    public string llegada;
    public string horario;
    public int capacidad;
    public int asientosDisponibles;
}

class esp
{
    public int id;
    public string escalas;
    public string salida;
    public string llegada;
    public string horario;
    public int capacidad;
    public int asientosDisponibles;
}

class col
{
    public int id;
    public string escalas;
    public string salida;
    public string llegada;
    public string horario;
    public int capacidad;
    public int asientosDisponibles;
}

class cost
{
    public int id;
    public string escalas;
    public string salida;
    public string llegada;
    public string horario;
    public int capacidad;
    public int asientosDisponibles;
}

class peru
{
    public int id;
    public string escalas;
    public string salida;
    public string llegada;
    public string horario;
    public int capacidad;
    public int asientosDisponibles;
}

class Paises
{
    public int id;
    public string destino;
    public string horario;
    public int capacidadpasajeros;
    public int asientosDisponibles;

}
class Destinosreserv
{
    public int id;
    public string destino2;
    public string horario2;
    public int capacidad2;
    public int asientosDisponibles2;
}

class Reserva
{
    public int idCliente;
    public int idVuelo;
}

class Program
{

    static bool AutenticarEmpleado()
    {
        string claveCorrecta = "admin123";
        Console.Write("Ingrese la contraseña de empleado: ");
        string claveIngresada = Console.ReadLine();
        return claveIngresada == claveCorrecta;
    }

    static void RegistrarCliente(Cliente[] clientes, ref int totalClientes)
    {
        if (totalClientes >= clientes.Length)
        {
            Console.WriteLine("No se pueden registrar más clientes. Límite alcanzado.");
            return;
        }

        Console.Write("Ingrese el ID del cliente: ");
        if (!int.TryParse(Console.ReadLine(), out int id))
        {
            Console.WriteLine("ID inválido.");
            return;
        }

        clientes[totalClientes] = new Cliente(); // Se inicializa la posición en el array
        clientes[totalClientes].id = id;

        Console.Write("Ingrese el nombre del cliente: ");
        clientes[totalClientes].nombre = Console.ReadLine();

        Console.Write("Ingrese el apellido del cliente: ");
        clientes[totalClientes].apellido = Console.ReadLine();

        Console.Write("Ingrese el número de pasaporte: ");
        clientes[totalClientes].pasaporte = Console.ReadLine();

        Console.Write("Ingrese el correo electronico del cliente: ");
        clientes[totalClientes].correo = Console.ReadLine();

        Console.Write("Ingrese la fecha de nacimiento del cliente: ");
        clientes[totalClientes].nacimiento = Console.ReadLine();

        Console.Write("Ingrese el número de telefono del cliente: ");
        clientes[totalClientes].telefono = Console.ReadLine();

        Console.Write("Ingrese la direccion del cliente: ");
        clientes[totalClientes].direccion = Console.ReadLine();

        Console.Write("Ingrese el pais o region de procedencia del cliente: ");
        clientes[totalClientes].paisregion = Console.ReadLine();



    totalClientes++;
        Console.WriteLine("Cliente registrado con éxito!\n");
    }

    static void RegistrarVuelo(Vuelo[] vuelos, ref int totalVuelos)
    {
        if (totalVuelos >= vuelos.Length)
        {
            Console.WriteLine("No se pueden registrar más vuelos. Límite alcanzado.");
            return;
        }

        Console.Write("Ingrese el ID del vuelo: ");
        if (!int.TryParse(Console.ReadLine(), out int id))
        {
            Console.WriteLine("ID inválido.");
            return;
        }

        vuelos[totalVuelos] = new Vuelo(); // Se inicializa la posición en el array
        vuelos[totalVuelos].id = id;

        Console.Write("Ingrese el destino: ");
        vuelos[totalVuelos].destino = Console.ReadLine();

        Console.Write("Ingrese el horario: ");
        vuelos[totalVuelos].horario = Console.ReadLine();

        //aqui es de agregar la cantidad de asientos y alguna cosa que sea necesaria

        Console.Write("Ingrese la capacidad del vuelo: ");
        if (!int.TryParse(Console.ReadLine(), out int capacidad))
        {
            Console.WriteLine("Capacidad inválida.");
            return;
        }

        vuelos[totalVuelos].capacidad = capacidad;
        vuelos[totalVuelos].asientosDisponibles = capacidad;
        totalVuelos++;
        Console.WriteLine("Vuelo registrado con éxito!\n");
    }


    //Reservas de  vuelo creo que va ser un monton de switches
    static void Reservavuelo(Destinosreserv[] Destino, ref int reservVuelo)

    {
        Cliente[] clientes = new Cliente[100];
        Vuelo[] vuelos = new Vuelo[10];
        Reserva[] reservas = new Reserva[100];
        int totalClientes = 0, totalVuelos = 0, rVuelo = 0, reserPais = 0;
        usa[] USA = new usa[100];
        mex[] MEX = new mex[100];
        cost[] COST = new cost[100];
        col[] COL = new col[100];
        peru[] PERU = new peru[100];
        esp[] ESP = new esp[100];

        Console.WriteLine("\t=========================================");
        Console.WriteLine("\t      SELECCIONE UN PAIS");
        Console.WriteLine("\t=========================================");
        Console.WriteLine("\t 1. USA");
        Console.WriteLine("\t 2. Mexico");
        Console.WriteLine("\t 3. Costa Rica");
        Console.WriteLine("\t 4. Colombia");
        Console.WriteLine("\t 5. Peru");
        Console.WriteLine("\t 6. España");
        Console.WriteLine("\t 7. Regresar al menu");
        Console.WriteLine("\t=========================================");
        Console.WriteLine("\n");
        string Paises = Console.ReadLine();
        Console.WriteLine("\n");
        // Aqui funciona el switch con sus cases
        switch (Paises)
        {
            case "USA":
                DestinatarioUsa(USA, ref reserPais);
                break;
            case "Mexico":
                DestinatarioMex(MEX, ref reserPais);

                break;
            case "Costa Rica":
                DestinatarioCost(COST, ref reserPais);

                break;
            case "Colombia":
                DestinatarioCol(COL, ref reserPais);
                break;
            case "Peru":
                DestinatarioPeru(PERU, ref reserPais);
                break;
            case "España":
                DestinatarioEsp(ESP, ref reserPais);
                break;
            case "Menu":
                Menu();
                break;
            case "Salir":
                Environment.Exit(0); // esta instruccion se sale de un solo del programa
                break;

            default:
                Console.WriteLine("\t Opcion no definida.. intente de nuevo");
                break;
        }
    }



    static void DestinatarioUsa(usa[] pais, ref int reserPais)

    {

        Destinosreserv[] reservVuelo = new Destinosreserv[100];
        int totalClientes = 0, totalVuelos = 0, rVuelo = 0;
        Console.WriteLine("\t=========================================");
        Console.WriteLine("\t      SELECCIONE UN DESTINO");
        Console.WriteLine("\t=========================================");
        Console.WriteLine("\t 1. Los Angeles");
        Console.WriteLine("\t 2. Nueva York");
        Console.WriteLine("\t 3. Miami");
        Console.WriteLine("\t 4. Houston");
        Console.WriteLine("\t 5. Washington D.C");
        Console.WriteLine("\t 6. Regresar al menú");
        Console.WriteLine("\t=========================================");
        Console.Write("\nSeleccione una opción: ");

        string destino = Console.ReadLine();
        Console.WriteLine("\n=========================================");

        switch (destino)
        {
            case "Los Angeles":
                MostrarVuelos("Los Angeles", new string[] { "6:00 a.m. - 9:00 a.m.", "8:00 a.m. - 11:00 a.m.", "2:00 p.m. - 5:00 p.m.", "6:00 p.m. - 9:00 p.m." }, "$150", "$200", "$30", new string[] { "Sin escalas" });
                break;

            case "Nueva York":
                MostrarVuelos("New York", new string[] { "5:30 a.m. - 8:30 a.m.", "7:30 a.m. - 10:30 a.m.", "9:30 a.m. - 12:30 p.m.", "3:30 p.m. - 6:30 p.m." }, "$160", "$210", "$35", new string[] { "Atlanta", "Miami" });
                break;

            case "Miami":
                MostrarVuelos("Miami", new string[] { "6:15 a.m. - 9:15 a.m.", "8:15 a.m. - 11:15 a.m.", "2:15 p.m. - 5:15 p.m.", "6:15 p.m. - 9:15 p.m." }, "$140", "$190", "$25", new string[] { "Sin escalas" });
                break;

            case "Houston":
                MostrarVuelos("Houston", new string[] { "7:00 a.m. - 10:00 a.m.", "9:00 a.m. - 12:00 p.m.", "3:00 p.m. - 6:00 p.m.", "7:00 p.m. - 10:00 p.m." }, "$145", "$195", "$28", new string[] { "Dallas" });
                break;

            case "Washington D.C":
                MostrarVuelos("Washington D.C", new string[] { "6:45 a.m. - 9:45 a.m.", "8:45 a.m. - 11:45 a.m.", "2:45 p.m. - 5:45 p.m.", "4:45 p.m. - 7:45 p.m." }, "$145", "$195", "$28", new string[] { "Charlotte" });
                break;

            case "6":
                Console.WriteLine("Regresando al menú principal...");
                Reservavuelo(reservVuelo, ref rVuelo);
                break;

            default:
                Console.WriteLine("Opción no válida. Intente nuevamente.");
                break;
        }
    }



    static void DestinatarioMex(mex[] pais, ref int reserPais)

    {
        Destinosreserv[] reservVuelo = new Destinosreserv[100];
        int totalClientes = 0, totalVuelos = 0, rVuelo = 0;
        Console.WriteLine("\t=========================================");
        Console.WriteLine("\t      SELECCIONE UN DESTINO");
        Console.WriteLine("\t=========================================");
        Console.WriteLine("\t 1. Ciudad de Mexico");
        Console.WriteLine("\t 2. Regresar al menú");
        Console.WriteLine("\t=========================================");
        Console.Write("\nSeleccione una opción: ");

        string destino = Console.ReadLine();
        Console.WriteLine("\n=========================================");

        switch (destino)
        {
            case "Ciudad de Mexico":
                MostrarVuelos("Ciudad de México", new string[] { "5:00 a.m. - 10:00 a.m.", "9:00 a.m. - 2:00 p.m.", "3:00 p.m. - 8:00 p.m." }, "$120", "$170", "$20", new string[] { "Guadalajara", "Monterrey" });
                break;

            case "2":
                Console.WriteLine("Regresando al menú principal...");
                Reservavuelo(reservVuelo, ref rVuelo);
                break;

            default:
                Console.WriteLine("Opción no válida. Intente nuevamente.");
                break;
        }
    }



    static void DestinatarioCost(cost[] pais, ref int reserPais)

    {
        Destinosreserv[] reservVuelo = new Destinosreserv[100];
        int totalClientes = 0, totalVuelos = 0, rVuelo = 0;
        Console.WriteLine("\t=========================================");
        Console.WriteLine("\t      SELECCIONE UN DESTINO");
        Console.WriteLine("\t=========================================");
        Console.WriteLine("\t 1. San José");
        Console.WriteLine("\t 2. Regresar al menú");
        Console.WriteLine("\t=========================================");
        Console.Write("\nSeleccione una opción: ");

        string destino = Console.ReadLine();
        Console.WriteLine("\n=========================================");

        switch (destino)
        {
            case "San José":
                MostrarVuelos("San José", new string[] { "6:00 a.m. - 11:00 a.m.", "10:00 a.m. - 3:00 p.m.", "4:00 p.m. - 9:00 p.m." }, "$130", "$180", "$25", new string[] { "Panamá" });
                break;

            case "2":
                Console.WriteLine("Regresando al menú principal...");
                Reservavuelo(reservVuelo, ref rVuelo);
                break;

            default:
                Console.WriteLine("Opción no válida. Intente nuevamente.");
                break;
        }
    }

    static void DestinatarioCol(col[] pais, ref int reserPais)

    {
        Destinosreserv[] reservVuelo = new Destinosreserv[100];
        int totalClientes = 0, totalVuelos = 0, rVuelo = 0;
        Console.WriteLine("\t=========================================");
        Console.WriteLine("\t      SELECCIONE UN DESTINO");
        Console.WriteLine("\t=========================================");
        Console.WriteLine("\t 1. Bogotá");
        Console.WriteLine("\t 2. Regresar al menú");
        Console.WriteLine("\t=========================================");
        Console.Write("\nSeleccione una opción: ");

        string destino = Console.ReadLine();
        Console.WriteLine("\n=========================================");

        switch (destino)
        {
            case "Bogotá":
                MostrarVuelos("Bogotá", new string[] { "6:00 a.m. - 2:00 p.m.", "8:00 a.m. - 6:00 p.m.", "10:00 a.m. - 8:00 p.m.", "2:00 p.m. - 11:00 p.m." }, "$135", "$185", "$22", new string[] { "Panamá", "Miami", "Lima" });
                break;
 
            case "2":
                Console.WriteLine("Regresando al menú principal...");
                Reservavuelo(reservVuelo, ref rVuelo);
                break;

            default:
                Console.WriteLine("Opción no válida. Intente nuevamente.");
                break;
        }
    }

    static void DestinatarioPeru(peru [] pais, ref int reserPais)

    {
        Destinosreserv[] reservVuelo = new Destinosreserv[100];
        int totalClientes = 0, totalVuelos = 0, rVuelo = 0;
        Console.WriteLine("\t=========================================");
        Console.WriteLine("\t      SELECCIONE UN DESTINO");
        Console.WriteLine("\t=========================================");
        Console.WriteLine("\t 1. Lima");
        Console.WriteLine("\t 2. Regresar al menú");
        Console.WriteLine("\t=========================================");
        Console.Write("\nSeleccione una opción: ");

        string destino = Console.ReadLine();
        Console.WriteLine("\n=========================================");

        switch (destino)
        {
            case "Lima":
                MostrarVuelos("Lima", new string[] { "7:00 a.m. - 3:00 p.m.", "9:00 a.m. - 7:00 p.m.", "11:00 a.m. - 9:00 p.m." }, "$140", "$190", "$25", new string[] { "Bogotá", "Santiago" });
                break;

            case "2":
                Console.WriteLine("Regresando al menú principal...");
                Reservavuelo(reservVuelo, ref rVuelo);
                break;

            default:
                Console.WriteLine("Opción no válida. Intente nuevamente.");
                break;
        }
    }


    static void DestinatarioEsp(esp[] pais, ref int reserPais)

    {

        Destinosreserv[] reservVuelo = new Destinosreserv[100];
        int totalClientes = 0, totalVuelos = 0, rVuelo = 0;
        Console.WriteLine("\t=========================================");
        Console.WriteLine("\t      SELECCIONE UN DESTINO");
        Console.WriteLine("\t=========================================");
        Console.WriteLine("\t 1. Madrid");
        Console.WriteLine("\t 2. Regresar al menú");
        Console.WriteLine("\t=========================================");
        Console.Write("\nSeleccione una opción: ");

        string destino = Console.ReadLine();
        Console.WriteLine("\n=========================================");

        switch (destino)
        {
            case "Madrid":
                MostrarVuelos("Madrid", new string[] { "8:00 a.m. - 11:00 p.m.", "2:00 p.m. - 5:00 a.m.", "10:00 p.m. - 1:00 p.m." }, "$500", "$750", "$50", new string[] { "Miami", "Paris" });
                break;

            case "2":
                Console.WriteLine("Regresando al menú principal...");
                Reservavuelo(reservVuelo, ref rVuelo);
                break;

            default:
                Console.WriteLine("Opción no válida. Intente nuevamente.");
                break;
        }
    }



    static void MostrarVuelos(string destino, string[] horarios, string precioNino, string precioAdulto, string equipaje, string[] escalas)
    {
        Console.WriteLine($"Destino: {destino}");
        Console.WriteLine(" Horario de vuelos:");
        for (int i = 0; i < horarios.Length; i++)
        {
            Console.WriteLine($" {i + 1}. {horarios[i]}");
        }
        Console.WriteLine($"Precios: Niños: {precioNino}, Adultos: {precioAdulto}, Equipaje adicional: {equipaje}");
        Console.WriteLine(" Escalas:");
        foreach (var escala in escalas)
        {
            Console.WriteLine($" - {escala}");
        }
        Console.Write("Seleccione el número de vuelo que desea: ");
        string seleccionVuelo = Console.ReadLine();
        if (int.TryParse(seleccionVuelo, out int vueloIndex) && vueloIndex > 0 && vueloIndex <= horarios.Length)
        {
            Console.WriteLine($"Ha seleccionado el vuelo {horarios[vueloIndex - 1]}");
        }
        else
        {
            Console.WriteLine("Selección no válida.");
        }
    }



    static void Menu()
    {
        Console.Clear();
        Cliente[] clientes = new Cliente[100];
        Vuelo[] vuelos = new Vuelo[10];
        Reserva[] reservas = new Reserva[100];
        Destinosreserv[] reservVuelo = new Destinosreserv[100];
        int totalClientes = 0, totalVuelos = 0 , rVuelo = 0;

        bool esEmpleado = AutenticarEmpleado();

        int opcion;
        do
        {
            Console.WriteLine("\n--- Menú ---");
            Console.WriteLine("1. Reservar vuelo");
            Console.WriteLine("2. Cancelar reserva");
            Console.WriteLine("3. Registrar cliente");
            Console.WriteLine("4. Registrar vuelo"); // Se agregó esta opción

            if (esEmpleado)
            {
                Console.WriteLine("5. Guardar datos");
                Console.WriteLine("6. Cargar datos");
            }

            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");
            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Opción inválida.\n");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    // Lógica para reservar vuelo
                    Reservavuelo(reservVuelo, ref rVuelo);
                    break;
                case 2:
                    // Lógica para cancelar reserva
                    Console.WriteLine("Funcionalidad de cancelar reserva no implementada aún.");
                    break;
                case 3:
                    RegistrarCliente(clientes, ref totalClientes);
                    break;
                case 4:
                    RegistrarVuelo(vuelos, ref totalVuelos);
                    break;
                case 5:
                    if (esEmpleado)
                    {
                        // Lógica para guardar datos
                        Console.WriteLine("Funcionalidad de guardar datos no implementada aún.");
                    }
                    else
                        Console.WriteLine("Acceso denegado.\n");
                    break;
                case 6:
                    if (esEmpleado)
                    {
                        // Lógica para cargar datos
                        Console.WriteLine("Funcionalidad de cargar datos no implementada aún.");
                    }
                    else
                        Console.WriteLine("Acceso denegado.\n");
                    break;
                case 7:
                    Console.WriteLine("Saliendo...");
                    break;
                default:
                    Console.WriteLine("Opción inválida.\n");
                    break;
            }
        } while (opcion != 7);
    }

    static void Main()
    {
        Menu();
    }
}


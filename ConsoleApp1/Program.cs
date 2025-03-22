// See https://aka.ms/new-console-template for more information
using System;

class Cliente
{
    public int id;
    public string nombre;
    public string pasaporte;
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

        Console.Write("Ingrese el número de pasaporte: ");
        clientes[totalClientes].pasaporte = Console.ReadLine();

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
        Paises[] pais = new Paises[100];

        int Paises;
        Console.WriteLine("\t=========================================");
        Console.WriteLine("\t      SELECCIONE UN PAIS");
        Console.WriteLine("\t=========================================");
        Console.WriteLine("\t 1. USA");
        Console.WriteLine("\t 2. Mexico");
        Console.WriteLine("\t 3. Colombia");
        Console.WriteLine("\t 4. Peru");
        Console.WriteLine("\t 5. España");
        Console.WriteLine("\t 6. Regresar al menu");
        Console.WriteLine("\t=========================================");
        Console.WriteLine("\n");
        Paises = int.Parse(Console.ReadLine());
        Console.WriteLine("\n");
        // Aqui funciona el switch con sus cases
        switch (Paises)
        {
            case 1:
                DestinatarioUsa(pais, ref reserPais);
                break;
            case 2:

                break;
            case 3:

                break;
            case 4:
                RegistrarCliente(clientes, ref totalClientes);
                break;
            case 5:
                RegistrarVuelo(vuelos, ref totalVuelos);
                break;
            case 6:

                break;
            case 7:
                Environment.Exit(0); // esta instruccion se sale de un solo del programa
                break;

            default:
                Console.WriteLine("\t Opcion no definida.. intente de nuevo");
                break;
        }
    }



    static void DestinatarioUsa(Paises[] pais, ref int reserPais)

    {


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
                Console.WriteLine("Destino: Los Angeles");
                Console.WriteLine(" Horario de vuelos:");
                Console.WriteLine(" - 6:00 a.m. - 2:00 p.m.");
                Console.WriteLine(" - 8:00 a.m. - 6:00 p.m.");
                Console.WriteLine(" - 2:00 p.m. - 8:00 p.m.");
                Console.WriteLine(" - 6:00 p.m. - 2:00 a.m.");
                Console.WriteLine(" - 8:00 p.m. - 4:00 a.m.");
                Console.WriteLine("Precios: Niños: $150, Adultos: $200, Equipaje adicional: $30");
                break;

            case "Nueva York":
                Console.WriteLine("Destino: Nueva York");
                Console.WriteLine("\t=========================================");
                Console.WriteLine(" - 5:30 a.m. - 1:30 p.m.");
                Console.WriteLine(" - 7:30 a.m. - 3:30 p.m.");
                Console.WriteLine(" - 9:30 a.m. - 7:30 p.m.");
                Console.WriteLine(" - 3:30 p.m. - 9:30 p.m.");
                Console.WriteLine(" - 7:30 p.m. - 1:30 a.m.");
                Console.WriteLine(" - 9:30 p.m. - 5:30 a.m.");
                Console.WriteLine("Precios: Niños: $160, Adultos: $210, Equipaje adicional: $35");
                break;

            case "Miami":
                Console.WriteLine("Destino: Miami");
                Console.WriteLine("\t=========================================");
                Console.WriteLine(" Horario de vuelos:");
                Console.WriteLine(" - 6:15 a.m. - 2:45 p.m.");
                Console.WriteLine(" - 8:15 a.m. - 6:45 p.m.");
                Console.WriteLine(" - 2:15 p.m. - 8:45 p.m.");
                Console.WriteLine(" - 6:15 p.m. - 2:45 a.m.");
                Console.WriteLine(" - 8:15 p.m. - 4:45 a.m.");
                Console.WriteLine("Precios: Niños: $140, Adultos: $190, Equipaje adicional: $25");
                break;

            case "Houston":
                Console.WriteLine("Destino: Houston");
                Console.WriteLine("\t=========================================");
                Console.WriteLine(" Horario de vuelos:");
                Console.WriteLine(" - 7:00 a.m. - 1:30 p.m.");
                Console.WriteLine(" - 9:00 a.m. - 3:30 p.m.");
                Console.WriteLine(" - 3:00 p.m. - 7:30 p.m.");
                Console.WriteLine(" - 7:00 p.m. - 9:30 p.m.");
                Console.WriteLine(" - 9:00 p.m. - 1:30 a.m.");
                Console.WriteLine("Precios: Niños: $145, Adultos: $195, Equipaje adicional: $28");
                break;

            case "Washington D.C":
                Console.WriteLine("Destino: Washington D.C");
                Console.WriteLine("\t=========================================");
                Console.WriteLine(" - 6:45 a.m. - 2:45 p.m.");
                Console.WriteLine(" - 8:45 a.m. - 4:45 p.m.");
                Console.WriteLine(" - 2:45 p.m. - 6:45 p.m.");
                Console.WriteLine(" - 4:45 p.m. - 8:45 p.m.");
                Console.WriteLine(" - 6:45 p.m. - 2:45 a.m.");
                Console.WriteLine(" - 8:45 p.m. - 4:45 a.m.");
                Console.WriteLine("Precios: Niños: $145, Adultos: $195, Equipaje adicional: $28");
                break;

            case "6":
                Console.WriteLine("Regresando al menú principal...");
                break;

            default:
                Console.WriteLine("Opción no válida. Intente nuevamente.");
                break;
        }
      }

    



    static void USA(usa[] DestUsa, ref string DestiUsa)
    {
        Console.WriteLine("Seleccione un destino: Los Ángeles, Nueva York, Miami, Houston");
        
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


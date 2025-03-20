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



    static void Reservavuelo(Destinosreserv[] Destino, ref int reservVuelo)

    {
        Cliente[] clientes = new Cliente[100];
        Vuelo[] vuelos = new Vuelo[10];
        Reserva[] reservas = new Reserva[100];
        int totalClientes = 0, totalVuelos = 0, rVuelo = 0, reserPais = 0;
        Paises[] pais = new Paises[100];

        int Paises;
        Console.Write("\tEscoge el destino a reservar un vuelo ");
        Console.WriteLine("\t=========================================");
        Console.WriteLine("\t Destinos a escoger");
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
                Destinatario(pais, ref reserPais);
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

    static void Destinatario(Paises[] pais, ref int reserPais)

    {
        Cliente[] clientes = new Cliente[100];
        Vuelo[] vuelos = new Vuelo[10];
        Reserva[] reservas = new Reserva[100];
        int totalClientes = 0, totalVuelos = 0, rVuelo = 0;
        Destinosreserv[] reservVuelo = new Destinosreserv[100];


        int Destinos;
        Console.Write("\tEscoge el destino a reservar un vuelo ");
        Console.WriteLine("\t=========================================");
        Console.WriteLine("\t Horarios a escoger");
        Console.WriteLine("\t 1. Los Angeles");
        Console.WriteLine("\t 2. New York");
        Console.WriteLine("\t 3. Miami");
        Console.WriteLine("\t 4. Houston");
        Console.WriteLine("\t 5. Washington D.C");
        Console.WriteLine("\t 6.Regresar al menu");
        Console.WriteLine("\t=========================================");
        Console.WriteLine("\n");
        Destinos = int.Parse(Console.ReadLine());
        Console.WriteLine("\n");
        // Aqui funciona el switch con sus cases
        switch (Destinos)
        {
            case 1:

                break;
            case 2:

                break;
            case 3:

                break;
            case 4:
                RegistrarCliente(clientes, ref totalClientes);
                break;
            case 5:
                break;
            case 6:
                Reservavuelo(reservVuelo, ref rVuelo);
                break;
            case 7:
                Environment.Exit(0); // esta instruccion se sale de un solo del programa
                break;

            default:
                Console.WriteLine("\t Opcion no definida.. intente de nuevo");
                break;
        }
    }















    static void Menu()
    {
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


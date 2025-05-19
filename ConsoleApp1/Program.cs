namespace ejemplo
{

    using System;
    using System.Diagnostics;
    using System.IO;
    internal class Program
    {
        struct Cliente
        {
            public string Nombre;
            public string Apellido;
            public string Pasaporte;
            public string Correo;
            public string Nacimiento;
            public string Telefono;
            public string Direccion;
            public string Paisregion;
        }

        struct Vuelo
        {
            public int id;
            public string destino;
            public string horario;
            public int capacidad;
            public int asientosDisponibles;
        }

        struct usa
        {
            public int id;
            public string escalas;
            public string salida;
            public string llegada;
            public string horario;
            public int capacidad;
            public int asientosDisponibles;
        }

        struct mex
        {
            public int id;
            public string escalas;
            public string salida;
            public string llegada;
            public string horario;
            public int capacidad;
            public int asientosDisponibles;
        }

        struct esp
        {
            public int id;
            public string escalas;
            public string salida;
            public string llegada;
            public string horario;
            public int capacidad;
            public int asientosDisponibles;
        }

        struct col
        {
            public int id;
            public string escalas;
            public string salida;
            public string llegada;
            public string horario;
            public int capacidad;
            public int asientosDisponibles;
        }

        struct cost
        {
            public int id;
            public string escalas;
            public string salida;
            public string llegada;
            public string horario;
            public int capacidad;
            public int asientosDisponibles;
        }

        struct peru
        {
            public int id;
            public string escalas;
            public string salida;
            public string llegada;
            public string horario;
            public int capacidad;
            public int asientosDisponibles;
        }

        struct Paises
        {
            public int id;
            public string destino;
            public string horario;
            public int capacidadpasajeros;
            public int asientosDisponibles;

        }
        struct Destinosreserv
        {
            public int id;
            public string destino2;
            public string horario2;
            public int capacidad2;
            public int asientosDisponibles2;
        }

        struct Reserva
        {
            public int idCliente;
            public int idVuelo;
        }

        struct aerolinea
        {

            static bool AutenticarEmpleado()
            {
                string claveCorrecta = "admin123";
                Console.Write("Ingrese la contraseña de empleado: ");
                string claveIngresada = Console.ReadLine();
                return claveIngresada == claveCorrecta;
            }

            static Cliente[] clientes = new Cliente[100];
            static int totalClientes = 0;

            static void RegistrarCliente()
            {
                Cliente nuevoCliente = new Cliente();

                Console.Clear();
                Console.WriteLine("===== REGISTRO DE CLIENTES =====");
                Console.Write("Nombre: ");
                nuevoCliente.Nombre = Console.ReadLine();
                Console.Write("Apellido: ");
                nuevoCliente.Apellido = Console.ReadLine();
                Console.Write("Pasaporte: ");
                nuevoCliente.Pasaporte = Console.ReadLine();
                Console.Write("Correo: ");
                nuevoCliente.Correo = Console.ReadLine();
                Console.Write("Nacimiento: ");
                nuevoCliente.Nacimiento = Console.ReadLine();
                Console.Write("Telefono: ");
                nuevoCliente.Telefono = Console.ReadLine();
                Console.Write("Direccion: ");
                nuevoCliente.Direccion = Console.ReadLine();
                Console.Write("Pais o Región: ");
                nuevoCliente.Paisregion = Console.ReadLine();

                static void RegistrarVuelo()
                {
                    Vuelo nuevoVuelo = new Vuelo();

                    Console.Clear();
                    Console.WriteLine("===== REGISTRO DE VUELOS =====");

                    Console.Write("ID del vuelo: ");
                    while (!int.TryParse(Console.ReadLine(), out nuevoVuelo.id))
                    {
                        Console.Write("❌ ID inválido. Ingrese un número: ");
                    }

                    Console.Write("Destino del vuelo: ");
                    nuevoVuelo.destino = Console.ReadLine();

                    Console.Write("Horario del vuelo: ");
                    nuevoVuelo.horario = Console.ReadLine();

                    Console.Write("Capacidad total de pasajeros: ");
                    while (!int.TryParse(Console.ReadLine(), out nuevoVuelo.capacidad))
                    {
                        Console.Write("❌ Capacidad inválida. Ingrese un número: ");
                    }

                    nuevoVuelo.asientosDisponibles = nuevoVuelo.capacidad;


                    // Guardar en archivo
                    using (StreamWriter escribir = new StreamWriter("Vuelos.txt", true))
                    {
                        escribir.WriteLine($"Vuelo ID: {nuevoVuelo.id}");
                        escribir.WriteLine($"Destino : {nuevoVuelo.destino}");
                        escribir.WriteLine($"Horario : {nuevoVuelo.horario}");
                        escribir.WriteLine($"Capacidad total      : {nuevoVuelo.capacidad}");
                        escribir.WriteLine($"Asientos disponibles : {nuevoVuelo.asientosDisponibles}");
                        escribir.WriteLine("------------------------------------------");
                        escribir.WriteLine();
                    }

                    Console.WriteLine("¡Vuelo registrado y guardado exitosamente!");
                    Console.WriteLine("Presione ENTER para continuar...");
                    Console.ReadLine();
                }

                static void RegistrarDestino()
                {
                    Console.Clear();
                    Console.WriteLine("===== REGISTRO DE DESTINOS =====");

                    Console.Write("País del destino: ");
                    string pais = Console.ReadLine();

                    Console.Write("Ciudad del destino: ");
                    string ciudad = Console.ReadLine();

                    Console.Write("Horario (mañana/tarde/noche): ");
                    string horario = Console.ReadLine();

                    Console.Write("¿Tiene escalas? (Sí/No): ");
                    string escala = Console.ReadLine();

                    Console.Write("Precio del vuelo: ");
                    string precio = Console.ReadLine();

                    // Guardar en archivo de texto
                    using (StreamWriter escribir = new StreamWriter("Destinos.txt", true))
                    {
                        escribir.WriteLine("===== NUEVO DESTINO REGISTRADO =====");
                        escribir.WriteLine($"País    : {pais}");
                        escribir.WriteLine($"Ciudad  : {ciudad}");
                        escribir.WriteLine($"Horario : {horario}");
                        escribir.WriteLine($"Escalas : {escala}");
                        escribir.WriteLine($"Precio  : {precio}");
                        escribir.WriteLine("-------------------------------------\n");
                    }

                    Console.WriteLine("¡Destino registrado y guardado en archivo exitosamente!");
                    Console.WriteLine("Presiona ENTER para continuar...");
                    Console.ReadLine();
                }

                // Guardar en array
                clientes[totalClientes] = nuevoCliente;
                totalClientes++;

                // Guardar en archivo de texto
                using (StreamWriter escribir = new StreamWriter("Clientes.txt", true))
                {
                    escribir.WriteLine($"Cliente {totalClientes}:");
                    escribir.WriteLine($"Nombre: {nuevoCliente.Nombre}");
                    escribir.WriteLine($"Apellido: {nuevoCliente.Apellido}");
                    escribir.WriteLine($"Pasaporte: {nuevoCliente.Pasaporte}");
                    escribir.WriteLine($"Correo: {nuevoCliente.Correo}");
                    escribir.WriteLine($"Nacimiento: {nuevoCliente.Nacimiento}");
                    escribir.WriteLine($"Telefono: {nuevoCliente.Telefono}");
                    escribir.WriteLine($"Direccion: {nuevoCliente.Direccion}");
                    escribir.WriteLine($"Pais/Región: {nuevoCliente.Paisregion}");
                    escribir.WriteLine("----------------------------------------");
                    escribir.WriteLine();
                }

                Console.WriteLine("¡Cliente registrado y guardado en archivo exitosamente!");
                Console.WriteLine("Presiona ENTER para continuar...");
                Console.ReadLine();
            }


            static void RegistrarDestino()
            {
                Console.Clear();
                Console.WriteLine("===== REGISTRO DE DESTINOS =====");

                Console.Write("País del destino: ");
                string pais = Console.ReadLine();
                while (string.IsNullOrWhiteSpace(pais))
                {
                    Console.Write(" País inválido. Intente de nuevo: ");
                    pais = Console.ReadLine();
                }

                Console.Write("Ciudad del destino: ");
                string ciudad = Console.ReadLine();
                while (string.IsNullOrWhiteSpace(ciudad))
                {
                    Console.Write(" Ciudad inválida. Intente de nuevo: ");
                    ciudad = Console.ReadLine();
                }

                Console.Write("Horario (mañana/tarde/noche): ");
                string horario = Console.ReadLine().ToLower();
                while (horario != "mañana" && horario != "tarde" && horario != "noche")
                {
                    Console.Write(" Horario inválido. Use 'mañana', 'tarde' o 'noche': ");
                    horario = Console.ReadLine().ToLower();
                }

                Console.Write("¿Tiene escalas? (sí/no): ");
                string escala = Console.ReadLine().ToLower();
                while (escala != "sí" && escala != "no")
                {
                    Console.Write(" Respuesta inválida. Escriba 'sí' o 'no': ");
                    escala = Console.ReadLine().ToLower();
                }

                Console.Write("Precio del vuelo (en USD): ");
                string precio = Console.ReadLine();
                while (!decimal.TryParse(precio, out _))
                {
                    Console.Write(" Precio inválido. Ingrese un número válido: ");
                    precio = Console.ReadLine();
                }

                // Guardar en archivo de texto
                using (StreamWriter escribir = new StreamWriter("Destinos.txt", true))
                {
                    escribir.WriteLine("===== NUEVO DESTINO REGISTRADO =====");
                    escribir.WriteLine($"País    : {pais}");
                    escribir.WriteLine($"Ciudad  : {ciudad}");
                    escribir.WriteLine($"Horario : {horario}");
                    escribir.WriteLine($"Escalas : {escala}");
                    escribir.WriteLine($"Precio  : {precio}");
                    escribir.WriteLine("-------------------------------------\n");
                }

                Console.WriteLine("¡Destino registrado y guardado en archivo exitosamente!");
                Console.WriteLine("Presiona ENTER para continuar...");
                Console.ReadLine();
            }
            static void MostrarVuelosDesdeArchivo()
            {
                string archivo = "Vuelos.txt";

                if (!File.Exists(archivo))
                {
                    Console.WriteLine("No hay vuelos registrados aún.");
                    return;
                }

                Console.Clear();
                Console.WriteLine("=== VUELOS DISPONIBLES ===\n");

                string[] lineas = File.ReadAllLines(archivo);
                int contador = 1;

                for (int i = 0; i < lineas.Length; i++)
                {
                    if (lineas[i].StartsWith("Vuelo"))
                    {
                        Console.WriteLine($"[{contador}]");
                        contador++;
                    }

                    Console.WriteLine(lineas[i]);
                }

                Console.WriteLine("\nPresione ENTER para continuar...");
                Console.ReadLine();
            }


            static void CancelarReserva()
            {
                string archivoReservas = "Reservas.txt";
                if (!File.Exists(archivoReservas))
                {
                    Console.WriteLine("❌ No hay reservas registradas aún.");
                    Console.WriteLine("Presione ENTER para continuar...");
                    Console.ReadLine();
                    return;
                }

                string[] reservas = File.ReadAllLines(archivoReservas);
                List<int> indicesReservasActivas = new List<int>();

                Console.Clear();
                Console.WriteLine("=== CANCELAR RESERVA ===\n");

                for (int i = 0; i < reservas.Length; i++)
                {
                    if (reservas[i].Contains("Estado: Activa"))
                    {
                        Console.WriteLine($"[{indicesReservasActivas.Count + 1}]");
                        Console.WriteLine(reservas[i - 2]); // Destino
                        Console.WriteLine(reservas[i - 1]); // Horario
                        Console.WriteLine(reservas[i]);     // Estado
                        Console.WriteLine(reservas[i + 1]); // Separador
                        Console.WriteLine();
                        indicesReservasActivas.Add(i);
                    }
                }

                if (indicesReservasActivas.Count == 0)
                {
                    Console.WriteLine("No hay reservas activas para cancelar.");
                    Console.WriteLine("Presione ENTER para continuar...");
                    Console.ReadLine();
                    return;
                }

                Console.Write("Seleccione el número de reserva a cancelar: ");
                if (int.TryParse(Console.ReadLine(), out int seleccion) && seleccion >= 1 && seleccion <= indicesReservasActivas.Count)
                {
                    int lineaEstado = indicesReservasActivas[seleccion - 1];
                    reservas[lineaEstado] = "Estado: Cancelada";

                    File.WriteAllLines(archivoReservas, reservas);
                    Console.WriteLine("\n✅ ¡Reserva cancelada exitosamente!");
                }
                else
                {
                    Console.WriteLine("❌ Selección no válida.");
                }

                Console.WriteLine("Presione ENTER para continuar...");
                Console.ReadLine();
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

                vuelos[totalVuelos] = new Vuelo(); // Inicializar
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

                // Guardar en archivo de texto
                using (StreamWriter escribir = new StreamWriter("Vuelos.txt", true))
                {
                    escribir.WriteLine($"Vuelo {totalVuelos + 1}:");
                    escribir.WriteLine($"ID: {vuelos[totalVuelos].id}");
                    escribir.WriteLine($"Destino: {vuelos[totalVuelos].destino}");
                    escribir.WriteLine($"Horario: {vuelos[totalVuelos].horario}");
                    escribir.WriteLine($"Capacidad Total: {vuelos[totalVuelos].capacidad}");
                    escribir.WriteLine($"Asientos Disponibles: {vuelos[totalVuelos].asientosDisponibles}");
                    escribir.WriteLine("----------------------------------------\n");
                }

                totalVuelos++;
                Console.WriteLine("✈ ¡Vuelo registrado y guardado exitosamente en Vuelos.txt!");
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
                    case "1":
                        DestinatarioUsa(USA, ref reserPais);
                        break;
                    case "2":
                        DestinatarioMex(MEX, ref reserPais);

                        break;
                    case "3":
                        DestinatarioCost(COST, ref reserPais);

                        break;
                    case "4":
                        DestinatarioCol(COL, ref reserPais);
                        break;
                    case "5":
                        DestinatarioPeru(PERU, ref reserPais);
                        break;
                    case "6":
                        DestinatarioEsp(ESP, ref reserPais);
                        break;
                    case "7":
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
                    case "1":
                        MostrarVuelos("Los Angeles", new string[] { "6:00 a.m. - 9:00 a.m.", "8:00 a.m. - 11:00 a.m.", "2:00 p.m. - 5:00 p.m.", "6:00 p.m. - 9:00 p.m." }, "$150", "$200", "$30", new string[] { "Sin escalas" });
                        break;

                    case "2":
                        MostrarVuelos("New York", new string[] { "5:30 a.m. - 8:30 a.m.", "7:30 a.m. - 10:30 a.m.", "9:30 a.m. - 12:30 p.m.", "3:30 p.m. - 6:30 p.m." }, "$160", "$210", "$35", new string[] { "Atlanta", "Miami" });
                        break;

                    case "3":
                        MostrarVuelos("Miami", new string[] { "6:15 a.m. - 9:15 a.m.", "8:15 a.m. - 11:15 a.m.", "2:15 p.m. - 5:15 p.m.", "6:15 p.m. - 9:15 p.m." }, "$140", "$190", "$25", new string[] { "Sin escalas" });
                        break;

                    case "4":
                        MostrarVuelos("Houston", new string[] { "7:00 a.m. - 10:00 a.m.", "9:00 a.m. - 12:00 p.m.", "3:00 p.m. - 6:00 p.m.", "7:00 p.m. - 10:00 p.m." }, "$145", "$195", "$28", new string[] { "Dallas" });
                        break;

                    case "5":
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
                    case "1":
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
                    case "1":
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
                    case "1":
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

            static void DestinatarioPeru(peru[] pais, ref int reserPais)

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
                    case "1":
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
                    case "1":
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

                Console.Write("\nSeleccione el número de vuelo que desea: ");
                string seleccionVuelo = Console.ReadLine();

                if (int.TryParse(seleccionVuelo, out int vueloIndex) && vueloIndex > 0 && vueloIndex <= horarios.Length)
                {
                    string horarioSeleccionado = horarios[vueloIndex - 1];
                    Console.WriteLine($"\n✈ Ha reservado el vuelo a {destino} en el horario: {horarioSeleccionado}");

                    // Guardar en archivo
                    using (StreamWriter escribir = new StreamWriter("VuelosReservados.txt", true))
                    {
                        escribir.WriteLine($"Vuelo reservado a: {destino}");
                        escribir.WriteLine($"Horario seleccionado: {horarioSeleccionado}");
                        escribir.WriteLine($"Precio (Niño): {precioNino}");
                        escribir.WriteLine($"Precio (Adulto): {precioAdulto}");
                        escribir.WriteLine($"Equipaje adicional: {equipaje}");
                        escribir.WriteLine("Escalas:");
                        foreach (var escala in escalas)
                        {
                            escribir.WriteLine($" - {escala}");
                        }
                        escribir.WriteLine("--------------------------------------------------\n");
                    }

                    Console.WriteLine("\n ¡Reserva de vuelo guardada exitosamente!");
                    // También guardamos en el archivo principal de reservas
                    using (StreamWriter escribirReserva = new StreamWriter("Reservas.txt", true))
                    {
                        escribirReserva.WriteLine($"Destino: {destino}");
                        escribirReserva.WriteLine($"Horario: {horarioSeleccionado}");
                        escribirReserva.WriteLine("Estado: Activa");
                        escribirReserva.WriteLine("--------------------------------------\n");
                    }

                }

                else
                {
                    Console.WriteLine("ERROR; Selección no válida.");
                }
            }


            static void MostrarClientesDesdeArchivo()
            {
                string archivo = "Clientes.txt";

                if (!File.Exists(archivo))
                {
                    Console.WriteLine("El archivo aún no existe.");
                    Console.WriteLine("Presione ENTER para continuar...");
                    Console.ReadLine();
                    return;
                }

                // Abre el archivo con el Bloc de notas
                Process.Start(new ProcessStartInfo()
                {
                    FileName = archivo,
                    UseShellExecute = true
                });
            }



            static void Menu()
            {
                Console.Clear();
                Cliente[] clientes = new Cliente[100];
                Vuelo[] vuelos = new Vuelo[10];
                Reserva[] reservas = new Reserva[100];
                Destinosreserv[] reservVuelo = new Destinosreserv[100];
                int totalClientes = 0, totalVuelos = 0, rVuelo = 0;

                bool esEmpleado = AutenticarEmpleado();

                int opcion;
                do
                {
                    Console.WriteLine("\n--- Menú ---");
                    Console.WriteLine("1. Reservar vuelo");
                    Console.WriteLine("2. Cancelar reserva");
                    Console.WriteLine("3. Registrar cliente");
                    Console.WriteLine("4. Mostrar clientes");
                    Console.WriteLine("5. Registrar vuelo"); // Se agregó esta opción
                    Console.WriteLine("6. Registrar Destino");// Se agregó esta opción :D
                    Console.WriteLine("7. Mostrar vuelos disponibles");// tambien se agrego esta :D

                    if (esEmpleado)
                    {
                        Console.WriteLine("9. Guardar datos");
                        Console.WriteLine("10. Cargar datos");
                    }

                    Console.WriteLine("8. Salir");
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
                            CancelarReserva();
                            break;
                        case 3:
                            RegistrarCliente();
                            break;
                        case 4:
                            MostrarClientesDesdeArchivo();
                            break;
                        case 5:
                            RegistrarVuelo(vuelos, ref totalVuelos);
                            break;
                        case 6:
                            RegistrarDestino();
                            break;
                        case 7:
                            MostrarVuelosDesdeArchivo();
                            break;
                        case 9:
                            if (esEmpleado)
                            {
                                // Lógica para guardar datos
                                Console.WriteLine("Funcionalidad de guardar datos no implementada aún.");
                            }
                            else
                                Console.WriteLine("Acceso denegado.\n");
                            break;
                        case 10:
                            if (esEmpleado)
                            {
                                // Lógica para cargar datos
                                Console.WriteLine("Funcionalidad de cargar datos no implementada aún.");
                            }
                            else
                                Console.WriteLine("Acceso denegado.\n");
                            break;
                        case 8:
                            Console.WriteLine("Saliendo...");
                            break;
                        default:
                            Console.WriteLine("Opción inválida.\n");
                            break;
                    }
                } while (opcion != 8);
            }

            static void Main()
            {
                Menu();
            }
        }
    }
}
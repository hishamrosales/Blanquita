using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace uwu
{
    class Program
    {
        static void Main(string[] args)
        {
            Metodos<string> metodos = new Metodos<string>();

            metodos.CrearTeamDeportes("Barcelona");
            metodos.CrearTeamDeportes("PSG");
            metodos.CrearTeamDeportes("Real Madrid");
            metodos.CrearTeamDeportes("Bayern");
            metodos.CrearTeamDeportes("Golden State");
            metodos.CrearTeamDeportes("Lakers");
            metodos.CrearTeamDeportes("Celtics");
            metodos.CrearTeamDeportes("Bulls");

            metodos.CrearTeameSports("G2");

            metodos.CrearJugador("Luis", 25, "Portero", "Deportes");
            metodos.CrearJugador("Andrés", 22, "Defensa", "Deportes");
            metodos.CrearJugador("Carlos", 27, "Delantero", "Deportes");
            metodos.CrearJugador("Miguel", 24, "Mediocampista", "Deportes");
            metodos.CrearJugador("Diego", 23, "Lateral Derecho", "Deportes");
            metodos.CrearJugador("Sergio", 29, "Lateral Izquierdo", "Deportes");
            metodos.CrearJugador("Emilio", 21, "Extremo Derecho", "Deportes");
            metodos.CrearJugador("Ricardo", 26, "Extremo Izquierdo", "Deportes");
            metodos.CrearJugador("José", 24, "Defensa Central", "Deportes");
            metodos.CrearJugador("Héctor", 30, "Delantero Centro", "Deportes");
            metodos.CrearJugador("Manuel", 28, "Mediocentro Defensivo", "Deportes");
            metodos.CrearJugador("Adrián", 22, "Mediocentro Ofensivo", "Deportes");

            metodos.CrearJugador("Javier", 21, "Base", "Deportes");
            metodos.CrearJugador("Fernando", 23, "Escolta", "Deportes");
            metodos.CrearJugador("Raúl", 26, "Alero", "Deportes");
            metodos.CrearJugador("Iván", 28, "Pívot", "Deportes");
            metodos.CrearJugador("Marcos", 24, "Base", "Deportes");
            metodos.CrearJugador("Tomás", 25, "Escolta", "Deportes");
            metodos.CrearJugador("Esteban", 27, "Alero", "Deportes");
            metodos.CrearJugador("Pablo", 23, "Ala-Pívot", "Deportes");
            metodos.CrearJugador("Ramiro", 29, "Pívot", "Deportes");
            metodos.CrearJugador("Nicolás", 21, "Escolta", "Deportes");
            metodos.CrearJugador("David", 26, "Alero", "Deportes");
            metodos.CrearJugador("Gustavo", 28, "Base", "Deportes");

            for (int i = 1; i < 9; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    metodos.AñadirJug(1, i);
                }
            }

            int respuesta = 0;
            do
            {
                Console.WriteLine("----MENÚ----");
                Console.WriteLine("1. Crear Jugadores");
                Console.WriteLine("2. Crear Equipos");
                Console.WriteLine("3. Añadir Jugador a Equipo");
                Console.WriteLine("4. Crear Torneo");
                Console.WriteLine("5. Historial de Torneos");
                Console.WriteLine("6. Mostrar Ranking general de Jugadores");
                Console.WriteLine("7. Calcular promedio de nivel de equipo");
                Console.WriteLine("8. Mostrar jugadores de torneo");
                Console.WriteLine("9. Estadísticas individuales y por equipos");
                Console.WriteLine("10. Quitar jugadores de equipos");
                Console.WriteLine("11. Logros y MVP");
                Console.WriteLine("12. Partido amistoso");
                Console.WriteLine("13. Comparar puntuaciones");
                Console.WriteLine("14. Salir");
                respuesta = Convert.ToInt32(Console.ReadLine());

                switch (respuesta)
                {
                    case 1:
                        string tipoJugador;

                        Console.WriteLine("Escriba el nombre del Jugador");
                        string nombre = Console.ReadLine();
                        Console.WriteLine("Escribe la edad del Jugador");
                        int edad = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Escribe las características especiales del jugador");
                        string especial = Console.ReadLine();

                        do
                        {
                            Console.WriteLine("Escribe si será un jugador de Deportes o de eSports");
                            tipoJugador = Console.ReadLine();
                        } while (tipoJugador != "Deportes" && tipoJugador != "eSports");
                        metodos.CrearJugador(nombre, edad, especial, tipoJugador);
                        break;

                    case 2:
                        string tipoTeam;
                        do
                        {
                            Console.WriteLine("Será un equipo de Deportes o de eSports?");
                            tipoTeam = Console.ReadLine();

                            if (tipoTeam == "Deportes")
                            {
                                Console.WriteLine("Escriba el nombre del Equipo");
                                string nombreE = Console.ReadLine();
                                metodos.CrearTeamDeportes(nombreE);
                            }
                            else if (tipoTeam == "eSports")
                            {
                                Console.WriteLine("Escriba el nombre del Equipo");
                                string nombreE = Console.ReadLine();
                                metodos.CrearTeameSports(nombreE);
                            }
                        } while (tipoTeam != "Deportes" && tipoTeam != "eSports");

                        break;
                    case 3:
                        string tipoAñadir;

                        do
                        {
                            Console.WriteLine("Añadirás a team de Deportes o eSports?");
                            tipoAñadir = Console.ReadLine();

                        } while (tipoAñadir != "eSports" && tipoAñadir != "Deportes");
                        if (metodos.ListaJugadores() == false)
                        {
                            Console.WriteLine("No hay jugadores disponibles sin equipo");
                        }
                        else if (tipoAñadir == "Deportes")
                        {
                            Console.WriteLine("Selecciona el Jugador");
                            metodos.ListaJugadores();
                            int selJugador = Convert.ToInt16(Console.ReadLine());

                            Console.WriteLine("Selecciona el Equipo");
                            metodos.ListaEquiposDeportes();
                            int selEquipo = Convert.ToInt32(Console.ReadLine());

                            metodos.AñadirJug(selJugador, selEquipo);
                        }
                        else if (tipoAñadir == "eSports")
                        {
                            Console.WriteLine("Selecciona el Jugador");
                            metodos.ListaJugadores();
                            int selJugador = Convert.ToInt16(Console.ReadLine());

                            Console.WriteLine("Selecciona el Equipo");
                            metodos.ListaEquiposeSports();
                            int selEquipo = Convert.ToInt32(Console.ReadLine());

                            metodos.AñadirJug(selJugador, selEquipo);
                        }


                        break;
                    case 4:
                        string tipoTorneo;

                        Console.WriteLine("¿Cómo se llamará el Torneo?");
                        string nomTorneo = Console.ReadLine();

                        do
                        {
                            Console.WriteLine("¿De qué tipo será el torneo? Deportes/eSports?");
                            tipoTorneo = Console.ReadLine();

                            if (tipoTorneo != "Deportes" && tipoTorneo != "eSports")
                                Console.WriteLine("Selecciona una opción válida");

                        } while (tipoTorneo != "Deportes" && tipoTorneo != "eSports");


                        metodos.CrearTorneo(nomTorneo, tipoTorneo);


                        break;
                    case 5:
                        metodos.HistorialTorneos();
                        break;
                    case 6:
                        metodos.RankingJugadores();
                        break;
                    case 7:
                        string tipoEquipo;
                        do
                        {
                            Console.WriteLine("¿Deportes o eSports?");
                            tipoEquipo = Console.ReadLine();
                        } while (tipoEquipo != "Deportes" && tipoEquipo != "eSports");

                        if (tipoEquipo == "Deportes")
                        {
                            metodos.ListaEquiposDeportes();
                            Console.WriteLine("Selecciona el equipo para calcular promedio:");
                            int selEquipo = Convert.ToInt32(Console.ReadLine());
                            var equipo = metodos.ObtenerEquiposDeportes().ElementAt(selEquipo - 1);

                            double promedio = metodos.CalculateAverage(equipo);
                            Console.WriteLine($"Promedio de nivel del equipo {equipo.NombreTeam}: {promedio:F2}");
                        }
                        else
                        {
                            metodos.ListaEquiposeSports();
                            Console.WriteLine("Selecciona el equipo para calcular promedio:");
                            int selEquipo = Convert.ToInt32(Console.ReadLine());
                            var equipo = metodos.ObtenerEquiposEsports().ElementAt(selEquipo - 1);

                            double promedio = metodos.CalculateAverage(equipo);
                            Console.WriteLine($"Promedio de nivel del equipo {equipo.NombreTeam}: {promedio:F2}");
                        }
                        break;

                    case 8:
                        metodos.MostrarTorneos();
                        Console.WriteLine("Selecciona el torneo para ver sus jugadores:");
                        int selTorneo = Convert.ToInt32(Console.ReadLine());
                        metodos.MostrarJugadoresDeTorneo(selTorneo - 1);
                        break;
                    case 9:
                        Console.WriteLine("1. Estadísticas individuales");
                        Console.WriteLine("2. Estadísticas por equipos");
                        int opcionStats = Convert.ToInt32(Console.ReadLine());

                        if (opcionStats == 1)
                        {
                            metodos.MostrarEstadisticasIndividuales();
                        }
                        else if (opcionStats == 2)
                        {
                            metodos.MostrarEstadisticasPorEquipos();
                        }
                        break;

                    case 10:
                        metodos.QuitarJugadorDeEquipo();
                        break;

                    case 11:
                        metodos.MostrarLogrosYMVP();
                        break;

                    case 12:
                        metodos.PartidoAmistoso();
                        break;

                    case 13:
                        Console.WriteLine("1. Comparar dos jugadores");
                        Console.WriteLine("2. Comparar dos equipos");
                        int opcionComparar = Convert.ToInt32(Console.ReadLine());

                        if (opcionComparar == 1)
                        {
                            metodos.CompararJugadores();
                        }
                        else if (opcionComparar == 2)
                        {
                            metodos.CompararEquipos();
                        }
                        break;
                }

            } while (respuesta != 14);


        }
        public class Player<T>
        {
            public string NombreP { get; set; }
            public int Edad { get; set; }
            public double Nivel { get; set; }
            public T Especiales { get; set; }
            public string Stats { get; set; }
            public Team<T> Equipo { get; set; }
            public string TipoJ { get; set; }

            public void MostrarInfo()
            {
                Console.WriteLine($"Nombre: {NombreP} || Edad: {Edad} || Nivel {Nivel} || Stats: {Stats}");
            }
            public void ActualizarStats(double newStat)
            {
                Nivel = Nivel + newStat;
                if (Nivel > 25)
                {
                    Nivel = 25;
                }

                if (Nivel >= 0 && Nivel < 5)
                    Stats = "Jugador de una estrella * ";
                else if (Nivel >= 5 && Nivel < 10)
                    Stats = "Jugador de dos estrellas **";
                else if (Nivel >= 10 && Nivel < 15)
                    Stats = "Jugador de tres estrellas ***";
                else if (Nivel >= 15 && Nivel < 20)
                    Stats = "Jugador de cuatro estrellas ****";
                else if (Nivel >= 20 && Nivel <= 25)
                    Stats = "Jugador de cinco estrellas *****";

            }
        }
        public class Team<T>
        {
            public string NombreTeam { get; set; }
            public List<Player<T>> Jugadores { get; set; } = new List<Player<T>>();
            public string TipoT { get; set; }
        }

        public class Tournament<T>
        {
            public string NombreTour { get; set; }
            public string TipoTour { get; set; }
            public List<T> Participantes { get; set; }
        }

        public class Achievement<T>
        {
            public string Titulo { get; set; }
            public string Descripcion { get; set; }
            public Player<T> Jugador { get; set; }
            public Team<T> Equipo { get; set; }
            public DateTime Fecha { get; set; }
        }

        public class Partido<T>
        {
            public Team<T> EquipoLocal { get; set; }
            public Team<T> EquipoVisitante { get; set; }
            public int PuntosLocal { get; set; }
            public int PuntosVisitante { get; set; }
            public Team<T> Ganador { get; set; }
            public Player<T> MVP { get; set; }
            public DateTime Fecha { get; set; }
        }


        public class Metodos<T>
        {
            List<Player<T>> jugadores = new List<Player<T>>();
            List<Player<T>> jugadoresConEquipo = new List<Player<T>>();
            Dictionary<string, Team<T>> EquiposDeportes = new Dictionary<string, Team<T>>();
            Dictionary<string, Team<T>> EquiposeSports = new Dictionary<string, Team<T>>();
            Queue<Player<T>> turnos = new Queue<Player<T>>();
            Stack<Player<T>> historial = new Stack<Player<T>>();
            Stack<string> torneosPasados = new Stack<string>();
            public List<Tournament<Team<T>>> Torneos = new List<Tournament<Team<T>>>();
            public List<Achievement<T>> Logros = new List<Achievement<T>>();
            public List<Partido<T>> Partidos = new List<Partido<T>>();


            public void CompareScoresJugadores(int a, int b)
            {
                Player<T> p1 = jugadores.ElementAt(a);
                Player<T> p2 = jugadores.ElementAt(b);
            }
            public void CompareScoresEquipos(T a, T b)
            {
                Team<T> t1 = EquiposDeportes.Values.FirstOrDefault(e => e.Equals(a));
                Team<T> t2 = EquiposDeportes.Values.FirstOrDefault(e => e.Equals(b));
            }
            public double CalculateAverage(Team<T> equipo)
            {
                if (equipo.Jugadores.Count == 0)
                    return 0;

                double total = equipo.Jugadores.Sum(j => j.Nivel);
                return total / equipo.Jugadores.Count;
            }

            public void PrintDetails<T>(T item)
            {

            }


            // METODOS PARA LISTAS
            public void ListaEquiposDeportes()
            {
                var lista = EquiposDeportes.Values.Where(e => e.TipoT == "Deportes").ToList();
                if (lista.Count == 0)
                {
                    Console.WriteLine("No hay equipos de eSports registrados.");
                    return;
                }

                int index = 1;
                foreach (var item in lista)
                {
                    Console.WriteLine(index + ". " + item.NombreTeam);
                    index++;
                }
            }
            public void ListaEquiposeSports()
            {
                var lista = EquiposeSports.Values.Where(e => e.TipoT == "eSports").ToList();
                if (lista.Count == 0)
                {
                    Console.WriteLine("No hay equipos de eSports registrados.");
                    return;
                }

                int index = 1;
                foreach (var item in lista)
                {
                    Console.WriteLine(index + ". " + item.NombreTeam);
                    index++;
                }
            }
            public void ListaEquiposConJugadoresDeportes()
            {
                int index = 1;
                foreach (var equipo in EquiposDeportes.Values)
                {
                    Console.WriteLine(index + ". " + equipo.NombreTeam);
                    if (equipo.Jugadores.Count <= 0)
                        Console.WriteLine("No hay jugadores aún");
                    else
                    {
                        int indexer = 1;
                        foreach (var jugador in equipo.Jugadores)
                        {
                            Console.WriteLine("   " + indexer + ". " + jugador.NombreP + " " + "(Edad: " + jugador.Edad + ") " + "Posición: " + jugador.Especiales);
                            indexer++;
                        }
                    }
                    index++;
                }
            }
            public void ListaEquiposConJugadoreseSports()
            {
                int index = 1;
                foreach (var equipo in EquiposeSports.Values)
                {
                    Console.WriteLine(index + ". " + equipo.NombreTeam);
                    if (equipo.Jugadores.Count <= 0)
                        Console.WriteLine("No hay jugadores aún");
                    else
                    {
                        int indexer = 1;
                        foreach (var jugador in equipo.Jugadores)
                        {
                            Console.WriteLine("   " + indexer + ". " + jugador.NombreP + " " + "(Edad: " + jugador.Edad + ") " + "Posición: " + jugador.Especiales);
                            indexer++;
                        }
                    }
                    index++;
                }
            }
            public bool ListaJugadores()
            {
                bool vacio = false;
                int index = 1;
                foreach (var item in jugadores)
                {
                    if (item.Equipo == null)
                    {
                        Console.WriteLine(index + ". " + item.NombreP);
                        index++;
                        vacio = true;
                    }
                }
                return vacio;
            }


            //MÉTODOS PARA CREAR
            public void CrearJugador(string nombre, int edad, T especial, string TipoJ)
            {
                jugadores.Add(new Player<T>
                {
                    NombreP = nombre,
                    Edad = edad,
                    Especiales = especial,
                    TipoJ = TipoJ,
                });
            }

            public void CrearTeamDeportes(string nombre)
            {
                EquiposDeportes.Add(nombre, new Team<T>
                {
                    NombreTeam = nombre,
                    TipoT = "Deportes"
                });
            }
            public void CrearTeameSports(string nombre)
            {
                EquiposeSports.Add(nombre, new Team<T>
                {
                    NombreTeam = nombre,
                    TipoT = "eSports"
                });
            }
            public void CrearTorneo(string nombreTorneo, string tipoTorneo)
            {
                int cantidad = 0;
                int seleccion = 0;
                Tournament<Team<T>> torneo = new Tournament<Team<T>>
                {
                    NombreTour = nombreTorneo,
                    Participantes = new List<Team<T>>(),
                    TipoTour = tipoTorneo,
                };

                do
                {
                    Console.WriteLine("¿Cuántos equipos deseas agregar al torneo? 4 u 8?");
                    cantidad = Convert.ToInt32(Console.ReadLine());

                    if (cantidad != 4 && cantidad != 8)
                        Console.WriteLine("Escoge una respuesta correcta");

                } while (cantidad != 4 && cantidad != 8);


                if (cantidad == 4)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        bool valido = false;
                        Team<T> equipoSeleccionado = null;

                        while (!valido)
                        {
                            Console.WriteLine($"Selecciona el equipo #{i + 1}:");
                            if (tipoTorneo == "Deportes")
                            {
                                ListaEquiposDeportes();
                                seleccion = Convert.ToInt32(Console.ReadLine());

                                if (seleccion < 1 || seleccion > EquiposDeportes.Count)
                                {
                                    Console.WriteLine("Opción no válida. Intenta nuevamente.");
                                    continue;
                                }

                                equipoSeleccionado = EquiposDeportes.Values.ElementAt(seleccion - 1);

                                if (torneo.Participantes.Contains(equipoSeleccionado))
                                {
                                    Console.WriteLine("Ese equipo ya fue agregado al torneo. Elige otro.");
                                }
                                else
                                {
                                    valido = true;
                                }
                            }
                            else if (tipoTorneo == "eSports")
                            {
                                ListaEquiposeSports();
                                seleccion = Convert.ToInt32(Console.ReadLine());

                                if (seleccion < 1 || seleccion > EquiposeSports.Count)
                                {
                                    Console.WriteLine("Opción no válida. Intenta nuevamente.");
                                    continue;
                                }

                                equipoSeleccionado = EquiposeSports.Values.ElementAt(seleccion - 1);

                                if (torneo.Participantes.Contains(equipoSeleccionado))
                                {
                                    Console.WriteLine("Ese equipo ya fue agregado al torneo. Elige otro.");
                                }
                                else
                                {
                                    valido = true;
                                }
                            }


                        }
                        torneo.Participantes.Add(equipoSeleccionado);
                        Console.WriteLine($"Equipo '{equipoSeleccionado.NombreTeam}' agregado al torneo.");
                    }

                    List<int> ints = new List<int>();
                    Random rnd = new Random();

                    while (ints.Count < 4)
                    {
                        int num = rnd.Next(torneo.Participantes.Count);
                        if (!ints.Contains(num))
                            ints.Add(num);
                    }

                    Team<T> p1 = torneo.Participantes[ints[0]];
                    Team<T> p2 = torneo.Participantes[ints[1]];
                    Team<T> p3 = torneo.Participantes[ints[2]];
                    Team<T> p4 = torneo.Participantes[ints[3]];

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"RESULTADOS DEL TORNEO {nombreTorneo}");

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"El equipo {p1.NombreTeam} pasó a la GRAN FINAL ganando contra {p2.NombreTeam}");
                    Console.WriteLine($"El equipo {p3.NombreTeam} pasó a la GRAN FINAL ganando contra {p4.NombreTeam}");

                    Console.WriteLine($"El equipo {p2.NombreTeam} quedó en TERCER PUESTO ganando contra {p4.NombreTeam}");

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"El equipo {p1.NombreTeam} ganó el partido contra {p3.NombreTeam}");

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"EL EQUIPO {p1.NombreTeam} ES EL GRAN GANADOR DEL TORNEO {nombreTorneo}");
                    Console.ForegroundColor = ConsoleColor.White;

                    torneosPasados.Push("\nNombre del Torneo: " + torneo.NombreTour +
                        $"\nGanador: {p1.NombreTeam}" +
                        $"\n2do Puesto: {p3.NombreTeam}" +
                        $"\n3er Puesto: {p2.NombreTeam}" +
                        $"\n4to Puesto: {p4.NombreTeam}");

                    // Crear logros para el torneo
                    var equipoGanador = p1;
                    var mvpTorneo = equipoGanador.Jugadores.OrderByDescending(j => j.Nivel).First();

                    // Logro para el equipo ganador
                    var logroGanador = new Achievement<T>
                    {
                        Titulo = $"Campeón del Torneo {nombreTorneo}",
                        Descripcion = $"Equipo ganador del torneo {nombreTorneo}",
                        Jugador = null,
                        Equipo = equipoGanador,
                        Fecha = DateTime.Now
                    };
                    Logros.Add(logroGanador);

                    // Logro para el MVP del torneo
                    var logroMVP = new Achievement<T>
                    {
                        Titulo = $"MVP del Torneo {nombreTorneo}",
                        Descripcion = $"Jugador más valioso del torneo {nombreTorneo}",
                        Jugador = mvpTorneo,
                        Equipo = equipoGanador,
                        Fecha = DateTime.Now
                    };
                    Logros.Add(logroMVP);

                    // Logro para el subcampeón
                    var logroSubcampeon = new Achievement<T>
                    {
                        Titulo = $"Subcampeón del Torneo {nombreTorneo}",
                        Descripcion = $"Segundo lugar en el torneo {nombreTorneo}",
                        Jugador = null,
                        Equipo = p3, // En torneo de 4 equipos
                        Fecha = DateTime.Now
                    };
                    Logros.Add(logroSubcampeon);

                    List<Team<T>> posiciones = new List<Team<T>> { p1, p3, p2, p4 };

                    for (int pos = 0; pos < posiciones.Count; pos++)
                    {
                        Team<T> equipoActual = posiciones[pos];
                        var jugadoresEquipo = equipoActual.Jugadores;

                        double min = 0, max = 0;
                        switch (pos + 1)
                        {
                            case 1: min = 1.30; max = 1.50; break;
                            case 2: min = 1.15; max = 1.29; break;
                            case 3: min = 1.05; max = 1.14; break;
                            case 4: min = 0.95; max = 1.04; break;
                        }


                        foreach (var jugador in jugadoresEquipo)
                        {
                            double puntos = rnd.NextDouble() * (max - min) + min;
                            jugador.ActualizarStats(puntos);
                        }
                    }


                }
                else if (cantidad == 8)
                {
                    for (int i = 0; i < 8; i++)
                    {
                        bool valido = false;
                        Team<T> equipoSeleccionado = null;

                        while (!valido)
                        {
                            Console.WriteLine($"Selecciona el equipo #{i + 1}:");
                            if (tipoTorneo == "Deportes")
                            {
                                ListaEquiposDeportes();
                                seleccion = Convert.ToInt32(Console.ReadLine());

                                if (seleccion < 1 || seleccion > EquiposDeportes.Count)
                                {
                                    Console.WriteLine("Opción no válida. Intenta nuevamente.");
                                    continue;
                                }

                                equipoSeleccionado = EquiposDeportes.Values.ElementAt(seleccion - 1);

                                if (torneo.Participantes.Contains(equipoSeleccionado))
                                {
                                    Console.WriteLine("Ese equipo ya fue agregado al torneo. Elige otro.");
                                }
                                else
                                {
                                    valido = true;
                                }
                            }
                            else if (tipoTorneo == "eSports")
                            {
                                ListaEquiposeSports();
                                seleccion = Convert.ToInt32(Console.ReadLine());

                                if (seleccion < 1 || seleccion > EquiposeSports.Count)
                                {
                                    Console.WriteLine("Opción no válida. Intenta nuevamente.");
                                    continue;
                                }

                                equipoSeleccionado = EquiposeSports.Values.ElementAt(seleccion - 1);

                                if (torneo.Participantes.Contains(equipoSeleccionado))
                                {
                                    Console.WriteLine("Ese equipo ya fue agregado al torneo. Elige otro.");
                                }
                                else
                                {
                                    valido = true;
                                }
                            }


                        }
                        torneo.Participantes.Add(equipoSeleccionado);
                        Console.WriteLine($"Equipo '{equipoSeleccionado.NombreTeam}' agregado al torneo.");
                    }

                    List<int> ints = new List<int>();
                    Random rnd = new Random();

                    while (ints.Count < 8)
                    {
                        int num = rnd.Next(torneo.Participantes.Count);
                        if (!ints.Contains(num))
                            ints.Add(num);
                    }

                    Team<T> p1 = torneo.Participantes[ints[0]];
                    Team<T> p2 = torneo.Participantes[ints[1]];
                    Team<T> p3 = torneo.Participantes[ints[2]];
                    Team<T> p4 = torneo.Participantes[ints[3]];
                    Team<T> p5 = torneo.Participantes[ints[4]];
                    Team<T> p6 = torneo.Participantes[ints[5]];
                    Team<T> p7 = torneo.Participantes[ints[6]];
                    Team<T> p8 = torneo.Participantes[ints[7]];

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"RESULTADOS DEL TORNEO {nombreTorneo}");

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"El equipo {p1.NombreTeam} pasó a SEMIFINALES ganando contra {p2.NombreTeam}");
                    Console.WriteLine($"El equipo {p3.NombreTeam} pasó a SEMIFINALES ganando contra {p4.NombreTeam}");
                    Console.WriteLine($"El equipo {p5.NombreTeam} pasó a SEMIFINALES ganando contra {p6.NombreTeam}");
                    Console.WriteLine($"El equipo {p7.NombreTeam} pasó a SEMIFINALES ganando contra {p8.NombreTeam}");

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"El equipo {p1.NombreTeam} pasó a la GRAN FINAL ganando contra {p3.NombreTeam}");
                    Console.WriteLine($"El equipo {p5.NombreTeam} pasó a la GRAN FINAL ganando contra {p7.NombreTeam}");

                    Console.WriteLine($"El equipo {p3.NombreTeam} quedó en TERCER PUESTO ganando contra {p7.NombreTeam}");

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"El equipo {p1.NombreTeam} ganó el partido contra {p5.NombreTeam}");

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"EL EQUIPO {p1.NombreTeam} ES EL GRAN GANADOR DEL TORNEO {nombreTorneo}");
                    Console.ForegroundColor = ConsoleColor.White;

                    torneosPasados.Push("Nombre del Torneo: " + torneo.NombreTour +
                        $"\nGanador: {p1.NombreTeam}" +
                        $"\n2do Puesto: {p5.NombreTeam}" +
                        $"\n3er Puesto: {p3.NombreTeam}" +
                        $"\n4to Puesto: {p7.NombreTeam}" +
                        $"\n5to Puesto: {p2.NombreTeam}" +
                        $"\n6to Puesto: {p4.NombreTeam}" +
                        $"\n7mo Puesto: {p6.NombreTeam}" +
                        $"\n8vo Puesto: {p8.NombreTeam}"
                        );

                    // Crear logros para el torneo
                    var equipoGanador = p1;
                    var mvpTorneo = equipoGanador.Jugadores.OrderByDescending(j => j.Nivel).First();

                    // Logro para el equipo ganador
                    var logroGanador = new Achievement<T>
                    {
                        Titulo = $"Campeón del Torneo {nombreTorneo}",
                        Descripcion = $"Equipo ganador del torneo {nombreTorneo}",
                        Jugador = null,
                        Equipo = equipoGanador,
                        Fecha = DateTime.Now
                    };
                    Logros.Add(logroGanador);

                    // Logro para el MVP del torneo
                    var logroMVP = new Achievement<T>
                    {
                        Titulo = $"MVP del Torneo {nombreTorneo}",
                        Descripcion = $"Jugador más valioso del torneo {nombreTorneo}",
                        Jugador = mvpTorneo,
                        Equipo = equipoGanador,
                        Fecha = DateTime.Now
                    };
                    Logros.Add(logroMVP);

                    // Logro para el subcampeón
                    var logroSubcampeon = new Achievement<T>
                    {
                        Titulo = $"Subcampeón del Torneo {nombreTorneo}",
                        Descripcion = $"Segundo lugar en el torneo {nombreTorneo}",
                        Jugador = null,
                        Equipo = p3, // En torneo de 4 equipos
                        Fecha = DateTime.Now
                    };
                    Logros.Add(logroSubcampeon);

                    List<Team<T>> posiciones = new List<Team<T>> { p1, p5, p3, p7, p2, p4, p6, p8 };

                    for (int pos = 0; pos < posiciones.Count; pos++)
                    {
                        Team<T> equipoActual = posiciones[pos];
                        var jugadoresEquipo = equipoActual.Jugadores;

                        double min = 0, max = 0;
                        switch (pos + 1)
                        {
                            case 1: min = 1.30; max = 1.50; break;
                            case 2: min = 1.15; max = 1.29; break;
                            case 3: min = 1.05; max = 1.14; break;
                            case 4: min = 0.95; max = 1.04; break;
                            case 5: min = 0.85; max = 0.94; break;
                            case 6: min = 0.75; max = 0.84; break;
                            case 7: min = 0.65; max = 0.74; break;
                            case 8: min = 0.50; max = 0.64; break;
                        }

                        foreach (var jugador in jugadoresEquipo)
                        {
                            double puntos = rnd.NextDouble() * (max - min) + min;
                            jugador.ActualizarStats(puntos);
                        }
                    }


                }
                GuardarTorneo(torneo);
                Console.WriteLine();
            }
            public void HistorialTorneos()
            {
                Console.WriteLine("Historial de torneos pasados");

                foreach (var item in torneosPasados)
                    Console.WriteLine(item);
            }

            //MÉTODOS PARA AÑADIR
            public void AñadirJug(int jugador, int equipo)
            {
                Player<T> p1 = jugadores.ElementAt(jugador - 1);
                Team<T> e1 = EquiposDeportes.Values.ElementAt(equipo - 1);

                e1.Jugadores.Add(p1);

                p1.Equipo = e1;

                jugadoresConEquipo.Add(p1);
                jugadores.Remove(p1);
            }

            public List<Team<T>> ObtenerEquiposDeportes()
            {
                return EquiposDeportes.Values.ToList();
            }

            public List<Team<T>> ObtenerEquiposEsports()
            {
                return EquiposeSports.Values.ToList();
            }


            //TORNEOS OWO
            public void GuardarTorneo(Tournament<Team<T>> torneo)
            {
                Torneos.Add(torneo);
            }

            public void MostrarTorneos()
            {
                if (Torneos.Count == 0)
                {
                    Console.WriteLine("No hay torneos pasados.");
                    return;
                }

                for (int i = 0; i < Torneos.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {Torneos[i].NombreTour} ({Torneos[i].TipoTour})");
                }
            }

            public void MostrarJugadoresDeTorneo(int index)
            {
                if (index < 0 || index >= Torneos.Count)
                {
                    Console.WriteLine("Índice de torneo no válido.");
                    return;
                }

                var torneo = Torneos[index];
                Console.WriteLine($"Jugadores del torneo: {torneo.NombreTour}");

                foreach (var equipo in torneo.Participantes)
                {
                    Console.WriteLine($"Equipo: {equipo.NombreTeam}");
                    foreach (var jugador in equipo.Jugadores)
                    {
                        Console.WriteLine($"- {jugador.NombreP} ({jugador.Stats})");
                    }
                }
            }
            public void MostrarEstadisticasIndividuales()
            {
                if (jugadoresConEquipo.Count == 0)
                {
                    Console.WriteLine("No hay jugadores registrados.");
                    return;
                }

                Console.WriteLine("ESTADÍSTICAS INDIVIDUALES");
                foreach (var jugador in jugadoresConEquipo.OrderByDescending(j => j.Nivel))
                {
                    Console.WriteLine($"\nNombre: {jugador.NombreP}");
                    Console.WriteLine($"Edad: {jugador.Edad}");
                    Console.WriteLine($"Nivel: {jugador.Nivel:F2}");
                    Console.WriteLine($"Stats: {jugador.Stats}");
                    Console.WriteLine($"Especialidad: {jugador.Especiales}");
                    Console.WriteLine($"Tipo: {jugador.TipoJ}");
                    Console.WriteLine($"Equipo: {(jugador.Equipo != null ? jugador.Equipo.NombreTeam : "Sin equipo")}");
                }
            }

            public void MostrarEstadisticasPorEquipos()
            {
                Console.WriteLine("ESTADÍSTICAS POR EQUIPOS");

                Console.WriteLine("\nEQUIPOS DE DEPORTES");
                foreach (var equipo in EquiposDeportes.Values)
                {
                    Console.WriteLine($"\nEquipo: {equipo.NombreTeam}");
                    Console.WriteLine($"Cantidad de jugadores: {equipo.Jugadores.Count}");
                    Console.WriteLine($"Promedio de nivel: {CalculateAverage(equipo):F2}");
                    Console.WriteLine($"Jugadores:");
                    foreach (var jugador in equipo.Jugadores.OrderByDescending(j => j.Nivel))
                    {
                        Console.WriteLine($"  - {jugador.NombreP} (Nivel: {jugador.Nivel:F2}, {jugador.Stats})");
                    }
                }

                Console.WriteLine("\nEQUIPOS DE ESPORTS");
                foreach (var equipo in EquiposeSports.Values)
                {
                    Console.WriteLine($"\nEquipo: {equipo.NombreTeam}");
                    Console.WriteLine($"Cantidad de jugadores: {equipo.Jugadores.Count}");
                    Console.WriteLine($"Promedio de nivel: {CalculateAverage(equipo):F2}");
                    Console.WriteLine($"Jugadores:");
                    foreach (var jugador in equipo.Jugadores.OrderByDescending(j => j.Nivel))
                    {
                        Console.WriteLine($"  - {jugador.NombreP} (Nivel: {jugador.Nivel:F2}, {jugador.Stats})");
                    }
                }
            }

            public void QuitarJugadorDeEquipo()
            {
                Console.WriteLine("¿De qué tipo de equipo quieres quitar el jugador? (Deportes/eSports)");
                string tipo = Console.ReadLine();

                if (tipo == "Deportes")
                {
                    ListaEquiposConJugadoresDeportes();
                    Console.WriteLine("Selecciona el equipo:");
                    int equipoIndex = Convert.ToInt32(Console.ReadLine()) - 1;

                    var equipo = EquiposDeportes.Values.ElementAt(equipoIndex);
                    if (equipo.Jugadores.Count == 0)
                    {
                        Console.WriteLine("Este equipo no tiene jugadores.");
                        return;
                    }

                    Console.WriteLine("Jugadores del equipo:");
                    for (int i = 0; i < equipo.Jugadores.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {equipo.Jugadores[i].NombreP}");
                    }

                    Console.WriteLine("Selecciona el jugador a quitar:");
                    int jugadorIndex = Convert.ToInt32(Console.ReadLine()) - 1;

                    if (jugadorIndex >= 0 && jugadorIndex < equipo.Jugadores.Count)
                    {
                        var jugador = equipo.Jugadores[jugadorIndex];
                        equipo.Jugadores.RemoveAt(jugadorIndex);
                        jugador.Equipo = null;
                        jugadores.Add(jugador);
                        Console.WriteLine($"Jugador {jugador.NombreP} quitado del equipo {equipo.NombreTeam}");
                    }
                }
                else if (tipo == "eSports")
                {
                    ListaEquiposConJugadoreseSports();
                    Console.WriteLine("Selecciona el equipo:");
                    int equipoIndex = Convert.ToInt32(Console.ReadLine()) - 1;

                    var equipo = EquiposeSports.Values.ElementAt(equipoIndex);
                    if (equipo.Jugadores.Count == 0)
                    {
                        Console.WriteLine("Este equipo no tiene jugadores.");
                        return;
                    }

                    Console.WriteLine("Jugadores del equipo:");
                    for (int i = 0; i < equipo.Jugadores.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {equipo.Jugadores[i].NombreP}");
                    }

                    Console.WriteLine("Selecciona el jugador a quitar:");
                    int jugadorIndex = Convert.ToInt32(Console.ReadLine()) - 1;

                    if (jugadorIndex >= 0 && jugadorIndex < equipo.Jugadores.Count)
                    {
                        var jugador = equipo.Jugadores[jugadorIndex];
                        equipo.Jugadores.RemoveAt(jugadorIndex);
                        jugador.Equipo = null;
                        jugadores.Add(jugador);
                        jugadoresConEquipo.Remove(jugador);
                        Console.WriteLine($"Jugador {jugador.NombreP} quitado del equipo {equipo.NombreTeam}");
                    }
                }
            }

            public void MostrarLogrosYMVP()
            {
                if (Logros.Count == 0)
                {
                    Console.WriteLine("No hay logros registrados aún.");
                    Console.WriteLine("Los logros se crean automáticamente al completar torneos.");
                    return;
                }

                Console.WriteLine("LOGROS Y MVP");

                // Mostrar logros de equipos
                Console.WriteLine("\nLOGROS DE EQUIPOS:");
                var logrosEquipos = Logros.Where(l => l.Equipo != null && l.Jugador == null);
                if (logrosEquipos.Any())
                {
                    foreach (var logro in logrosEquipos)
                    {
                        Console.WriteLine($"\nTítulo: {logro.Titulo}");
                        Console.WriteLine($"Descripción: {logro.Descripcion}");
                        Console.WriteLine($"Equipo: {logro.Equipo.NombreTeam}");
                        Console.WriteLine($"Fecha: {logro.Fecha:dd/MM/yyyy}");
                        Console.WriteLine(new string('-', 50));
                    }
                }
                else
                {
                    Console.WriteLine("No hay logros de equipos registrados.");
                }

                // Mostrar logros individuales (MVP)
                Console.WriteLine("\nLOGROS INDIVIDUALES (MVP):");
                var logrosIndividuales = Logros.Where(l => l.Jugador != null);
                if (logrosIndividuales.Any())
                {
                    foreach (var logro in logrosIndividuales)
                    {
                        Console.WriteLine($"\nTítulo: {logro.Titulo}");
                        Console.WriteLine($"Descripción: {logro.Descripcion}");
                        Console.WriteLine($"Jugador: {logro.Jugador.NombreP}");
                        Console.WriteLine($"Equipo: {logro.Equipo?.NombreTeam}");
                        Console.WriteLine($"Fecha: {logro.Fecha:dd/MM/yyyy}");
                        Console.WriteLine(new string('-', 50));
                    }
                }
                else
                {
                    Console.WriteLine("No hay logros individuales registrados.");
                }

                // Estadísticas de logros
                Console.WriteLine($"\nESTADÍSTICAS DE LOGROS:");
                Console.WriteLine($"Total de logros: {Logros.Count}");
                Console.WriteLine($"Logros de equipos: {Logros.Count(l => l.Jugador == null)}");
                Console.WriteLine($"Logros individuales: {Logros.Count(l => l.Jugador != null)}");

                // Jugador con más logros
                var jugadorConMasLogros = Logros
                    .Where(l => l.Jugador != null)
                    .GroupBy(l => l.Jugador)
                    .OrderByDescending(g => g.Count())
                    .FirstOrDefault();

                if (jugadorConMasLogros != null)
                {
                    Console.WriteLine($"\nJUGADOR CON MÁS LOGROS:");
                    Console.WriteLine($"{jugadorConMasLogros.Key.NombreP} - {jugadorConMasLogros.Count()} logros");
                }

                // Equipo con más logros
                var equipoConMasLogros = Logros
                    .Where(l => l.Equipo != null)
                    .GroupBy(l => l.Equipo)
                    .OrderByDescending(g => g.Count())
                    .FirstOrDefault();

                if (equipoConMasLogros != null)
                {
                    Console.WriteLine($"\nEQUIPO CON MÁS LOGROS:");
                    Console.WriteLine($"{equipoConMasLogros.Key.NombreTeam} - {equipoConMasLogros.Count()} logros");
                }
            }

            public void PartidoAmistoso()
            {
                Console.WriteLine("PARTIDO AMISTOSO");
                Console.WriteLine("Selecciona el tipo de equipos (Deportes/eSports):");
                string tipo = Console.ReadLine();

                Team<T> equipo1 = null, equipo2 = null;

                if (tipo == "Deportes")
                {
                    ListaEquiposDeportes();
                    Console.WriteLine("Selecciona el primer equipo:");
                    int eq1 = Convert.ToInt32(Console.ReadLine()) - 1;
                    equipo1 = EquiposDeportes.Values.ElementAt(eq1);

                    Console.WriteLine("Selecciona el segundo equipo:");
                    int eq2 = Convert.ToInt32(Console.ReadLine()) - 1;
                    equipo2 = EquiposDeportes.Values.ElementAt(eq2);
                }
                else if (tipo == "eSports")
                {
                    ListaEquiposeSports();
                    Console.WriteLine("Selecciona el primer equipo:");
                    int eq1 = Convert.ToInt32(Console.ReadLine()) - 1;
                    equipo1 = EquiposeSports.Values.ElementAt(eq1);

                    Console.WriteLine("Selecciona el segundo equipo:");
                    int eq2 = Convert.ToInt32(Console.ReadLine()) - 1;
                    equipo2 = EquiposeSports.Values.ElementAt(eq2);
                }

                if (equipo1 != null && equipo2 != null)
                {
                    Random rnd = new Random();
                    int puntosEq1 = rnd.Next(0, 100);
                    int puntosEq2 = rnd.Next(0, 100);

                    while (puntosEq1 == puntosEq2)
                    {
                        puntosEq2 = rnd.Next(0, 100);
                    }

                    Team<T> ganador = puntosEq1 > puntosEq2 ? equipo1 : equipo2;
                    Team<T> perdedor = puntosEq1 > puntosEq2 ? equipo2 : equipo1;

                    var mvp = ganador.Jugadores.OrderByDescending(j => j.Nivel).First();

                    // Crear partido
                    var partido = new Partido<T>
                    {
                        EquipoLocal = equipo1,
                        EquipoVisitante = equipo2,
                        PuntosLocal = puntosEq1,
                        PuntosVisitante = puntosEq2,
                        Ganador = ganador,
                        MVP = mvp,
                        Fecha = DateTime.Now
                    };

                    Partidos.Add(partido);

                    // Crear logro para el MVP
                    var logroMVP = new Achievement<T>
                    {
                        Titulo = "MVP Partido Amistoso",
                        Descripcion = $"Jugador más valioso del partido entre {equipo1.NombreTeam} vs {equipo2.NombreTeam}",
                        Jugador = mvp,
                        Equipo = ganador,
                        Fecha = DateTime.Now
                    };
                    Logros.Add(logroMVP);

                    // Mostrar resultados
                    Console.WriteLine($"\nRESULTADO DEL PARTIDO:");
                    Console.WriteLine($"{equipo1.NombreTeam} {puntosEq1} - {puntosEq2} {equipo2.NombreTeam}");
                    Console.WriteLine($"GANADOR: {ganador.NombreTeam}");
                    Console.WriteLine($"⭐ MVP: {mvp.NombreP} ({mvp.Stats})");

                    // Mejorar stats del MVP
                    double mejora = rnd.NextDouble() * 0.5 + 0.1;
                    mvp.ActualizarStats(mejora);
                    Console.WriteLine($"{mvp.NombreP} ha mejorado su nivel en {mejora:F2} puntos!");
                }
            }

            public void CompararJugadores()
            {
                if (jugadoresConEquipo.Count < 2)
                {
                    Console.WriteLine("Se necesitan al menos 2 jugadores para comparar.");
                    return;
                }

                Console.WriteLine("Selecciona el primer jugador:");
                for (int i = 0; i < jugadoresConEquipo.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {jugadoresConEquipo[i].NombreP} (Nivel: {jugadoresConEquipo[i].Nivel:F2})");
                }
                int jug1 = Convert.ToInt32(Console.ReadLine()) - 1;

                Console.WriteLine("Selecciona el segundo jugador:");
                for (int i = 0; i < jugadoresConEquipo.Count; i++)
                {
                    if (i != jug1)
                        Console.WriteLine($"{i + 1}. {jugadoresConEquipo[i].NombreP} (Nivel: {jugadoresConEquipo[i].Nivel:F2})");
                }
                int jug2 = Convert.ToInt32(Console.ReadLine()) - 1;

                var player1 = jugadoresConEquipo[jug1];
                var player2 = jugadoresConEquipo[jug2];

                Console.WriteLine($"\nCOMPARACIÓN ENTRE JUGADORES:");


                Console.WriteLine($"Comparando Nombre: {player1.NombreP} vs {player2.NombreP}");
                Console.WriteLine($"Comparando Edad: {player1.Edad} vs {player2.Edad}");
                Console.WriteLine($"Comparando Nivel: {player1.Nivel:F2} vs {player2.Nivel:F2}");
                Console.WriteLine($"Comparando Stats: {player1.Stats} vs {player2.Stats}");
                Console.WriteLine($"Comparando Especialidad: {player1.Especiales} vs {player2.Especiales}");


                if (player1.Nivel > player2.Nivel)
                    Console.WriteLine($"\n{player1.NombreP} tiene MEJOR nivel que {player2.NombreP}");
                else if (player1.Nivel < player2.Nivel)
                    Console.WriteLine($"\n{player2.NombreP} tiene MEJOR nivel que {player1.NombreP}");
                else
                    Console.WriteLine($"\nAmbos jugadores tienen el MISMO nivel");
            }

            public void CompararEquipos()
            {
                Console.WriteLine("Selecciona el tipo de equipos a comparar (Deportes/eSports):");
                string tipo = Console.ReadLine();

                List<Team<T>> equipos = tipo == "Deportes" ? EquiposDeportes.Values.ToList() : EquiposeSports.Values.ToList();

                if (equipos.Count < 2)
                {
                    Console.WriteLine($"Se necesitan al menos 2 equipos de {tipo} para comparar.");
                    return;
                }

                Console.WriteLine("Selecciona el primer equipo:");
                for (int i = 0; i < equipos.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {equipos[i].NombreTeam} (Jugadores: {equipos[i].Jugadores.Count})");
                }
                int eq1 = Convert.ToInt32(Console.ReadLine()) - 1;

                Console.WriteLine("Selecciona el segundo equipo:");
                for (int i = 0; i < equipos.Count; i++)
                {
                    if (i != eq1)
                        Console.WriteLine($"{i + 1}. {equipos[i].NombreTeam} (Jugadores: {equipos[i].Jugadores.Count})");
                }
                int eq2 = Convert.ToInt32(Console.ReadLine()) - 1;

                var equipo1 = equipos[eq1];
                var equipo2 = equipos[eq2];

                double promedio1 = CalculateAverage(equipo1);
                double promedio2 = CalculateAverage(equipo2);

                Console.WriteLine($"\nCOMPARACIÓN ENTRE EQUIPOS:");

                Console.WriteLine($"Nombre del equipo: {equipo1.NombreTeam} vs {equipo2.NombreTeam}");
                Console.WriteLine($"Cantidad de jugadores: {equipo1.Jugadores.Count} vs {equipo2.Jugadores.Count}");
                Console.WriteLine($"Nivel promedio: {promedio1:F2} vs {promedio2:F2}");
                Console.WriteLine($"Tipo de equipo: {equipo1.TipoT} vs {equipo2.TipoT}");


                if (promedio1 > promedio2)
                    Console.WriteLine($"\n{equipo1.NombreTeam} tiene MEJOR promedio que {equipo2.NombreTeam}");
                else if (promedio1 < promedio2)
                    Console.WriteLine($"\n{equipo2.NombreTeam} tiene MEJOR promedio que {equipo1.NombreTeam}");
                else
                    Console.WriteLine($"\nAmbos equipos tienen el MISMO nivel promedio");
            }

            // Modificar el método RankingJugadores existente para ordenar por Nivel
            public void RankingJugadores()
            {
                if (jugadoresConEquipo.Count == 0)
                {
                    Console.WriteLine("No hay jugadores registrados.");
                    return;
                }

                var ranking = jugadoresConEquipo.OrderByDescending(j => j.Nivel).ThenByDescending(j => j.Stats);

                Console.WriteLine("RANKING GENERAL DE JUGADORES");
                Console.WriteLine(new string('=', 50));

                int posicion = 1;
                foreach (var jugador in ranking)
                {
                    Console.WriteLine($"Posición: {posicion}");
                    Console.WriteLine($"Nombre: {jugador.NombreP}");
                    Console.WriteLine($"Nivel: {jugador.Nivel:F2}");
                    Console.WriteLine($"Stats: {jugador.Stats}");
                    Console.WriteLine($"Equipo: {(jugador.Equipo != null ? jugador.Equipo.NombreTeam : "Sin equipo")}");
                    Console.WriteLine(new string('-', 30));
                    posicion++;
                }
            }
        }


    }
}

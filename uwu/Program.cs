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
                Console.WriteLine("----menu----");
                Console.WriteLine("1. Crear Jugadores");
                Console.WriteLine("2. Crear Equipos");
                Console.WriteLine("3. Añadir Jugador a Equipo");
                Console.WriteLine("4. Crear Torneo");
                Console.WriteLine("5. Historial de Torneos");
                Console.WriteLine("6. Mostrar Ranking general de Jugadores");
                Console.WriteLine("10. Salir");
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

                        break;
                    case 8:
                        break;
                    case 9:
                        break;
                }

            } while (respuesta != 10);


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
                else
                {
                    Console.WriteLine("Se actualizó el nivel del jugador");
                    Console.WriteLine($"Nuevo nivel: {Nivel:F2}");
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


        public class Metodos<T>
        {
            List<Player<T>> jugadores = new List<Player<T>>();
            Dictionary<string, Team<T>> EquiposDeportes = new Dictionary<string, Team<T>>();
            Dictionary<string, Team<T>> EquiposeSports = new Dictionary<string, Team<T>>();
            Queue<Player<T>> turnos = new Queue<Player<T>>();
            Stack<Player<T>> historial = new Stack<Player<T>>();
            Stack<string> torneosPasados = new Stack<string>();


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
            public static double CalculateAverage<T>(List<T> list)
            {

                return;
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

                jugadores.Remove(p1);
            }

            //RANKINGS

            public void RankingJugadores()
            {
                var topStats = jugadores.OrderByDescending(t => t.Stats);
                Console.WriteLine("Jugadores ordenados por Mejores Estadisticas");
                foreach (var t in topStats)
                    Console.WriteLine(t.NombreP + " - " + t.Stats + " - " + t.Equipo);
            }
        }
    }
}

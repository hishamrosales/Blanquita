using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
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

            metodos.CrearTeam("Barcelona");
            metodos.CrearTeam("PSG");
            metodos.CrearTeam("Real Madrid");
            metodos.CrearTeam("Bayern");
            metodos.CrearTeam("Golden State");
            metodos.CrearTeam("Lakers");
            metodos.CrearTeam("Celtics");
            metodos.CrearTeam("Bulls");

            metodos.CrearJugador("Luis", 25, "Portero");
            metodos.CrearJugador("Andrés", 22, "Defensa");
            metodos.CrearJugador("Carlos", 27, "Delantero");
            metodos.CrearJugador("Miguel", 24, "Mediocampista");
            metodos.CrearJugador("Diego", 23, "Lateral Derecho");
            metodos.CrearJugador("Sergio", 29, "Lateral Izquierdo");
            metodos.CrearJugador("Emilio", 21, "Extremo Derecho");
            metodos.CrearJugador("Ricardo", 26, "Extremo Izquierdo");
            metodos.CrearJugador("José", 24, "Defensa Central");
            metodos.CrearJugador("Héctor", 30, "Delantero Centro");
            metodos.CrearJugador("Manuel", 28, "Mediocentro Defensivo");
            metodos.CrearJugador("Adrián", 22, "Mediocentro Ofensivo");

            metodos.CrearJugador("Javier", 21, "Base");
            metodos.CrearJugador("Fernando", 23, "Escolta");
            metodos.CrearJugador("Raúl", 26, "Alero");
            metodos.CrearJugador("Iván", 28, "Pívot");
            metodos.CrearJugador("Marcos", 24, "Base");
            metodos.CrearJugador("Tomás", 25, "Escolta");
            metodos.CrearJugador("Esteban", 27, "Alero");
            metodos.CrearJugador("Pablo", 23, "Ala-Pívot");
            metodos.CrearJugador("Ramiro", 29, "Pívot");
            metodos.CrearJugador("Nicolás", 21, "Escolta");
            metodos.CrearJugador("David", 26, "Alero");
            metodos.CrearJugador("Gustavo", 28, "Base");

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
                Console.WriteLine("7.Mostrar Información del jugador");
                Console.WriteLine("10. Salir");
                respuesta = Convert.ToInt32(Console.ReadLine());

                switch (respuesta)
                {
                    case 1:
                        Console.WriteLine("Escriba el nombre del Jugador");
                        string nombre = Console.ReadLine();
                        Console.WriteLine("Escribe la edad del Jugador");
                        int edad = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Escribe las características especiales del jugador");
                        string especial = Console.ReadLine();

                        metodos.CrearJugador(nombre, edad, especial);
                        break;
                    case 2:
                        Console.WriteLine("Escriba el nombre del Equipo");
                        string nombreE = Console.ReadLine();

                        metodos.CrearTeam(nombreE);
                        break;
                    case 3:

                        if (metodos.ListaJugadores() == false)
                        {
                            Console.WriteLine("No hay jugadores disponibles sin equipo");
                        }
                        else
                        {
                            Console.WriteLine("Selecciona el Jugador");
                            metodos.ListaJugadores();
                            int selJugador = Convert.ToInt16(Console.ReadLine());

                            Console.WriteLine("Selecciona el Equipo");
                            metodos.ListaEquipos();
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
            public int Stats { get; set; }
            public Team<T> Equipo { get; set; }

            public void MostrarInfo()
            {
                Console.WriteLine($"Nombre: {NombreP} || Edad: {Edad} || Nivel {Nivel} || Especial: {Especiales} || Stats: {Stats}");
            }
            /*public void ActualizarStats(int nuevoNivel)
            {
                Console.WriteLine($"Se actualizaron las estadistícas de: {NombreP}");
                Console.Write($"Nivel anterior: {Nivel} || ");
                Console.Write($"Estadíasticas anteriores: {Stats} || ");
                Nivel = nuevoNivel;
                
                int nuevasEst =
                Stats = nuevasEst
                Console.Write($"Nuevo nivel: {Nivel}");
                Console.Write($"Nuevas estadísticas: {Stats}");


           } */
        }
        public class Team<T>
        {
            public string NombreTeam { get; set; }
            public List<Player<T>> Jugadores { get; set; } = new List<Player<T>>();
        }

        public class Tournament<T>
        {
            public string NombreTour { get; set; }
            public string TipoJ { get; set; }
            public List<T> Participantes { get; set; }
        }


        public class Metodos<T>
        {
            List<Player<T>> jugadores = new List<Player<T>>();
            Dictionary<string, Team<T>> equipos = new Dictionary<string, Team<T>>();
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
                Team<T> t1 = equipos.Values.FirstOrDefault(e => e.Equals(a));
                Team<T> t2 = equipos.Values.FirstOrDefault(e => e.Equals(b));
            }
            //public static double CalculateAverage<T>(List<T> list)
            //{
            //    return;
            //}
            public void PrintDetails<T>(T item)
            {

            }


            // METODOS PARA LISTAS
            public void ListaEquipos()
            {
                int index = 1;
                foreach (var item in equipos)
                {
                    Console.WriteLine(index + ". " + item.Key);
                    index++;
                }
            }
            public void ListaEquiposConJugadores()
            {
                int index = 1;
                foreach (var equipo in equipos.Values)
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
            public void CrearJugador(string nombre, int edad, T especial)
            {
                jugadores.Add(new Player<T>
                {
                    NombreP = nombre,
                    Edad = edad,
                    Especiales = especial
                });
            }

            public void CrearTeam(string nombre)
            {
                equipos.Add(nombre, new Team<T>
                {
                    NombreTeam = nombre,
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
                    TipoJ = tipoTorneo,
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
                            ListaEquipos();

                            seleccion = Convert.ToInt32(Console.ReadLine());

                            if (seleccion < 1 || seleccion > equipos.Count)
                            {
                                Console.WriteLine("Opción no válida. Intenta nuevamente.");
                                continue;
                            }

                            equipoSeleccionado = equipos.Values.ElementAt(seleccion - 1);

                            if (torneo.Participantes.Contains(equipoSeleccionado))
                            {
                                Console.WriteLine("Ese equipo ya fue agregado al torneo. Elige otro.");
                            }
                            else
                            {
                                valido = true;
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

                    var primer = jugadores.Where(e => e.Equipo.Equals(p1)).ToList();
                    var segundo = jugadores.Where(e => e.Equipo.Equals(p3)).ToList();

                    foreach (var item in primer)
                    {
                        int pLugar = rnd.Next(90, 100);
                        item.Stats = pLugar;
                        Console.WriteLine(item.Stats + " q");
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
                            ListaEquipos();

                            seleccion = Convert.ToInt32(Console.ReadLine());

                            if (seleccion < 1 || seleccion > equipos.Count)
                            {
                                Console.WriteLine("Opción no válida. Intenta nuevamente.");
                                continue;
                            }

                            equipoSeleccionado = equipos.Values.ElementAt(seleccion - 1);

                            if (torneo.Participantes.Contains(equipoSeleccionado))
                            {
                                Console.WriteLine("Ese equipo ya fue agregado al torneo. Elige otro.");
                            }
                            else
                            {
                                valido = true;
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
                Team<T> e1 = equipos.Values.ElementAt(equipo - 1);

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
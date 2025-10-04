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
                Console.WriteLine("7. Mostrar Ranking general de Equipos");
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
                        Console.WriteLine("Selecciona el Jugador");
                        metodos.ListaJugadores();
                        int selJugador = Convert.ToInt16(Console.ReadLine());

                        Console.WriteLine("Selecciona el Equipo");
                        metodos.ListaEquipos();
                        int selEquipo = Convert.ToInt32(Console.ReadLine());

                        metodos.AñadirJug(selJugador, selEquipo);
                        break;
                    case 4:
                        Console.WriteLine("¿Cómo se llamará el Torneo?");
                        string nombTorneo = Console.ReadLine();

                        Console.WriteLine("Selecciona el equipo que deseas agregar al Torneo");
                        metodos.ListaEquipos();
                        int agregar = Convert.ToInt32(Console.ReadLine());


                        break;
                    case 5:
                        break;
                    case 6:
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
            public int Nivel { get; set; }
            public T Especiales { get; set; }
            public T Stats { get; set; }
            public Team<T> Equipo { get; set; }

            public void MostrarInfo()
            {
                Console.WriteLine($"Nombre: {NombreP} || Edad: {Edad} || Nivel {Nivel} || Stats: {Stats}");
            }
            public void ActualizarStats(int newStat)
            {
                Console.WriteLine("Se actualizó el nivel del jugador");
                Console.Write($"Nivel anterior: {Nivel} || ");
                Nivel = newStat;
                Console.Write($"Nuevo nivel: {Nivel}");

            }
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

            public void ListaJugadores()
            {
                int index = 1;
                foreach (var item in jugadores)
                {
                    if (item.Equipo == null)
                    {
                        Console.WriteLine(index + ". " + item.NombreP);
                        index++;
                    }
                }
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
            public void Torneos(int nombre)
            {
                Team<T> seleccionado = equipos.Values.ElementAt(nombre - 1);
                turnos.Enqueue(seleccionado.NombreTeam);
            }
            public void HistorialTorneos(int e1, int e2, int e3, int e4)
            {

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
        }


    }

}

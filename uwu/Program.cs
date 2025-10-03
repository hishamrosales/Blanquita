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
            int respuesta = 0;

            do
            {
                Console.WriteLine("----menu----");
                Console.WriteLine("1. Crear Jugadores");
                Console.WriteLine("2. Crear Equipos");
                Console.WriteLine("3. Añadir Jugador a Equipo");
                Console.WriteLine("4. Salir");
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
                }

                metodos.ListaEquiposConJugadores();
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
            public void ListaEquipos() {
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
                    else {
                        int indexer = 1;
                        foreach (var jugador in equipo.Jugadores)
                        {
                            Console.WriteLine("   " + indexer + ". " + jugador.NombreP + " " + "(Edad: " + jugador.Edad + ")");
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

            public void AñadirJug(int jugador, int equipo)
            { 
                Player<T> p1 = jugadores.ElementAt(jugador - 1);
                Team<T> e1 = equipos.Values.ElementAt(equipo - 1);

                e1.Jugadores.Add(p1);

                p1.Equipo = e1;
            }
        }


    }
   
}

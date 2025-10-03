using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace uwu
{
    class Program <T>
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("----menu----");
            Console.WriteLine("1. Crear Jugadores");
            Console.WriteLine("2. Crear Equipos");

        }
        public class Player<T>
        {
            public string NombreP { get; set; }
            public int Edad { get; set; }
            public int Nivel { get; set; }
            public T Stats { get; set; }
        }
        public class Team<T>
        {
            public string NombreTeam { get; set; }
            public List<T> Jugadores { get; set; }
        }

        public class Tournament<T>
        {
            public string NombreTour { get; set; }
            public string TipoJ { get; set; }
            public List<T> Participantes { get; set; }
        }


        public class ScoreUtils
        {
            List<Player<T>> jugadores = new List<Player<T>>();
            Dictionary<string, Team<T>> equipos = new Dictionary<string, Team<T>>();
            Queue<Player<T>> turnos = new Queue<Player<T>>();
            Stack<Player<T>> historial = new Stack<Player<T>>();


            public void CompareScoresJugadores(int a, int b)
            {
                Player<T> p1 = jugadores.ElementAt(a);
                Player<T> p2 = jugadores.ElementAt(b);

                Team<T> t1 = equipos.ContainsValue(a);

            }
            public void CompareScoresEquipos(T a, T b)
            {

                Team<T> t1 = equipos.Values.FirstOrDefault(e => e.Equals(a));
                Team<T> t2 = equipos.Values.FirstOrDefault(e => e.Equals(b));

            }
            public static double CalculateAverage<T>(List<T> list)
            {
                return;
            }
            public static void PrintDetails<T>(T item)
            {


            }
        }


    }
   
}

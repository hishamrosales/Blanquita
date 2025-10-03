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
            List<Player<T>> jugadores = new List<Player<T>>();
            Dictionary<string, Team<T>> equipos = new Dictionary<string, Team<T>>();
            Queue<Player<T>> turnos = new Queue<Player<T>>();
            Stack<Player<T>> historial = new Stack<Player<T>>();

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
            public string NombreTe { get; set; }
            public List<T> Jugadores { get; set; }
        }

        public class Tournament<T>
        {
            public string NombreTo { get; set; }
            public string TipoJ { get; set; }
            public List<T> Participantes { get; set; }
        }
        public static class ScoreUtils
        {
            public static void CompareScores<T>(T a, T b)
            {
                Player<T> p1 = jugadores[a];
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

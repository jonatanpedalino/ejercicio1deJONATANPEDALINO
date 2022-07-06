using System;

namespace ejercicio1deJONATANPEDALINO
{
    class Program
    {
        static void Main(string[] args)
        {
            float distanciarecorrida = 0f;
            int metrosporsegundo = 0;
            int segundostranscurridos = 0;
            const float metroAkm = 0.001f;
            Console.WriteLine("metros recorridos por segundo:");
            metrosporsegundo = Int32.Parse(Console.ReadLine());
            Console.WriteLine("tiempo transcurrido en segundos:");
            segundostranscurridos = Int32.Parse(Console.ReadLine());
            distanciarecorrida = metrosporsegundo * segundostranscurridos;

            Console.WriteLine("se recorrieron : " + distanciarecorrida + " metros en " + segundostranscurridos + " segundos.");
            Console.WriteLine("se recorrieron:" + distanciarecorrida * metroAkm + "kms.");



        }

    }
}

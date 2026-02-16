namespace AverageDayTemp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Det jeg skrev først
            /*
            int[] temperature = { 7, 4, 5, 5, 5, 4, 4, 4 };

            Console.WriteLine("Her er de forskellige temperaturer i løbet af ugen: ");
            for (int i = 0; i < temperature.Length; i++)
            {
                Console.WriteLine(temperature[i]);
            }

            temperature.GetUpperBound(0);
            Console.WriteLine($"Ugens højeste temperatur: {temperature[0]} ");
            
            Array.Sort( temperature );
            temperature.GetLowerBound(0);
            Console.WriteLine($"Ugens laveste temperatur: {temperature[0]} ");

            Console.WriteLine("Den gennemsnitlige temperatur er: ");

            double temp; 

            for (int i = 0; i < temperature.Length; i++) 
            { 

            }
            */

            //Live kodning i klassen
            double[] vejr = { 7, 4, 5, 5, 5, 4, 4, 4 };

            double avgTemp = 0;

            for (int i = 0; i < vejr.Length; i++)
            { 
                avgTemp += vejr[i];
                Console.WriteLine(avgTemp);
            }

            Console.WriteLine("Gennemsnitstemperatur: ");
            avgTemp = avgTemp / vejr.Length;
            Console.WriteLine(avgTemp);

            //Sort array
            vejr.Sort();
            Console.WriteLine($"Den laveste temperatur er: {vejr[0]}");

            Console.WriteLine($"og den højeste temperatur er: {vejr[7]}");

            //Eller
            Console.WriteLine($"... {vejr[vejr.Length - 1]}");
        }

    }
}

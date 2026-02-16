namespace AverageDayTemp
{
    internal class Program
    {
        static void Main(string[] args)
        {
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


        }

    }
}

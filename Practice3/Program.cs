using System;

namespace Practice3
{
    class Program
    {
        static void Main(string[] args)
        {
       

            Lectures lecture = new Lectures();
            
            lecture.SetTitle("Evolution and Genetics");
            lecture.SetDescription("Misconseptions about genetics.");
            lecture.SetDate(new DateOnly(2022, 08, 10));
            lecture.SetTime(new TimeOnly(16, 0, 0));
            lecture.SetSpeaker("Roger Rabbit");
            lecture.SetCapacity(500);
            lecture.SetAddress(new Address("1206, Main Street", "Miami", "FL"));
            lecture.PrintEventDetail(true);
            Console.WriteLine("");

            Outdoors outdoor = new Outdoors();

            outdoor.SetTitle("Pets Convention");
            outdoor.SetDescription("Fun day to be with your pet.");
            outdoor.SetDate(new DateOnly(2022, 07, 09));
            outdoor.SetTime(new TimeOnly(15, 0, 0));
            outdoor.SetAddress(new Address("497, Road Valley", "Jacksonville", "AB"));
            outdoor.SetWeather("Sunny");
            outdoor.PrintEventDetail(false);
            Console.WriteLine("");

            Receptions reception = new Receptions();

            reception.SetTitle("Wedding Reception");
            reception.SetDescription("Wedding reception of Richard and Emily");
            reception.SetDate(new DateOnly(2022, 06, 08));
            reception.SetTime(new TimeOnly(14, 0, 0));
            reception.SetAddress(new Address("2924, Rocky CottomWood", "Riverdalle", "NV"));
            reception.SetEmail("emily@gmail.com");
            reception.SetRegistered(20);
            reception.PrintEventDetail(true);
            Console.WriteLine("");

        }
    }
}

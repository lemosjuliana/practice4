using System;

namespace Practice3
{
    class Program
    {
        static void Main(string[] args)
        {
            Lectures lecture = new Lectures();
            lecture.SetSpeaker("Roger");
            lecture.SetCapacity(500);
            lecture.Address("62 Main Street");
            var dateLecture = new DateOnly(2022, 08, 10);
            var timeLecture = new TimeOnly(16, 0, 0);

            lecture.SetTitle("Evolution and Genetics");
            lecture.SetDescription("Misconseptions about genetics.");

            Console.WriteLine(lecture.StandardDetails());
            Console.WriteLine(lecture.OutdoorsPrint());
            Console.WriteLine(lecture.ShortDescription());


            Outdoors outdoor = new Outdoors();
            outdoor.SetSpeaker("Roger");
            outdoor.SetCapacity(500);
            outdoor.Address("72 Main Avenue");
            var dateOutdoor = new DateOnly(2022, 07, 09);
            var timeOutdoor = new TimeOnly(15, 0, 0);

            outdoor.SetTitle("Pets Convention");
            outdoor.SetDescription("Fun day to be with your pet.");

            Console.WriteLine(outdoor.StandardDetails());
            Console.WriteLine(outdoor.OutdoorsPrint());
            Console.WriteLine(outdoor.ShortDescription());


            
           Receptions reception = new OReceptions();
            reception.SetSpeaker("Roger");
            reception.SetCapacity(500);
            reception.Address("82 Main Road");
            var dateReception = new DateOnly(2022, 06, 08);
            var timeReception = new TimeOnly(14, 0, 0);

            reception.SetTitle("Wedding reception");
            reception.SetDescription("Wedding reception of Richard and Emily");

            Console.WriteLine(reception.StandardDetails());
            Console.WriteLine(reception.OutdoorsPrint());
            Console.WriteLine(reception.ShortDescription());
            
            
        }
    }
}

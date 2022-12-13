using System;

namespace Practice4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Activity> activityList = new List<Activity>();

            Running running = new Running();
            running.SetDistance(6);
            running.SetMinutes(30);
            var runningDate = new DateOnly(2022, 05, 12);
            running.SetDate(runningDate);
            activityList.Add(running);


            Cycling cycling = new Cycling();
            cycling.SetSpeed(40);
            cycling.SetMinutes(30);
            var cyclingDate = new DateOnly(2022, 05, 12);
            cycling.SetDate(cyclingDate);
            activityList.Add(cycling);


            Swimming swimming = new Swimming();
            swimming.SetLaps(12);
            swimming.SetMinutes(20);
            var swimmingDate = new DateOnly(2022, 05, 12);
            swimming.SetDate(swimmingDate);
            activityList.Add(swimming);


            foreach (Activity activity in activityList)
            {
                Console.WriteLine(activity.GetSummary());
            }


        }
    }
}

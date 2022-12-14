using System;

namespace Practice3
{
    public class Outdoors : Event
    {
        private string _weather;

        public Outdoors()
        {
            SetEventType("OUTDOORS");
        }

        public void SetWeather(string weather)
        {
            _weather = weather;
        }

        public string GetWeather()
        {
            return _weather;
        }

        public void PrintEventDetail(Boolean standard)
        {
            if (standard)
            {
                PrintStandardDescrition();
            }
            else
            {
                PrintShortDescription();
            }
            Console.WriteLine($"Weather: {_weather}");
        }
    }



}
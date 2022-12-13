using System;
namespace Practice3
{
    public class Outdoors: Event
    {
        private string _weather;

        public Outdoors()
        {

        }
        public string OutdoorsPrint()
        {
            return $"{title()} {description()} {date()} {time()} {address()}";
        }

        public void SetWeather(string weather)
        {            
            _weather = weather;
        }
        public string GetWeather(string weather)
        {
            return _weather;
        }
    }
        

    
}
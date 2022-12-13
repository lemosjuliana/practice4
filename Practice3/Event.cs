using System;
namespace Practice3
{
    public class Event
    {
        private string _title;
        private string _description;
        private DateOnly _date;
        private TimeOnly _time;
        private string _address;
        private string _eventType;  
    
    public Event(string title, string description, DateOnly date, TimeOnly time, string address, string eventType)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _eventType = eventType;
    }

       public void SetTitle(string title)
        {
            _eventTitle = title;
        }
        public void SetDescription(string description)
        {
            _description = description;
        }
        public void SetDate(DateOnly date)
        {
            _date = date;
        }
        public void SetTime(TimeOnly time)
        {
            _time = time;
        }
        public void SetAddress(string address)
        {
            _address = address;
        }

        public string eventType()
        {
             switch(this.GetType().ToString())
            {
                case "Practice3.Lectures" :
                    _eventType = "Lectures";
                    break;                
                case "Practice3.Receptions" :
                    _eventType = "Receptions";
                    break;
                case "Practice3.Outdoors" :
                    _eventType = "Outdoors";
                    break;
                default:
                    _eventType = "Event";
                    break;
            }

            return _myType;
        }

        public string ShortDescription()
        {
            return $"{title()} {date()} ({eventType()})";
        }

        public string StandardDetails()
        {
            return $"{title()} {description()} {date()} {time()} {address()}";
        }

        }

    }
    

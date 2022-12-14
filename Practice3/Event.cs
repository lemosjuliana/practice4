using System;
using System.Text;

namespace Practice3
{
    public class Event
    {
        private string _title;
        private string _description;
        private DateOnly _date;
        private TimeOnly _time;
        private Address _address;
        private string _eventType;

        public string GetTitle()
        {
            return _title;
        }

        public void SetTitle(string title)
        {
            _title = title;
        }

        public string GetDescription()
        {
            return _description;
        }

        public void SetDescription(string description)
        {
            _description = description;
        }

        public DateOnly GetDate()
        {
            return _date;
        }

        public void SetDate(DateOnly date)
        {
            _date = date;
        }

        public TimeOnly GetTime()
        {
            return _time;
        }

        public void SetTime(TimeOnly time)
        {
            _time = time;
        }

        public Address GetAddress()
        {
            return _address;
        }
        
        public void SetAddress(Address address)
        {
            _address = address;
        }

        public string GetEventType()
        {
            return _eventType;
        }

        protected void SetEventType(string eventType)
        {
            _eventType = eventType;
        }

        public void PrintShortDescription()
        {
            StringBuilder text = new StringBuilder();
            text.AppendLine($"Title: {_title}");
            text.AppendLine($"Event Type: {_eventType}");
            text.Append($"Date: {_date}");
            Console.WriteLine(text.ToString());
        }

        public void PrintStandardDescrition()
        {
            StringBuilder text = new StringBuilder();
            text.AppendLine($"Title: {_title}");
            text.AppendLine($"Description: {_description}");
            text.AppendLine($"Date/Time: {_date} {_time}");
            text.Append($"{_address.GetAddress()}");
            Console.WriteLine(text.ToString());
        }

    }

}


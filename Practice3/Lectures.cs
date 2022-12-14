using System;
using System.Net;
using System.Text;

namespace Practice3
{
    public class Lectures : Event
    {
        private string _speakerName;
        private int _capacity;

        public Lectures()
        {
            SetEventType("LECTURE");
        }

        public void SetSpeaker(string speaker)
        {
            _speakerName = speaker;
        }

        public void SetCapacity(int capacity)
        {
            _capacity = capacity;
        }

        public string GetSpeaker()
        {
            return _speakerName;
        }

        public int GetCapacity()
        {
            return _capacity;
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
            StringBuilder text = new StringBuilder();
            text.AppendLine($"Speaker Name: {_speakerName}");
            text.AppendLine($"Place Capacity: {_capacity}");
            Console.Write(text.ToString());
        }
    }

}
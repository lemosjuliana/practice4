using System;
namespace Practice3
{
    public class Lectures: Event
    {
        private string _speakerName;
        private int _speakerCapacity;

        public Lectures()
        {

        }
        public LecturesPrint()
        {
            return $"{title()} {description()} {date()} {time()} {address()}";
        }

        public void SetSpeaker(string speaker)
        {            
            _speakerName = speakerName;
        }
        public void SetCapacity(int capacity)
        {
            _speakerCapacity = speakerCapacity;
        }

         public string GetSpeaker()
        {
            return _speakerName;
        }
        public int GetCapacity()
        {
            return _speakerCapacity;
        }
    }
        

    
}
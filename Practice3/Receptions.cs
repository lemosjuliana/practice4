using System;
using System.Text;

namespace Practice3
{
    public class Receptions: Event
    {
        private string _email;
        private int _registered;

        public Receptions()
        {
            SetEventType("RECEPTIONS");
        }

        public void SetEmail(string email)
        {            
            _email = email;
        }
        public void SetRegistered(int registered)
        {
            _registered = registered;
        }

         public string GetEmail()
        {
            return _email;
        }
        
        public int GetRegistered()
        {
            return _registered;
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
            Console.Write($"Atendee E-mail: {_email}");
        }

    }
        

    
}
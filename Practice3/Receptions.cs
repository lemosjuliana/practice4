using System;
namespace Practice3
{
    public class Receptions: Event
    {
        private string _email;
        private int _registered;

        public Receptions()
        {

        }
        public ReceptionsPrint()
        {
            return $"{title()} {description()} {date()} {time()} {address()}";
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
    }
        

    
}
namespace hello_console.Countries
{
    internal class BaseCountry : ICountry
    {
        // Fields
        private string _name = "";
        private string _message = "";

        public BaseCountry()
        {
        }

        // Properties
        public string Name 
        {
            get => _name;
            set 
            {
                // NOTE: Add custom logic here
                _name = value;
            }
        }

        public string Message
        { 
            get => _message;
            set => _message = value;
        }

    }
}

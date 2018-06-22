using Microsoft.Extensions.Configuration;

namespace OdeToFood
{
    public interface IGreeter
    {
        string getMessageOfTheDay();
    }

    public class Greeter : IGreeter
    {
        private IConfiguration _configuration;

        public Greeter(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string getMessageOfTheDay()
        {
            return _configuration["Greeting"];
        }
    }
}
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = "Hello, world";
            ILogger logger = NullLogger.Instance;
            logger.LogError($"My message: {message}"); // This should alert CA2254
        }
    }
}

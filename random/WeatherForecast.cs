using System;
using MySqlConnector;
namespace random
{
    public class WeatherForecast
    {
        /// <summary>
        /// dick
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// dicked
        /// </summary>
        public int TemperatureC { get; set; }
        /// <summary>
        /// dickster
        /// </summary>
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }
    public class WeatherForecasts
    {
        /// <summary>
        /// dick
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// dicked
        /// </summary>
        public int TemperatureC { get; set; }
        /// <summary>
        /// dickster
        /// </summary>
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }
  

namespace BlogPostApi
    {
        public class AppDb : IDisposable
        {
            public MySqlConnection Connection { get; }

            public AppDb(string connectionString)
            {
                Connection = new MySqlConnection(connectionString);
            }

            public void Dispose() => Connection.Dispose();
        }
    }
}
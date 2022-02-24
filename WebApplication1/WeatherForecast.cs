using System.Globalization;

namespace WebApplication1
{
    public class WeatherForecast
    {
        private DateTime _date;

        public DateTime Date
        {
            get
            {
                //return _date.AddMilliseconds(5);
                return _date;
            }
            set
            {
                _date = new DateTime(value.Year, value.Month, value.Day, value.Hour, value.Minute, value.Second);
                //_date = Convert.ToDateTime($"{value.Year}-{value.Month}-{value.Day}T{value.Hour}:{value.Minute}:{value.Second}", new CultureInfo("ru-Ru"));
                //_date = value.AddMilliseconds(-value.Millisecond);
            }
        }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }

        /*public WeatherForecast(string? input)
        { 
            Summary = input;
            Date = DateTime.Now;
            TemperatureC = Random.Shared.Next(-20, 55);
        }*/

    }
}
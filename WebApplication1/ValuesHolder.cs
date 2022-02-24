namespace WebApplication1
{
    public class ValuesHolder
    {
        public List<WeatherForecast> Values = new List<WeatherForecast>();

        public void Add(string inputSummary)
        {
            Add(inputSummary);
        }

        public void Add(DateTime date, string inputSummary, int inputTemperatureC)
        {
            if (date == DateTime.MinValue)
            {
                date = DateTime.Now;
            };

            if (inputSummary == null)
                inputSummary = "";

            Values.Add(new WeatherForecast { Date = date, TemperatureC = inputTemperatureC, Summary = inputSummary });
        }

        public WeatherForecast[] Get(DateTime dateFrom, DateTime dateBefore)
        {
            if (dateBefore == DateTime.MinValue) dateBefore = DateTime.Now;
            return Values.Where(f => ((f.Date >= dateFrom) & (f.Date <= dateBefore))).ToArray();
        }

    }
}

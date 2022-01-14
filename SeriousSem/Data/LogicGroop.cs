using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeriousSem.Data
{
    public class LogicGroop
    {
        public string name;
        public string surname;
        public int group;
        public string faculty;

        public LogicGroop(string name, string surname, int group, string faculty)
        {
            this.name = name;
            this.surname = surname;
            this.group = group;
            this.faculty = faculty;
        }

        public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
        {
            var rng = new Random();
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = startDate.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            }).ToArray());
        }
    }
}

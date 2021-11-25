using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.FacadePattern
{
    public class TemperatureService : ITemperatureService
    {
        public IWeatherService _weatherService { get; private set; }
        public IGeoLocationService _geoLocService { get; private set; }

        public TemperatureService(IWeatherService weatherService, IGeoLocationService geoLocService)
        {
            _weatherService = weatherService;
            _geoLocService = geoLocService;
        }

        public LocalTemperature GetTemperature(string zipCode)
        {
            Coordinates coords = _geoLocService.GetCoordinatesForZipCode(zipCode);
            string city = _geoLocService.GetCityForZipCode(zipCode);
            string state = _geoLocService.GetStateForZipCode(zipCode);

            double farenheit = _weatherService.GetTempFarenheit(coords.Latitude, coords.Longitude);
            double celcius = farenheit.FarenheitToCelcius();

            LocalTemperature localTemperature = new LocalTemperature()
            {
                Farenheit = farenheit,
                Celcius = celcius,
                City = city,
                State = state
            };

            return localTemperature;
        }
    }
}

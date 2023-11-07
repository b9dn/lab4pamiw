using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.VisualBasic.FileIO;
using Newtonsoft.Json;
using P04WeatherForecastAPI.Client.Configuration;
using P06Shop.Shared;
using P06Shop.Shared.Shop;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using P06.Shared.Films;
using P06.Shared.Services.FilmService;

namespace P04WeatherForecastAPI.Client.Services.FilmServices
{
    internal class FilmService : IFilmService
    {
        private readonly HttpClient _httpClient;
        private readonly AppSettings _appSettings;
        public FilmService(HttpClient httpClient, IOptions<AppSettings> appSettings) {
            _httpClient = httpClient;
            _appSettings = appSettings.Value;
        }

        public async Task<ServiceResponse<Film>> CreateFilmAsync(Film film) {
            var response = await _httpClient.PostAsJsonAsync(_appSettings.BaseFilmEndpoint.AddFilmAsync, film);
            var result = await response.Content.ReadFromJsonAsync<ServiceResponse<Film>>();
            return result;
        }

        public async Task<ServiceResponse<bool>> DeleteFilmAsync(int id) {
            var response = await _httpClient.DeleteAsync($"{_appSettings.BaseFilmEndpoint.DeleteFilmAsync}/{id}");
            var result = await response.Content.ReadFromJsonAsync<ServiceResponse<bool>>();
            return result;
        }


        public async Task<ServiceResponse<List<Film>>> GetFilmAsync() {
            var response = await _httpClient.GetAsync(_appSettings.BaseFilmEndpoint.GetFilmAsync);
            var json = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ServiceResponse<List<Film>>>(json);
            return result;
        }

        public async Task<ServiceResponse<Film>> UpdateFilmAsync(Film film) {
            var response = await _httpClient.PutAsJsonAsync(_appSettings.BaseFilmEndpoint.UpdateFilmAsync, film);
            var result = await response.Content.ReadFromJsonAsync<ServiceResponse<Film>>();
            return result;
        }
    }
}

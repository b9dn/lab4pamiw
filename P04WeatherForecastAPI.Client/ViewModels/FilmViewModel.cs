using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using P04WeatherForecastAPI.Client.Models;
using P04WeatherForecastAPI.Client.Services.WeatherServices;
using P06.Shared.Services.FilmService;
using P06.Shared.Films;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using P06Shop.Shared.Shop;
using P06Shop.Shared.MessageBox;

namespace P04WeatherForecastAPI.Client.ViewModels {
    public partial class FilmViewModel : ObservableObject {
        private readonly IFilmService _filmService;
        private readonly FilmDetailsView _filmDetailsView;
        private readonly IMessageDialogService _messageDialogService;
        public ObservableCollection<Film> Films { get; set; }



        [ObservableProperty]
        private Film selectedFilm;


        public FilmViewModel(IFilmService filmService, FilmDetailsView filmDetailsView, IMessageDialogService messageDialogService) {
            _messageDialogService = messageDialogService;
            _filmDetailsView = filmDetailsView;
            _filmService = filmService;
            Films = new ObservableCollection<Film>();
        }

        public async Task GetFilm() {
            Films.Clear();
            var filmResult = await _filmService.GetFilmAsync();
            if (filmResult.Success) {
                foreach (var p in filmResult.Data) {
                    Films.Add(p);
                }
            }
        }

        public async Task CreateFilm() {
            var newFilm = new Film() {
                Title = selectedFilm.Title,
                Director = selectedFilm.Director,
                Barcode = selectedFilm.Barcode,
                Price = selectedFilm.Price,
                ReleaseDate = selectedFilm.ReleaseDate,
            };

            var result = await _filmService.CreateFilmAsync(newFilm);
            if (result.Success)
                await GetFilm();
            else
                _messageDialogService.ShowMessage(result.Message);
        }

        public async Task UpdateFilm() {
            var filmToUpdate = new Film() {
                Id = selectedFilm.Id,
                Title = selectedFilm.Title,
                Director = selectedFilm.Director,
                Barcode = selectedFilm.Barcode,
                Price = selectedFilm.Price,
                ReleaseDate = selectedFilm.ReleaseDate,
            };

            await _filmService.UpdateFilmAsync(filmToUpdate);
            GetFilm();
        }

        public async Task DeleteFilm() {
            await _filmService.DeleteFilmAsync(selectedFilm.Id);
            await GetFilm();
        }

        [RelayCommand]
        public async Task ShowDetails(Film film) {
            _filmDetailsView.Show();
            _filmDetailsView.DataContext = this;
            SelectedFilm = film;
        }


        [RelayCommand]
        public async Task Save() {
            if (selectedFilm.Id == 0) {
                CreateFilm();
            }
            else {
                UpdateFilm();
            }

        }

        [RelayCommand]
        public async Task Delete() {
            DeleteFilm();
        }

        [RelayCommand]
        public async Task New() {
            _filmDetailsView.Show();
            _filmDetailsView.DataContext = this;
            SelectedFilm = new Film();
        }

    }
}

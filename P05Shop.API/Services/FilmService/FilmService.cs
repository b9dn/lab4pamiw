using P06Shop.Shared;
using P06.Shared.Services.FilmService;
using P06.Shared.Films;
using P07Film.DataSeeder;
using P05Shop.API.Models;
using P06Shop.Shared.Shop;
using Microsoft.EntityFrameworkCore;

namespace P05Shop.API.Services.FilmService {
    public class FilmService : IFilmService {
        private readonly DataContext _dataContext;
        public FilmService(DataContext context) {
            _dataContext = context;
        }

        public async Task<ServiceResponse<Film>> CreateFilmAsync(Film film) {
            try {
                _dataContext.Films.Add(film);
                await _dataContext.SaveChangesAsync();
                return new ServiceResponse<Film>() { Data = film, Success = true };
            } catch (Exception) {
                return new ServiceResponse<Film>() {
                    Data = null,
                    Success = false,
                    Message = "Cannot create film"
                };
            }

        }

        public async Task<ServiceResponse<bool>> DeleteFilmAsync(int id) {
            var film = new Film() { Id = id };
            _dataContext.Films.Attach(film);
            _dataContext.Films.Remove(film);
            await _dataContext.SaveChangesAsync();

            return new ServiceResponse<bool>() { Data = true, Success = true };
        }

        public async Task<ServiceResponse<List<Film>>> GetFilmAsync() {
            var films = await _dataContext.Films.ToListAsync();

            try {
                var response = new ServiceResponse<List<Film>>() {
                    Data = films,
                    Message = "Ok",
                    Success = true
                };

                return response;
            } catch (Exception) {
                return new ServiceResponse<List<Film>>() {
                    Data = null,
                    Message = "Problem with database",
                    Success = false
                };
            }

        }

        public async Task<ServiceResponse<Film>> UpdateFilmAsync(Film film) {
            try {
                var filmToEdit = new Film() { Id = film.Id };
                _dataContext.Films.Attach(filmToEdit);

                filmToEdit.Title = film.Title;
                filmToEdit.Director = film.Director;
                filmToEdit.Price = film.Price;
                filmToEdit.Barcode = film.Barcode;
                filmToEdit.ReleaseDate = film.ReleaseDate;

                await _dataContext.SaveChangesAsync();
                return new ServiceResponse<Film> { Data = filmToEdit, Success = true };
            } catch (Exception) {
                return new ServiceResponse<Film> {
                    Data = null,
                    Success = false,
                    Message = "An error occured while updating film"
                };
            }
        }
    }
}

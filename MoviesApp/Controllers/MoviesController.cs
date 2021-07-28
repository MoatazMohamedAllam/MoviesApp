using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoviesApp.Models;
using MoviesApp.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using NToastNotify;
using Microsoft.Extensions.Localization;

namespace MoviesApp.Controllers
{
    public class MoviesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IStringLocalizer<MoviesController> _localizer;
        private readonly IToastNotification _toastNotification;
        private List<string> _allowedExtensions = new List<string> { ".jpg", ".png" };
        private long _maxAllowedPosterSize = 1048576;
        public MoviesController(ApplicationDbContext context, 
                                IStringLocalizer<MoviesController> localizer 
                                ,IToastNotification toastNotification)
        {
            _context = context;
            _localizer = localizer;
            _toastNotification = toastNotification;
        }

        public async Task<IActionResult> Index() =>
             View(await _context.Movies.OrderByDescending(m => m.Id).ToListAsync());


        public async Task<IActionResult> Create()
        {
            var viewModel = new MovieFormViewModel
            {
                Genres = await _context.Genres.OrderBy(m => m.Name).ToListAsync()
            };

            return View("MovieForm", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(MovieFormViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                viewModel.Genres = await _context.Genres.OrderBy(m => m.Name).ToListAsync();
                return View("MovieForm", viewModel);
            }

            var files = Request.Form.Files;

            if (!files.Any())
            {
                viewModel.Genres = await _context.Genres.OrderBy(m => m.Name).ToListAsync();
                ModelState.AddModelError("Poster", "Please select movie poster");
                return View("MovieForm", viewModel);
            }

            var poster = files.FirstOrDefault();

             await ValidatePoster(viewModel, poster);

            //if (!_allowedExtensions.Contains(Path.GetExtension(poster.FileName).ToLower()))
            //{
            //    viewModel.Genres = await _context.Genres.OrderBy(m => m.Name).ToListAsync();
            //    ModelState.AddModelError("Poster", "only .png, .jpg are allowed");
            //    return View("MovieForm", viewModel);
            //}

            //if(poster.Length > _maxAllowedPosterSize)
            //{
            //    viewModel.Genres = await _context.Genres.OrderBy(m => m.Name).ToListAsync();
            //    ModelState.AddModelError("Poster", "Poster can not be more than 1 MB");
            //    return View("MovieForm", viewModel);
            //}

            using var dataStream = new MemoryStream();

            await poster.CopyToAsync(dataStream);

            var movie = new Movie
            {
                Title = viewModel.Title,
                Storeline = viewModel.Storeline,
                Rate = viewModel.Rate,
                GenreId = viewModel.GenreId,
                Year = viewModel.Year,
                Poster = dataStream.ToArray()
            };

            _context.Movies.Add(movie);
            await _context.SaveChangesAsync();

            _toastNotification.AddSuccessToastMessage("Movie Added Successfully");

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return BadRequest();

            var movie = await _context.Movies.FindAsync(id);
            
            if (movie == null)
                return BadRequest();

            var viewModel = new MovieFormViewModel
            {
                Id = movie.Id,
                Title = movie.Title,
                GenreId = movie.GenreId,
                Rate = movie.Rate,
                Year = movie.Year,
                Storeline = movie.Storeline,
                Poster = movie.Poster,
                Genres = await _context.Genres.OrderBy(m => m.Name).ToListAsync()
            };

            return View("MovieForm", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(MovieFormViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                viewModel.Genres = await _context.Genres.OrderBy(m => m.Name).ToListAsync();
                return View("MovieForm", viewModel);
            }

            var movie = await _context.Movies.FindAsync(viewModel.Id);
            
            if (movie == null)
                return NotFound();

            var files = Request.Form.Files;
            if (files.Any())
            {
                var poster = files.FirstOrDefault();
                using var dataStream = new MemoryStream();
                await poster.CopyToAsync(dataStream);

                viewModel.Poster = dataStream.ToArray();

                await ValidatePoster(viewModel, poster);

                movie.Poster = dataStream.ToArray();
            }

            movie.Title = viewModel.Title;
            movie.Rate = viewModel.Rate;
            movie.Year = viewModel.Year;
            movie.Storeline = viewModel.Storeline;
            movie.GenreId = viewModel.GenreId;

            await _context.SaveChangesAsync();

            _toastNotification.AddSuccessToastMessage("Movie Edit Successfully");

            return RedirectToAction(nameof(Index));

        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return BadRequest();
            
            var movie = await _context.Movies.Include(m => m.Genre).SingleOrDefaultAsync(m => m.Id == id);

            if (movie == null)
                return NotFound();

            return View(movie);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return BadRequest();

            var movie = await _context.Movies.SingleOrDefaultAsync(m => m.Id == id);

            if (movie == null)
                return NotFound();

            _context.Movies.Remove(movie);
            await _context.SaveChangesAsync();

            return Ok();
        }



        private async Task<IActionResult> ValidatePoster(MovieFormViewModel viewModel, IFormFile file)
        {
            if (!_allowedExtensions.Contains(Path.GetExtension(file.FileName).ToLower()))
                ModelState.AddModelError("Poster", "only .png, .jpg are allowed");
            
            if (file.Length > _maxAllowedPosterSize)
                ModelState.AddModelError("Poster", "Poster can not be more than 1 MB");
          

            viewModel.Genres = await _context.Genres.OrderBy(m => m.Name).ToListAsync();
            return View("MovieForm", viewModel);

        }

    }
}

using Bookstore.Data;
using Bookstore.Domain;
using Bookstore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Controllers
{
    public class BooksController : Controller
    {
        private readonly ApplicationDbContext context;

        public BooksController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Create(BookCreateViewModel bindingModel)
        {
            if (ModelState.IsValid)
            {
                Book bookFromDb = new Book
                {
                    BookName = bindingModel.BookName,
                    Author = bindingModel.Author,
                    Genre = bindingModel.Genre,
                    Picture = bindingModel.Picture,
                    YearOfPublication = bindingModel.YearOfPublication,
                    Price = bindingModel.Price,
                };

                context.Books.Add(bookFromDb);
                context.SaveChanges();

                return this.RedirectToAction("Success");
            }
            return this.View();
        }
        public IActionResult Success()
        {
            return this.View();
        }
        //public IActionResult All()
        //{
        //    List<DogAllViewModel> dogs = context.Dogs
        //        .Select(dogFrpmDb => new DogAllViewModel

        //        {
        //            Id = dogFrpmDb.Id,
        //            Name = dogFrpmDb.Name,
        //            Age = dogFrpmDb.Age,
        //            Breed = dogFrpmDb.Breed,
        //            Picture = dogFrpmDb.Picture

        //        }
        //         ).ToList();

        //    return View(dogs);
        //}

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Book item = context.Books.Find(id);
            if (item == null)
            {
                return NotFound();
            }

            BookCreateViewModel dog = new BookCreateViewModel()
            {
                BookName = item.BookName,
                Author = item.Author,
                Genre = item.Genre,
                Picture = item.Picture,
                YearOfPublication = item.YearOfPublication,
                Price = item.Price,

            };
            return View();


        }

        [HttpPost]
        public IActionResult Edit(BookCreateViewModel bindingModel)
        {
            if (ModelState.IsValid)
            {
                Book book = new Book
                {
                    BookName = bindingModel.BookName,
                    Author = bindingModel.Author,
                    Genre = bindingModel.Genre,
                    Picture = bindingModel.Picture,
                    YearOfPublication = bindingModel.YearOfPublication,
                    Price = bindingModel.Price,
                };

                context.Books.Update(book);
                context.SaveChanges();
                return this.RedirectToAction("All");
            }

            return View(bindingModel);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Book item = context.Books.Find(id);
            if (item == null)
            {
                return NotFound();
            }

            BookCreateViewModel dog = new BookCreateViewModel()
            {

                BookName = item.BookName,
                Author = item.Author,
                Genre = item.Genre,
                Picture = item.Picture,
                YearOfPublication = item.YearOfPublication,
                Price = item.Price,

            };
            return View();

        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            Book item = context.Books.Find(id);

            if (item == null)
            {
                return NotFound();
            }

            context.Books.Remove(item);
            context.SaveChanges();
            return this.RedirectToAction("All", "Books");
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Book item = context.Books.Find(id);
            if (item == null)
            {
                return NotFound();
            }

            BookCreateViewModel dog = new BookCreateViewModel()
            {
                BookName = item.BookName,
                Author = item.Author,
                Genre = item.Genre,
                Picture = item.Picture,
                YearOfPublication = item.YearOfPublication,
                Price = item.Price,

            };
            return View();

        }

        public IActionResult All(string searchStringGenre, string searchStringBookName)
        {
            List<BookAllViewModel> books = context.Books
                .Select(bookFromDb => new BookAllViewModel
                {
                    BookName = bookFromDb.BookName,
                    Author = bookFromDb.Author,
                    Genre = bookFromDb.Genre,
                    Picture = bookFromDb.Picture,
                    YearOfPublication = bookFromDb.YearOfPublication,
                    Price = bookFromDb.Price,
                })
                .ToList();
            if (!String.IsNullOrEmpty(searchStringGenre) && !String.IsNullOrEmpty(searchStringBookName))
            {
                books = books.Where(d => d.Genre.Contains(searchStringGenre) && d.BookName.Contains(searchStringBookName)).ToList();

            }
            else if (!String.IsNullOrEmpty(searchStringGenre))
            {
                books = books.Where(d => d.Genre.Contains(searchStringGenre)).ToList();
            }
            else if (!String.IsNullOrEmpty(searchStringGenre))
            {


                books = books.Where(d => d.BookName.Contains(searchStringBookName)).ToList();
            }
            return this.View(books);
        }
    }
}



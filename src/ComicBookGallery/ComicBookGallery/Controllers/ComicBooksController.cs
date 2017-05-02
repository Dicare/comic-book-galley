using ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            var comicBook = new ComicBook()
            {
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 700,
                DescriptionHtml = "<p>Final issue! Witness the final hours of Doctor Octopus's life and his one, last, great act of revenge! Even if Spider-Man suvives...<strong>will Peter Parker?</strong></p>",
                Artists = new Artist[]
               {
                   new Artist(){ Name="Dan Slott",Role = "Script"},
                   new Artist(){ Name="Humber Ramos",Role = "Pencils"},
                   new Artist(){ Name="Victor Olazada",Role ="Inks"},
                   new Artist(){ Name="Edgar Delgado",Role ="Colors"},
                   new Artist(){ Name="Hector Eliopoulos",Role = "Letters"}
               }
            };
            return View(comicBook );
        }
    }
}
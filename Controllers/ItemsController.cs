using DSCEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace DSCEntity.Controllers
{
    public class ItemsController : Controller
    {
        private ApplicationDbContext context;

        public ItemsController()
        {
            context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            context.Dispose();
        }

        // GET: Items
        public ActionResult Index()
        {
            List<ItemModel> items = context.Items.ToList();

            return View("Index", items);
        }

        public ActionResult Details(int id)
        {
            

            return View("Details");
        }

        public ActionResult Create()
        {
            return View("ItemForm");
        }
        public ActionResult Edit(int id)
        {
            

            return View("ItemForm");
        }
        public ActionResult Delete(int id)
        {
           


            return View("Index");
        }

        public ActionResult ProcessCreate(ItemModel itemModel)
        {
           

            return View("Details", itemModel);
        }

        public ActionResult SearchForm()
        {
            return View("SearchForm");
        }

        public ActionResult SearchForName(string searchPhrase)
        {
            // get a list of search results from the DB.



            return View("Index");
        }
        public ActionResult SearchForDescription(string searchPhrase)
        {
            // get a list of search results from the DB.



            return View("Index");
        }


    }
}
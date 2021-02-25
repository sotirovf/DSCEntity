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
        // GET: Items
        public ActionResult Index()
        {
            

            return View("Index", items);
        }

        public ActionResult Details(int id)
        {
            

            return View("Details", item);
        }

        public ActionResult Create()
        {
            return View("ItemForm");
        }
        public ActionResult Edit(int id)
        {
            

            return View("ItemForm", item);
        }
        public ActionResult Delete(int id)
        {
           

            List<ItemModel> items = itemDAO.FetchAll();

            return View("Index", items);
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

            ItemDAO itemDAO = new ItemDAO();

            List<ItemModel> searchResults = itemDAO.SearchForName(searchPhrase);

            return View("Index", searchResults);
        }
        public ActionResult SearchForDescription(string searchPhrase)
        {
            // get a list of search results from the DB.

            ItemDAO itemDAO = new ItemDAO();

            List<ItemModel> searchResults = itemDAO.SearchForName(searchPhrase);

            return View("Index", searchResults);
        }


    }
}
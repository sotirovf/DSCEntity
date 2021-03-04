using DSCEntity.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
            ItemModel item = context.Items.SingleOrDefault(i => i.Id == id);

            return View("Details", item);
        }

        public ActionResult Create()
        {
            return View("ItemForm", new ItemModel());
        }
        public ActionResult Edit(int id)
        {
            ItemModel item = context.Items.SingleOrDefault(i => i.Id == id);

            return View("ItemForm", item);
        }

        public ActionResult Delete(int id)
        {
            ItemModel item = context.Items.SingleOrDefault(i => i.Id == id);

            context.Entry(item).State = EntityState.Deleted;

            context.SaveChanges();

            return Redirect("/Items");
        }

        [HttpPost]
        public ActionResult ProcessCreate(ItemModel itemModel)
        {
            ItemModel item = context.Items.SingleOrDefault(i => i.Id == itemModel.Id);

            // TO DO: Fix: instead of updating existing item it creates a new one currently.
            // edit
            if (item != null)
            {
                item.Name = itemModel.Name;
                item.Type = itemModel.Type;
                item.Size = itemModel.Size;
                item.Price = itemModel.Price;
                item.Description = itemModel.Description;
            }
            else
            {
                context.Items.Add(itemModel);
            }

            context.SaveChanges();

            return View("Details", itemModel);
        }

        public ActionResult SearchForm()
        {
            return View("SearchForm");
        }

        public ActionResult SearchForName(string searchPhrase)
        {
            // get a list of search results from the DB.

            // this is LINQ statement
            var items = from i in context.Items
                        where i.Name.Contains(searchPhrase)
                        select i;


            return View("Index", items);
        }
        public ActionResult SearchForDescription(string searchPhrase)
        {
            // get a list of search results from the DB.

            // this is LINQ statement
            var items = from i in context.Items
                        where i.Description.Contains(searchPhrase)
                        select i;

            return View("Index", items);

        }


    }
}
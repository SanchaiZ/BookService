using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;

namespace BookStore.Controllers
{
    public class BooksController : Controller
    {

        // GET: /Books
        public ActionResult Index(string start="0",string end="100000")
        {
            float sp = float.Parse(start);
            float ep = float.Parse(end);
            Read(sp,ep);

            return View();
        }

        // Get: /Books/new/
        public ActionResult New(string submit)
        {
 
            return View();
        }

        // Get : /Books/Edit
        public ActionResult Edit(string id , string isbn10, string isbn13, string title, string author, string year, string category, string price)
        {

            ViewBag.id = id;
            ViewBag.isbn13 = isbn13;
            ViewBag.title_ = title;
            ViewBag.isbn10 = isbn10;
            ViewBag.author = author;
            ViewBag.year = year;
            ViewBag.category = category;
            ViewBag.price = price;
            return View();
        }



        public ActionResult Update(string id , string name , string value)
        {
            BookCRUD.BookCRUDSoapClient client = new BookCRUD.BookCRUDSoapClient("BookCRUDSoap");
            client.Update_Element(Int32.Parse(id),name,value);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(string id)
        {
            BookCRUD.BookCRUDSoapClient client = new BookCRUD.BookCRUDSoapClient("BookCRUDSoap");
            client.Delete(Int32.Parse(id));
            return RedirectToAction("Index");
        }

        public ActionResult Save(string isbn10,string isbn13,string title,string author,string year,string category,string price)
        {
            BookCRUD.BookCRUDSoapClient client = new BookCRUD.BookCRUDSoapClient("BookCRUDSoap");
            client.InsertAll(title,price, author, year, category, isbn10, isbn13);
            return RedirectToAction("Index");
            }


       public ActionResult Findid(string id)
        {
            BookCRUD.BookCRUDSoapClient client = new BookCRUD.BookCRUDSoapClient("BookCRUDSoap");
            object result = client.ReadByID(Int32.Parse(id));
            XDocument read = XDocument.Parse(result.ToString()); // Create object XDocument is read for object is gotten to string
            string id_ = "";
            string price = "";
            string isbn_13 = "";
            string isbn_10 = "";
            string title = "";
            string author = "";
            string year = "";
            string category = "";

            id_ = read.Element("book").Attribute("ID").Value.ToString();
            price = read.Elements("book").Where(x => (string)x.Attribute("ID") == id).Elements("Price").Single().Value;
            isbn_13 = read.Elements("book").Where(x => (string)x.Attribute("ID") == id).Elements("ISBN-13").Single().Value.ToString();
            isbn_10 = read.Elements("book").Where(x => (string)x.Attribute("ID") == id).Elements("ISBN-10").Single().Value.ToString();
            title = read.Elements("book").Where(x => (string)x.Attribute("ID") == id).Elements("Title").Single().Value.ToString();
            author = read.Elements("book").Where(x => (string)x.Attribute("ID") == id).Elements("Author").Single().Value.ToString();
            year = read.Elements("book").Where(x => (string)x.Attribute("ID") == id).Elements("Year").Single().Value.ToString();
            category = read.Elements("book").Where(x => (string)x.Attribute("ID") == id).Elements("Category").Single().Value.ToString();
            ViewBag.id = id_;
            ViewBag.isbn13 = isbn_13;
            ViewBag.title_ = title;
            ViewBag.isbn10 = isbn_10;
            ViewBag.author = author;
            ViewBag.year = year;
            ViewBag.category = category;
            ViewBag.price = price;

            return View();
        }

        public void Read(float price_strat, float price_end)
        {
            BookCRUD.BookCRUDSoapClient client = new BookCRUD.BookCRUDSoapClient("BookCRUDSoap");
            object result = client.Read();
            DataTable dt = new DataTable(); // Create source for create table

            XDocument read = XDocument.Parse(result.ToString()); // Create object XDocument is read for object is gotten to string
            var count = read.Element("bookstore").Descendants(); // notice count variable for count element of bookstore

            ArrayList isbn13_list = new ArrayList();
            ArrayList isbn10_list = new ArrayList();
            ArrayList title_list_ = new ArrayList();
            ArrayList author_list = new ArrayList();
            ArrayList year_list = new ArrayList();
            ArrayList category_list = new ArrayList();
            ArrayList price_list = new ArrayList();
            ArrayList id_list = new ArrayList();
            // Read element of bookstore
            foreach (XElement item in count)
            {
                if (item.Name == "book") //check element == book ?
                {
                    string id = item.Attribute("ID").Value.ToString();
                    string price = read.Elements("bookstore").Elements("book").Where(x => (string)x.Attribute("ID") == id).Elements("Price").Single().Value;
                    float price_float = float.Parse(price);
                    if (price_float >= price_strat && price_float <= price_end)
                    {

                        
                        string isbn_13 = read.Elements("bookstore").Elements("book").Where(x => (string)x.Attribute("ID") == id).Elements("ISBN-13").Single().Value.ToString();
                        string isbn_10 = read.Elements("bookstore").Elements("book").Where(x => (string)x.Attribute("ID") == id).Elements("ISBN-10").Single().Value.ToString();
                        string title = read.Elements("bookstore").Elements("book").Where(x => (string)x.Attribute("ID") == id).Elements("Title").Single().Value.ToString();
                        string author = read.Elements("bookstore").Elements("book").Where(x => (string)x.Attribute("ID") == id).Elements("Author").Single().Value.ToString();
                        string year = read.Elements("bookstore").Elements("book").Where(x => (string)x.Attribute("ID") == id).Elements("Year").Single().Value.ToString();
                        string category = read.Elements("bookstore").Elements("book").Where(x => (string)x.Attribute("ID") == id).Elements("Category").Single().Value.ToString();
                        //price = read.Elements("bookstore").Elements("book").Where(x => (string)x.Attribute("ID") == id).Elements("Price").Single().Value;

                        id_list.Add(id);
                        isbn13_list.Add(isbn_13); // add data of a books
                        isbn10_list.Add(isbn_10);
                        title_list_.Add(title);
                        author_list.Add(author);
                        year_list.Add(year);
                        category_list.Add(category);
                        price_list.Add(price);
                    }
                }

            }
            ViewBag.id = id_list;
            ViewBag.isbn13 = isbn13_list;
            ViewBag.title_ = title_list_;
            ViewBag.isbn10 = isbn10_list;
            ViewBag.author = author_list;
            ViewBag.year = year_list;
            ViewBag.category = category_list;
            ViewBag.price = price_list;
        }

    }

    
}
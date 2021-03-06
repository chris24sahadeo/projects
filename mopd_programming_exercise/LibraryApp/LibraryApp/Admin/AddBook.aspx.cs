﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LibraryApp.Models;

namespace LibraryApp.Admin
{
    public partial class AddBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void addBookForm_InsertItem()
        {
            var item = new LibraryApp.Models.book();
            TryUpdateModel(item);
            if (ModelState.IsValid)
            {
                // Save changes here
                using (LibraryContext __db = new LibraryContext())
                {
                    __db.books.Add(item);
                    __db.SaveChanges();
                }
            }
        }

        protected void addBookForm_ItemInserted(object sender, FormViewInsertedEventArgs e)
        {
            Response.Redirect("~/Admin/Books");
        }

        protected void cancelButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Admin/Books");
        }
    }
}
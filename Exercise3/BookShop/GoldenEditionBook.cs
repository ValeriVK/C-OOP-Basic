﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop
{
   public class GoldenEditionBook : Book
    {
        public GoldenEditionBook(string author, string title, decimal price) 
                          : base(author, title, price)
        {

        }

        protected override decimal Price
        {
            get
            {
                return base.Price * 1.3m;
            }           
        }

    }
}

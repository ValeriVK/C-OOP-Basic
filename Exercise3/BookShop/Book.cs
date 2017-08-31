using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BookShop
{
    public class Book
    {        
        private string author;
        private string title;
        private decimal price;
        public Book(string author, string title, decimal price)
        {
            this.Author = author;
            this.Title = title;
            this.Price = price;
        }

        protected string Author
        {
            get { return this.author; }
            set
            {
                if (!IsValidAuthor(value))
                {
                    throw new ArgumentException($"{nameof(Author)} not valid!");
                }
                this.author = value;
            }
        }


        protected string Title
        {
            get { return this.title; }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException($"{nameof(Title)} not valid!");
                }
                this.title = value;
            }
        }
        protected virtual decimal Price
        {
            get { return this.price; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(Price)} not valid!");
                }
                this.price = value;
            }
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("Type: ").AppendLine(this.GetType().Name)
                .Append("Title: ").AppendLine(this.Title)
                .Append("Author: ").AppendLine(this.Author)
                .Append("Price: ").Append($"{this.Price:f1}")
                .AppendLine();

            return sb.ToString();
        }
        private bool IsValidAuthor(string name)
        {
            bool isValid = true;

            if (Regex.IsMatch(name, @"(\w+ [^a-zA-Z]\w+)"))
            {
                isValid = false;
            }
            return isValid;
        }


    }
}

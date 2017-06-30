using System;
using System.Text;


namespace BookShop
{
    public class Book
    {
        private string author;
        private string title;
        private double price;

        public Book(string author, string title, double price)
        {
            this.Author = author;
            this.Title = title;
            this.Price = price;
        }

        public string Author
        {
            get { return this.author; }
            set
            {
                string[] authorName = value.Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries);
                if (authorName.Length > 1 && char.IsDigit(authorName[1][0]))
                    throw new ArgumentException("Author not valid!");
                this.author = value;
            }
        }

        public string Title
        {
            get { return this.title; }
            set
            {
                if (value.Length < 3)
                    throw new ArgumentException("Title not valid!");
                this.title = value;
            }
        }

        public virtual double Price
        {
            get { return this.price; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Price not valid!");
                this.price = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Type: ").Append(this.GetType().Name)
                .Append(Environment.NewLine)
                .Append("Title: ").Append(this.Title)
                .Append(Environment.NewLine)
                .Append("Author: ").Append(this.Author)
                .Append(Environment.NewLine)
                .Append(String.Format("Price: {0:f1}", this.Price))
                .Append(Environment.NewLine);
            
            return sb.ToString();
        }
                
    }
}

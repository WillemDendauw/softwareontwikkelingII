﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheek.Item
{
    public class Article : LibraryItem
    {
        private int startPage, lastPage;

        public Article(string author, string title, int startPage, int lastPage) : base(title)
        {
            Author = author;
            this.startPage = startPage;
            this.lastPage = lastPage;
        }

        public string Author { get; }

        public int NumberOfPages
        {
            get { 
                return lastPage - startPage + 1;
            }
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

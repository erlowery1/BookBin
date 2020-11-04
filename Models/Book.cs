namespace api.Models
{
    public class Book
    {
        public string Title {get;set;}
        public string Author {get;set;}
        public int Isbn {get;set;}
        public string Genre{get;set;}
        public int Id{get;set;}

        public override string ToString(){
            return "Title: {0}; Author: {1}, ISBN: {2}, Genre {3}; ID: {4}" Title, Author, Isbn, Genre, Id;
        }
    }
}
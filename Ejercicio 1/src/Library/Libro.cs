using System;
using System.Collections.Generic;

namespace SRP
{
    public class Book
    {

        public string Title { get ; }
        public string Author { get ; }
        public string Code { get ;  }
        public string LibrarySector { get ; set; }
        public string LibraryShelve { get ; set; }

        public List<string> titleList { get; set; }

        public Book(String title, String author, String code)
        {
            
            this.Title = title;
            this.Author = author;
            this.Code = code;

    
           
        }
 
    

    }

    public class Shelve 
    {
        public string Name{get; set;}
        public int Capacidad {get; set;}
        public List<Book> Libros {get; set;} //creo lista libros con el objeto libro adentro

        public Shelve (int capacidad)
        {
            Libros=new List<Book>(); //<Book> porque la lista va a contener solo elementos de tipo Book
            Capacidad = capacidad;
        }
        public void AddBook(Book book)
        {
            if (Libros.Count < Capacidad) //.Count, propiedad que cuenta la cantidad de cosas de una lista 
            {
                Libros.Add(book);
            }
            else
            {
                Console.WriteLine("La estantería esta llena");
            }
        }
    }

   public class Sector
   {
        public string Name{get; set;}
        public List<Shelve> Shelves {get; set;}

        public Sector(string name)
        {
            Name = name;
            Shelves = new List<Shelve>();
        }
        public void addShelve(Shelve shelve)
        {
            Shelves.Add(shelve);
        }
        public Shelve findShelve(string shelveName)
        {
            foreach (Shelve shelve in Shelves)
            {
                if (shelve.Name == shelveName)
                {
                    return shelve;
                }
                

            }
            return null;
        }
      
        
   }

    
    
   

}

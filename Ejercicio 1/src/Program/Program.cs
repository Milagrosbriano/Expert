using System;

namespace SRP
{

    class Program
    {
        static void Main()
        {   //crear los dos libros 
            Book book1 = new Book("Design Patterns","Erich Gamma & Others","001-034");
            Book book2 = new Book("Pro C#","Troelsen","001-035");
            
            //agregar los libros a la estanteria 
            var shelve1 = new Shelve(2); 
            shelve1.AddBook(book1);
            shelve1.AddBook(book2);

            //sector 
            Sector sectorA = new Sector("Sector A");
            //agregar estanteria en el sector A
            sectorA.addShelve(shelve1);
            //buscar estanteria por el nombre
            Shelve encontar = sectorA.findShelve("shelve1");

            if (encontar == null)
            {
                Console.WriteLine("No se encontró la estantería");
            }
           
                    

        }
    }
}
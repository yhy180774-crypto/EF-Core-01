using EF_Core_01.DbContext;

namespace EF_Core_01
{
    using Microsoft.EntityFrameworkCore;
    internal class Program
    {
      
            static void Main(string[] args)
            {
                using (var context = new BookStoreContext())
                {
                    context.Database.EnsureCreated();

                    if (context.Database.CanConnect())
                    {
                        Console.WriteLine("Database Created Successfully!");

                        Console.WriteLine("Books Table: " +
                            context.Books.Count());

                        Console.WriteLine("Authors Table: " +
                            context.Authors.Count());

                        Console.WriteLine("Categories Table: " +
                            context.Categories.Count());
                    }
                    else
                    {
                        Console.WriteLine("Database Connection Failed!");
                    }
                }

                Console.ReadKey();
            }
        }

    }
    

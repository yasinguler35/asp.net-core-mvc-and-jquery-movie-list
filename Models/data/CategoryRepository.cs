using System.Collections.Generic;
using System.Linq;
using mvc_movie.Models;

namespace mvc_movie.Data
{
    public class CategoryRepository
    {
                private static List<Category> _category=null;

        static CategoryRepository()
        {
             _category=new List<Category>()
             {
                     new Category(){
                      Id=1,
                      Name="Macera",
   
                     },
                        new Category(){
                      Id=2,
                      Name="Romantik", 
                     },
                          new Category(){
                      Id=3,
                      Name="Bilim Kurgu",
  
                     },
                        new Category(){
                      Id=4,
                      Name="Komedi",
  
                     }
             };
        }

        public static List<Category> Categories
        {
                get{
                     return _category;
                }
        }

        public static void AddCategory(Category entity)
        {
             _category.Add(entity);
        }

         public static Category GetById(int Id){
             return _category.FirstOrDefault(i=>i.Id==Id);
         }
    }
}
using System.Collections.Generic;
using System.Linq;
using mvc_movie.Models;

namespace mvc_movie.Data
{
    public static class MovieRepository
    {
        private static List<Movie> _movies=null;

        static MovieRepository()
        {
             _movies=new List<Movie>()
             {
                     new Movie(){
                      Id=1,
                      Name="Arog",
                      Description="Bilim Kurgu",
                      ImageUrl="1.jpg",
                      CategoryId=3   
                     },
                        new Movie(){
                      Id=2,
                      Name="Aşk Tesadüfleri Sever",
                      Description="Romantik",
                      ImageUrl="2.jpg",
                      CategoryId=2     
                     },
                          new Movie(){
                      Id=3,
                      Name="3 Idiots",
                      Description="Komedi",
                      ImageUrl="1.jpg",
                      CategoryId=4   
                     },
                        new Movie(){
                      Id=4,
                      Name="Aquaman",
                      Description="Macera",
                      ImageUrl="4.jpg",
                      CategoryId=1    
                     }
             };
        }

        public static List<Movie> Moives
        {
                get{
                     return _movies;
                }
        }

        public static void AddMoives(Movie entity)
        {
             _movies.Add(entity);
        }

         public static Movie GetById(int Id){
             return _movies.FirstOrDefault(i=>i.Id==Id);
         }
    } 
}
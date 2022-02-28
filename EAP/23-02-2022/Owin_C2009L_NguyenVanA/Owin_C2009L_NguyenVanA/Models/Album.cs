using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Owin_C2009L_NguyenVanA.Models
{
    public class Album
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public double Price { get; set; }
        public static Album Input() {
            try
            {
                Console.WriteLine("Enter Album's ID");
                int albumId = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter album's title:");
                string albumTitle = Console.ReadLine();

                Console.WriteLine("Enter album's Genre:");
                string albumGenre = Console.ReadLine();

                Console.WriteLine("Enter album's Price:");
                double albumPrice = Convert.ToDouble(Console.ReadLine());
                return new Album
                {
                    Id = albumId,
                    Title = albumTitle,
                    Genre = albumGenre,
                    Price = albumPrice
                };
            }
            catch (Exception e) {
                Console.WriteLine($"cannot create album: {e.Message}");
                return null;
            }

            
        }
    }
}

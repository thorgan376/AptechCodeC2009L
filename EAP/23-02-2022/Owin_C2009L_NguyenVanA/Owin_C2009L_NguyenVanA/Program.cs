using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin.Hosting;
using System;
using System.Net.Http;
using Newtonsoft.Json;
using Owin_C2009L_NguyenVanA.Models;

namespace Owin_C2009L_NguyenVanA
{
    public class Program
    {        
        static void Main(string[] args)
        {            
            // Start OWIN host 
            using (WebApp.Start<Startup>(url: ApiClient.baseAddress))
            {

                int choice = 0;
                ApiClient apiClient = new ApiClient();  
                while (choice != 5) {
                    Console.WriteLine("Enter your choice: ");
                    Console.WriteLine("1.Show all albums");
                    Console.WriteLine("2.Insert album");
                    Console.WriteLine("3.Update an album");
                    Console.WriteLine("4.Delete an album");
                    Console.WriteLine("5.Exit");
                    Console.WriteLine("Enter your choice:");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice) { 
                        case 1: {
                                apiClient.GetAllAlbums();
                                break;
                            }
                        case 2:
                            {
                                Album album = Album.Input();
                                if (album != null) {
                                    apiClient.InsertAlbum(album);
                                }
                                
                                break;
                            }
                        case 3:
                            {
                                Album album = Album.Input();
                                if (album != null)
                                {
                                    apiClient.UpdateAlbum(album);
                                }

                                break;
                            }

                        case 4:
                            {
                                Console.WriteLine("Enter album's id: ");
                                int albumId = Convert.ToInt32(Console.ReadLine());
                                apiClient.DeleteAlbumById(albumId);
                                break;
                            }

                        default:
                            Console.WriteLine("Enter 1 - 5");
                            break;
                    }
                }
                Console.ReadLine();             
            }
        }
    }
}

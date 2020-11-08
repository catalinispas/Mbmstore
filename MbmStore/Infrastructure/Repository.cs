
using MbmStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Infrastructure
{
    public static class Repository
    {
        public static List<Product> Products = new List<Product>();
        public static List<Invoice> Invoices = new List<Invoice>();


        static Repository()
        {

            // Books
            Book book = new Book();
            book.ProductID = 1;
            book.Title = "A Hard Day's Write: The Stories Behind Every Beatles Song ";
            book.Author = "Steve Turner";
            book.Price = 150.00M;
            book.Publisher = "It Books";
            book.Published = 2005;
            book.ISBN = "978-0060844097";
            book.ImageUrl = "A_Hard_Days_Write.jpg";
            Products.Add(book);
            book.Category = "Book";

            Book book2 = new Book(2, "Georg Martin", "With a Little Help from My Friends: The Making of Sgt. Pepper", 180.00M, 1995);
            book2.ProductID = 1;
            book2.Title = "A Hard Day's Write: The Stories Behind Every Beatles Song ";
            book2.Author = "Steve Turner";
            book.Price = 150.00M;

            book2.Publisher = "Little Brown & Co";
            book2.ISBN = "0316547832";
            book2.ImageUrl = "The Making of Sgt. Pepper.jpg";
            Products.Add(book2);
            book2.Category = "Book";


            // MusicCDs
            MusicCD cd = new MusicCD();
            cd.Title = "Abbey Road (Remastered)";
            cd.ProductID = 3;
            cd.Artist = "Beatles";
            cd.Price = 128.00M;
            cd.Released = 2009;
            cd.Label = "EMI";
            cd.ImageUrl = "abbey_road.jpg";
            cd.Category = "MusicCD";
            cd.AddTrack(new Track("Come Together", new TimeSpan(0, 4, 20), "Lennon, McCartney"));
            cd.AddTrack(new Track("Something", new TimeSpan(0, 3, 03), "Harrison"));
            cd.AddTrack(new Track("Maxwell's Silver Hammer", new TimeSpan(0, 3, 29), "Lennon, McCartney"));
            cd.AddTrack(new Track("Oh! Darling", new TimeSpan(0, 3, 26), "Lennon, McCartney"));
            cd.AddTrack(new Track("Octopus's Garden", new TimeSpan(0, 2, 51), "Starkey"));
            cd.AddTrack(new Track("I Want You (She's So Heavy)", new TimeSpan(0, 7, 47), "Lennon, McCartney"));
            cd.AddTrack(new Track("Here Comes The Sun", new TimeSpan(0, 3, 05), "Harrison"));
            cd.AddTrack(new Track("Because", new TimeSpan(0, 2, 45), "Lennon, McCartney"));
            cd.AddTrack(new Track("You Never Give Me Your Money", new TimeSpan(0, 4, 02), "Lennon, McCartney"));
            cd.AddTrack(new Track("Sun King", new TimeSpan(0, 2, 26), "Lennon, McCartney"));
            cd.AddTrack(new Track("Mean Mr. Mustard", new TimeSpan(0, 1, 6), "Lennon, McCartney"));
            cd.AddTrack(new Track("Polythene Pam", new TimeSpan(0, 1, 12), "Lennon, McCartney"));
            cd.AddTrack(new Track("She Came In Through The Bathroom Window", new TimeSpan(0, 1, 57), "Lennon, McCartney"));
            cd.AddTrack(new Track("Golden Slumbers", new TimeSpan(0, 1, 31), "Lennon, McCartney"));
            cd.AddTrack(new Track("Carry That Weight", new TimeSpan(0, 1, 36), "Lennon, McCartney"));
            cd.AddTrack(new Track("The End", new TimeSpan(0, 2, 19), "Lennon, McCartney"));
            cd.AddTrack(new Track("Her Majesty", new TimeSpan(0, 0, 23), "Lennon, McCartney"));
            Products.Add(cd);
           

            MusicCD cd2 = new MusicCD(4, "The Beatles", "Revolver (Remastered)", 128.00M, 2009);
            cd2.Label = "EMI";
            cd2.ImageUrl = "revolver.jpg";
            cd2.Category = "MusicCD";

            Track track01 = new Track("Taxman", new TimeSpan(0, 2, 28));
            track01.Composer = "Harrison";
            cd2.AddTrack(track01);

            Track track02 = new Track("Eleanor Rigby", new TimeSpan(0, 2, 6), "Lennon, McCartney");
            track02.Composer = "Lennon, McCartney";
            cd2.AddTrack(track02);

            Track track03 = new Track("I'm Only Sleeping", new TimeSpan(0, 3, 0), "Lennon, McCartney");
            track03.Composer = "Lennon, McCartney";
            cd2.AddTrack(track03);

            Track track04 = new Track("Love You To", new TimeSpan(0, 2, 59));
            track04.Composer = "Harrison";
            cd2.AddTrack(track04);

            Track track05 = new Track("Here, There And Everywhere", new TimeSpan(0, 2, 23));
            track05.Composer = "Harrison";
            cd2.AddTrack(track05);

            Track track06 = new Track("Yellow Submarine", new TimeSpan(0, 2, 38));
            track06.Composer = "Lennon, McCartney";
            cd2.AddTrack(track06);

            Track track07 = new Track("She Said She Said", new TimeSpan(0, 2, 36));
            track07.Composer = "Lennon, McCartney";
            cd2.AddTrack(track07);

            Track track08 = new Track("Good Day Sunshine", new TimeSpan(0, 2, 9));
            track08.Composer = "Lennon, McCartney";
            cd2.AddTrack(track08);

            Track track09 = new Track("And Your Bird Can Sing", new TimeSpan(0, 2, 0));
            track09.Composer = "Lennon, McCartney";
            cd2.AddTrack(track09);

            Track track10 = new Track("For No One", new TimeSpan(0, 1, 59));
            track10.Composer = "Lennon, McCartney";
            cd2.AddTrack(track10);

            Track track11 = new Track("Doctor Robert", new TimeSpan(0, 1, 14));
            track11.Composer = "Lennon, McCartney";
            cd2.AddTrack(track11);

            Track track12 = new Track("I Want To Tell You", new TimeSpan(0, 2, 27));
            track12.Composer = "Harrison";
            cd2.AddTrack(track12);

            Track track13 = new Track("Got To Get You Into My Life", new TimeSpan(0, 2, 29));
            track13.Composer = "Lennon, McCartney";
            cd2.AddTrack(track13);

            Track track14 = new Track("Tomorrow Newer Knows", new TimeSpan(0, 3, 01));
            track14.Composer = "Lennon, McCartney";
            cd2.AddTrack(track14);
            Products.Add(cd2);

            MusicCD cd3 = new MusicCD(9, "Florin Salam", "Nebunia lui Salam", 999M, 2018)
            {
                Label = "Music Sound Production LTD",
                ImageUrl = "nebunia-lui-salam.jpg",
                Category = "MusicCD"
            };

            cd3.AddTrack(new Track("Du-ma unde vrei", new TimeSpan(0, 4, 20), "Lennon, McCartney"));
            cd3.AddTrack(new Track("Sa vina toata lumea", new TimeSpan(0, 3, 03), "Harrison"));
            cd3.AddTrack(new Track("Frumoasa ispita Daniela Crudu", new TimeSpan(0, 3, 29), "Lennon, McCartney"));
            cd3.AddTrack(new Track("Zile pentru mama mea", new TimeSpan(0, 3, 26), "Lennon, McCartney"));
            cd3.AddTrack(new Track("Abrasame Mi Amor", new TimeSpan(0, 2, 51), "Starkey"));
            cd3.AddTrack(new Track("Cine mi-a schimbat viata", new TimeSpan(0, 7, 47), "Lennon, McCartney"));
            cd3.AddTrack(new Track("Regina din Maroc", new TimeSpan(0, 3, 05), "Harrison"));
            cd3.AddTrack(new Track("Zana buna, corp perfect", new TimeSpan(0, 2, 45), "Lennon, McCartney"));
            cd3.AddTrack(new Track("Da - l bine regele meu", new TimeSpan(0, 4, 02), "Lennon, McCartney"));
            cd3.AddTrack(new Track("Nu are ce cauta", new TimeSpan(0, 2, 26), "Lennon, McCartney"));
            Products.Add(cd3);



            // Movies
            Movie movie1 = new Movie(5, "Jungle Book", 160.50M, "junglebook.jpg", "Jon Favreau");
            movie1.Category = "Movie";
            Products.Add(movie1);


            Movie movie2 = new Movie(6, "Gladiator", 49.95M, "gladiator.jpg", "Ridley Scott");
            movie2.Category = "Movie";
            Products.Add(movie2);

            Movie movie3 = new Movie(7, "Forrest Gump", 154.50M, "forrest-gump.jpg", "Robert Zemeckis");
            movie3.Category = "Movie";
            Products.Add(movie3);

            Customer customer1 = new Customer(0, "Sabina", "Albu", "Stationspladsen 2B", "8883", "Silkeborg");
            Customer customer2 = new Customer(1, "Catalin", "Ispas", "Sondervangen 73", "8260", "Viby J");

            Invoice invoice1 = new Invoice(1, new DateTime(2020, 9, 01), customer1);
            Invoice invoice2 = new Invoice(2, new DateTime(2019, 12, 24), customer2);

            invoice1.AddOrderItem(movie3, 1);
            invoice1.AddOrderItem(book2, 1);

            invoice2.AddOrderItem(book, 1);
            invoice2.AddOrderItem(cd2, 1);

            Invoices.Add(invoice1);
            Invoices.Add(invoice2);
        }

    }
}
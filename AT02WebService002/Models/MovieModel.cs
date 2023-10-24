/*
   DESIGNER: Claudinei Pereira de Sousa (ID: 100647340)
   Date: 25/10/2023   
   Project Name: (Assignment 02 Web Services) 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using AT02WebService002.Controllers;
using System.Web.Script.Serialization;
using AT02WebService002;
using System.Web.Mvc;
using System.Web.Optimization;


namespace AT02WebService002.Models
{
    public class MovieModel
    {
        public object GetMovieSearch(string movieTitle)
        {
            //string movieType = "Movie";
            string url = string.Format("http://www.omdbapi.com/?i=tt3896198&apikey=e88615c3&t={0}", movieTitle/*, movieType*/);
            var client = new WebClient();

            try
            {
                var content = client.DownloadString(url); //Kay: visit: https://jsonformatter.org/ to format JSON in a nice form
                var serializer = new JavaScriptSerializer();
                var jsonContent = serializer.Deserialize<Root>(content);
                return jsonContent;
            }
            catch
            {
                return ("Wrong title");
            }
        }

        //use https://json2csharp.com/ to build getters and setters for JSON format retrieved from the WS, i.e., from http://api.openweathermap.org/data/2.5/weather?q=London&APPID=542ffd081e67f4512b705f89d2a611b2&units=metric
        //===========================
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Rating
        {
            public string Source { get; set; }
            public string Value { get; set; }
        }
        public class Root
        {
            public string Title { get; set; }
            public string Year { get; set; }
            public string Rated { get; set; }
            public string Released { get; set; }
            public string Runtime { get; set; }
            public string Genre { get; set; }
            public string Director { get; set; }
            public string Writer { get; set; }
            public string Actors { get; set; }
            public string Plot { get; set; }
            public string Language { get; set; }
            public string Country { get; set; }
            public string Awards { get; set; }
            public string Poster { get; set; }
            public List<Rating> Ratings { get; set; }
            public string Metascore { get; set; }
            public string ImdbRating { get; set; }
            public string ImdbVotes { get; set; }
            public string ImdbID { get; set; }
            public string Type { get; set; }
            public string DVD { get; set; }
            public string BoxOffice { get; set; }
            public string Production { get; set; }
            public string Website { get; set; }
            public string Response { get; set; }
        }


    }

}
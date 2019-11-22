using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1.Clases
{
    public class film
    {
        public int film_id;
        public string title;
        public string description;
        public string release_year;
        public int language_id;
        public Byte original_language_id;
        public int rental_duration;
        public decimal rental_rate;
        public int length;
        public decimal replacement_cost;
        public string rating;
        public string special_features;
        public DateTime last_update;
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace Lab_Countries_State_Management.Models
{
    public class Country
    {

        public string Name { get; set; }
        public string Languages { get; set; }
        public string Hello { get; set; }
        public string Description { get; set; }
        public string Colors { get; set; }
        //public byte Flag { get; set; }

        public Country() { }

        public Country(string name, string languages, string hello, string description, string colors)
        {
            Name = name;
            Languages = languages;
            Hello = hello;
            Description = description;
            Colors = colors;
        }

    }
}

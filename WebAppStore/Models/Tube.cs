﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppStore.Models
{
    public class Tube
    {
        public int TubeId { get; set; }
        public string Type { get; set; }
        public string Brand { get; set; }
        public string Date { get; set; } //years, era
        public string ShortDescription { get; set; } //getter, pins, plates
        public string FullDescription { get; set; } //history, sound description
        public string Parameters { get; set; } //electric
        
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public bool IsTubeOfTheWeek { get; set; }
        public bool InStock { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}

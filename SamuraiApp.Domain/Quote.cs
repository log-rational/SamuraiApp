﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SamuraiApp.Domain
{
    public class Quote
    {
        public int SamuraiId { get; set; }
        public Samurai Samurai { get; set; }
        public string Text { get; set; }
        public int Id { get; set; }
    }
}

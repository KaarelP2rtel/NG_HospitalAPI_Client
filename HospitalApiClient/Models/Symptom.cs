﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalApiClient.Models
{
    public class Symptom
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Disease> Diseases { get; set; }

    }
}

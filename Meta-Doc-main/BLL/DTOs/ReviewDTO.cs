﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ReviewDTO
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public int Patient_Id { get; set; }

        public int Doctor_Id { get; set; }
    }
}

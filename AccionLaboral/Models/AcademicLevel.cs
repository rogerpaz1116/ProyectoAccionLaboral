﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Proyecto_AccionLaboral.Models
{
    public class AcademicLevel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]   
        public int AcademicLevelId { get; set; }
        [Required]
        public string Name { get; set; }
    }
}

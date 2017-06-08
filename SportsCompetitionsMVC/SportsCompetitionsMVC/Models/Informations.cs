﻿using SportsCompetitions.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using static SportsCompetitions.Enums.Enums;

namespace SportsCompetitionsMVC.Models
{
    public class Informations
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public eSex Sex { get; set; }
        public DateTime BirthDate { get; set; }
        public string Avatar { get; set; }
        public eUsertype UserType { get; set; } = eUsertype.NormalUser;
    }
}
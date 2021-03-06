﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;


namespace BookingSystem.Models
{
    public partial class Seller
    {
        public Seller()
        {
            this.Appointments = new HashSet<Appointment>();
            this.WorkingHours = new HashSet<TimeFrame>();
            this.ProvidedServices = new HashSet<Service>();
        }

        [Key]
        public string Id { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }

        public virtual ICollection<TimeFrame> WorkingHours { get; set; }

        public virtual ICollection<Service> ProvidedServices { get; set; }
    }
}

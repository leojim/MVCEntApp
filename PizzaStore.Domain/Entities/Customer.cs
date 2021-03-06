﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq.Mapping;
using System.ComponentModel.DataAnnotations;

namespace PizzaStore.Domain.Entities
{
    [Table(Name = "CustomerDetails")]
    public class Customer
    {
        //[HiddenInput(DisplayValue = false)] // Can't use this it links the Domain model to the MVC model
        [ScaffoldColumn(false)]
        [Column(IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.OnInsert)]
        public int CustomerID { get; set; }

        [Column]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter a name!")]
        [Column]
        public string Firstname { get; set; }

        [Required(ErrorMessage = "Please enter a surname!")]
        [Column]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Please enter a Contact Phone!")]
        [Column]
        public string ContactPhone { get; set; }

        [Required(ErrorMessage = "Please enter your Email Address!")]
        [Column]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter a Password!")]
        [Column]
        public string LoginPassword { get; set; }

        [Required(ErrorMessage = "Please enter the Delivery Address!")]
        [Column]
        public string Address1 { get; set; }

        [Column]
        public string Address2 { get; set; }

        [Column]
        public string Address3 { get; set; }

        [Required(ErrorMessage = "Please enter the County!")]
        [Column]
        public string County { get; set; }

        [Column]
        public string Country { get; set; }

    }
}

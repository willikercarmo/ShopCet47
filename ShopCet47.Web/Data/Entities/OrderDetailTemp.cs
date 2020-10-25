﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopCet47.Web.Data.Entities
{
    public class OrderDetailTemp : IEntity // Carrinho de Compra. Enquanto não confirmar a compra, fica nesta classe
    {
        public int Id { get; set; }

        [Required]
        public User User { get; set; }


        [Required]
        public Product Product { get; set; }


        [DisplayFormat(DataFormatString = "{0:C2}")]
        public decimal Price { get; set; }


        [DisplayFormat(DataFormatString = "{0:N2}")]
        public double Quantity { get; set; }


        public decimal Value { get { return this.Price * (decimal)this.Quantity; } }


    }
}

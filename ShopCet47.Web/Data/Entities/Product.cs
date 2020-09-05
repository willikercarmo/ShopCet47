using System;
using System.ComponentModel.DataAnnotations;

namespace ShopCet47.Web.Data.Entities
{
    public class Product
    {
        public int Id { get; set; }



        public string Name { get; set; }



        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)] // Mostra para a Web apenas com 2 casas decimais
        public decimal Price { get; set; }



        [Display(Name = "Image")] // Mostra na Web a palavra Image ao invés de ImageUrl
        public string ImageUrl { get; set; }



        [Display(Name = "Last Purchase")]
        public DateTime LastPurchase { get; set; }



        [Display(Name = "Last Sale")]
        public DateTime LastSale { get; set; }



        [Display(Name = "Is Available")]
        public bool IsAvailable { get; set; }



        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        public double Stock { get; set; }

    }
}

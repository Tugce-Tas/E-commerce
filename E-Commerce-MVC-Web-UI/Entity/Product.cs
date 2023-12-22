using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace E_Commerce_MVC_Web_UI.Entity
{
    public class Product
    {
        public int Id { get; set; }

        [DisplayName("Ürün Adı")]
        public string Name { get; set; }

        [DisplayName("Açıklama")]
        public string Description { get; set; }

        [DisplayName("Fiyat")]
        public double Price { get; set; }

        [DisplayName("Stok Durumu")]
        public int Stock { get; set; }

        [DisplayName("Görünürlük")]
        public bool IsApproved { get; set; }

        [DisplayName("Ana Sayfa")]
        public bool IsHome { get; set; }

        [DisplayName("Ürün Görseli")]
        public string Image { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
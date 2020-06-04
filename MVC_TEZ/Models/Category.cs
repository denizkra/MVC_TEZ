using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace MVC_TEZ.Models
{
    public class Category
    {
        public int urunID { get; set; }
        public string marketAdi { get; set; }
        public string genelkategoriAdi { get; set; }
        public string altkategoriAdi { get; set; }
        public string urunAdi { get; set; }
        public bool indirimDurumu { get; set; }
        public int indirimYüzdesi { get; set; }
        public double fiyat { get; set; }
        public double eskiFiyat { get; set; }
        public double yeniFiyat { get; set; }
        public DateTime tarih { get; set; }
    }
}
using System;
using System.ComponentModel.DataAnnotations;

namespace Warungcd.Models
{
    public class Barang
    {
        public int Id { get; set; }
        public string NamaBarang { get; set; }
        public string Deskripsi { get; set; }
        public string UrlGambar { get; set; }
        public int Harga { get; set; }
    }
}
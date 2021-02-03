using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Warungcd.Data;
using System;
using System.Linq;

namespace Warungcd.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new WarungCdContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<WarungCdContext>>()))
            {
                // Look for any movies.
                if (context.Barang.Any())
                {
                    return;   // DB has been seeded
                }

                context.Barang.AddRange(
                    new Barang
                    {
                        NamaBarang = "CD Windows 10",
                        Deskripsi = "Buat Instalasi Windows",
                        UrlGambar = "/mnt/220C6C040C6BD179/(Dhan Punya)/Tugas AING/VSC/zzz/tugasBesar/Warungcd/wwwroot/img/Win10.jpeg",
                        Harga = 12500
                    },

                    new Barang
                    {
                        NamaBarang = "CD Kali Linux",
                        Deskripsi = "Kali Linux ",
                        UrlGambar = "/mnt/220C6C040C6BD179/(Dhan Punya)/Tugas AING/VSC/zzz/tugasBesar/Warungcd/wwwroot/img/Kali.jpeg",
                        Harga = 45000
                    },

                    new Barang
                    {
                        NamaBarang = "CD Linux Mint",
                        Deskripsi = "Buat Instalasi LM",
                        UrlGambar = "/mnt/220C6C040C6BD179/(Dhan Punya)/Tugas AING/VSC/zzz/tugasBesar/Warungcd/wwwroot/img/LM.jpeg",
                        Harga = 20000
                    },

                    new Barang
                    {
                        NamaBarang = "CD Driver Pack Solution",
                        Deskripsi = "Driver Windows",
                        UrlGambar = "/mnt/220C6C040C6BD179/(Dhan Punya)/Tugas AING/VSC/zzz/tugasBesar/Warungcd/wwwroot/img/DPS.jpeg",
                        Harga = 55000
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
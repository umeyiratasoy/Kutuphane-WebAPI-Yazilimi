using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class EmanetDetayDto : IDto
    {
        public int EmanetId { get; set; }
        public string OgrenciAd { get; set; }
        public string OgrenciSoyad { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Cinsiyet { get; set; }
        public int Sinif { get; set; }
        public string KitapAd { get; set; }
        public int SayfaSayisi { get; set; }
        public string YazarAd { get; set; }
        public string YazarSoyad { get; set; }
        public string TurAd { get; set; }
        public DateTime AlinanTarih { get; set; }
        public DateTime VerilecekTarih { get; set; }
    }
}

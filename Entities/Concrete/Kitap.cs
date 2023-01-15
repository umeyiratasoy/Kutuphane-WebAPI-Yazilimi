using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Kitap : IEntity
    {
        public int KitapId { get; set; }
        public string KitapAd { get; set; }
        public int SayfaSayisi { get; set; }
        public int YazarId { get; set; }
        public int TurId { get; set; }
    }
}

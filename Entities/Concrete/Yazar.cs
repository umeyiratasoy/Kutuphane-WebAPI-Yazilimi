using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Yazar : IEntity
    {
        public int YazarId { get; set; }
        public string YazarAd { get; set; }
        public string YazarSoyad { get; set; }
    }
}

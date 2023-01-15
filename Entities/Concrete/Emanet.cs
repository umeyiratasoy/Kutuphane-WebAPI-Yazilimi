using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Emanet : IEntity
    {
        public int EmanetId { get; set; }
        public int OgrenciId { get; set; }
        public int KitapId { get; set; }
        public DateTime AlinanTarih { get; set; }
        public DateTime VerilecekTarih { get; set; }

    }
}

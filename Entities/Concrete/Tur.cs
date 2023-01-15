using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Tur : IEntity
    {
        public int TurId { get; set; }
        public string TurAd { get; set; }
    }
}

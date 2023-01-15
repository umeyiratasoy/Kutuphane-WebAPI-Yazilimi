using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfEmanetDal : EfEntityRepositoryBase<Emanet, ReCapProjectContext>, IEmanetDal
    {
        public List<EmanetDetayDto> GetEmanetDetaylar()
        {
            using (ReCapProjectContext context = new ReCapProjectContext())
            {
                var result = from em in context.Emanetler
                             join og in context.Ogrenciler
                             on em.OgrenciId equals og.OgrenciId
                             join ki in context.Kitaplar
                             on em.KitapId equals ki.KitapId
                             join yaz in context.Yazarlar
                             on ki.YazarId equals yaz.YazarId
                             join tur in context.Turler
                             on ki.TurId equals tur.TurId
                             select new EmanetDetayDto
                             {
                                 EmanetId = em.EmanetId,
                                 OgrenciAd = og.OgrenciAd,
                                 OgrenciSoyad = og.OgrenciSoyad,
                                 DogumTarihi = og.DogumTarihi,
                                 Cinsiyet = og.Cinsiyet,
                                 Sinif = og.Sinif,
                                 KitapAd = ki.KitapAd,
                                 SayfaSayisi = ki.SayfaSayisi,
                                 YazarAd = yaz.YazarAd,
                                 YazarSoyad = yaz.YazarSoyad,
                                 TurAd = tur.TurAd,
                                 AlinanTarih = em.AlinanTarih,
                                 VerilecekTarih = em.VerilecekTarih

                             };

                return result.ToList();
            }
        }

    }
}

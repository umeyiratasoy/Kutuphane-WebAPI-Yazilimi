using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Performance;
using Core.Aspects.Autofac.Transaction;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Business.Concrete
{
    public class OgrenciManager : IOgrenciService
    {
        IOgrenciDal _ogrenciDal;

        public OgrenciManager(IOgrenciDal ogrenciDal)
        {
            _ogrenciDal = ogrenciDal;
        }

        [CacheRemoveAspect("IOgrenciService.Get")] //önbellek // sürekli veritabanına gitmemek için
        [SecuredOperation("gorevli")] // yetki
        [ValidationAspect(typeof(OgrenciValidator))] // doğrulama
        public IResult Add(Ogrenci ogrenci)
        {
            IResult result = BusinessRules.Run();
            if (result != null)
            {
                return result;
            }
            _ogrenciDal.Add(ogrenci);
            return new SuccessResult(Messages.OgrenciEklendi);
        }

        
        [CacheRemoveAspect("IOgrenciService.Get")]
        [SecuredOperation("gorevli")] // yetki
        public IResult Delete(Ogrenci ogrenci)
        {
            _ogrenciDal.Delete(ogrenci);
            return new SuccessResult(Messages.OgrenciSilindi);
        }


        
        [CacheAspect] //key,value 
        public IDataResult<List<Ogrenci>> GetAll()
        {
            
            Thread.Sleep(5000);
            return new SuccessDataResult<List<Ogrenci>>(_ogrenciDal.GetAll(), Messages.OgrenciListelendi);

        }

        
        [CacheAspect]
        public IDataResult<Ogrenci> GetById(int id)
        {
            
            Thread.Sleep(5000);
            return new SuccessDataResult<Ogrenci>(_ogrenciDal.Get(o => o.OgrenciId == id), Messages.İstenilenOgrenciListelendi);
        }

        
        [CacheRemoveAspect("IOgrenciService.Get")]
        [SecuredOperation("gorevli")] // yetki
        [ValidationAspect(typeof(OgrenciValidator))] // doğrulama
        public IResult Update(Ogrenci ogrenci)
        {
            _ogrenciDal.Update(ogrenci);
            return new SuccessResult(Messages.OgrenciGüncellendi);
        }
    }
}

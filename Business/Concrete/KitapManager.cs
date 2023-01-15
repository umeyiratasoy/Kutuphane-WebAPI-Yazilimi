using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Performance;
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
    public class KitapManager : IKitapService
    {
        IKitapDal _kitapDal;


        public KitapManager(IKitapDal kitapDal)
        {
            _kitapDal = kitapDal;
        }

        [CacheRemoveAspect("IKitapService.Get")] //önbellek // sürekli veritabanına gitmemek için
        [SecuredOperation("gorevli")] // yetki
        [ValidationAspect(typeof(KitapValidator))] // doğrulama
        public IResult Add(Kitap kitap)
        {
            IResult result = BusinessRules.Run();
            if (result != null)
            {
                return result;
            }
            _kitapDal.Add(kitap);
            return new SuccessResult(Messages.KitapEklendi);
        }

        
        [SecuredOperation("gorevli")] // yetki
        [CacheRemoveAspect("IKitapService.Get")]
        public IResult Delete(Kitap kitap)
        {
            _kitapDal.Delete(kitap);
            return new SuccessResult(Messages.KitapSilindi);
           
        }


        
        [CacheAspect] //key,value 
        public IDataResult<List<Kitap>> GetAll()
        {

            Thread.Sleep(46000);
            return new SuccessDataResult<List<Kitap>>(_kitapDal.GetAll(), Messages.KitapListelendi);

        }

        
        [CacheAspect]
        public IDataResult<Kitap> GetById(int id)
        {
            return new SuccessDataResult<Kitap>(_kitapDal.Get(o => o.KitapId == id), Messages.İstenilenKitapListelendi);
        }

        
        [SecuredOperation("gorevli")] // yetki
        [CacheRemoveAspect("IKitapService.Get")]
        [ValidationAspect(typeof(KitapValidator))] // doğrulama
        public IResult Update(Kitap kitap)
        {
            _kitapDal.Update(kitap);
            return new SuccessResult(Messages.KitapGüncellendi);
        }




    }
}

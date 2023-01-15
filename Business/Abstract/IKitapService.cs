using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IKitapService
    {
        IDataResult<List<Kitap>> GetAll();
        IResult Add(Kitap kitap);
        IResult Update(Kitap kitap);
        IResult Delete(Kitap kitap);
        IDataResult<Kitap> GetById(int id);
    }
}

using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IYazarService
    {
        IDataResult<List<Yazar>> GetAll();
        IResult Add(Yazar yazar);
        IResult Update(Yazar yazar);
        IResult Delete(Yazar yazar);
        IDataResult<Yazar> GetById(int id);
    }
}

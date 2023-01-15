using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ITurService
    {
        IDataResult<List<Tur>> GetAll();
        IResult Add(Tur tur);
        IResult Update(Tur tur);
        IResult Delete(Tur tur);
        IDataResult<Tur> GetById(int id);
    }
}

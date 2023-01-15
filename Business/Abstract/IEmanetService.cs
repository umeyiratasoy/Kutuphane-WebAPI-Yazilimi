using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IEmanetService
    {
        IDataResult<List<Emanet>> GetAll();
        IResult Add(Emanet emanet);
        IResult Update(Emanet emanet);
        IResult Delete(Emanet emanet);
        IDataResult<Emanet> GetById(int id);

        IDataResult<List<EmanetDetayDto>> GetEmanetDetaylar();

    }
}

using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{

    public interface IOgrenciService
    {
        IDataResult<List<Ogrenci>> GetAll();
        IResult Add(Ogrenci ogrenci);
        IResult Update(Ogrenci ogrenci);
        IResult Delete(Ogrenci ogrenci);
        IDataResult<Ogrenci> GetById(int id);
    }
}

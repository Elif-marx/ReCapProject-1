using System;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICarImagesService
    {
        IResult Add(CarImages carImages);
        IResult Delete(CarImages carImages);
        IResult Update(CarImages carImages);
    }
}

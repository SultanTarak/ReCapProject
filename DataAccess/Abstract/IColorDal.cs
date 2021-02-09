using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IColorDal : IEntityRepository<Color>
    {
        void Add(System.Drawing.Color color);
        void Delete(System.Drawing.Color color);
        void Update(System.Drawing.Color color);
    }
}

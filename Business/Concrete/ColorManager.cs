using Business.Abstract;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }
        public void Add(Color color)
        {
            _colorDal.Add(color);
            Console.WriteLine("Yeni renk eklendi.");
        }

        public void Delete(Color color)
        {
            _colorDal.Delete(color);
            Console.WriteLine("Renk silindi.");
        }

        public List<Color> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Color color)
        {
            _colorDal.Update(color);
            Console.WriteLine("Renk güncellendi.");

        }
    }
}

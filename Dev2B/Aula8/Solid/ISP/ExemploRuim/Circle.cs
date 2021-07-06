using System;
using System.Collections.Generic;
using System.Text;

namespace Aula8.ISP.ExemploRuim
{
    public class Circle : IShape
    {
        public void DrawCircle()
        {
            throw new NotImplementedException();
        }

        public void DrawRectangle()
        {
            throw new NotImplementedException();
        }

        public void DrawSquare()
        {
            throw new NotImplementedException();
        }
    }
}

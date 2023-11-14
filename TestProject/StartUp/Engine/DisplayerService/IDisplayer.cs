using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.StartUp.Engine.Displayer
{
    public interface IDisplayer
    {
        public void DisplayRequest<T>(T data);
    }
}

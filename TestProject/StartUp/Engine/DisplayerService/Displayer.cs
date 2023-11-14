using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.StartUp.Engine.Displayer
{
    internal class Displayer : IDisplayer
    {
        private IDisplayer _displayerImplementation;
        public void DisplayRequest<T>(T data)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using Planets.Model;
using Planets.View;
using Planets.Controller;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Execute Controller
            Controller.Controller controller = new Controller.Controller();
            controller.MainController();
            #endregion
        }
    }
}

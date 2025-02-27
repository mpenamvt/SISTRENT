using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SISTRENT.Classes
{
    internal class CarNodes
    {
    
        public string regnum { get; private set; }
        public string description { get; private set; }
        public string year { get; private set; }
        public string color { get; private set; }
        public List<CarNodes> Children { get; private set; }
        public CarNodes(string Placa, string Descripcion, string Año, string Color)
        {
            this.regnum = Placa;
            this.description = Descripcion;
            this.year = Año;
            this.color = Color;
            this.Children = new List<CarNodes>();
        }
    }
}


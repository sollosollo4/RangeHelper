using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DeathgiverHelper
{
    [Serializable]
    public class Settings
    {
        public int width;
        public int height;

        public int x;
        public int y;

        public int brushsize;

        [XmlElement(Type = typeof(XmlColor))]
        public Color color { get; set; }
    }
}

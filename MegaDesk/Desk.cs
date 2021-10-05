using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
    public enum DesktopMaterial
    {
        Laminate, 
        Oak, 
        Rosewood, 
        Veneer, 
        Pine
    }
    class Desk
    {
        public decimal Width{ get; set;}
        public decimal Height{ get; set;}
        public int NumberOfDrawers{ get; set;}
        public DesktopMaterial SurfaceArea { get; set;}


    }
}

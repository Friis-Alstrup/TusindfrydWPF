using System;
using System.Collections.Generic;
using System.Text;

namespace TusindfrydWPF
{
    public class FlowerSort
    {
        public string Name { get; set; }
        public string PicturePath { get; set; }
        public int ProductionTime { get; set; }
        public int HalfLifeTime { get; set; }
        public int Size { get; set; }

        public FlowerSort(string name, string picturePath, int productionTime, int halfLifeTime, int size)
        {
            this.Name = name;
            this.PicturePath = picturePath;
            this.ProductionTime = productionTime;
            this.HalfLifeTime = halfLifeTime;
            this.Size = size;
        }
    }
}

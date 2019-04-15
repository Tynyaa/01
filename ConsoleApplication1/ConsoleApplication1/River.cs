using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class River
    {

        private string name;
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        private double plosh;
        public double Plosh
        {
            get { return this.plosh; }
            set { this.plosh = value; }
        }

        private double prot;
        public double Prot
        {
            get { return this.prot; }
            set { this.prot = value; }
        }

        public River()
        {
            this.Name = "";
            this.Plosh = 0.0;
            this.Prot = 0.0;
        }
        public River(string name, double plosh, double prot)
        {
            this.Name = name;
            this.Plosh = plosh;
            this.Prot = prot;
        }

        public void Fill()
        {
            Console.Write("Введите название: ");
            name = Console.ReadLine();
            Console.Write("Введите площадь: ");
            plosh = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите протяженность: ");
            prot = Convert.ToDouble(Console.ReadLine());
        }



        public override string ToString()
        {
            return "Название: " + this.Name + " Площадь: " + this.Plosh + " Протяженность: " + this.Prot;
        }


    }
}
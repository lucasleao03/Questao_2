using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace caNum_complexo
{
    internal class Num_complexo
    {
        //atributos
        private double re;  //Real
        private double im;  //Imaginário

        //Construtores
        public Num_complexo()
        {
            re = 0;
            im = 0;
        }

        public Num_complexo(double _re, double _im)
        {
            re = _re;
            im = _im;
        }

        //getters e setters
        public double Re { get => re; set => re = value; }
        public double Im { get => im; set => im = value; }

        //Métodos
        public Num_complexo soma(Num_complexo y)
        {
            Num_complexo res = new Num_complexo();
            res.re = (this.re + y.re);
            res.im = (this.im + y.im);
            return res;
        }

        public Num_complexo vezes(Num_complexo y)
        {
            Num_complexo res = new Num_complexo();
            res.re = (this.re * y.re) + ((this.im * y.im) * (-1));
            res.im = (this.re * y.im) + (this.im * y.re);
            return res;
        }

        public double Modulo()
        {
            double x = (this.re) * (this.re);
            double y = (this.im) * (this.im);
            return (Math.Sqrt(x + y));
        }

        public double argumento()
        {
            double res = (im / re);
            return (Math.Atan(res));
        }

        public void ImprimeFormaPolar()
        {
            double ro = this.Modulo();
            double cos = ((re) / (ro));
            double sin = ((im) / (ro));
            double P = (ro * (cos + sin));

            Console.WriteLine("P = " + P);

        }
    }
}

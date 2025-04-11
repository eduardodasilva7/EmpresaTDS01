using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Padaria
{
    public class Operacoes
    {
        private double num1;
        private double num2;
        private double resp;

        public void setSoma(double num1, double num2)
        {
            resp = num1 + num2;
        }

        //public double getSoma()
        //{
        //    return resp;
        //}

        public void setSubt(double num1, double num2)
        {
            resp = num1 - num2;
        }

        //public double getSubt()
        //{
        //    return resp;
        //}

        public void setMult(double num1, double num2)
        {
            resp = num1 * num2;
        }

        //public double getMult()
        //{
        //    return resp;
        //}

        public void setDivi(double num1, double num2)
        {
            resp = num1 / num2;
        }

        public double getResp()
        {
            return resp;
        }

    }
}

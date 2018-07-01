using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Console_App.Models
{
    class Operation
    {
        private bool ifDouble;
        private bool ifInt;
        private int firstValue;
        private int secondValue;
        private double dfirstValue;
        private double dsecondValue;
        private int value = 0;
        private double dvalue =0.0;

        public Operation()
        {
            ifDouble = false;
            ifInt = true;

        }
        public static int Add(int x, int y) => x + y;
        public static int Sub(int x, int y) => x - y;
        public static int Mul(int x, int y) => x * y;
        public static int Div(int x, int y) => x / y;
        public static int Mod(int x, int y) => x % y;

        public static double Add(double x, double y) => x + y;
        public static double Sub(double x, double y) => x - y;
        public static double Mul(double x, double y) => x * y;
        public static double Div(double x, double y) => x / y;
        public static double Mod(double x, double y) => x % y;

        public void Add(int x)
        {   
                value += x;  
        }
        public void Add(double x)
        {
                dvalue += x;
        }
        public void Sub(int x)
        {
            value -= x;
        }
        public void Sub(double x)
        {
            dvalue -= x;
        }
    }
}

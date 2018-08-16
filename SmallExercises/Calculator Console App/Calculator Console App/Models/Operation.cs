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

        public bool IfDouble { get => ifDouble; set => ifDouble = value; }
        public bool IfInt { get => ifInt; set => ifInt = value; }
        public int FirstValue { get => firstValue; set => firstValue = value; }
        public double DfirstValue { get => dfirstValue; set => dfirstValue = value; }
        public int SecondValue { get => secondValue; set => secondValue = value; }
        public double DsecondValue { get => dsecondValue; set => dsecondValue = value; }
        public int Value { get => this.value; }
        public double Dvalue { get => dvalue; }


        public Operation(string answer)
        {
            switch (answer)
            {
                case "integers":
                    ifDouble = false;
                    ifInt = true;
                    break;
                case "doubles":
                    ifDouble = true;
                    ifInt = false;
                    break;
                default:
                    ifInt = true;
                    ifDouble = false;
                    break;

            }
        }
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
        public void Mul(int x)
        {
            value *= x;
        }
        public void Mul(double x)
        {
            dvalue *= x;
        }
        public void Div(int x)
        {
            value /= x;
        }
        public void Div(double x)
        {
            dvalue /= x;
        }
        public void Mod(int x)
        {
            value %= x;
        }
        public void Mod(double x)
        {
            dvalue %= x;
        }
    }
}

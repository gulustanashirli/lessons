using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {


            {


                #region
                // Impilicit conversion
                //1. int to long 
                int intVal = int.MaxValue;
                long longVal= long.MaxValue;
                long takeIntVal = intVal;
            }

            {
                int c = 23456789;
                long f = c;
            }
            




            {
                //2.short to int
                short shortVal = short.MaxValue;
                int intVal = int.MaxValue;
                int takeShortVal = shortVal;
                {
                    short val = 5000;
                    int val2 = val;
                 }

            }

            {
                //3 sbyte to long

                sbyte sbyteVal = sbyte.MaxValue;
                long longVal = long.MaxValue;
                long takeSbyteVal = sbyteVal;


                {
                    sbyte h = 124;
                    long e = h;
                }

            }





            {

                //4.int to decimal
                int intVal = int.MaxValue;
                decimal decimalVal = decimal.MaxValue;
                decimal takeIntVal = intVal;

                {
                    int val3 = 3456899;
                    decimal val5 = val3;
                }




            }



            {
                //5.short to double
                short shortVal = short.MaxValue;
                double doubleVal2 = double.MaxValue;
                double takeShortVal = shortVal;

                {
                    short l = 22345;
                    double s = l;
                }


            }
            #endregion




            #region
            //Explıcıt Conversıon

            //1.long to short
            long w9 = 1234;
            float s5 = (float)w9;

            //2.long to int
            long c8 = 67890;
            int b5 = (int)c8;

            //3. ınt to sbyte   
            int d2 = 67;
            sbyte r4 = (sbyte)d2;


            //4.float to ushort
            float t9 = 5678;
            ushort d7 = (ushort)t9;

            //5.ulong to byte

            ulong r3 = 78;
            byte k4 = (byte)r3;
            #endregion

































        }




    }
}

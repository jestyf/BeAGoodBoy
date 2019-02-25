using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace BeAGoodBoy
{
    class Utils
    {
        public static string[] StringConcat2(int pos,char sgn,int a,int b,int c)
        {
            string[] s=new string[2];
            string format;
            format = "{0} {1} {2} = {3}";
            switch (pos)
            {
                case 0:
                    s[0] = String.Format(format, @"(  )", sgn, b, c);
                    s[1] = a.ToString();
                    break;
                case 1:
                    s[0] = String.Format(format, a, sgn, @"(  )", c);
                    s[1] = b.ToString();
                    break;
                case 2:
                    s[0] = String.Format(format, a, sgn, b, @"(  )");
                    s[1] = c.ToString();
                    break;
                default:
                    break;
            }
            return s;
        }

        public static string[] StringConcat3(int pos, char sgn1, char sgn2, int a, int b, int c, int d)
        {
            string[] s = new string[2];
            string format;
            format = "{0} {1} {2} {3} {4} = {5}";
            switch (pos)
            {
                case 0:
                    s[0] = String.Format(format, @"(  )", sgn1, b, sgn2, c, d);
                    s[1] = a.ToString();
                    break;
                case 1:
                    s[0] = String.Format(format, a, sgn1, @"(  )", sgn2, c, d);
                    s[1] = b.ToString();
                    break;
                case 2:
                    s[0] = String.Format(format, a, sgn1, b, sgn2, @"(  )", d);
                    s[1] = c.ToString();
                    break;
                case 3:
                    s[0] = String.Format(format, a, sgn1, b, sgn2, c, @"(  )");
                    s[1] = d.ToString();
                    break;
                default:
                    break;
            }
            return s;
        }

        public static string[] StringConcat4(int pos, char sgn1, char sgn2, char sgn3, int a, int b, int c, int d, int e)
        {
            string[] s = new string[2];
            string format;
            format = "{0} {1} {2} {3} {4} {5} {6} = {7}";
            switch (pos)
            {
                case 0:
                    s[0] = String.Format(format, @"(  )", sgn1, b, sgn2, c, sgn3, d, e);
                    s[1] = a.ToString();
                    break;
                case 1:
                    s[0] = String.Format(format, a, sgn1, @"(  )", sgn2, c, sgn3, d, e);
                    s[1] = b.ToString();
                    break;
                case 2:
                    s[0] = String.Format(format, a, sgn1, b, sgn2, @"(  )", sgn3, d, e);
                    s[1] = c.ToString();
                    break;
                case 3:
                    s[0] = String.Format(format, a, sgn1, b, sgn2, c, sgn3, @"(  )", e);
                    s[1] = d.ToString();
                    break;
                case 4:
                    s[0] = String.Format(format, a, sgn1, b, sgn2, c, sgn3, d, @"(  )");
                    s[1] = e.ToString();
                    break;
                default:
                    break;
            }
            return s;
        }
    }


    class PMProblemGenerator
    {
        public static char[] sgn_list = new char[2] { '+', '-' };

        public static string[] Generate2(int num_range)
        {
            Random random = new Random();
            string[] s;
            int a = random.Next(0, num_range);
            int b = random.Next(0, num_range - a);
            int c = a + b;
            //生成位置
            int p = random.Next(0, 3);
            //生成符号
            int i = random.Next(0, 2);
            if (i == 0)
            {
                //加法
                s = Utils.StringConcat2(p, '+', a, b, c);
            }
            else
            {
                //减法
                s = Utils.StringConcat2(p, '-', c, b, a);
            }
            //延时，用来防止随机数相同
            Thread.Sleep(20);
            return s;
        }

        public static string[] Generate3(int num_range)
        {
            Random random = new Random();
            string[] s;
            int a, b, c, d;
            a = random.Next(0, num_range);
            //第一个符号
            int sgn1 = random.Next(0, 2);
            if (sgn1 == 0)
            {
                b = random.Next(0, num_range - a);
                d = a + b;
            }
            else
            {
                b = random.Next(0, a);
                d = a - b;
            }
            //第二个符号
            int sgn2 = random.Next(0, 2);
            if (sgn2 == 0)
            {
                c = random.Next(0, num_range - d);
                d = d + c;
            }
            else
            {
                c = random.Next(0, d);
                d = d - c;
            }
            //未知数位置
            int pos = random.Next(0, 4);
            s = Utils.StringConcat3(pos, sgn_list[sgn1], sgn_list[sgn2], a, b, c, d);
            //延时，用来防止随机数相同
            Thread.Sleep(20);
            return s;
        }

        public static string[] Generate4(int num_range)
        {
            Random random = new Random();
            string[] s;
            int a, b, c, d, e;
            a = random.Next(0, num_range);
            //第一个符号
            int sgn1 = random.Next(0, 2);
            if (sgn1 == 0)
            {
                b = random.Next(0, num_range - a);
                e = a + b;
            }
            else
            {
                b = random.Next(0, a);
                e = a - b;
            }
            //第二个符号
            int sgn2 = random.Next(0, 2);
            if (sgn2 == 0)
            {
                c = random.Next(0, num_range - e);
                e = e + c;
            }
            else
            {
                c = random.Next(0, e);
                e = e - c;
            }
            //第三个符号
            int sgn3 = random.Next(0, 2);
            if (sgn3 == 0)
            {
                d = random.Next(0, num_range - e);
                e = e + d;
            }
            else
            {
                d = random.Next(0, e);
                e = e - d;
            }
            int pos = random.Next(0, 5);
            s = Utils.StringConcat4(pos, sgn_list[sgn1], sgn_list[sgn2], sgn_list[sgn3], a, b, c, d, e);
            //延时，用来防止随机数相同
            Thread.Sleep(20);
            return s;
        }

    }

    class MDProblemGenerator
    {

    }
}

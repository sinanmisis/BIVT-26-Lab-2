using System.Collections.Generic;

namespace Lab2
{
    public class Green
    {
        const double E = 0.0001;
        const double Da = 0.0000000001;
        public double Task1(int n)
        {
            double answer = 0;

            // code here
            double s = 0,a=2,b=3;
            int i=2 ;
            while (i <= n) 
            {
                s += a / b;
                a+=2;b+=2;i+=2;
                
                

            }
            answer = s;
            
            // end

            return answer;
        }
        public double Task2(int n, double x)
        {
            double answer = 0;

            // code here
            double s = 1, a=0;
            int i = 1;
            while (i <= n)
            {

                a = 1 / Math.Pow(x, i);
                s = s + a;
                i++;

            }

            answer = s;
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            long s = 0, add = 1;
            for (int i=0; i<=n;i++) 
            {
                s += add;
                add *= i+1;
                
            }
            answer = s;
            
            
            // end

            return answer;
        }
        public double Task4(double x)
        {
            double answer = 0;

            // code here
            double n=1,s = 0,a=1;
            
            while (Math.Abs(a) >= E)
            {
                a = Math.Sin(n * Math.Pow(x, n));
                s = s + a;
                n++;
            }

            answer = s;
            // end
            
            return answer;
        }
        public int Task5(double x)
        {
            int answer = 0;

            // code here
            double s1=1,s = 1;
            int n = 1;
            double num = x, num1 = 1;
            
            
            do
            {
                num *= x;
                s = 1 / num;
                
                num1 *= x;
                s1 = 1 / num1;
                

                n++;
            } while (Math.Abs(s-s1) >= E);
            

            
            answer = n;
            
            // end

            return answer;
        }
        public int Task6(int limit)
        {
            int answer = 0;

            // code here
            int elem = 1, i = 0;
            while (elem < limit)
            
            {
                elem *= 2;
                answer += elem;
                i++;

            }
            
            
            return answer;
            
                
                
                
                
                
                
            // end

            return answer;
        }

        public int Task7(double L)
        {
            int answer = 0,n=0;

            // code here
            while (L > Da)
            {
                L /= 2;
                n++;
            }

            answer = n;
            // end

            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            for (double x = a; x <= b+0.0000001; x = x + h)
            {

                double el = x;
                for (double i = 0; ; i++)
                {
                    SS = SS + el;
                    if (Math.Abs(el) < E)
                    {
                        break;
                    }

                    el = (-el * x * x * (2.0 * i + 1.0)) / (2.0 * i + 3.0);
                }
                SY = SY + Math.Atan(x);
            }
            
            // end

            return (SS, SY);
        }
    }
}
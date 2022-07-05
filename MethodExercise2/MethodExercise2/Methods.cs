using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodExercise2
{
    internal class Methods
    {
        public static int Add(int f, int g)
        {
            int sum = f + g;
            return sum;
        }
        public static int Multiply(int t, int r)
        {
            int total = t * r;
            return total; 
        }
        public static int Subtract(int q, int p)
        {
            int result = q - p;
            return result;
        }
        public static int Divide(int d, int u)
        {
            int answer = d / u;
            return answer;
        }
        public static int Modulus(int j, int k)
        {
            int ans = j % k;
            return ans;
        }
        public static int AddSeveralNumbers(params int[] list)
        {
            int sum2 = list.Sum();
            return sum2;
               
        }
    }   
}

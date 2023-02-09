using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DelegateEx_Feb08.DelegateEx;

namespace DelegateEx_Feb08
{
    //delegate example
    public class DelegateEx
    {
        //declaring delegate
        public delegate int addnum(int x,int y);
        
        public int Add(int a, int b)
        {
            return a + b;
        }
    } 
    class Program
    {
        static void Main(string[] args)
        {
            DelegateEx Obj = new DelegateEx();
            addnum delegateObj = new addnum(Obj.Add);
            Console.WriteLine(delegateObj(1,2));


        }
    }
}

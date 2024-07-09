using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GithubPractise;

namespace GithubPractise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            calci calci = new calci();
            Console.WriteLine("ADD is -> "+calci.add(10,20));
            Console.WriteLine("hello world");
            Console.WriteLine("Sub is ->"+calci.sub(110,20));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication27
{
    public class A
    {
        public void NormalFun() { Console.WriteLine("A NormalFun()"); }
        public virtual void VirtualFun() { Console.WriteLine("A VirtualFun()"); VirtualFun2(); }
        public virtual void VirtualFun2() { Console.WriteLine("A VirtualFun2()"); }
    }

    public class B : A
    {
        public void NormalFun() { Console.WriteLine("B NormalFun()"); }
        public virtual void VirtualFun() { Console.WriteLine("B VirtualFun()"); }
        public override void VirtualFun2() { Console.WriteLine("B VirtualFun2()"); }
    }

    public class C : B
    {
        public override void VirtualFun() { Console.WriteLine("C VirtualFun()"); }
    }

    public class D : C
    {
        public void NormalFun() { Console.WriteLine("D NormalFun()"); }
        public override void VirtualFun() { Console.WriteLine("D VirtualFun()"); }
        public override void VirtualFun2() { Console.WriteLine("D VirtualFun2()"); }
    }

    public abstract class E : D
    {
        public virtual void VirtualFun() { Console.WriteLine("E VirtualFun()"); }
        public abstract void VirtualFun2();
    }

    public class F : E
    {
        public override void VirtualFun() { Console.WriteLine("F VirtualFun()"); }
        public override void VirtualFun2() { Console.WriteLine("F VirtualFun2()"); }
    }

  /* 
        A VirtualFun()
        B VirtualFun2()
        A NormalFun()
        B NormalFun()
        C VirtualFun()
        D VirtualFun()
        D VirtualFun2()
        D VirtualFun2()
        A VirtualFun()
        D VirtualFun2()
*/
    class Program
    {
        static void Main(string[] args)
        {
            
            A a = new B();
            B b = new C();
            C c = new D();
            A d = new D();

            Console.WriteLine("Tu jest wynik:");
            a.VirtualFun();
            a.NormalFun();
            b.NormalFun();
            b.VirtualFun();
            c.VirtualFun();
            c.VirtualFun2();
            d.VirtualFun2();
            d.VirtualFun();


            Console.ReadKey();
 
        }
    }
}

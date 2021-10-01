using System;

namespace Lan2_attechment
{
    class A
    {
        public A() { }
        public class B
        {
            public B() { }
            public class D
            {
                public D() { }
                public void mD() { Console.WriteLine("method of D"); }
            }

            public class K
            {
                public K() { }
                public void mK() { Console.WriteLine("method of K"); }
            }

            public void mB() { Console.WriteLine("method of B"); }
            public void mK() { Console.WriteLine("method of B"); }
            public D dA { get { Console.Write("get d -> "); return d; } }
            public K kA { get { Console.Write("get k -> "); return k; } }

            private D d = new D();
            private K k = new K();
        }
        public class C
        {
            public C() { }
            public class E
            {
                public E() { }
                public void mE() { Console.WriteLine("method of E"); }
            }

            public void mC() { Console.WriteLine("method of C"); }
            public E eA { get { Console.Write("get e -> "); return e; } }

            private E e = new E();
        }
        public class J
        {
            public J() { }
            public class F
            {
                public F() { }
                public void mF() { Console.WriteLine("method of F"); }
            }
            public void mJ() { Console.WriteLine("method of J"); }
            public F fA { get { Console.Write("get f -> "); return f; } }

            public F f = new F();
        }
        public void mA() { Console.WriteLine("method of A"); }
        public B bA { get { Console.Write("get b -> "); return b; } }
        public C cA { get { Console.Write("get c -> "); return c; } }
        public J jA { get { Console.Write("get j -> "); return j; } }

        private B b = new B();
        private C c = new C();
        private J j = new J();
    }
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            a.mA();

            a.bA.mB();
            a.cA.mC();
            a.jA.mJ();

            a.bA.dA.mD();
            a.bA.kA.mK();

            a.cA.eA.mE();

            a.jA.fA.mF();

            Console.ReadKey();
        }
    }

}

using System;
using System.Security.Cryptography.X509Certificates;
using ConsoleApp7.Binding;
using ConsoleApp7.Inheritence;
using ConsoleApp7.Overriding;

namespace ConsoleApp7
{
    internal class Program
    {
        //static int Sum(int X, int Y)
        //{
        //    return X + Y;
        //}
        //static int Sum(int X, int Y, int Z)
        //{
        //    return X + Y + Z;
        //}

        //static double Sum(double X, double Y)
        //{
        //    return X + Y;
        //}

        //static void EmployeeProcess(FullTimeEmployee emplpyee)
        //{
        //    if(emplpyee is not null)
        //    emplpyee.Fun01();
        //    emplpyee.Fun02();

        //}
        //static void EmployeeProcess(PartTimeEmployee emplpyee)
        //{
        //    if (emplpyee is not null)
        //        emplpyee.Fun01();
        //    emplpyee.Fun02();

        //}
      
        static void EmployeeProcess(Employee emplpyee)
        {
            if (emplpyee is not null)
            {
                emplpyee.Fun01();
                emplpyee.Fun02();
            }

        }
        class Protected
        {
            protected int X1;
        }

        public class PrivateProtected
        {
            private protected int Y = 10;
        }
        public class PrivateProtected2 : PrivateProtected
        {
            public void displayY()
            {
                Y= 20;
                Console.WriteLine(Y);
            }
        }
        class ProtectedInternal
        {
            protected internal int X;
        }
      
        class ProtectedInternal2 : ProtectedInternal
        {
            public void displayX()
            {
                X = 20;
                Console.WriteLine(X);
            }
        }
        static void Main(string[] args)
        {
            #region Inheretance
            // Class Vs Struct
            // 1. Data type ( reference type : Value type)
            // 2. Object ( Heap : Stack)
            // 3. New
            // 4. default 
            // Inheretance
            // x --> y
            // Clean code => DRY (Don't repeat yourself)
            //Parent parent = new Parent(1, 2);
            ////Console.WriteLine(parent);
            ////parent.Fun01();
            //Child child = new Child(5, 3, 2);
            //child.Fun01();
            #endregion
            #region Polymorphism 
            // object => leh aktr mn shakl
            //Console.WriteLine(); // 18
            // 1. polymorphism methods Overloading
            // there are more than one function => have same name nut with different signature (type , count , order) of parameter
            // in same scope (same class or struct)
            //Sum(1, 2); // CANOT enter double number
            //Sum(1.2, 5.5);
            //Sum(1, 2, 3);
            // 2. polymorphism methods overriding
            // more than one function in different class these function have same name and signature but differ in behavior(body)
            // => relationship between them => inheritance
            // object intializer
            //TypeB typeB = new TypeB() { A = 12, B = 13 };
            //typeB.A = 12;
            //typeB.B = 13;
            //Console.WriteLine(typeB.A);
            //typeB.Fun01();
            //typeB.Fun02();
            #endregion

            #region Binding 
            // Refeference from parent ---> object from child
            //TypeA Ref;
            //Ref = new TypeA();
            //Ref = new TypeB();
            // Child is a parent 
            // TypeA == TypeB
            //Ref.A = 15;
            ////Ref.B = 15; // XX
            //Ref.Fun01();// static 
            //// Compiler will bind function call based on Reference type not object type
            //Ref.Fun02(); // TYPEB

            #endregion
            #region Not Binding 
            //TypeB Ref = new TypeB();
            //ref = new TypeA(); XX
            // child is a parent 
            //TypeA Ref = new TypeA();
            //Ref = new TypeB();
            //// valid 
            //TypeB typeB = (TypeB)Ref; // casting not binding 
            #endregion
            #region When use binding
            //FullTimeEmployee fullTime = new FullTimeEmployee()
            //{
            //    Id = 1,
            //    Name = "Mariam",
            //    Email = "mariam@gmail.com",
            //    Address = "Alex",
            //    Salary = 15000

            //};
            //// PartTimeEmployee
            //PartTimeEmployee PartTime = new PartTimeEmployee()
            //{
            //    Id = 2,
            //    Name = "Ahmed",
            //    Email = "Ahmed@gmail.com",
            //    Address = "Alex",
            //    HourRate = 300,
            //    NumOfHours = 100,

            //};
            //EmployeeProcess(PartTime);
            //#endregion

            //#region Binding example
            //TypeA typeA;
            //typeA = new TypeA();
            //typeA = new TypeB(); // TypeA is parent of TypeB
            //typeA = new TypeC(); // TypeA is indirect Parent
            //typeA.A = 12;
            ////typeA.B = 15; // XX
            //typeA.Fun01(); // fromType A
            //typeA.Fun02(); // Virtual ==> akher override typeD

            #endregion
            #region Task
            // Task 01: Draw memory 
            // Task 02: proteted priviedprotected internal protected acessable 
            // 1. protected
            // 	The code is accessible within the same class, or in a class that is inherited from that class.
            Protected P = new Protected();
            //P.X : cannot access the variable X
            // But in can use if the base class is inhirted
            // 2. private protected
            PrivateProtected P3 = new PrivateProtected();
            //P3.displayY(); error can't access the value or the function
            //3. protected internal
            //Only code in the same assembly or in a derived class in another assembly can access this type or member.
            ProtectedInternal2 P2 = new ProtectedInternal2();
            //P2.X = 1;
            P2.displayX(); // =20
            // protected + private
            #endregion



        }
    }
}

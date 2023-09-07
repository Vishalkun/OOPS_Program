using static OOPS_Concept.@interface;
using static OOPS_Concept.singleinheritance;

namespace OOPS_Concept
{
    internal class Program
    {
       
        static void ChangeReferenceType(string name)
        {
            name = "Steve";
        }
        static void ChangeValue(int x)
        {
            x = 200;

            Console.WriteLine(x);
        }
        static void Main(string[] args)
        {

            string name = "Bill";

            ChangeReferenceType(name);

            Console.WriteLine(name);
            int i = 100;

            Console.WriteLine(i);

            ChangeValue(i);

            Console.WriteLine(i);
            //Class_object co=new Class_object();
            //co.classandmethod();

            // Programmer p1 = new Programmer();

            // Console.WriteLine("Salary: " + p1.salary);
            //Console.WriteLine("Bonus: " + p1.bonus);

            /* overloading ob = new overloading();

             int sum1 = ob.Add(1, 2);
             Console.WriteLine("sum of the two "
                               + "integer value : " + sum1);

             int sum2 = ob.Add(1, 2, 3);
             Console.WriteLine("sum of the three "
                               + "integer value : " + sum2);*/
            /* encapsulation encap = new encapsulation();
             encap.Name = "vishal";
             encap.Age = 21;  
             Console.WriteLine(" Name : " + encap.Name);
             Console.WriteLine(" Age : " + encap.Age);*/
            //derived d = new derived();
            //d.show();
            /* Pig myPig = new Pig(); 
             myPig.animalSound();  
             myPig.sleep();*/
            //StudentDetails sd = new StudentDetails();
            //sd.StudentAge();
            Drawable d;
            d = new Rectangle();
            d.draw();
            d = new Circle();
            d.draw();

       





    }
    }
}
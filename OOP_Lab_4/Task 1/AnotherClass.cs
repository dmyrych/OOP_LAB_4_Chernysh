using System;
namespace OOP_Lab_4
{
    public class AnotherClass : SomeClass
    {
        public AnotherClass()
        {
            SomeClass someClass = new SomeClass();
            someClass.Debug(12, "Glory to Ukraine");
        }
    }
}

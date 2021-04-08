using System;
namespace task4
{
    abstract class Employee
    {
        public abstract float Method();
    }

    class child : Employee
    {
        private float salary;

        public child(float salary)
        {
            this.salary = salary;
        }

        public override float Method()
        {
            return salary * 12;
        }
    }
}

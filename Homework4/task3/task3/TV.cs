using System;
namespace task3
{
    abstract class TV
    {
        public abstract float Method();
    }

    class child : TV
    {
        private float hoursWorked;
        private float energyAmount;


        public child(float hoursWorked, float energyAmount)
        {
            this.hoursWorked = hoursWorked;
            this.energyAmount = energyAmount;
        }

        public override float Method()
        {
            return hoursWorked * energyAmount;
        }
    }
}

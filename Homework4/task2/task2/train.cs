using System;
namespace task2
{
    abstract class Train
    {
        public abstract float Calculate();
    }

    class Child1 : Train
    {
        private float time;
        private float speed;

        public Child1(float time, float speed)
        {
            this.time = time;
            this.speed = speed;
        }

        public override float Calculate()
        {
            return time * speed;

        }
    }
    class Child2 : Train
    {
        private float EnergyAmount;
        private float Distnace;

        public Child2(float EnergyAmount, float Distnace)
        {
            this.EnergyAmount = EnergyAmount;
            this.Distnace = Distnace;
        }

        public override float Calculate()
        {
            return EnergyAmount * Distnace;

        }

    }
}


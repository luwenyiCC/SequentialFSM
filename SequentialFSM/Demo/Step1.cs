using System;

namespace SequentialFSM
{
    class Step1 : IState
    {
        float time = 0;
        int val = 0;
        public void OnEnter()
        {
            val = new Random().Next(1, 5);
            Console.WriteLine("Step1 OnEnter");
        }

        public bool OnExecute(float deltaTime)
        {
            Console.WriteLine("Step1 OnExecute");
            time += deltaTime;
            if(val > time)
            {
                return true;
            }
            else
            {
                return false;

            }
        }

        public void OnExit()
        {
            Console.WriteLine("Step1 OnExit");
        }
    }
}

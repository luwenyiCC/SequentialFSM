using System;

namespace SequentialFSM
{
    class Step2 : IState
    {
        float time = 0;
        int val = 0;
        public void OnEnter()
        {
            val = new Random().Next(1, 5);
            Console.WriteLine("Step2 OnEnter");
        }

        public bool OnExecute(float deltaTime)
        {
            Console.WriteLine("Step2 OnExecute");
            time += deltaTime;
            if (val > time)
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
            Console.WriteLine("Step2 OnExit");
        }
    }
}

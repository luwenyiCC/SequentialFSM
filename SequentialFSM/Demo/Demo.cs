using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SequentialFSM.Demo
{
    class Demo
    {
        public static void Main(string [] strg)
        {
            Console.WriteLine("Demo Main Start");
            var fsm = new SequentialFSMControl();
            fsm.EnState(new Step1());
            fsm.EnState(new Step2());
            fsm.EnState(new Step3());
            while (true)
            {
                fsm.Update(0.3f);
                Thread.Sleep(300);
            }
        }
    }
}



using System.Collections.Generic;

namespace SequentialFSM
{
    public class SequentialFSMControl 
    {
        Queue<IState> fsmQueue = new Queue<IState>();
        public SequentialFSMControl()
        {
        }
        public void EnState(IState state)
        {
            fsmQueue.Enqueue(state);

        }

        IState curState = null;
        public void Update(float deltaTime)
        {
            if(curState == null)
            {
                if(fsmQueue.Count > 0)
                {
                    curState = fsmQueue.Dequeue();
                    curState.OnEnter();
                }
            }
            if(curState!= null)
            {
                if (!curState.OnExecute(deltaTime))
                {
                    curState.OnExit();
                    curState = null;
                }
            }
        }

    }

}


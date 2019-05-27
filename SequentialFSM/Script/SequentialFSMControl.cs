

using System.Collections.Generic;

namespace SequentialFSM
{
    /// <summary>
    /// 顺序执行状态机控制器
    /// 使用方法
    /// 1,实例化SequentialFSMControl
    /// 2,添加IState状态对象到队列中
    /// 3,循环执行Update方法 传入执行时间间隔
    /// </summary>
    public class SequentialFSMControl 
    {

        Queue<IState> fsmQueue = new Queue<IState>();

        /// <summary>
        /// 添加要顺序执行的状态
        /// </summary>
        /// <param name="state"></param>
        public void EnState(IState state)
        {
            fsmQueue.Enqueue(state);

        }

        IState curState = null;
        /// <summary>
        /// 此方法需要循环调用
        /// 维护状态的生命周期
        /// </summary>
        /// <param name="deltaTime">调用间隔</param>
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


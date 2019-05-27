
namespace SequentialFSM
{
    /// <summary>
    /// 状态的接口
    /// </summary>
    public interface IState
    {
        /// <summary>
        /// 进入状态
        /// </summary>
        void OnEnter();
        /// <summary>
        /// 离开状态
        /// </summary>
        void OnExit();
        /// <summary>
        /// 循环更新状态
        /// </summary>
        /// <returns>true 未执行完毕 , false 执行完毕</returns>
        bool OnExecute(float deltaTime);

    }
}

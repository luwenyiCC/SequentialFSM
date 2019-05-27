
namespace SequentialFSM
{
    public interface IState
    {
        //进入状态方法
       void OnEnter();
        //离开状态方法
       void OnExit();
        /// <summary>
        /// 更新状态方法
        /// 
        /// </summary>
        /// <returns>true 未执行完毕 , false 执行完毕</returns>
        bool OnExecute(float deltaTime);

    }
}

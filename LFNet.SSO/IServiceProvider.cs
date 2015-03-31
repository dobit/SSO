namespace LFNet.SSO
{
    /// <summary>
    /// 服务提供支持
    /// </summary>
    public interface IServiceProvider
    {
        T GetService<T>() where T : IService;
    }
}
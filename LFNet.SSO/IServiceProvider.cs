namespace LFNet.SSO
{
    /// <summary>
    /// �����ṩ֧��
    /// </summary>
    public interface IServiceProvider
    {
        T GetService<T>() where T : IService;
    }
}
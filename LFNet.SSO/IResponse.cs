using System.Security.Cryptography.X509Certificates;

namespace LFNet.SSO
{
    /// <summary>
    /// 响应数据
    /// </summary>
    /// <typeparam name="TData"></typeparam>
    public interface IResponse<TData>
    {
        int StatusCode { get; set; }
        string Description { get; set; }
        TData Data { get; set; }
    }
}
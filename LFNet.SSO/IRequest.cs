using System;

namespace LFNet.SSO
{
    /// <summary>
    /// ÇëÇóÊý¾Ý
    /// </summary>
    /// <typeparam name="TData"></typeparam>
    public interface IRequest<TData>
    {
        Guid ApplicationId { get; }

        string Token { get; }

        TData Data { get; set; }
    }
}
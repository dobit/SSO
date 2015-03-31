using System;
using System.ComponentModel;

namespace LFNet.SSO
{
    /// <summary>
    /// 应用管理接口
    /// </summary>
    public interface IApplicationManager
    {
        void Add(AppliactionInfo appliactionInfo);

        void Delete(Guid appId);

    }
}
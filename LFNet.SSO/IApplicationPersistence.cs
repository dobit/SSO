using System;
using System.Collections.Generic;

namespace LFNet.SSO.Store
{
    /// <summary>
    /// 应用管理持久化接口
    /// </summary>
    public interface IApplicationPersistence:IPersistence<AppliactionInfo,Guid>
    {

    }
}
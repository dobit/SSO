using System;
using System.Collections.Generic;

namespace LFNet.SSO.Store
{
    public interface IAppStore
    {

        void Update(AppInfo appInfo);

        void Add(AppInfo appInfo);

        void Delete(Guid appId);

        IList<AppInfo> GetList(int pageSize, int page);

        AppInfo Get(Guid appId);
    }
}
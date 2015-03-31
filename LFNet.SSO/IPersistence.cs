using System.Collections.Generic;

namespace LFNet.SSO.Store
{
    /// <summary>
    /// 对象持久化
    /// </summary>
    /// <typeparam name="TObject"></typeparam>
    /// <typeparam name="TIndentify"></typeparam>
    public interface IPersistence<TObject,TIndentify>
    {
        void Update(TObject anobj);

        TIndentify Add(TObject anobj);

        void Delete(TIndentify id);

        IList<TObject> ListAll();

        TObject FindOne(TIndentify id);
    }
}
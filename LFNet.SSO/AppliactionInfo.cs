using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LFNet.SSO
{
    /// <summary>
    /// 应用信息
    /// </summary>
    public class AppliactionInfo
    {
        /// <summary>
        /// 应用id
        /// </summary>
        public Guid AppId { get; set; }

        /// <summary>
        /// 应用名称
        /// </summary>
        public string Name { get; set; }

        public string Description { get; set; }
        /// <summary>
        /// 加密串
        /// </summary>
        public string Secret { get; set; }

        /// <summary>
        /// 应用类型
        /// </summary>
        public int Type { get; set; }
        /// <summary>
        /// 加密类型
        /// </summary>
        public string SecretType { get; set; }
    }
}

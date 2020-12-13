using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 測試DocFX
{/// <summary>
 /// 測試類別
 /// </summary>
    public class EX
    {
        /// <summary>
        /// 數值
        /// </summary>
        public int number { get; set; }
        /// <summary>
        /// 初始化
        /// </summary>
        public EX()
        {

        }
        /// <summary>
        /// 重寫顯示字串
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"數值:{number}";
        }
    }
}

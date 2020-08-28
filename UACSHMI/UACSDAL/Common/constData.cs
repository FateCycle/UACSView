using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UACSDAL
{
    public class constData
    {
        /// <summary>
        /// 平台名称
        /// </summary>
        public const string tagServiceName = "iplature";

        /// <summary>
        /// 机组入口定义
        /// </summary>
        public const int EntrySaddleDefine = 0;

        /// <summary>
        /// 机组出口定义
        /// </summary>
        public const int ExitSaddleDefine = 1;

        /// <summary>
        /// 机组号
        /// </summary>
        public const string UnitNo = "D401";

        public const string bayNo = "2250";

        public const long Z2250BaySpaceX = 339000;
        public const long Z2250BaySpaceY = 42000;


        public const long Z11_Z12BaySpaceX = 400000;
        public const long Z11_Z12BaySpaceY = 42000;

        public const bool xAxisRight = false;
        public const bool yAxisDown = false;
    }
}

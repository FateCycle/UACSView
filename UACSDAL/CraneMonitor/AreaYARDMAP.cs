using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UACSDAL
{
  public  class AreaYARDMAP:ICloneable
    {
        object ICloneable.Clone()
        {
            return this.Clone();
        }

        public AreaYARDMAP Clone()
        {
            return (AreaYARDMAP)this.MemberwiseClone();
        }

        private string cOIL_NO;
        /// <summary>
        /// 方坯号
        /// </summary>
        public string COIL_NO
        {
            get { return cOIL_NO; }
            set { cOIL_NO = value; }
        }



    }
}

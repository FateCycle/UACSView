using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;
using System.Windows.Forms;
using System.IO;

namespace UACSDAL
{

    /// <summary>
    /// L3基类
    /// </summary>
   public class CraneL3 : ICloneable
    {

        object ICloneable.Clone()
        {
            return this.Clone();
        }
        public CraneL3 Clone()
        {
            return (CraneL3)this.MemberwiseClone();
        }

        private string order_Type;
        /// <summary>
        /// 命令类别
        /// ORDER_TYPE
        /// </summary>
        public string Oreder_Type
        {
            get { return order_Type; }
            set { order_Type = value; }
        }
       
       private string mat_no_1;
        /// <summary>
        ///方坯号
        /// mat_no_1
        /// </summary>
      public string Mat_no_1
        {

            get { return mat_no_1; }
            set { mat_no_1 = value; }
        }

        private string from_STOCK_NO;
        /// <summary>
        ///方坯号
        /// FROM_STOCK_NO
        /// </summary>
        public string FROM_STOCK_NO
        {

            get { return from_STOCK_NO; }
            set { from_STOCK_NO = value; }
        }


        public CraneL3  getAreaRowDesc(string areaNO)
        {
            CraneL3  cranel3 = new CraneL3();
            try
            {
                string sql = @"SELECT * FROM UACS_CRANE_ORDER_L3";

                using (IDataReader rdr = DB2Connect.DBHelper.ExecuteReader(sql))
                {
                    while (rdr.Read())
                    {
                        if (rdr["ORDER_TYPE"] != System.DBNull.Value)
                        {
                            cranel3.Oreder_Type = rdr["ORDER_TYPE"].ToString ();
                        }
                        if (rdr["MAT_NO_1"] != System.DBNull.Value)
                        {
                            cranel3.Mat_no_1 = rdr["MAT_NO_1"].ToString ();
                        }
                        //if (rdr["X_MAX"] != System.DBNull.Value)
                        //{
                        //    cranel3.Y_Max = Convert.ToInt32(rdr["Y_MAX"]);
                        //}

                        //areaRowsBase.X_Width = areaRowsBase.X_Max - areaRowsBase.X_Min;

                        //areaRowsBase.X_Center = areaRowsBase.X_Width / 2 + areaRowsBase.X_Min;

                        //areaRowsBase.Y_Center = areaRowsBase.Y_Max + 1700;

                        //areaRowsBase.Y_Height = 1400;

                    }
                }
            }
            catch (Exception er)
            { }
            return cranel3;
        }

    }
}

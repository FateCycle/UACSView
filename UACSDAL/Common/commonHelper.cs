using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;

namespace UACSDAL.Common
{
    class commonHelper
    {

        public static IList<T> BindingDaTable2Entitys<T>(DataTable dt)
        {
            IList<T> TList = new List<T>();
            for (int i = 0; i < dt.Rows.Count; i++)            {
                T item = BindingData2Entity<T>(dt, i);
                TList.Add(item);
            }
            return TList;
        }

        public static T BindingData2Entity<T>(DataTable dt, int irow)
        {
            T item = Activator.CreateInstance<T>();  //生成TNYardmapCrane类的实例
            Type t = typeof(T);
            // 获取对象的各个属性
            foreach (PropertyInfo property in t.GetProperties())
            {
                if (!dt.Columns.Contains(property.Name) || dt.Rows[irow][property.Name] == null || dt.Rows[irow][property.Name] == DBNull.Value)
                    continue;
                // datatable 有对应的t的属性值，那么取出来进行赋值
                try
                {
                    //因为不能将decimal强转为int,多加个判断
                    if ("Int32".Equals(property.PropertyType.Name) || "Nullable`1".Equals(property.PropertyType.Name))
                    {
                        property.SetValue(item, Convert.ToInt32(dt.Rows[irow][property.Name]), null);
                    }
                    else if ("Double".Equals(property.PropertyType.Name))
                    {
                        property.SetValue(item, Convert.ToDouble(dt.Rows[irow][property.Name]), null);
                    }
                    else
                    {
                        property.SetValue(item, dt.Rows[irow][property.Name], null);
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            return item;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeDemo
{
    public static class AttributeExtend
    {
        public static void Validate<T>(this T tModel) where T : new()
        {
            Type type = tModel.GetType();
            foreach (var prop in type.GetProperties())
            {
                if (prop.IsDefined(typeof(AbstractValidateAttribute), true))
                {
                    object[] attributeArray = prop.GetCustomAttributes(typeof(AbstractValidateAttribute), true);
                    foreach (AbstractValidateAttribute attribute in attributeArray)
                    {
                        if (attribute.Validate(prop.GetValue(tModel, null)))
                        {
                            //return true;//表示终止
                            throw new Exception(string.Format("{0}的值不可为{1}", prop.Name, prop.GetValue(tModel, null) == null ? "null" : prop.GetValue(tModel, null).ToString()));
                        }
                    }
                }
            }
            //return false;
        }


    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using ValidationAttributes.Attributes;

namespace ValidationAttributes
{
    public static class Validator
    {
        public static bool IsValid(object obj)
        {
            Type objType = obj.GetType();
            PropertyInfo[] propertyInfos = objType.GetProperties();

            foreach (var propInfo in propertyInfos)
            {
                List<MyValidationAttribute> myAttributes = propInfo.GetCustomAttributes<MyValidationAttribute>().ToList();

                object propertyObj = propInfo.GetValue(obj);

                foreach (var myValidationAttribute in myAttributes)
                {
                    bool isValid = myValidationAttribute.IsValid(propertyObj);

                    if (!isValid)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}

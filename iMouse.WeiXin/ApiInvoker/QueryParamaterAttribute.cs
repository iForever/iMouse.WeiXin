using System;
using System.Reflection;

namespace iMouse.WeiXin.ApiInvoker
{
    internal class QueryParamaterAttribute : Attribute
    {
        public QueryParamaterAttribute(string paramaterName)
        {
            ParamaterName = paramaterName;
        }

        public QueryParamaterAttribute(string paramaterName, bool isRequired = false, bool isEnum = false)
            : this(paramaterName)
        {
            IsRequired = isRequired;
            IsEnum = isEnum;
        }

        public string ParamaterName { get; }

        public bool IsRequired { get; } = false;
        public bool IsEnum { get; }


        public bool TryQueryParamterValue(PropertyInfo item, object sender, out string? result)
        {
            result = null;
            var paramValue = item.GetValue(sender);
            if (paramValue == null)
                return false;

            result = paramValue.ToString();

            if (paramValue.GetType().IsEnum)
            {
                var type = paramValue.GetType();
                string? enumName = Enum.GetName(type, paramValue);
                if (enumName != null)
                {
                    var field = type.GetField(enumName);
                    var valueAttr = field?.GetCustomAttribute<QueryParamaterValueAttribute>(false);
                    result = valueAttr?.ParamaterValue;
                }
            }
            else if (paramValue.GetType() == typeof(bool))
            {
                result = result?.ToLowerInvariant();
            }

            return true;
        }
    }


    public class QueryParamaterValueAttribute : Attribute
    {
        public QueryParamaterValueAttribute(string paramaterValue)
        {
            ParamaterValue = paramaterValue;
        }

        public string ParamaterValue { get; }
    }

}




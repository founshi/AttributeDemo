using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeDemo
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public sealed class RequiredAttribute:Attribute
    {
        public  bool Validate(object value)
        {
            if (value == null) return true;
            if (string.IsNullOrEmpty(value.ToString())) return true;
            if (string.IsNullOrWhiteSpace(value.ToString())) return true;
            return false;
        }
    }
}

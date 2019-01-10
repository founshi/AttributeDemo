using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeDemo
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public sealed class NullEmptyAttribute : AbstractValidateAttribute
    {
        public override bool Validate(object value)
        {
            if (null == value) return true;
            return string.IsNullOrEmpty(value.ToString());
        }
    }
}

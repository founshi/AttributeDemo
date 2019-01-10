using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeDemo
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public sealed class NumberAttribute : AbstractValidateAttribute
    {
        public override bool Validate(object value)
        {
            if (null == value) return true;
            decimal outval = 0;
            if (!Decimal.TryParse(value.ToString(), out outval))
            {
                return true;
            }
            return false;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeDemo
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public sealed class NullAttribute : AbstractValidateAttribute
    {
        public override bool Validate(object value)//
        {
            return value == null ? true : false;
        }
    }
}

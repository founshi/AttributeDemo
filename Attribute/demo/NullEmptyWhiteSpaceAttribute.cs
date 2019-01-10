using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeDemo
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public sealed class NullEmptyWhiteSpaceAttribute : AbstractValidateAttribute
    {
        public override bool Validate(object value)
        {
            bool _vali = false;
            _vali = value == null ? true : false;//NULL
            if (_vali) return _vali;
            _vali = _vali && string.IsNullOrEmpty(value.ToString());
            if (_vali) return _vali;
            _vali = _vali && string.IsNullOrWhiteSpace(value.ToString());
            if (_vali) return _vali;
            return _vali;
        }
    }
}
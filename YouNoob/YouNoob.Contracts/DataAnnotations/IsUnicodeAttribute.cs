using System;

namespace YouNoob.Contracts.DataAnnotations
{
    public class IsUnicodeAttribute : Attribute
    {
        public IsUnicodeAttribute(bool isUnicode)
        {
            this.IsUnicode = isUnicode;
        }

        public bool IsUnicode { get; private set; }
    }
}
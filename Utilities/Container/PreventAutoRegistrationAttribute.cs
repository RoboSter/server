using System;

namespace Utilities.Container
{
    public class PreventAutoRegistrationAttribute : Attribute
    {
        public string Reason { get; }

        public PreventAutoRegistrationAttribute()
        {
            
        }

        public PreventAutoRegistrationAttribute(string reason)
        {
            Reason = reason;
        }
    }
}
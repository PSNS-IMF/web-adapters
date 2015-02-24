using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Web.Helpers;

namespace Psns.Common.Web.Adapters
{
    /// <summary>
    /// An adapter for AntiForgery.Validate to better enable loose coupling
    /// </summary>
    public static class AntiForgeryHelperAdapter
    {
        /// <summary>
        /// An alternate validation function that will be called instead of AntiForgery.Validate
        /// </summary>
        public static Action ValidationFunction;

        /// <summary>
        /// Will call ValidationFuncion if defined; otherwise, Antiforgery.Validate is called
        /// </summary>
        public static void Validate()
        {
            if(ValidationFunction != null)
                ValidationFunction.Invoke();
            else
                AntiForgery.Validate();
        }
    }
}

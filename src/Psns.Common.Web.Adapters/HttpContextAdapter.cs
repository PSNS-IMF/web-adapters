using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Web;

namespace Psns.Common.Web.Adapters
{
    /// <summary>
    /// An adapter for HttpContext.Current to better enable loose coupling
    /// </summary>
    public class HttpContextAdapter
    {
        static HttpContextBase _context;

        /// <summary>
        /// Unless explicitly set, HttpContext.Current is returned
        /// </summary>
        public static HttpContextBase Current
        {
            get
            {
                if(_context != null)
                    return _context;

                if(HttpContext.Current == null)
                    throw new InvalidOperationException("HttpContext is not available");

                return new HttpContextWrapper(HttpContext.Current);
            }

            set { _context = value; }
        }
    }
}

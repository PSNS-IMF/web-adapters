using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Web;

namespace Psns.Common.Web.Adapters
{
    /// <summary>
    /// An adapter for HttpRequest.ClientCertificate to better enable loose coupling
    /// </summary>
    public class HttpClientCertificateAdapter
    {
        static string _subject;

        /// <summary>
        /// Unless explicitly set, HttpContext.Current.Request.ClientCertificate.Subject is returned
        /// </summary>
        public static string Subject
        {
            get
            {
                return _subject ?? HttpContext.Current.Request.ClientCertificate.Subject;
            }

            set { _subject = value; }
        }
    }
}

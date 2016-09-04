using System;
using System.Collections.Generic;
using System.Text;
using DnDnsCore.Query;

namespace DnDnsCore.Security
{
    public interface IMessageSecurityProvider
    {
        DnsQueryRequest SecureMessage(DnsQueryRequest dnsQueryRequest);
    }
}

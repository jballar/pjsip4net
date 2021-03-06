using pjsip4net.Core;
using pjsip4net.Core.Data;

namespace pjsip4net.Interfaces
{
    internal interface IVoIPTransportFactory
    {
        IVoIPTransport CreateTransport(TransportType transportType);
        IVoIPTransport CreateTransport(TransportType transportType, TransportConfig config);
    }
}
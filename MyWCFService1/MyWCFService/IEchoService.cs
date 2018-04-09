using System.ServiceModel;

namespace MyWCFService
{
    [ServiceContract]
    public interface IEchoService
    {
        [OperationContract]
        string GetData(int value);
    }
}

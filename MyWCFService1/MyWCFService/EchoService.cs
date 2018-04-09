namespace MyWCFService
{
    public class EchoService : IEchoService
    {
        public string GetData(int value)
        {
            return string.Format("Yes yes yes I got: {0}", value);
        }
    }
}

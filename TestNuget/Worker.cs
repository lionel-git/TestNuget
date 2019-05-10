using System.Text;
using Google.Protobuf;

namespace TestNuget
{
    public class Worker
    {
        public int DoSumLength( int a, int b)
        {
            var x = ByteString.CopyFrom("toto", Encoding.ASCII);
            return a + b + x.Length;
        }
    }
}

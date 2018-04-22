using System;

namespace CSharpServices
{
    public class ACSharpService : ICSharpService
    {
        public int Double(int x)
        {
            return x * 2;
        }
    }
}

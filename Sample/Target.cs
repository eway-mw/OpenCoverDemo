using System;

namespace Sample
{
    public static class Target
    {
        public static int AddOne(int x)
        {
            return x + 1;
        }

        public static int AddTwo(int x)
        {
            throw new NotImplementedException();
        }
    }
}

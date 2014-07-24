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

        public static int MethodWithBranching(int x)
        {
            switch (x)
            {
                case 1:
                    return 1;
                case 2:
                    return 2;
                case 3:
                    return 3;
                default:
                    throw new ArgumentOutOfRangeException("x");
            }
        }
    }
}

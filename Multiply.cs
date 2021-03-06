using System;

namespace InterviewPreps
{
    class Multiplier
    {
        private readonly int p1;
        private readonly int p2;

        public Multiplier(int p1, int p2)
        {
            this.p1 = p1;
            this.p2 = p2;
        }

        internal int Multiply()
        {
            if (this.p1 == 0 || this.p2 == 0)
            {
                return 0;
            }

            int res = this.p1;
            // dont like the fact that I am checking for the same thing here
            int max = (this.p2 < 0) ? 0 - this.p2 : this.p2;

            for (int i = 1; i < max; i++)
            {
                res += this.p1;
            }

            // and here...
            res = (this.p2 < 0) ? 0 - res : res;
            return res;
        }
    }
}

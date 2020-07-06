using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WhatsNewCSharp8
{
    public static class AsyncIterators
    {
        public static async Task Demo()
        {
            await foreach (var number in GenerateSequence())
            {
                System.Console.WriteLine($"The time is {DateTime.Now:hh:mm:ss}. Retrieved {number}");
            }
        }

        internal static async IAsyncEnumerable<int> GenerateSequence()
        {
            for (int i = 0; i < 50; i++)
            {
                if (i % 10 == 0)
                    await Task.Delay(2000);
                yield return i;
            }
        }
    }
}

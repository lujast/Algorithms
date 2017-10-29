using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.AccordingToBook.Lib
{
    public class Timer
    {
        private TimeSpan startingTime;
        private TimeSpan duration;

        public Timer()
        {
            this.startingTime = new TimeSpan(0);
            this.duration = new TimeSpan(0);

        }

        public void Start()
        {
            this.startingTime = Process.GetCurrentProcess().Threads[0].UserProcessorTime;

        }

        public void End()
        {
            this.duration = Process.GetCurrentProcess().Threads[0].UserProcessorTime.Subtract(this.startingTime);
        }

        public TimeSpan GetResult()
        {
            return this.duration;
        }

    }
}

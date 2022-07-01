using System;

namespace StopWatch
{
    public partial class Program
	{
        public class StopWatch
        {
            private TimeSpan _duration;
            private DateTime _startTime;
            private DateTime _endTime;
            private bool watchActive = false;

            //public StopWatch ()
            //{
            //}

            //public StopWatch (bool watchActive)
            //    : this()
            //{
            //    this.watchActive = watchActive;
            //}

            public void SetWatchActive (bool active)
            {
                watchActive = active;
            }

            public bool GetWatchActive ()
            {
                return watchActive;
            }

            public void Start()
            {
                if (!watchActive)
                {
                    _startTime = DateTime.Now;
                    watchActive = true;
                }
                else
                {
                    throw new Exception("Stopwatch already running");
                }
            }

            public string Stop()
            {
                if (watchActive)
                {
                    _endTime = DateTime.Now;
                    _duration = _endTime - _startTime;
                    watchActive = false;
                }
                    return _duration.ToString();
            }
        }
	}
}


using System;

namespace Exercise1_DesignAStopwatch
{
    class Stopwatch
    {
        private DateTime _startTime;                        // Start Time
        private DateTime _endTime;                          // End Time
        public TimeSpan Duration { get; private set; }      // Active Time Duration
        private bool _inUse;                                // Stopwatch in use flag

        /*
         * --- Constructor ---
         * Used to reset the stopwatch before initial use.
         */
        public Stopwatch()
        {
            // Reset the stopwatch
            Reset();
        }

        /*
         * --- Start ---
         * Used to start the stopwatch if not in use.
         */
        public void Start()
        {
            try
            {
                if (_inUse)
                {
                    throw new InvalidOperationException("_inUse");
                }

                _startTime = DateTime.Now;
                _inUse = true;
            }

            catch (InvalidOperationException)
            {
                Console.WriteLine("The stopwatch has already been started.");
                return;
            }
        }

        /*
         * --- End ---
         * Used to stop the stopwatch if in use.
         */
        public void End()
        {
            try
            {
                if (!_inUse)
                {
                    throw new InvalidOperationException("_inUse");
                }

                _endTime = DateTime.Now;
                Duration = _endTime - _startTime;
                _inUse = false;
            }

            catch (InvalidOperationException)
            {
                Console.WriteLine("The stopwatch has not yet been started.");
            }
        }

        /*
         * --- Reset ---
         * Used to set the stopwatch to an initial ready state
         */
        public void Reset()
        {
            _startTime = DateTime.Now;
            _endTime = _startTime;
            Duration = TimeSpan.Zero;
            _inUse = false;
        }
    }
}
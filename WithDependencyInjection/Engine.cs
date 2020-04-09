using System;

namespace WithDependencyInjection
{
    public class Engine
    {
        private readonly ILog _log;
        private readonly int _id; 

        public Engine(ILog log)
        {
            this._log = log;
            this._id = new Random().Next();
        }

        public Engine(ILog log, int id)
        {
            this._log = log;
            this._id = id;
        }

        public void Start(int power)
        {
            _log.Write($"Engine [{_id}] started with {power}");
        }

    }
}
﻿namespace WithDependencyInjection
{
    public class Car
    {
        private readonly Engine _engine;
        private readonly ILog _log;

        public Car(Engine engine, ILog log)
        {
            this._engine = engine;
            this._log = log;
        }

        public Car(Engine engine)
        {
            this._engine = engine;
            this._log = new EmailLog();
        }

        public void Go(int power)
        {
            _engine.Start(power);
            _log.Write("Car is started");
        }
    }
}
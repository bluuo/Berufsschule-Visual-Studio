using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PatternObserver;
namespace BusinessLogic
{
    /// <summary>
    /// Das Modell der Geschäftslogik. 
    /// Hier liegen die Daten, die visualisiert werden sollen.
    /// </summary>
    public class Model : Subject
    {
        private Random _random = new Random();
        public bool _halt = false;
        public int Number { set; get; }
        private void delay(long time)
        {
            long time1 = System.Environment.TickCount;
            while ((System.Environment.TickCount - time1) < time)
            {
                System.Windows.Forms.Application.DoEvents();
            }
        }
        public void Start()
        {
            do
            {
                Number = _random.Next(50) + 1;
                this.NotifyObservers(this);
                this.delay(500);
            } while (!_halt);
        }
        public void Stop()
        {
            _halt = true;
        }
    }
}
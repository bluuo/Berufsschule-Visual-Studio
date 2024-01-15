using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace PatternObserver
{
    /// <summary>
    /// Das Interface f�r die observierten Klassen.
    /// </summary>
    public interface IObservable
    {
        void RegisterObserver(IObserver observer);
        void UnRegisterObserver(IObserver observer);
        void NotifyObservers(object obj);
    }
}
using System;
using System.Collections.Generic;
using System.Text;
namespace PatternObserver
{
    /// <summary>
    /// Das Interface, das von den Observern implementiert wird.
    /// </summary>
    public interface IObserver
    {
        void UpdateDisplay(object obj);
    }
}

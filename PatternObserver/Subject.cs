using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace PatternObserver
{
	/// <summary>
	/// Das zu beobachtende Subjekt.
	/// </summary>
	public abstract class Subject : IObservable
	{
		// Eine generische Liste als Container f�r die Observer-Referenzen.
		// Da kommen die Beobachter rein!
		private List<IObserver> _observers = new List<IObserver>();
		#region IObservable Member
		// Ein Observer wird dem Container hinzugef�gt
		public void RegisterObserver(IObserver observer)
		{
			_observers.Add(observer);
		}
		// Ein Observer wird aus dem Container entfernt
		public void UnRegisterObserver(IObserver observer)
		{
			_observers.Remove(observer);
		}
		/// <summary>
		/// F�r alle registrierten Observer wird die Methode UpdateDisplay aufgerufen.
		/// Den Observern kann ein (Gesch�fts-)Objekt �bergeben werden, dass Informationen
		/// f�r die Anzeige enth�lt.
		/// </summary>
		/// <param name="obj">Objekt, dass Informationen f�r die Anzeige enth�lt.</param>
		public void NotifyObservers(object obj)
		{
			foreach (IObserver obs in _observers) obs.UpdateDisplay(obj);
		}
		#endregion
	}
}

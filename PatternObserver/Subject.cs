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
		// Eine generische Liste als Container für die Observer-Referenzen.
		// Da kommen die Beobachter rein!
		private List<IObserver> _observers = new List<IObserver>();
		#region IObservable Member
		// Ein Observer wird dem Container hinzugefügt
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
		/// Für alle registrierten Observer wird die Methode UpdateDisplay aufgerufen.
		/// Den Observern kann ein (Geschäfts-)Objekt übergeben werden, dass Informationen
		/// für die Anzeige enthält.
		/// </summary>
		/// <param name="obj">Objekt, dass Informationen für die Anzeige enthält.</param>
		public void NotifyObservers(object obj)
		{
			foreach (IObserver obs in _observers) obs.UpdateDisplay(obj);
		}
		#endregion
	}
}

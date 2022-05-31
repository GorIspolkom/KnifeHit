using System.Collections.Generic;
using UnityEngine;

public class UsedKnifePool
{
    private List<IObserver> _observers;

    public UsedKnifePool()
    {
        _observers = new List<IObserver>();

    }
    public void Update(Transform transform)
    {
        foreach (IObserver observer in _observers)
            observer.Notify(transform);
    }
    public void Add(IObserver observer) => _observers.Add(observer);
    public void Remove(IObserver observer) => _observers.Remove(observer);
    public void Cleare() => _observers.Clear();
}

using UnityEngine;
using UnityEditor;

[CreateAssetMenu(fileName = "DestroyedTimedLifeEvent", menuName = "Events/DestoyredTimedLifeEvent")]
public class DestoryedTimeLifeEvent : ScriptableObject {
    public delegate void OccuredEvent(TimedLife timedLife);
    public event OccuredEvent OnOccuredEvent;
    public void Raise(TimedLife timedLife) {
        OnOccuredEvent?.Invoke(timedLife);
    }
}

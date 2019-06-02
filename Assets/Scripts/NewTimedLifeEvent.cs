using UnityEngine;
using UnityEditor;

[CreateAssetMenu(fileName = "NewTimedLifeEvent", menuName = "Events/NewTimedLifeEvent")]
public class NewTimedLifeEvent : ScriptableObject {
    public delegate void OccuredEvent(TimedLife timedLife);
    public event OccuredEvent OnOccuredEvent;
    public void Raise(TimedLife timedLife) {
        OnOccuredEvent?.Invoke(timedLife);
    }
}

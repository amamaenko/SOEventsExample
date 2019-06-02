using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimedLifeCounter : MonoBehaviour
{
    public Text timedLifeCounterText;
    public NewTimedLifeEvent newTimedLifeEvent;
    public DestoryedTimeLifeEvent destroyedTimedLifeEvent;

    private int timedLifeCounter = 0;

    private void Start() {
        UpdateHUD();
    }

    private void OnEnable() {
        newTimedLifeEvent.OnOccuredEvent += OnNewTimedLife;
        destroyedTimedLifeEvent.OnOccuredEvent += OnDestroyedTimedLife;
    }

    private void OnDisable() {
        newTimedLifeEvent.OnOccuredEvent -= OnNewTimedLife;
        destroyedTimedLifeEvent.OnOccuredEvent -= OnDestroyedTimedLife;
    }


    private void OnNewTimedLife(TimedLife timedLife) {
        timedLifeCounter++;
        UpdateHUD();
    }

    private void OnDestroyedTimedLife(TimedLife timedLife) {
        timedLifeCounter--;
        UpdateHUD();
    }

    private void UpdateHUD() {
        timedLifeCounterText.text = timedLifeCounter.ToString();
    }
}

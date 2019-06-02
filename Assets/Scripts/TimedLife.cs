using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedLife : MonoBehaviour
{
    public NewTimedLifeEvent newTimedLifeEvent;
    public DestoryedTimeLifeEvent destroyedTimedLifeEvent;

    public float timeToLive = 2.0f;
    private float timer;


    private void Start() {
        newTimedLifeEvent.Raise(this);
    }
    // Update is called once per frame
    void Update() {
        timer += Time.deltaTime;

        if(timer > timeToLive) {
            destroyedTimedLifeEvent.Raise(this);
            Destroy(gameObject);
        }

    }
}

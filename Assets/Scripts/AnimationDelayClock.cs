using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationDelayClock : MonoBehaviour
{
    public float delaytime;
    private bool coRoutineIsOn = false;
    public bool tracked = false;
    bool isCoroutineStarted = false;
    //PlayableDirector animation;
    Animator animat;
    GameObject clock;
    void Start()
    {
        //yield  WaitForSeconds(delaytime);
        clock = GameObject.Find("clockP");
        animat=clock.GetComponent<Animator>();
        //animation = GetComponent<PlayableDirector>();
        //StartCoroutine(DelayedAnimation());
        //trackedBegin();
    }



    void trackedBegin()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (tracked == true)
        {
            if (!isCoroutineStarted)
            {
                StartCoroutine(DelayedAnimation());
            }
            //animation.Play();
        }
    }

    IEnumerator DelayedAnimation()
    {
        yield return new WaitForSeconds(delaytime);
        //animat.Play("C4D Animation Take");
        animat.enabled = true;
    }
}

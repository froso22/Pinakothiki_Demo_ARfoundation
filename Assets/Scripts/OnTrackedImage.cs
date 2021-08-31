using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.UI;

public class OnTrackedImage : MonoBehaviour
{
   

    ARTrackedImageManager manag_tracked;
    GameObject detectText;
    Behaviour clockDelay;
    
    // Start is called before the first frame update
    void Start()
    {
        manag_tracked = GetComponent<ARTrackedImageManager>();
        detectText = GameObject.Find("DetectedMsg");
        clockDelay = GameObject.Find("clockP").GetComponent<AnimationDelayClock>();
    }
    void OnEnable()
    {
        manag_tracked.trackedImagesChanged += OnTrackedImagesChanged;
    }

    void OnDisable()
    {
        manag_tracked.trackedImagesChanged -= OnTrackedImagesChanged;
    }

    void OnTrackedImagesChanged(ARTrackedImagesChangedEventArgs eventArgs)
    {

        foreach (ARTrackedImage trackedImg in eventArgs.added)
        {

            if (trackedImg.trackingState == TrackingState.Tracking)
            {
                //trackedImg is tracked
                detectText.SetActive(true);
                clockDelay.enabled = true;

            }
            else
            {
                //trackedImg is lost  
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

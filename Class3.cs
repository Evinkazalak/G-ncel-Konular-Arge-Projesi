using System;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class Class1
{
    public Class1()
    {

    }
//ARRaycastManager Kullanımı



    public class ShapePlacement : MonoBehaviour
    {
        public GameObject shapePrefab;
        private ARRaycastManager raycastManager;

        void Start()
        {
            raycastManager = FindObjectOfType<ARRaycastManager>();
        }

        void Update()
        {
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);
                if (touch.phase == TouchPhase.Began)
                {
                    PlaceShape(touch.position);
                }
            }
        }
        void PlaceShape(Vector2 touchPosition)
        {
            List<ARRaycastHit> hits = new List<ARRaycastHit>();
            if (raycastManager.Raycast(touchPosition, hits, TrackableType.PlaneWithinPolygon))
            {
                Pose hitPose = hits[0].pose;
                Instantiate(shapePrefab, hitPose.position, hitPose.rotation);
            }
        }
    }

}


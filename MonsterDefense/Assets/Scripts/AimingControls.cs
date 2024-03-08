using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponAiming : MonoBehaviour
{
    
    public GameObject particle;
    public Camera screen;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    Vector3 startPosition;
    Vector3 endPosition;
    Vector3 worldStartPosition;
    Vector3 worldEndPosition;
    
    // Update is called once per frame
    void Update()
    {
        //creates visual indication of where your fingers have touched
        foreach(Touch touch in Input.touches)
        {
            if (touch.phase == TouchPhase.Began)
            {
                startPosition = touch.position;
            } 
            else if (touch.phase == TouchPhase.Ended)
            {
                endPosition = touch.position;
            }

            if (startPosition!=Vector3.zero && endPosition!=Vector3.zero)
            {
                worldStartPosition = screen.ScreenToWorldPoint(startPosition);
                worldEndPosition = screen.ScreenToWorldPoint(endPosition);
                worldStartPosition.z = 0;
                worldEndPosition.z = 0;
                Instantiate(particle, worldStartPosition, Quaternion.identity);
                Instantiate(particle, worldEndPosition, Quaternion.identity);
                
                Debug.DrawLine(worldStartPosition,worldEndPosition);
                
                Debug.Log("LINE MADE");
                startPosition=Vector3.zero;
                endPosition=Vector3.zero;
            }
        }
    }
}

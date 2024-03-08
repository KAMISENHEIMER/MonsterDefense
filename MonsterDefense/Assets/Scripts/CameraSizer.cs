using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSizer : MonoBehaviour
{
    // Start is called before the first frame update
    public SpriteRenderer screenBounds; 
    void Start()
    {
        float orthoSize = screenBounds.bounds.size.x * Screen.height / Screen.width * .5f;
        Camera.main.orthographicSize = orthoSize;
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public GameObject Scoreboard;

    Vector3 touchedPosition;
    
    // Update is called once per frame
    void Update()
    {
        foreach(Touch touch in Input.touches)
        {
            if (touch.phase == TouchPhase.Ended)
            {
                touchedPosition = Camera.main.ScreenToWorldPoint(touch.position);
                touchedPosition.z = 0f;

                if (Vector3.Distance(touchedPosition, transform.position) < 50)
                Destroy(gameObject);
                
            }
        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clickable : MonoBehaviour
{

    public GameObject Scoreboard;
    public int AddAmount = 1;

    Vector3 touchedPosition;
    Vector2 size;
    public Sprite idleSprite;
    public Sprite clickedSprite;


    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = idleSprite;
        size = GetComponent<SpriteRenderer>().bounds.size;
    }
	
    


    // Update is called once per frame
    void Update()
    {
        foreach(Touch touch in Input.touches)
        {
            if (touch.phase == TouchPhase.Began)
            {
                touchedPosition = Camera.main.ScreenToWorldPoint(touch.position);
                touchedPosition.z = 0f;

                if (gameObject.GetComponent<CircleCollider2D>().OverlapPoint(touchedPosition))
                    gameObject.GetComponent<SpriteRenderer>().sprite = clickedSprite;
                


            }
            if (touch.phase == TouchPhase.Ended)
                gameObject.GetComponent<SpriteRenderer>().sprite = idleSprite;
        }
        
    }
}
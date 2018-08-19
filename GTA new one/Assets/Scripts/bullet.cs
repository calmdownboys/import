using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour {
public int horiz =0;
public int vertic =0;
public int max_speed=1;
	// Use this for initialization
	void Start () {
		
		
	}
	
	// Update is called once per frame
	void Update () {
		if ((Input.GetKey(KeyCode.Space)))
		{  
			gameObject.SetActive(true);
			horiz = 1;
			vertic = 0;
			Move();
			//gameObject.SetActive(true);  //пока не работает
			
		}
		if (GetComponent<Transform>().position.x >= 0.1)
		{
			DestroyBullet();
			
		}
	}
	void DestroyBullet()
	{
		Destroy(gameObject);
		gameObject.SetActive(false);
	}
	       void Move()
        {
            if ((horiz != 0) && (vertic == 0))
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(horiz * max_speed, GetComponent<Rigidbody2D>().velocity.y);
              
             }

             if ((vertic != 0) && (horiz == 0))
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, vertic * max_speed);
            
             }
		}
		}

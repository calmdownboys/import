using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maincharactermoving : MonoBehaviour {
    public int max_speed = 5;
    public int horiz = 0;
    public int vertic = 0;
    // Use this for initialization
    void Start () {

       
	}
	
	// Update is called once per frame
	void Update () {
        if ((Input.GetKey(KeyCode.RightArrow)) | (Input.GetKey(KeyCode.D))) //right side
        {
            horiz = 1;
            Move();
            GetComponent<Transform>().rotation = new Quaternion(0,0,0,0);
        }
        else if ((Input.GetKey(KeyCode.LeftArrow)) | (Input.GetKey(KeyCode.A))) //left side
        {
            horiz = -1;
            Move();
                GetComponent<Transform>().rotation = new Quaternion(0,0,180,0);
            
        }
        else if ((Input.GetKey(KeyCode.UpArrow)) | (Input.GetKey(KeyCode.W))) //up side
        {
            vertic = 1;
            Move();
            GetComponent<Transform>().rotation = new Quaternion(0,0,180,180);
        }
        else if ((Input.GetKey(KeyCode.DownArrow)) | (Input.GetKey(KeyCode.S))) //down side
        {
            vertic = -1;
            Move();
             GetComponent<Transform>().rotation = new Quaternion(0,0,180,-180);
        }
      
        
        else
        {
            horiz = 0;
            vertic = 0;
            Stop();
        }
    }
    //describing walking
    void Move () {
        if ((horiz != 0)&&(vertic == 0))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(horiz * max_speed, GetComponent<Rigidbody2D>().velocity.y);
           // Debug.Log(GetComponent<Rigidbody2D>().velocity);
        }

       if ((vertic != 0)&&(horiz == 0))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, vertic * max_speed);
           // Debug.Log(GetComponent<Rigidbody2D>().velocity);
        }
        /*if (((horiz > 0) && (vertic > 0)) | ((horiz<0) && (vertic >0))) //definately works, but it's hard to reproduce
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(vertic * max_speed, GetComponent<Rigidbody2D>().velocity.x);
        }
        if (((horiz > 0) && (vertic < 0)) | ((horiz > 0) && (vertic < 0)))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, horiz * max_speed);
        }*/

        //i am not sure about this part above, definetely need to look through and analyse, cause it's really tough to reproduce diagonal движение.
}
    void Stop()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, GetComponent<Rigidbody2D>().velocity.y);
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, GetComponent<Rigidbody2D>().velocity.x);
    }

}


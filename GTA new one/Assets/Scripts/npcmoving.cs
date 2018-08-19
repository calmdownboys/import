using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npcmoving : MonoBehaviour {
    public int max_speed = 5;
    public int horiz = -1;
    public int vertic = 0;
    // Use this for initialization

    void Start () {
    
		Move();
        
	}

    // Update is called once per frame
    void Update()
    {/*Вот то что снизу - работает, какого хера я хз и как, но работает, бтв это логично
        По идее нпц теперь двигается, надо проверить привязку по координатам и про столкновения  объектами
        то бишь ща заполню трелло, когда сяду допиливать обяз надо проверить*/
        
        if ((GetComponent<Transform>().position.x <= -4) && (GetComponent<Transform>().position.y<=-3))
        {
            Stop();
            vertic = 1;
            horiz  = 0;
            
            GetComponent<Transform>().rotation = new Quaternion(0,0,180,180);
            
            
        }
        if ((GetComponent<Transform>().position.x <= -4) && (GetComponent<Transform>().position.y >= 1))
        {
            Stop();
            vertic = 0;
            horiz = 1;
          GetComponent<Transform>().rotation = new Quaternion(0,0,0,0);
        }
        if ((GetComponent<Transform>().position.y >= 0.99) && (GetComponent<Transform>().position.x >= 0.21))
        {
            Stop();
            vertic = -1;
            horiz = 0;
             GetComponent<Transform>().rotation = new Quaternion(0,0,180,-180);
        }
        if ((GetComponent<Transform>().position.y<=-3.6) && (GetComponent<Transform>().position.x >= 0.2))
        {   Stop();
            horiz = -1;
            vertic = 0;
             GetComponent<Transform>().rotation = new Quaternion(0,0,180,0);
        }

        
        Move();
       
    

      
        
    }
        

       /* void Rotate()
        {короче потом покурить ротейшн адекватно, вроде как реализовать просто но кватернион работает не понятно
        надо посмотреть что конкретно передавать
            GetComponent<Transform>().rotation = new 
        }* */
        void Rotation()
        {
            if ((horiz == -1) && (vertic == -1))
            {
                
            }
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
        void Stop()
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, GetComponent<Rigidbody2D>().velocity.y);
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, GetComponent<Rigidbody2D>().velocity.x);
        }
    }


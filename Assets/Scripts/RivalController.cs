using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RivalController : MonoBehaviour
{
   	public Transform target;
   	public float speed = 3f;
   	public Rigidbody2D rb;
   	Vector2 mousePos;
   	public Camera cam;
   	public Rigidbody2D PlayerRb;
    public float distance = 5f;

    void Start()
    {
    	mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }

    void Update()
    {
        if(Vector2.Distance(transform.position, target.position) >= distance)
        {
        	 transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
     	
     	Vector2 lookDir = target.position - transform.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;
        rb.rotation = angle;

    }


		IEnumerator Knockback(float duration, float power, Transform obj)
		{
			float timer = 0;

			while(duration > timer)
			{
				timer =  Time.deltaTime;
				Vector2 dir = (mousePos - PlayerRb.position).normalized;
				rb.AddForce(-dir * 30);
			}

			yield return 0;
		}
}

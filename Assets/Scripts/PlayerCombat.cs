using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
     public Animator LeftPunch;
     public Animator RightPunch;
     public Transform LeftHitPoint;
     public Transform RightHitPoint;
     public float Range = 0.5f;
     public LayerMask PunchableLayers;
     public float AttackRate = 2f;
     float nextAttackTime = 0f;

    void Start()
    {}

    void Update()
    {
        
    	if(Time.time >= nextAttackTime)
    	{
    		if(Input.GetKeyDown(KeyCode.Mouse0))
        	{
        		Attack();
        		nextAttackTime = Time.time + 1f/AttackRate;
        	}
    	}
    }

    void Attack()
    {
		int num = Random.Range(1,3);

		if(num == 1)
		{
			LeftPunch.SetTrigger("Punch");
			Collider2D[] LeftPunchableObjects = Physics2D.OverlapCircleAll(LeftHitPoint.position, Range, PunchableLayers);
			
			foreach(Collider2D obj in LeftPunchableObjects)
			{
				print(obj.name);
			}
		}

		else
		{
			RightPunch.SetTrigger("Punch");
			Collider2D[] RightPunchableObjects = Physics2D.OverlapCircleAll(RightHitPoint.position, Range, PunchableLayers);
			foreach(Collider2D obj in RightPunchableObjects)
			{
				print(obj.name);
			}
		}

		void OnDrawGizmosSelected()
		{
			if(LeftHitPoint == null || RightHitPoint == null)
			{
				return;
			}
			
			Gizmos.DrawWireSphere(LeftHitPoint.position, Range);
			Gizmos.DrawWireSphere(RightHitPoint.position, Range);
		}



    }
}

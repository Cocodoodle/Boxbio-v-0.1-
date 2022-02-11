using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopPushing : MonoBehaviour
{
    public CircleCollider2D collider;
    public CircleCollider2D blocker;
    // public CircleCollider2D R_Arm;
    // public CircleCollider2D L_Arm;
    public CircleCollider2D RR_Arm;
    public CircleCollider2D RL_Arm;


    void Start()
    {
        Physics2D.IgnoreCollision(collider, blocker, true);
        Physics2D.IgnoreCollision(collider, RR_Arm, true);
        Physics2D.IgnoreCollision(collider, RL_Arm, true);
        // Physics2D.IgnoreCollision(R_Arm, blocker, true);
        // Physics2D.IgnoreCollision(L_Arm, blocker, true);
        // Physics2D.IgnoreCollision(RL_Arm, L_Arm, true);
        // Physics2D.IgnoreCollision(RR_Arm, L_Arm, true);
        // Physics2D.IgnoreCollision(RL_Arm, R_Arm, true);
        // Physics2D.IgnoreCollision(RR_Arm, R_Arm, true);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

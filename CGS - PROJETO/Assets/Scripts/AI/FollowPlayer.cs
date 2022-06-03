using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class FollowPlayer : MonoBehaviour
{
    public NavMeshAgent Agent;
    public bool Seguir;
    public float WaitTime;

    Animator animator;

    
  //  public Transform VisaoLocal;
 //   public LayerMask Layoso; 
 //   private Vector3 LastPos;


    private void Start()
    {
        Cursor.visible = true;
        Screen.lockCursor = false;
        animator = GetComponent<Animator>();
    }

    void Update()
    {

        animator.SetFloat("Move", Mathf.Abs(Agent.velocity.magnitude));

        if (Seguir == true)
        {
            WaitTime = 0;
        }
        else
        {
            if (WaitTime <= 2)
                WaitTime += 1 * Time.deltaTime;
            if (Agent.destination != transform.position)
                Agent.destination = transform.position;
        }

        if (WaitTime <= 2)
        {
           // RaycastHit Hit = new RaycastHit();
         //   VisaoLocal.LookAt(GameObject.FindWithTag("Player").transform.position);
        //    if (Physics.Raycast(VisaoLocal.position, VisaoLocal.forward, out Hit, 500, Layoso, QueryTriggerInteraction.Ignore))
         //   {
         //       Debug.DrawLine(VisaoLocal.position, Hit.point, Color.green);
          //      if (Hit.transform.gameObject.tag == "Player")
            //    {
                    Agent.destination = GameObject.FindWithTag("Player").transform.position;
             //       LastPos = GameObject.FindWithTag("Player").transform.position; 
            //    }
            //    else
            //    {
            //        if (Agent.destination != LastPos)
            //            Agent.destination = LastPos;
            //    }
            //}
            //else
            //{
            //    if (Agent.destination != LastPos)
            //        Agent.destination = LastPos;
          //  }

            
        }


    }

    void OnCollisionEnter(Collision col)
    {
        if (col.collider.tag == "Player")
        {
            SceneManager.LoadScene("GAMEOVER");
        }
    }


}

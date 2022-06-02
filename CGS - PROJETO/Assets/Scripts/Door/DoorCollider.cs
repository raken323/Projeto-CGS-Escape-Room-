using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorCollider : MonoBehaviour
{

    public Animator myDoor = null;
    public GameObject obj1;
    public GameObject obj2;
    public float dist;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        dist = Vector3.Distance(obj1.transform.position,obj2.transform.position);

        if(dist <= 0.739139)
        {
            myDoor.Play("DoorClose", 0, 0.0f);
        }
        else
        {
            myDoor.Play("DoorOpen", 0, 0.0f);
        }
    }

    //private void OnCollisionStay(Collision collision)
    //{
    //    if(collision.gameObject.tag == "Trigger")
    //    {
    //        myDoor.Play("DoorOpen", 0, 0.0f);
    //    }
    //    else
    //    {
    //        myDoor.Play("DoorClose", 0, 0.0f);
    //    }

    //}
   
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderCheck : MonoBehaviour
{
    public FollowPlayer Script;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Script.Seguir = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            Script.Seguir = false;
        }
    }
}

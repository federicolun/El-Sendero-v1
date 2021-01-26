using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpObject : MonoBehaviour
{
    public Transform pivot;

    private void Start()
    {
    
}
    private void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        //Si el objeto es pickeable
        if(collision.gameObject.tag == "ItemPickeable")
        {
            collision.gameObject.GetComponent<Rigidbody>().isKinematic = true;
            collision.gameObject.GetComponent<BoxCollider>().enabled = false;

            collision.transform.position = pivot.position;
            collision.transform.rotation = pivot.rotation;

            collision.transform.SetParent(pivot);
        }
    }
}

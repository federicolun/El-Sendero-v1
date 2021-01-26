using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicPies : MonoBehaviour
{
    public LogicPlayerMovement logicPlayerMovement;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        logicPlayerMovement.puedoSaltar = true;
    }

    private void OnTriggerExit(Collider other)
    {
        logicPlayerMovement.puedoSaltar = false;
    }
}

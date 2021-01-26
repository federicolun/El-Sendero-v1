using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PruebaDamage : MonoBehaviour
{
    public LogicHealthBar logicHealthBar;

    public float damage = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.G))
        {
            logicHealthBar.vidaActual -= damage; 
        }    
        
    }
}

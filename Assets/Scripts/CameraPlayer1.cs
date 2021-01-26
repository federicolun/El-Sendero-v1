using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPlayer1 : MonoBehaviour
{
    public GameObject player;
    private Vector3 distance;
    // Start is called before the first frame update
    void Start()
    {
        distance = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //cambiamos la position de la camara manteniendo la distancia con el player
        transform.position = player.transform.position + distance; 
    }
}

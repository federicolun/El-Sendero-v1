using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LogicObjeticsTutorial : MonoBehaviour
{
    public int cantidadDeObjetivos;
    public TextMeshProUGUI textoMision;
    public GameObject botonDeMision;

    // Start is called before the first frame update
    void Start()
    {
        cantidadDeObjetivos = GameObject.FindGameObjectsWithTag("Objetivo").Length;
        textoMision.text = "Consigue las cargas magicas" +
                            "\n Restantes: " + cantidadDeObjetivos;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Objetivo")
        {
            Destroy(collider.transform.parent.gameObject);
            cantidadDeObjetivos--;
            textoMision.text = "Consigue las cargas magicas" +
                            "\n Restantes: " + cantidadDeObjetivos;
            if (cantidadDeObjetivos <= 0)
            {
                textoMision.text = "Completaste la mision";
                botonDeMision.SetActive(true);
            }
        }
    }
}

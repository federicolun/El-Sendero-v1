using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicPlayerMovement : MonoBehaviour
{
    public float velocidadMovimiento = 8.0f;
    public float velocidadRotacion = 170.0f;
    private Animator animator;
    public float x, y;

    public Rigidbody rigidBody;
    public float fuerzaDeSalto = 10.0f;
    //public int fuerzaExtra = 0;
    public bool puedoSaltar;

    public bool estoyAtacando;
    public bool avanzoSolo;
    public float impulsoDeGolpe = 50.0f;

    // Start is called before the first frame update
    void Start()
    {
        puedoSaltar = false;
        animator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        if(!estoyAtacando)
        {
            transform.Rotate(0, x * Time.deltaTime * velocidadRotacion, 0);
            transform.Translate(0, 0, y * Time.deltaTime * velocidadMovimiento);
        }

        if(avanzoSolo)
        {
            rigidBody.velocity = transform.forward * impulsoDeGolpe;
        }
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        /*
        if(Input.GetKeyDown(KeyCode.J))
        {
            animator.SetTrigger("arcoEquipado");
        }*/

        if(Input.GetKeyDown(KeyCode.H) && puedoSaltar && !estoyAtacando)
        {
            animator.SetTrigger("golpeo");
            estoyAtacando = true;
        }

        animator.SetFloat("VelX", x);
        animator.SetFloat("VelY", y);

        if (puedoSaltar)
        {
            if (!estoyAtacando)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    animator.SetBool("salte", true);
                    rigidBody.AddForce(new Vector3(0, fuerzaDeSalto, 0), ForceMode.Impulse);
                }
            }
            animator.SetBool("tocoSuelo", true);
        }
        else
        {
            EstoyCayendo();
        }
    }

    public void EstoyCayendo()
    {
        //rigidBody.AddForce(fuerzaExtra * Physics.gravity);
        animator.SetBool("tocoSuelo", false);
        animator.SetBool("salte", false);
    }

    public void DejeDeGolpear()
    {
        estoyAtacando = false;
    }

    public void AvanzoSolo()
    {
        avanzoSolo = true;
    }

    public void DejeDeAvanzar()
    {
        avanzoSolo = false;
    }
}

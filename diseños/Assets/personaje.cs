using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class personaje : MonoBehaviour
{
    public float velocidadPersonaje = 3.0f;
    public float rotarPersonaje = 50.0f;
    private Animator anim;

    public float movimientox, movimientoy;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();


    }

    // Update is called once per frame
    void Update()
    {
        movimientox= Input.GetAxis("Horizontal");
        movimientoy= Input.GetAxis("Vertical");

        transform.Translate(0, 0, movimientoy * Time.deltaTime * velocidadPersonaje);

        transform.Rotate(0, movimientox * Time.deltaTime * rotarPersonaje, 0);

        anim.SetFloat("velocidadX", movimientox);
        anim.SetFloat("velocidadY", movimientoy);
        
        
    }
}

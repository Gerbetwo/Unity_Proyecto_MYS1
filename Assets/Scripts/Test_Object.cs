using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Object : MonoBehaviour
{
    [SerializeField]
    private float speed = 5f;
    public float Horizontal_Input;
    public float Vertical_Input;
    public GameObject proyectil;
    public Boolean colisionObjeto = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Horizontal_Input = Input.GetAxis("Horizontal");
        Vertical_Input = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * Time.deltaTime * speed * Horizontal_Input);
        transform.Translate(Vector3.forward * Time.deltaTime * speed * Vertical_Input);

                //Utilizar click izquierdo para disparar
        if(Input.GetKeyDown(KeyCode.Mouse0)){
            Instantiate(proyectil, transform.position, Quaternion.identity);
            //dispara_Proyectil();
        }

    }
    public void dispara_Proyectil(){

    }
}

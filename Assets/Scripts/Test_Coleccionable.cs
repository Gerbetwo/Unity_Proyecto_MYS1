using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class Test_Coleccionable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void on_trigger_ingresar(Collider otro){
        Debug.Log("Colisiones con:" + otro.name);

        Test_Object jugador = GetComponent<Test_Object>();
        jugador.colisionObjeto = true;
        Destroy(this.gameObject);
    }
}

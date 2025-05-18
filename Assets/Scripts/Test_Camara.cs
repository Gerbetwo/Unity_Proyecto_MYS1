using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text_Clase : MonoBehaviour
{
    public float posX = 0;
    public float posY = 0;
    public float posZ = 0;

    // Start is called before the first frame update
    void Start()
    {
        /*
        Debug.Log("Mi nombre es: " + name);
        Debug.Log("Mi posición en X es: " + transform.position.x);
        Debug.Log("La posición actual es: " + transform.position);
        */
        Debug.Log("Vieja posicion es: " + transform.position);
        transform.position = new Vector3(posX, posY, posZ);
        Debug.Log("Nueva posicion es: " + transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("Hola Mundo");
    }
}

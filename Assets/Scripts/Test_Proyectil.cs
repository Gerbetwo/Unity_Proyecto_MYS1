using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Proyectil : MonoBehaviour
{
    public float speed = 5f;
    public float posZ = 10f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        if (transform.position.z > posZ){
            Destroy(this.gameObject);
        }
    }
}

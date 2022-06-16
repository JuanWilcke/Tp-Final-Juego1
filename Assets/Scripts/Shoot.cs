using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    //Agregan punto de inicio de donde la bala saldra.
    public GameObject BalaInicio;
    //Agregan Bala Prefab
    public GameObject BalaPrefab;
    //Agregar Bala Velocidad
    public float BalaVelocidad;
    float tiempodisparo;
    int disparos;
    private void Start()
    {
        tiempodisparo = 0;
    }
    // Update is called once per frame
   
    void Update()
    {
        if (Time.time > tiempodisparo + 0.5)
        {

        
            if (Input.GetKeyDown(KeyCode.E))
            {
                disparos += 1;
            //1-Instanciar la BalaPrefab en las posiciones de BalaInicio
            GameObject BalaTemporal = Instantiate(BalaPrefab, BalaInicio.transform.position, BalaInicio.transform.rotation) as GameObject;

            //Obtener Rigidbody para agregar Fuerza. 
            Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();

            //Agregar la fuerza a la Bala
            rb.AddForce(transform.forward * BalaVelocidad);


            //Debemos Destruir la bala
            Destroy(BalaTemporal, 5.0f);
                tiempodisparo = Time.time;
            }
        }
    }
}
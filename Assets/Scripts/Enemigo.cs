using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public GameObject jugador;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="jugador")
        {
            gameObject.GetComponent<AudioSource>().Play();
            gameObject.GetComponent<CapsuleCollider>().enabled = false;
            gameObject.GetComponent<MeshRenderer>().enabled = false;
            Destroy(gameObject, 0.6f);
        }      
    }
    // Update is called once per frame
    void OnTriggerEnter(Collider colwithUser)
    {
        if (colwithUser.gameObject.name == "Bala(Clone)")
        {
            transform.position = new Vector3(-4, -4, -4);
            
        }
    }

}

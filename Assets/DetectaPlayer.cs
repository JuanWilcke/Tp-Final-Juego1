using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectaPlayer : MonoBehaviour
{
    public Transform enemigo;
    public Transform jugador;
    public float velocidad;

    private bool activo;
    private Vector3 playerPosicion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerPosicion = new Vector3(jugador.position.x, enemigo.position.y, jugador.position.z);

        if (activo==true)
        {
            enemigo.transform.position = Vector3.MoveTowards(transform.position, playerPosicion, velocidad * Time.deltaTime);
            enemigo.transform.LookAt(playerPosicion);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="jugador")
        {
            activo = true;
        }
    }


}

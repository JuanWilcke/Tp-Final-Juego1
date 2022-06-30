using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MuerteDelJugador : MonoBehaviour
{
   void OnTriggerEnter(Collision col)
    {
        transform.position = new Vector3(0, 0, 0);
    }
}

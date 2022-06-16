using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatarEnemigo : MonoBehaviour
{
   private void OnTriggerEnter(Collider col)
    {
        Enemigo enemy = col.GetComponent<Enemigo>();
        if (enemy != null)
        {
            Destroy(enemy);
        }
    }
}

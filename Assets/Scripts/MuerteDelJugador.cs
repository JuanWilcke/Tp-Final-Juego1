using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MuerteDelJugador : MonoBehaviour
{
   void OncollisionEnter(Collision other)
    {
        SceneManager.LoadScene("SceneDerrota");
    }
}

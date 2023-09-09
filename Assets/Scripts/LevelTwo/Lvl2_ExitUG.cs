using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl2_ExitUG : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(4);
    }
}

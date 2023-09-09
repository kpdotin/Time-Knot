using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitHouse : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D collision)
    {
        SceneManager.LoadScene(1);
    }
}

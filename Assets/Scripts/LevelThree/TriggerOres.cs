using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerOres : MonoBehaviour
{
    public static bool gotInput =  false;
    
    private void OnTriggerStay2D(Collider2D collision)
    {
        StartCoroutine(Mining());
    }

    IEnumerator Mining()
    {
        yield return new WaitForSeconds(1.5f);
        this.gameObject.SetActive(false);
        ThreeLevelManager.oresCollected++;
    }
}

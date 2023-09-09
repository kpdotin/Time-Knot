using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl3_Gears : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        ThreeLevelManager.gearsCollected++;
        this.gameObject.GetComponent<SpriteRenderer>().enabled = false;
        Destroy(this.gameObject);
    }
}

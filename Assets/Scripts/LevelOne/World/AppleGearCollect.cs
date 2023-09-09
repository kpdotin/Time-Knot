using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleGearCollect : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameController.gearsCollected++;
        this.gameObject.GetComponent<SpriteRenderer>().enabled = false;
        ONE_LevelManager.applesGear = false;
        Destroy(this.gameObject);
    }
}

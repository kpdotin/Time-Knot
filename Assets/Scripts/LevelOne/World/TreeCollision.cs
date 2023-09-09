using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeCollision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        ONE_LevelManager.OnAppleCollision(this.gameObject.name);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MerchantInteractLevelOne : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        NPCController.OnInteraction();
    }
}

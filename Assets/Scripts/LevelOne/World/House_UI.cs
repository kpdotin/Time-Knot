using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class House_UI : MonoBehaviour
{
    public TextMeshProUGUI gearCount;

    // Update is called once per frame
    void Update()
    {
        if (GameController.gearsCollected > 0)
        {
            gearCount.text = "Gears Collected = " + GameController.gearsCollected.ToString();
        }
    }
}

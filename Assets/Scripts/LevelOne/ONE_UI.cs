using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ONE_UI : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI apples;
    [SerializeField]
    TextMeshProUGUI gears;

    // Update is called once per frame
    void Update()
    {
        if(ONE_LevelManager.apples > 0) 
        {
            apples.text = "Apples Collected = " + ONE_LevelManager.apples.ToString();
        }
        if(GameController.gearsCollected > 0) 
        {
            gears.text = "Gears Collected = " + GameController.gearsCollected.ToString();
        }
    }
}

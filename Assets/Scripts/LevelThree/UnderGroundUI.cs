using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UnderGroundUI : MonoBehaviour
{
    [SerializeField]TextMeshProUGUI oresText;

    // Update is called once per frame
    void Update()
    {
        if(ThreeLevelManager.oresCollected > 0)
        {
            oresText.text = "Ores collected: " + ThreeLevelManager.oresCollected.ToString();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ThreeLevelManager : MonoBehaviour
{
    public static int oresCollected;
    public static int gearsCollected;

    public static bool showTheGear;

    public GameObject Gear;

    public TextMeshProUGUI gearText;
    private void Update()
    {
        if(gearsCollected > 0)
        {
            gearText.text ="Gears Collected: " + gearsCollected.ToString();
        }
        if(showTheGear)
        {
            Gear.SetActive(true);
            showTheGear = false;
        }
    }

}

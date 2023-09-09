using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class TwoLevelManager : MonoBehaviour
{
    public TextMeshProUGUI gearsText;


    public static bool sequenceCorrect = false;
    public static bool makeGearAppearLvl2 = false;

    public static int gearsCollected = 0;

    public GameObject juncGear;

    private void Update()
    {
        if (makeGearAppearLvl2)
        {
            juncGear.SetActive(true);
            makeGearAppearLvl2 = false;
        }

        if(gearsCollected > 0)
        {
            gearsText.text = "Gears Collected: " + gearsCollected.ToString();
        }

        if(gearsCollected == 3)
        {
            SceneManager.LoadScene(6);
            gearsCollected = 0;
        }
    }



}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class JuncBoxLogic : MonoBehaviour
{
    [SerializeField] Transform knobOne;
    [SerializeField] Transform knobTwo;
    [SerializeField] Transform knobThree;
    [SerializeField] TextMeshProUGUI answer;

    float one = 315f, two = 315f, three = 315f;

    private void Update()
    {
        if(knobOne.localEulerAngles.z == one && knobTwo.localEulerAngles.z == two && knobThree.localEulerAngles.z == three)
        {
            answer.text = "Correct Order!";
            UnityEngine.SceneManagement.SceneManager.LoadScene(4);
            TwoLevelManager.sequenceCorrect = true;
        }
    }


    public void ClickKnobOne()
    {
        //135 - 43 - -45
        Rotation(knobOne);
    }
    public void ClickKnobTwo()
    {
        //135 - 43 - -45
        Rotation(knobTwo);
    }
    public void ClickKnobThree()
    {
        //135 - 43 - -45
        Rotation(knobThree);
    }

    void Rotation(Transform knob)
    {
        if(knob.localRotation.eulerAngles == new Vector3(0f, 0f, 135f))
        {
            knob.localRotation = Quaternion.Euler(0, 0, 43);
        }
        else if(knob.localRotation.eulerAngles == new Vector3(0f,0f,43f))
        {
            knob.localRotation = Quaternion.Euler(0, 0, 315);
        }
        else if(knob.localRotation.eulerAngles == new Vector3(0f, 0f, 315f))
        {
            knob.localRotation = Quaternion.Euler(0, 0, 135);
        }
    }
}

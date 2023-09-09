using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ONE_LevelManager : MonoBehaviour
{
    public static int apples = 0;
    public static bool applesGear = false;

    PlayerControls _controls;

    bool appleCollionOccured = false;
    string treeName;

    [SerializeField]
    SpriteRenderer[] ApplesArray;

    [SerializeField]
    SpriteRenderer ApplesGearSprite;

    public delegate void AppleCollision(string name);
    public static AppleCollision OnAppleCollision;

    

    private void Awake()
    {
        _controls = new PlayerControls();
    }

    private void OnEnable()
    {
        _controls.Enable();
        OnAppleCollision += ToggleApple;
    }

    private void OnDisable()
    {
        _controls.Disable();
        OnAppleCollision -= ToggleApple;
    }
    private void Start()
    {
        _controls.Player.Interaction.started += ctx => AppleInteraction(ctx);
    }

    private void Update()
    {
        if(applesGear == true)
        {
            ApplesGearSprite.enabled = true;
        }

    }

    void ToggleApple(string name)
    {
        appleCollionOccured = !appleCollionOccured;
        treeName = name;
        Debug.Log(treeName);
    }

    void AppleInteraction(InputAction.CallbackContext ctx)
    {
        if(appleCollionOccured)
        {
            switch (treeName)
            {
                case "appleTree1":
                    if (ApplesArray[0].enabled == true && ApplesArray[1].enabled == true) 
                    {
                        ApplesArray[0].enabled = false;
                        ApplesArray[1].enabled = false;
                        apples += 2;
                    }
                    
                    break;
                case "appleTree2":
                    if (ApplesArray[2].enabled == true && ApplesArray[3].enabled == true)
                    {
                        ApplesArray[2].enabled = false;
                        ApplesArray[3].enabled = false;
                        apples += 2;
                    }
                    
                    break;
                case "appleTree3":
                    if (ApplesArray[4].enabled == true && ApplesArray[5].enabled == true) 
                    {
                        ApplesArray[4].enabled = false;
                        ApplesArray[5].enabled = false;
                        apples += 2;
                    }
                    
                    break;
                case "appleTree4":
                    if (ApplesArray[6].enabled == true && ApplesArray[7].enabled == true)
                    {
                        ApplesArray[6].enabled = false;
                        ApplesArray[7].enabled = false;
                        apples += 2;
                    }
                    
                    break;
                case "appleTree5":
                    if (ApplesArray[8].enabled == true && ApplesArray[9].enabled == true)
                    {
                        ApplesArray[8].enabled = false;
                        ApplesArray[9].enabled = false;
                        apples += 2;
                    }
                    
                    break;
            }
        }
        appleCollionOccured = false;
    }

}

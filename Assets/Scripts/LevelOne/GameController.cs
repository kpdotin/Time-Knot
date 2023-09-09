using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum GameState { Roam, Dialogue }

public class GameController : MonoBehaviour
{
    [SerializeField] PlayerMovement playerController;

    GameState state;

    public static int gearsCollected = 0;
    private void Start()
    {
        DialogueController.Instance.OnShowDialogue += () =>
        {
            state = GameState.Dialogue;
        };
        DialogueController.Instance.OnCloseDialogue += () =>
        {
            if (state == GameState.Dialogue)
            {
                state = GameState.Roam;
            }
            

        };
    }

    private void Update()
    {
        if (state == GameState.Roam)
        {
            playerController.HandleUpdate();
        }
        else if (state == GameState.Dialogue)
        {
            DialogueController.Instance.HandleUpdate();
        }

        if(gearsCollected == 3)
        {
            SceneManager.LoadScene(3);
            gearsCollected = 0;
        }
    }

}
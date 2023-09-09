using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class DialogueController : MonoBehaviour
{
    [SerializeField] GameObject dialoguebox;
    [SerializeField] TextMeshProUGUI dialoguetext;
    [SerializeField] int lettersPerSecond;
    
    PlayerControls _controls;

    public event Action OnShowDialogue;
    public event Action OnCloseDialogue;

    Scene scene;

    [SerializeField] Image Panel;
    [SerializeField] TextMeshProUGUI PanelText;


    public static DialogueController Instance { get; private set; }
    private void Awake()
    {
        Instance = this;
        _controls = new PlayerControls();
    }

    Dialogue Dialogue;
    int currentLine = 0;
    bool IsTyping;
    bool GotInput;
    private void Start()
    {
        _controls.Player.Interaction.started += _ => NewInput();
    }
    private void OnEnable()
    {
        _controls.Enable();
    }
    private void OnDisable()
    {
        _controls.Disable();
    }

    void NewInput()
    {
        GotInput = !GotInput;
    }
    public IEnumerator ShowDialogue(Dialogue dialogue)
    {

        //yield return new WaitForEndOfFrame();
        yield return new WaitForSeconds(1);
        OnShowDialogue?.Invoke();

        this.Dialogue = dialogue;
        //dialoguebox.SetActive(true);
        //StartCoroutine(TypeDialogue(dialogue.Lines[0]));
    }

    public void HandleUpdate()
    {
        scene = SceneManager.GetActiveScene();

        if (scene.buildIndex == 1)
        {
            if (ONE_LevelManager.apples != 10)
            {
                if (GotInput && !IsTyping)
                {
                    //++currentLine;
                    if (currentLine < Dialogue.Lines1.Count)
                    {
                        dialoguebox.SetActive(true);
                        StartCoroutine(TypeDialogue(Dialogue.Lines1[currentLine]));
                        currentLine++;
                    }
                    else
                    {
                        currentLine = 0;
                        dialoguebox.SetActive(false);
                        OnCloseDialogue?.Invoke();
                    }

                }
            }
            else
            {
                if (GotInput && !IsTyping)
                {
                    //++currentLine;
                    if (currentLine < Dialogue.Lines2.Count)
                    {
                        dialoguebox.SetActive(true);
                        StartCoroutine(TypeDialogue(Dialogue.Lines2[currentLine]));
                        currentLine++;
                    }
                    else
                    {
                        currentLine = 0;
                        dialoguebox.SetActive(false);
                        ONE_LevelManager.applesGear = true;
                        OnCloseDialogue?.Invoke();
                    }

                }
            }

        } //Level 1

        else if (scene.buildIndex == 14)
        {
            if (GotInput && !IsTyping)
            {
                //++currentLine;
                if (currentLine < Dialogue.Lines1.Count)
                {
                    dialoguebox.SetActive(true);
                    StartCoroutine(TypeDialogue(Dialogue.Lines1[currentLine]));
                    currentLine++;
                }
                else
                {
                    currentLine = 0;
                    dialoguebox.SetActive(false);
                    OnCloseDialogue?.Invoke();
                }
            }
        } //House Level 1

        else if (scene.buildIndex == 3)
        {
            if (GotInput && !IsTyping)
            {
                //++currentLine;
                if (currentLine < Dialogue.Lines1.Count)
                {
                    dialoguebox.SetActive(true);
                    StartCoroutine(TypeDialogue(Dialogue.Lines1[currentLine]));
                    currentLine++;
                }
                else
                {
                    currentLine = 0;
                    dialoguebox.SetActive(false);
                    OnCloseDialogue?.Invoke();
                }
            }
        } //House Level 2

        else if (scene.buildIndex == 4) 
        {
            if (!TwoLevelManager.sequenceCorrect)
            {
                if (GotInput && !IsTyping)
                {
                    //++currentLine;
                    if (currentLine < Dialogue.Lines1.Count)
                    {
                        dialoguebox.SetActive(true);
                        StartCoroutine(TypeDialogue(Dialogue.Lines1[currentLine]));
                        currentLine++;
                    }
                    else
                    {
                        currentLine = 0;
                        dialoguebox.SetActive(false);
                        OnCloseDialogue?.Invoke();
                    }
                }   
            }
            else
            {
                if (GotInput && !IsTyping)
                {
                    //++currentLine;
                    if (currentLine < Dialogue.Lines2.Count)
                    {
                        dialoguebox.SetActive(true);
                        StartCoroutine(TypeDialogue(Dialogue.Lines2[currentLine]));
                        currentLine++;
                    }
                    else
                    {
                        currentLine = 0;
                        dialoguebox.SetActive(false);
                        TwoLevelManager.makeGearAppearLvl2 = true;
                        OnCloseDialogue?.Invoke();
                    }
                }
            }
        }  //Level 2

        else if(scene.buildIndex == 6)
        {
            if(ThreeLevelManager.gearsCollected == 2)
            {
                if (GotInput && !IsTyping)
                {
                    //++currentLine;
                    if (currentLine < Dialogue.Lines2.Count)
                    {
                        dialoguebox.SetActive(true);
                        StartCoroutine(TypeDialogue(Dialogue.Lines2[currentLine]));
                        currentLine++;
                    }
                    else
                    {
                        currentLine = 0;
                        dialoguebox.SetActive(false);
                        SceneManager.LoadScene(9);
                        OnCloseDialogue?.Invoke();
                    }
                }
            }

            else
            {
                if (GotInput && !IsTyping)
                {
                    //++currentLine;
                    if (currentLine < Dialogue.Lines1.Count)
                    {
                        dialoguebox.SetActive(true);
                        StartCoroutine(TypeDialogue(Dialogue.Lines1[currentLine]));
                        currentLine++;
                    }
                    else
                    {
                        currentLine = 0;
                        dialoguebox.SetActive(false);
                        OnCloseDialogue?.Invoke();
                    }
                }
            }
        } //House Level 3

        else if (scene.buildIndex == 7) 
        {
            if (ThreeLevelManager.oresCollected == 4)
            {
                if (GotInput && !IsTyping)
                {
                    //++currentLine;
                    if (currentLine < Dialogue.Lines2.Count)
                    {
                        dialoguebox.SetActive(true);
                        StartCoroutine(TypeDialogue(Dialogue.Lines2[currentLine]));
                        currentLine++;
                    }
                    else
                    {
                        currentLine = 0;
                        dialoguebox.SetActive(false);
                        ThreeLevelManager.showTheGear = true;
                        OnCloseDialogue?.Invoke();
                    }
                }
            }
            else
            {
                if (GotInput && !IsTyping)
                {
                    //++currentLine;
                    if (currentLine < Dialogue.Lines1.Count)
                    {
                        dialoguebox.SetActive(true);
                        StartCoroutine(TypeDialogue(Dialogue.Lines1[currentLine]));
                        currentLine++;
                    }
                    else
                    {
                        currentLine = 0;
                        dialoguebox.SetActive(false);
                        OnCloseDialogue?.Invoke();
                    }
                }
            }
            
        }   //Level 3

        else if(scene.buildIndex == 9)
        {
            if (GotInput && !IsTyping)
            {
                //++currentLine;
                if (currentLine < Dialogue.Lines1.Count)
                {
                    dialoguebox.SetActive(true);
                    StartCoroutine(TypeDialogue(Dialogue.Lines1[currentLine]));
                    currentLine++;
                }
                else
                {
                    currentLine = 0;
                    dialoguebox.SetActive(false);
                    SceneManager.LoadScene(10);
                    OnCloseDialogue?.Invoke();
                }
            }
        } //House Level 4

        else if (scene.buildIndex == 10) 
        {
            if (GotInput && !IsTyping)
            {
                //++currentLine;
                if (currentLine < Dialogue.Lines1.Count)
                {
                    dialoguebox.SetActive(true);
                    StartCoroutine(TypeDialogue(Dialogue.Lines1[currentLine]));
                    currentLine++;
                }
                else
                {
                    currentLine = 0;
                    dialoguebox.SetActive(false);
                    Panel.gameObject.SetActive(true);
                    Panel.DOFade(1f, 1f);
                    PanelText.DOFade(1f, 1f);
                    OnCloseDialogue?.Invoke();
                }
            }
        } //Level 4


    }
    public IEnumerator TypeDialogue(string line)
    {
        IsTyping = true;
        dialoguetext.text = "";
        foreach (var letter in line.ToCharArray())
        {
            dialoguetext.text += letter;
            yield return new WaitForSeconds(1f / lettersPerSecond);
        }
        IsTyping = false;
        NewInput();
    }

}
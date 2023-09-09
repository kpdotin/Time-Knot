using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue
{
    [SerializeField] List<string> lines1;
    [SerializeField] List<string> lines2;

    public List<string> Lines1
    {
        get { return lines1; }
    }
    public List<string> Lines2
    {
        get { return lines2; }
    }

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OverviewPanel : MonoBehaviour, IPanel
{
    public Text caseNumberTitle;
    public Text nameTitle;
    public Text dataTitle;
    public Text locationTitle;
    public Text locationNotes;
    public RawImage photoTaken;
    public Text photoNotes;

    public void ProcessInfo()
    {
        throw new System.NotImplementedException();
    }  
}

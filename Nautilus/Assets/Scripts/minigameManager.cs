using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class minigameManager : MonoBehaviour
{
    public TMP_Text interactText;
    public MoveSubmarine wheel;
    public ArpoonMinigameScript arpoonMinigame;
    public EletricalBoxScript eletricalBox;

    public void useWheel()
    {
        wheel.setCanMove(true);
    }

    public void useArpoon()
    {
        arpoonMinigame.ShowArpoon();
    }

    public void useEletricalBox()
    {
        eletricalBox.ShowEletrical();
    }

    public void setUiText(string textTouse)
    {
        interactText.text = textTouse;
    }


}

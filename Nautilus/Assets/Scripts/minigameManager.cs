using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class minigameManager : MonoBehaviour
{
    public TMP_Text interactText;
    public MoveSubmarine wheel;

    public void useWheel()
    {
        wheel.setCanMove(true);
    }

    public void setUiText(string textTouse)
    {
        interactText.text = textTouse;
    }


}

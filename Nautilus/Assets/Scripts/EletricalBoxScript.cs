using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EletricalBoxScript : MonoBehaviour
{
    public GameObject eletricalBoxObject;
    bool isEletrical;
    public Button[] switches;
    public Image[] ligths;
    public Sprite switchOn, switchOff,ligthOn,ligthOff;
    public Text debugText,Wintext;
    int switchesON;
    public void Update()
    {
        if (isEletrical)
        {
            debugText.text = "Switches on:" + switchesON;
            if (Input.GetKeyDown(KeyCode.E))
            {

                GameObject.FindObjectOfType<PlayerMovement>().setPlayerMove(true);
                GameObject.FindObjectOfType<minigameManager>().setUiText("");
                eletricalBoxObject.SetActive(false);
                isEletrical = false;
            }
            if (switchesON == 4)
            {
                Wintext.text = "YOU WIN";
                closeEletrical();
            }
        }

    }
    public void ShowEletrical()
    {
        GameObject.FindObjectOfType<PlayerMovement>().setPlayerMove(false);
        eletricalBoxObject.SetActive(true);
        GameObject.FindObjectOfType<minigameManager>().setUiText("");
        isEletrical = true;

        for (int i = 0; i < switches.Length; i++)
        {
            int determineOn = Random.Range(1, 3);
            if (determineOn == 1)
            {
                switches[i].GetComponent<Image>().sprite = switchOn;
                ligths[i].sprite = ligthOn;
                switchesON++;
            }
            else
            {
                switches[i].GetComponent<Image>().sprite = switchOff;
                ligths[i].sprite = ligthOff;
            }
        }
    }

    public void closeEletrical()
    {
        GameObject.FindObjectOfType<PlayerMovement>().setPlayerMove(true);
        GameObject.FindObjectOfType<minigameManager>().setUiText("");
        eletricalBoxObject.SetActive(false);
        isEletrical = false;
        switchesON = 0;
        Wintext.text = "";
    }

    public void changeButtonState(int index)
    {
        if (switches[index].GetComponent<Image>().sprite == switchOn)
        {
            switches[index].GetComponent<Image>().sprite = switchOff;
            ligths[index].sprite = ligthOff;
            switchesON--;
        }
        else
        {
            switches[index].GetComponent<Image>().sprite = switchOn;
            ligths[index].sprite = ligthOn;
            
            switchesON++;
        }
    }
}

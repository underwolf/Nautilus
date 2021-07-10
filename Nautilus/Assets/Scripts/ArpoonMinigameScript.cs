using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ArpoonMinigameScript : MonoBehaviour
{
    public GameObject arpoonObject;
    bool isArpoon;
    public Image crosshair;


    public void Update()
    {
        if (isArpoon)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {

                GameObject.FindObjectOfType<PlayerMovement>().setPlayerMove(true);
                GameObject.FindObjectOfType<minigameManager>().setUiText("");
                arpoonObject.SetActive(false);
                isArpoon = false;
            }
            crosshair.transform.position = Input.mousePosition;
        }

    }
    public void ShowArpoon()
    {
        GameObject.FindObjectOfType<PlayerMovement>().setPlayerMove(false);
        arpoonObject.SetActive(true);
        GameObject.FindObjectOfType<minigameManager>().setUiText("");
        isArpoon = true;
    }
}

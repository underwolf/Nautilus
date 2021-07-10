using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerInteract : MonoBehaviour
{

    private string colisionName;
    [SerializeField]
    private bool canInteract, hasTools;

    public GameObject tollVisualizer;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Interactable")
        {

            colisionName = collision.name;
            GameObject.FindObjectOfType<minigameManager>().setUiText("Press E to use:"+colisionName);
            canInteract = true;
            if (string.CompareOrdinal(colisionName, "TollBox") == 0 && hasTools)
            {
                GameObject.FindObjectOfType<minigameManager>().setUiText("You already have tools");
                canInteract = false;
            }


        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        GameObject.FindObjectOfType<minigameManager>().setUiText("");
        canInteract = false;
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.E) && canInteract)
        {
            canInteract = false;

            switch (colisionName)
            {
                case "Wheel":
                    GameObject.FindObjectOfType<minigameManager>().useWheel();
                    break;
                case "Arpoon":
                    GameObject.FindObjectOfType<minigameManager>().useArpoon();
                    break;
                case "EletricalBox":
                    GameObject.FindObjectOfType<minigameManager>().useEletricalBox();
                    break;
                case "TollBox":
                    hasTools = true;
                    tollVisualizer.SetActive(true);
                    break;
                default:
                    break;
            }
        }
    }
}

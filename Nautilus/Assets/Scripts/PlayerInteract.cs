using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerInteract : MonoBehaviour
{

    private string colisionName;
    private bool canInteract;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Interactable")
        {

            colisionName = collision.name;
            GameObject.FindObjectOfType<minigameManager>().setUiText("Press E to use:"+colisionName);
            colisionName = collision.name;
            canInteract = true;


        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        GameObject.FindObjectOfType<minigameManager>().setUiText("");
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

                default:
                    break;
            }
        }
    }
}

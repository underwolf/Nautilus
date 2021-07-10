using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSubmarine : MonoBehaviour
{
    public float subSpeed = 10f;
    Rigidbody2D rb;
    public bool canmove = false;
    private Vector3 m_Velocity = Vector3.zero;
    [Range(0, .3f)] [SerializeField] private float m_MovementSmoothing = .05f;
    float verticalVelocity;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canmove)
        {
            verticalVelocity = (Input.GetAxisRaw("Vertical")*subSpeed)*Time.deltaTime;
            // Move the character by finding the target velocity
            Vector3 targetVelocity = new Vector2(rb.velocity.x, verticalVelocity * 10f);
            // And then smoothing it out and applying it to the character
            rb.velocity = Vector3.SmoothDamp(rb.velocity, targetVelocity, ref m_Velocity, m_MovementSmoothing);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            canmove = false;
            GameObject.FindObjectOfType<PlayerMovement>().setPlayerMove(true);
            GameObject.FindObjectOfType<minigameManager>().setUiText("");
        }
    }

    public void setCanMove(bool move)
    {
        canmove = move;
        GameObject.FindObjectOfType<minigameManager>().setUiText("Press E to Leave The Wheel");
        GameObject.FindObjectOfType<PlayerMovement>().setPlayerMove(false);
    }
}

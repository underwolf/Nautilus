using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class ScrollingCamera : MonoBehaviour
{
    public CinemachineVirtualCamera vCamera;
    // Start is called before the first frame update
    void Start()
    {
       vCamera.m_Lens.FieldOfView=98;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.mouseScrollDelta.y > 0 && vCamera.m_Lens.FieldOfView<=134)
        {
           
            vCamera.m_Lens.FieldOfView = vCamera.m_Lens.FieldOfView + Input.mouseScrollDelta.y;
        }
        if (Input.mouseScrollDelta.y < 0 && vCamera.m_Lens.FieldOfView >= 82)
        {

            vCamera.m_Lens.FieldOfView = vCamera.m_Lens.FieldOfView + Input.mouseScrollDelta.y;
        }
    }
}

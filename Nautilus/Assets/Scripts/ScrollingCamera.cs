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
        vCamera.m_Lens.OrthographicSize = 19;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.mouseScrollDelta.y > 0 && vCamera.m_Lens.OrthographicSize<=35)
        {
           
            vCamera.m_Lens.OrthographicSize = vCamera.m_Lens.OrthographicSize + Input.mouseScrollDelta.y;
        }
        if (Input.mouseScrollDelta.y < 0 && vCamera.m_Lens.OrthographicSize >= 11)
        {

            vCamera.m_Lens.OrthographicSize = vCamera.m_Lens.OrthographicSize + Input.mouseScrollDelta.y;
        }
    }
}

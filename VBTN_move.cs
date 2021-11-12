using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VBTN_move : MonoBehaviour
{
    public Animator cubeAnim;
    public VirtualButtonBehaviour Vb;

    // Start is called before the first frame update
    void Start()
    {
        Vb.RegisterOnButtonPressed(OnButtonPressed);
        Vb.RegisterOnButtonReleased(OnButtonReleased);
    }

    public void OnButtonPressed(VirtualButtonBehaviour Vb)
    {
        cubeAnim.Play("CubeMove");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        //cubeAnim.Play("CubeNone");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public Player controlling;

    private float Xaxis()
    {
        return Input.GetAxisRaw("Horizontal");
    }

    private float Yaxis()
    {
        return Input.GetAxisRaw("Vertical");
    }

    void Update()
    {
        controlling.SetDirectionalInput(new Vector2(Xaxis(), Yaxis()));
        if (Input.GetButtonDown("Jump"))
        {
            controlling.OnJumpInputDown();
        }
        if (Input.GetButtonUp("Jump"))
        {
            controlling.OnJumpInputUp();
        }
    }
}

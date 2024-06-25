using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Animator Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)){Player.SetBool("left", true);}
        if (Input.GetKeyUp(KeyCode.A)){Player.SetBool("left", false);}
        if (Input.GetKeyDown(KeyCode.W)) { Player.SetBool("backward", true);}
        if (Input.GetKeyUp(KeyCode.W)) { Player.SetBool("backward", false);}
    }
}

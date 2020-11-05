using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputControlScript : MonoBehaviour
{
    public GameObject upCube;
    public GameObject downCube;
    public GameObject leftCube;
    public GameObject rightCube;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpKey();

        DownKey();

        LeftKey();

        RightKey();
    }

    private void UpKey()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
            print("Up key pressed");

            upCube.GetComponent<MeshRenderer>().material.color = new Color(0, 1, 0);
        }

        else if (Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.W))
        {
            print("Up key released");

            upCube.GetComponent<MeshRenderer>().material.color = new Color(1, 1, 1);
        }
    }

    private void DownKey()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {
            print("Down key pressed");

            downCube.GetComponent<MeshRenderer>().material.color = new Color(0, 1, 0);
        }

        else if (Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp(KeyCode.S))
        {
            print("Down key released");

            downCube.GetComponent<MeshRenderer>().material.color = new Color(1, 1, 1);
        }
    }

    private void LeftKey()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            print("Left key pressed");

            leftCube.GetComponent<MeshRenderer>().material.color = new Color(0, 1, 0);
        }

        else if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.A))
        {
            print("Left key released");

            leftCube.GetComponent<MeshRenderer>().material.color = new Color(1, 1, 1);
        }
    }

    private void RightKey()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            print("Right key pressed");

            rightCube.GetComponent<MeshRenderer>().material.color = new Color(0, 1, 0);
        }

        else if (Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.D))
        {
            print("Right key released");

            rightCube.GetComponent<MeshRenderer>().material.color = new Color(1, 1, 1);
        }
    }
}

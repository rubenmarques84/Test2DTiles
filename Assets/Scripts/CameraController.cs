using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// © 2017 TheFlyingKeyboard
// theflyingkeyboard.net
public class CameraController : MonoBehaviour
{
    
    public float offset;
    public float speed;
    //x - min y - max
    public Vector2 minMaxXPosition;
    public Vector2 minMaxYPosition;
    private float screenWidth;
    private float screenHeight;
    private Vector3 cameraMove;

    public GameObject Scenario;
    // Use this for initialization
    void Start()
    {
        this.minMaxXPosition.x = Scenario.transform.position.x - (Scenario.GetComponent<Renderer>().bounds.size.x / 2);
        this.minMaxXPosition.y = Scenario.transform.position.x + (Scenario.GetComponent<Renderer>().bounds.size.x / 2);

        this.minMaxYPosition.x = Scenario.transform.position.y - (Scenario.GetComponent<Renderer>().bounds.size.y / 2);
        this.minMaxYPosition.y = Scenario.transform.position.y + (Scenario.GetComponent<Renderer>().bounds.size.y / 2);

        screenWidth = Screen.width;
        screenHeight = Screen.height;
        cameraMove.x = transform.position.x;
        cameraMove.y = transform.position.y;
        cameraMove.z = transform.position.z;
    }
    // Update is called once per frame
    void Update()
    {
        //Move camera
        if ((Input.mousePosition.x > screenWidth - offset) && transform.position.x < minMaxXPosition.y)
        {
            cameraMove.x += MoveSpeed();
        }
        if ((Input.mousePosition.x < offset) && transform.position.x > minMaxXPosition.x)
        {
            cameraMove.x -= MoveSpeed();
        }
        if ((Input.mousePosition.y > screenHeight - offset) && transform.position.y < minMaxYPosition.y)
        {
            cameraMove.y += MoveSpeed();
        }
        if ((Input.mousePosition.y < offset) && transform.position.y > minMaxYPosition.x)
        {
            cameraMove.y -= MoveSpeed();
        }

       // this.transform.position = cameraMove;
    }
    float MoveSpeed()
    {
        return speed * Time.deltaTime;
    }
}
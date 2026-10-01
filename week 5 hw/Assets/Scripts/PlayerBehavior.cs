using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerBehavior: MonoBehaviour
{


    InputAction upButton;
    InputAction downButton;
    AudioSource myCDPlayer;
    InputAction leftButton;
    InputAction rightButton;

    private Vector3 playerStart;
 


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        upButton = InputSystem.actions.FindAction("Up");
        downButton = InputSystem.actions.FindAction("Down");
        leftButton = InputSystem.actions.FindAction("Left");
        rightButton = InputSystem.actions.FindAction("Right");
        playerStart = transform.position;


        myCDPlayer = GetComponent<AudioSource>();

            }

    // Update is called once per frame
    void Update()
    {
        //taking the players xyz
        Vector3 playerPosition = transform.position;
        if (upButton.IsPressed())
        {//delta time is the time between this frame and the last frame
            playerPosition.y += 2 * Time.deltaTime;
            Debug.Log("go up");

        }

        if (downButton.IsPressed())
        {
            playerPosition.y -= 2 * Time.deltaTime;
            Debug.Log("go down");
        }
        // set my position to what we just changed
       

        if (rightButton.IsPressed())
        {
            playerPosition.x += 2 * Time.deltaTime;
            Debug.Log("go right");
        }

        if (leftButton.IsPressed())
        {
            playerPosition.x -= 2 * Time.deltaTime;
            Debug.Log("go left");
        }
        transform.position = playerPosition;
    }

   //event function that begins at the first frame of a collider meeting a trigger
    private void OnTriggerEnter(Collider other)
    {
        myCDPlayer.Play();
        Debug.Log("Touched Something");
        transform.position = playerStart;
    }

}

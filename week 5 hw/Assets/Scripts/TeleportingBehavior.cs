using Unity.VisualScripting;
using UnityEngine;

public class TeleportingBehavior : MonoBehaviour
{

    // Variables
    public float speed = 0.1f;
    public string name = "TeleportingMeteor";
    public Vector3 targetPosition;
    // do you want this object to move between two points
    public bool InitialPath = false;
    // is this going straight (towards the end)
    private bool InMotion = true;
    

    private Vector3 strt;
    private Vector3 end;
   

    Vector2 twoDeePosition;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        strt = transform.position;
        
        //ending x value (ending point)
      
        end = targetPosition;
        //if this object is supposede to move between two points
        if (InitialPath)
        {

        }

    }
    void Update()
    {
        //move object towards target position
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        //checking if an object is on it's initial path
        if (InitialPath)
        {
            //if it's going straight (towards the end position)
            if (InMotion)
            {
                //if the current x position is equal to the target position x value (end position x)
                if (transform.position.x == targetPosition.x)
                {
                    //change the target x position to the start x position value
                    transform.position = strt;

                    //change from going to end position to going to start position
                    ///GoingRight = false;


                }


            }



        }
    }
}

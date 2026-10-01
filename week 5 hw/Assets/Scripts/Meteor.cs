using UnityEngine;

public class Meteor : MonoBehaviour
{

    // Variables
    
    
    public float speed = 0.1f;
    public string name = "Meteor";
    public Vector3 targetPosition;
    // do you want this object to move between two points
    public bool backForth = false;
    // is this going straight (towards the end)
    private bool GoingRight = true;
    private bool GoingDown = true;

    private float strtX = 0f;
    private float strtY = 0f;
    private float endY = 0f;
    private float endX = 0f;

    Vector2 twoDeePosition;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        //starting x and 7value (starting point) 
        strtX = transform.position.x;
        strtY = transform.position.y;
        //ending x value (ending point)
        endX = targetPosition.x;
        endY = targetPosition.y;
        //if this object is supposede to move between two points
        if (backForth)
        {

        }

    }
    void Update()
    {
        //move object towards target position
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
       
        //checking if an object is supposed to be going back and forth
        if (backForth)
        {
            //if it's going straight (towards the end position)
            if (GoingRight)
            {
                //if the current x position is equal to the target position x value (end position x)
                if (transform.position.x == targetPosition.x)
                {
                    //change the target x position to the start x position value
                    targetPosition.x = strtX;

                    //change from going to end position to going to start position
                    GoingRight = false;


                }


            }

            if (GoingDown)
            {
                //if the current y position is equal to the target position x value (end position y)
                if (transform.position.y == targetPosition.y)
                {
                    //change the target y position to the start x position value
                    targetPosition.y = strtY;

                    //change from going to end position to going to start position
                    GoingDown = false;


                }


            }

            //if it is not going straight (straight = false)
            else
            {
                //if the current x position is equal to the target position x value (start position x)
                if (transform.position.x == strtX)
                {
                    //change the target x position to the end x position value
                    targetPosition.x = endX;

                    //change from going to start position to going to end position
                    GoingRight = true;

                }

                if (transform.position.y == strtY)
                {
                    //change the target y position to the end y position value
                    targetPosition.y = endY;

                    //change from going to start position to going to end position
                    GoingDown = true;

                }
            }



        }
    }
}

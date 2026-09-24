
using UnityEngine;

public class MoveShip : MonoBehaviour
{
    // Variables
    public float speed = 0.1f;
    public string name = "Ship";
    public Vector3 targetPosition   ;
    // do you want this object to move between two points
    public bool backForth = false;
    // is this going straight (towards the end)
    private bool straight = true;
    private float strt = 0f;
    private float end = 0f;
    
    Vector2 twoDeePosition;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        //starting x value (starting point) 
        strt = transform.position.x;
        //ending x value (ending point)
        end = targetPosition.x;
        //if this object is supposede to move between two points
        if (backForth)
        {
            
        }

    }

    // Update is called once per frame
    void Update()
    {
        //move object towards target position
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        //checking if an object is supposed to be going back and forth
        if (backForth)
        {
            //if it's going straight (towards the end position)
            if (straight)
            {
                //if the current x position is equal to the target position x value (end position x)
                if (transform.position.x == targetPosition.x)
                {
                    //change the target x position to the start x position value
                    targetPosition.x = strt;
                 
                    //change from going to end position to going to start position
                    straight = false;
                    
                    
                }
            }
            //if it is not going straight (straight = false)
            else
            {
                //if the current x position is equal to the target position x value (start position x)
                if (transform.position.x == strt)
                {
                    //change the target x position to the end x position value
                    targetPosition.x = end;
                    
                    //change from going to start position to going to end position
                    straight = true;
                    
                }
            }

        }
    }
}

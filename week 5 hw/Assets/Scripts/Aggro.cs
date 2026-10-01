using UnityEngine;

public class Aggro : MonoBehaviour
{
    public Transform targetPosition;

    public float aggroRange = 10f;
    public float aggroSpeed = 2f;

    public float idleSpeed = 1f;
    public float idleTimeLimit = 5f;
    public Vector3 idleDest;
    private float idleTimer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PickIdleDest();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, targetPosition.position);
        if (distance <= aggroRange)
        {    //chase the player
            transform.position = Vector3.MoveTowards(transform.position, targetPosition.position, aggroSpeed * Time.deltaTime);
        }
        else
        {//idle
            idleTimer += Time.deltaTime;
            transform.position =Vector3.MoveTowards(transform.position, idleDest, idleSpeed * Time.deltaTime);
            if (idleTimer >= idleTimeLimit)
            {
                idleTimer = 0;
                PickIdleDest();

            }
        }
    }
    void PickIdleDest()
    {
        float randomX = Random.Range(-19.5f, 19.5f);
        float randomY = Random.Range(-12.5f, 12.5f);
        idleDest = new Vector3(randomX, randomY, 0);
    }
}

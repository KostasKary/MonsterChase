using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public Vector3 tempPos;
    private GameObject pl;
    public float minX = -80f;
    public float maxX = 70f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pl = GameObject.FindGameObjectWithTag("Player");   
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (!player)
        {
            return;
        }

        tempPos = transform.position;
        tempPos.x = player.position.x;
        
        if (tempPos.x < minX)
        {
            tempPos.x = minX;
        }

        if (tempPos.x > maxX)
        {
            tempPos.x = maxX;
        }
        transform.position = tempPos;
    }
}

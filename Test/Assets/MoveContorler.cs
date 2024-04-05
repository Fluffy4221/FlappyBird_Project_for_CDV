using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveContorler : MonoBehaviour
{
    public float Speed;
    public float DeSpawnPoint;
    public float SpawnPoint;
    public float MinY;
    public float MaxY;
    // Start is called before the first frame update
    void Start()
    {
           
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x + Speed * Time.deltaTime, transform.position.y, transform.position.z);
        if (transform.position.x < DeSpawnPoint)
        {
            transform.position = new Vector3(SpawnPoint, transform.position.y, transform.position.z);
        }
    }
}

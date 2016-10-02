using UnityEngine;
using System.Collections;

public class BookFwd : MonoBehaviour
{

    public Transform target;
    public float speed;

    public Transform playerTransform;

    void Start()
    {
    }


    void Update()
    {
        float step = speed * Time.deltaTime;

        playerTransform.Rotate(.5f, .5f, .5f);

        if (playerTransform.position.x>244)
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
    }
}

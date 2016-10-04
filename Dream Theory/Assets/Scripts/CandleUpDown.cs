using UnityEngine;
using System.Collections;

public class CandleUpDown : MonoBehaviour {

    public Transform playerTransform;
    public float speed;

    public Transform target;

    public Transform target2;

    public bool flag = true;


    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        Debug.Log(flag);

        float step = speed * Time.deltaTime;

        if (flag)
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        else
            transform.position = Vector3.MoveTowards(transform.position, target2.position, step);

        if (transform.position.y <= target2.position.y)
        {
            flag = true;
        }

        if (transform.position.y >= target.position.y)
        {
            flag = false;
        }

    }
}

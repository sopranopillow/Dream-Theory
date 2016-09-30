using UnityEngine;
using System.Collections;

public class CameraMenuScript : MonoBehaviour {

	public float speed = 1.0f;

	public float off_x;
	public float off_y;

	public GameObject background;

	public float startMeasures_x;
	public float startMeasures_y;

	public float x = 0f, y = -0.3f;
	public bool right = false, up = true;

	public int times_x;
	public int times_y;

	public int count_x = 0;
	public int count_y = 0;

	// Use this for initialization
	void Start () {
		times_x = (int)(off_x / speed);
		times_y = (int)(off_y / speed);
	}

	// Update is called once per frame
	void Update () {
		
		if (count_x <=times_x && right == true) {
			if (count_x == 0) {
				x+=speed;
				right = false;
				count_x = (int)(off_x / speed);
			} else {
				x+=speed;
				count_x--;
			}
		}else if (count_x <=times_x && right == false) {
			if (count_x == 0) {
				x-=speed;
				right = true;
				count_x = (int)(off_x / speed);
			} else {
				x-=speed;
				count_x--;
			}
		}

		if (count_y <=times_y && up == true) {
			if (count_y == 0) {
				y+=speed;
				up = false;
				count_y = (int)(off_y / speed);
			} else {
				y+=speed;
				count_y--;
			}
		}else if (count_y <=times_y && up == false) {
			if (count_y == 0) {
				y-=speed;
				up = true;
				count_y = (int)(off_y / speed);
			} else {
				y-=speed;
				count_y--;
			}
		}

		background.transform.position = new Vector2(x, y);
	}
}

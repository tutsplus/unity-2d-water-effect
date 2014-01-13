using UnityEngine;
using System.Collections;

public class Clickspawn : MonoBehaviour {

    public GameObject Brick;
	
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject brick = Instantiate(Brick, Camera.main.ScreenToWorldPoint(Input.mousePosition + new Vector3(0,0,10)), Brick.transform.rotation) as GameObject;
            brick.transform.Rotate(0, 0, UnityEngine.Random.Range(0, 0));
            brick.transform.localScale = new Vector3(UnityEngine.Random.Range(1f, 2f),0.6f,1)*0.4f;
            brick.rigidbody2D.mass = brick.transform.localScale.x * brick.transform.localScale.y*5f;
            Destroy(brick, 1.4f);
        }
	}
}

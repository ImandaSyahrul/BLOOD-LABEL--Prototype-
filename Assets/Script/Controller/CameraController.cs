using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
	public GameObject followTarget; //what sprite that camera want to follow
	private Vector3 targetPos; //target position(vector)
	public float moveSpeed; //Camera's speed

    // Start is called before the first frame update
    void Start()
    {
		//DontDestroyOnLoad(transform.gameObject);
	}

    // Update is called once per frame
    void Update()
    {
		targetPos = new Vector3(followTarget.transform.position.x, followTarget.transform.position.y, -10f);
		transform.position = Vector3.Lerp(transform.position, targetPos, moveSpeed * Time.deltaTime);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieController : MonoBehaviour
{
	public float moveSpeed;

	Rigidbody2D myRigidbody;

	public float timeBetweenMove;
	private float timeBetweenMoveCounter;
	private float timeToMove;
	private float timeToMoveCounter;

	bool moving;
	private Vector3 moveDirection;

	public float waitToReload;
	private bool reloading;

	private GameObject thePlayer;

	private Animator anim;


	// Start is called before the first frame update
	void Start()
    {
		//yang ini di aktifin pas nanti udh bikin zombienya 
		myRigidbody = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();
		timeBetweenMoveCounter = Random.Range(timeBetweenMove * 0.75f, timeBetweenMove * 1.25f);
		timeToMoveCounter = Random.Range(timeToMove * 0.75f, timeToMove * 1.25f);
    }

    // Update is called once per frame
    void Update()
    {
		if (moving)
		{
			timeToMoveCounter -= Time.deltaTime;
			myRigidbody.velocity = moveDirection;
			if (timeToMoveCounter < 0f)
			{
				moving = false;
				timeBetweenMoveCounter = Random.Range(timeBetweenMove * 0.75f, timeBetweenMove * 1.25f);
			}
		} else
		{
			timeBetweenMoveCounter -= Time.deltaTime;
			myRigidbody.velocity = Vector2.zero;
			if (timeBetweenMoveCounter < 0f)
			{
				
				moving = true;
				//timeToMoveCounter = timeToMove;
				timeToMoveCounter = Random.Range(timeToMove * 0.75f, timeToMove * 1.25f);
				moveDirection = new Vector3 (Random.Range(-1f, 1f) * moveSpeed, Random.Range(-1f, 1f) * moveSpeed, 0f);

				
			}
		}

		if (reloading)
		{
			waitToReload -= Time.deltaTime;
			if(waitToReload < 0)
			{
				
				Application.LoadLevel(Application.loadedLevel);
				thePlayer.SetActive(true);
			}
		}

		anim.SetFloat("MoveX", moveDirection.x);
		anim.SetFloat("MoveY", moveDirection.y);
		anim.SetBool("IsMoving", moving);
		anim.SetFloat("LastMoveX", moveDirection.x);
		anim.SetFloat("LastMoveY", moveDirection.y);
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.name == "Player")
		{
			other.gameObject.SetActive(false);
			reloading = true;
			thePlayer = other.gameObject;
		}
	}
}

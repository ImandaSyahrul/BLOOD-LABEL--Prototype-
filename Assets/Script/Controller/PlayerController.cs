using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    private Animator anim;
    private Rigidbody2D myRigidbody;

    private bool PlayerMoving;
	private bool PlayerRunning;
	private Vector2 lastMove;

    //stamina bar
    public float maxStamina;
    public float staminaLoss = 5;
    public Slider staminaBar;
    public Text staminaStatus;

    // Start is called before the first frame update
    void Start()
    {
        //Get the player animator
        anim = GetComponent<Animator>();
        myRigidbody = GetComponent<Rigidbody2D>();

        //DontDestroyOnLoad(transform.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMoving = false;

		//Move the player character
		
		


		if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f)
        {
			Running();
            transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f));
            PlayerMoving = true;
            lastMove = new Vector2(Input.GetAxisRaw("Horizontal"), 0f);
        }

        if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f)
        {
			Running();
            transform.Translate(new Vector3(0f, Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime, 0f));
            PlayerMoving = true;
            lastMove = new Vector2(0f, Input.GetAxisRaw("Vertical"));
        }

		if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
		{
			if (maxStamina > 10)
			{
				setRunning(true);
				moveSpeed = 10;
			}
			else setRunning(false);
			moveSpeed = 5;
		}
		if (Input.GetKeyUp(KeyCode.LeftShift) || Input.GetKeyUp(KeyCode.RightShift))
		{
			setRunning(false);
			moveSpeed = 5;
		}

		if (PlayerRunning)
		{
			updateStamina();
			if (maxStamina < 10)
			{
				maxStamina = 10;
				PlayerRunning = false;
			}
		}


		anim.SetFloat("MoveX", Input.GetAxisRaw("Horizontal"));
        anim.SetFloat("MoveY", Input.GetAxisRaw("Vertical"));
        anim.SetBool("Moving", PlayerMoving);
        anim.SetFloat("LastMoveX", lastMove.x);
        anim.SetFloat("LastMoveY", lastMove.y);
    }

    public void updateStamina()
    {
			maxStamina -= staminaLoss * Time.deltaTime;
			staminaBar.value = maxStamina;
			staminaStatus.GetComponent<UnityEngine.UI.Text>().text = maxStamina.ToString();
	}

	void setRunning(bool isRunning)
	{
		this.PlayerRunning = isRunning;
	}

	void Running()
	{
		if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
		{
			if (maxStamina > 10)
			{
				setRunning(true);
				moveSpeed = 10;
			}
			else setRunning(false);
			moveSpeed = 5;
		}
		if (Input.GetKeyUp(KeyCode.LeftShift) || Input.GetKeyUp(KeyCode.RightShift))
		{
			setRunning(false);
			moveSpeed = 5;
		}

		if (PlayerRunning)
		{
			updateStamina();
			if (maxStamina < 10)
			{
				maxStamina = 10;
				PlayerRunning = false;
			}
		}
	}
}
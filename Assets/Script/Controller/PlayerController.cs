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
    private Vector2 lastMove;

    //stamina bar
    public float maxStamina;
    public float staminaLoss = 2;
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
        if ((Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f) && (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)))
        {
			if (maxStamina > 2)
			{
				maxStamina -= staminaLoss;
				staminaBar.value = maxStamina;
				staminaStatus.GetComponent<UnityEngine.UI.Text>().text = maxStamina.ToString();

				moveSpeed = 7;
			}
			else moveSpeed = 5;
			transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f));
            PlayerMoving = true;
            lastMove = new Vector2(Input.GetAxisRaw("Horizontal"), 0f);
        }

        if ((Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f) && (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)))
        {
			if (maxStamina > 2)
			{
				maxStamina -= staminaLoss;
				staminaBar.value = maxStamina;
				staminaStatus.GetComponent<UnityEngine.UI.Text>().text = maxStamina.ToString();
				moveSpeed = 7;
			}
			else moveSpeed = 5;
			transform.Translate(new Vector3(0f, Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime, 0f));
            PlayerMoving = true;
            lastMove = new Vector2(0f, Input.GetAxisRaw("Vertical"));
        }

        if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f)
        {
            moveSpeed = 5;
            transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f));
            PlayerMoving = true;
            lastMove = new Vector2(Input.GetAxisRaw("Horizontal"), 0f);
        }

        if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f)
        {

            moveSpeed = 5;
            transform.Translate(new Vector3(0f, Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime, 0f));
            PlayerMoving = true;
            lastMove = new Vector2(0f, Input.GetAxisRaw("Vertical"));
        }

		if (PlayerMoving == false)
		{
			while (maxStamina != 100)
			{
				maxStamina += 1;
				staminaBar.value = maxStamina;
				staminaStatus.GetComponent<UnityEngine.UI.Text>().text = maxStamina.ToString();
			}
			if (maxStamina > 100)
			{
				maxStamina = 100;
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
		
    }
}
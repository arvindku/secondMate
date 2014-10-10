using UnityEngine;
using System.Collections;

public class playerController : MonoBehaviour {

	public float playerSpeed = 10.0f;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void FixedUpdate() {
	
		
		float verticalSpeed = Input.GetAxisRaw("Vertical");
		float horizontalSpeed = Input.GetAxisRaw("Horizontal");
		
		Vector3 velocity = new Vector3(horizontalSpeed, 0.0f , verticalSpeed);

		rigidbody.AddForce(velocity*playerSpeed);
		
		bool isGettingInput = false;
		
		//speed cap
		float currentSpeed = rigidbody.velocity.magnitude;
		if (currentSpeed > playerSpeed)
		{
			velocity = rigidbody.velocity.normalized;
			rigidbody.velocity = velocity*playerSpeed;
		}
		/*
		if (velocity.magnitude < 0.999)
		{
			rigidbody.velocity = Vector3.zero;
		}
		*/
		Debug.Log(Input.GetAxisRaw("Vertical"));
		
	}
	
	
}

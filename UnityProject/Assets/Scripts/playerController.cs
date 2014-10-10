using UnityEngine;
using System.Collections;

public class playerController : MonoBehaviour {

	public float playerSpeed = 10.0f;
	
	private Vector3 direction;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		float verticalSpeed = Input.GetAxisRaw("Vertical");
		float horizontalSpeed = Input.GetAxisRaw("Horizontal");
		
		direction = new Vector3(horizontalSpeed, 0.0f , verticalSpeed);
	}
	
	void FixedUpdate() {
		
		rigidbody.AddForce(direction*playerSpeed);
		
		bool isGettingInput = false;
		
		Debug.Log(Input.GetAxisRaw("Vertical"));
		
	}
	
}

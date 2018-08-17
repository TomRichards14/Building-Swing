using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private float PlayerSpeed = 0.1f;
    private float PlayerJumpMultiplier = 500.0f;

    private bool IsPlayerGrounded;

	// Use this for initialization
	void Start ()
    {
        IsPlayerGrounded = true;
	}
	
	// Update is called once per frame
	void Update ()
    {
        PlayerMovement();
        Debug.Log(IsPlayerGrounded);
	}

    void PlayerMovement()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * PlayerSpeed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * PlayerSpeed);
        }

        if ((Input.GetKeyDown(KeyCode.Space)) && (IsPlayerGrounded == true))
        {
            this.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * PlayerJumpMultiplier);
        }
    }

    private void OnCollisionEnter(Collision OtherCollider)
    {
        if ((OtherCollider.gameObject.tag == "Building") || (OtherCollider.gameObject.tag == "Rope"))
        {
            IsPlayerGrounded = true;
        }
    }

    private void OnCollisionExit(Collision OtherCollider)
    {
        if ((OtherCollider.gameObject.tag == "Building") || (OtherCollider.gameObject.tag == "Rope"))
        {
            IsPlayerGrounded = false;
        }
    }
}

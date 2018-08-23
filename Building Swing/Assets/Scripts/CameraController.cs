using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject PlayerObject;

	// Use this for initialization
	void Start ()
    {
        PlayerObject = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.position = Vector3.Lerp(transform.position, (new Vector3(PlayerObject.transform.position.x, PlayerObject.transform.position.y, transform.position.z)), 2.0f);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_Controller : MonoBehaviour
{
    public Rigidbody playerRB;
    public float playerSpeed;
    private float horizAxis;
    private float vertAxis;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetMouseButtonDown(1))
		{
			float mouseInput = Input.GetAxis("Mouse X");
			Vector3 lookhere = new Vector3(0, mouseInput, 0);
			transform.Rotate(lookhere);
		}

		vertAxis = Input.GetAxis("Vertical");
    }

    private void LateUpdate()
    {
        playerRB.velocity = new Vector3(playerRB.velocity.x, playerRB.velocity.y, vertAxis * playerSpeed);
    }

}

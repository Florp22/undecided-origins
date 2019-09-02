using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(player_Motor))]
public class player_Controller : MonoBehaviour
{
    public Camera cam;
    public LayerMask movementMask;
    player_Motor motor;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        motor = GetComponent<player_Motor>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 100, movementMask))
            {
                motor.MoveToPoint(hit.point);
                // Stop Focusing Objects

            }
        }
    }

    private void LateUpdate()
    {
      
    }

}

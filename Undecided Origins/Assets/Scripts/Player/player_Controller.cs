using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_Controller : MonoBehaviour
{
    public Camera cam;
    public LayerMask movementMask;

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
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
                // Move Player to what was hit
                // Stop Focusing Objects

            }
        }
    }

    private void LateUpdate()
    {
      
    }

}

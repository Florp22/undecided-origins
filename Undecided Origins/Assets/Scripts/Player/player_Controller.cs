using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(player_Motor))]
public class player_Controller : MonoBehaviour
{
    public Camera cam;
    public LayerMask movementMask;
    player_Motor motor;

    public Interactable focus;
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
                RemoveFocus();

            }
        }
        if (Input.GetMouseButtonDown(1))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 100))
            {
                // Check if interactable hit
              Interactable interactable = hit.collider.GetComponent<Interactable>();
                // if we did, set as focus
                if(interactable != null)
                {
                    SetFocus(interactable);
                }


            }
        }
    }

    void SetFocus(Interactable newFocus)
    {
        if(newFocus != focus)
        {
            if(focus != null)
            {
                focus.OnDeFocused();
            }
            focus = newFocus;
            motor.FollowTarget(newFocus);
        } 
        
        newFocus.OnFocused(transform);
    }
    void RemoveFocus()
    {
        if(focus != null)
        {
            focus.OnDeFocused();

        }
        focus = null;
        motor.StopFollowingTarget();
    }

    private void LateUpdate()
    {
      
    }

}

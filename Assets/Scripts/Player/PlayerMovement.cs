using System;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

[RequireComponent(typeof (ThirdPersonCharacter))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float walkMoveStopRadius = 0.2f;

    ThirdPersonCharacter m_Character;   // A reference to the ThirdPersonCharacter on the object
    CameraRaycaster cameraRaycaster;
    Vector3 currentClickTarget;
        
    private void Start()
    {
        cameraRaycaster = Camera.main.GetComponent<CameraRaycaster>();
        m_Character = GetComponent<ThirdPersonCharacter>();
        currentClickTarget = transform.position;
    }

    // Fixed update is called in sync with physics
    private void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            //TODO: Fix issue with click to move and WSAD conflicting and increasing speed

            print("Cursor raycast hit" + cameraRaycaster.hit.collider.gameObject.name.ToString());
            switch (cameraRaycaster.layerHit)
            {
                case Layer.Walkable:
                    currentClickTarget = cameraRaycaster.hit.point;
                    m_Character.Move(currentClickTarget - transform.position, false, false);
                    break;
                case Layer.Enemy:
                    print("Not moving to enemy");
                    break;
                default:
                    print("Shouldn't have ever gotten here!");
                    break;
            }
        }

//        var playertoClickPoint = currentClickTarget - transform.position;
//        if (playertoClickPoint.magnitude >= walkMoveStopRadius)
//        {
//            m_Character.Move(playertoClickPoint, false, false);
//        }
//        else
//        {
//            m_Character.Move(Vector3.zero, false, false);
//        }
    }
}


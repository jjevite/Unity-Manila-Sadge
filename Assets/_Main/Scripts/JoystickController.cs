using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class JoystickController : MonoBehaviour
{
    public GameObject joystick;
    public GameObject joystickBG;
    public Vector2 joystickVector;
    private Vector2 joystickTouchPos;
    private Vector2 joystickOriginalPos;
    private float joystickRadius;

    public void Start() {
        joystickOriginalPos = joystickBG.transform.position;
        joystickRadius = joystickBG.GetComponent<RectTransform>().sizeDelta.y / 4;
    }

    public void PointerDown() {
        joystick.transform.position = Input.mousePosition;
        joystick.transform.position = Input.mousePosition;
        joystickTouchPos = Input.mousePosition;
    }

    public void Drag(BaseEventData baseEventData) {
        PointerEventData pointerEventData = baseEventData as PointerEventData;
        Vector2 dragPos = pointerEventData.position;
        joystickVector = (dragPos - joystickTouchPos).normalized;

        float joystickDistance = Vector2.Distance(dragPos, joystickTouchPos);

        if(joystickDistance < joystickRadius) {
            joystick.transform.position = joystickTouchPos + joystickVector * joystickDistance;
        }
        else {
            joystick.transform.position = joystickTouchPos + joystickVector * joystickRadius;
        }
    }

    public void PointerUp() {
        joystickVector = Vector2.zero;
        joystick.transform.position = joystickOriginalPos;
        joystickBG.transform. position = joystickOriginalPos;
    }
}

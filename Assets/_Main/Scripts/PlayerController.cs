using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   public JoystickController joystickController;
   public float playerSpeed;
   private Rigidbody2D rb;

   void Start() {
    rb = GetComponent<Rigidbody2D>();
   }

   public void FixedUpdate() {
    if(joystickController.joystickVector.y != 0) {
        rb.velocity = new Vector2(joystickController.joystickVector.x * playerSpeed, joystickController.joystickVector.y * playerSpeed);
    }
    else {
        rb.velocity = Vector2.zero;
    }
   }

}

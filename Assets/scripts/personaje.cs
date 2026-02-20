using UnityEngine;
using UnityEngine.InputSystem; // Añade esto

public class Personaje : MonoBehaviour
{
    private Rigidbody2D Rigidbody2D;
    private float horizontal;
    [SerializeField] private float velocidad = 10f;

    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // En el nuevo sistema, puedes leer las teclas de flechas o A/D así:
        if (Keyboard.current != null)
        {
            float move = 0;
            if (Keyboard.current.aKey.isPressed || Keyboard.current.leftArrowKey.isPressed) move = -1f;
            if (Keyboard.current.dKey.isPressed || Keyboard.current.rightArrowKey.isPressed) move = 1f;
            
            horizontal = move;
        }
    }

    private void FixedUpdate()
    {
        Rigidbody2D.linearVelocity = new Vector2(horizontal * velocidad, Rigidbody2D.linearVelocity.y);
    }
}




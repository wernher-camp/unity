using UnityEngine;

public class DetectorFuego : MonoBehaviour {
    private Animator _animator;

    void Start() {
        _animator = GetComponent<Animator>();
    }

    // Se activa MIENTRAS entra al fuego
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.name == "fuego") { 
            _animator.SetBool("contacto", true); // Encendemos el estado
        }
    }

    // Se activa justo CUANDO SALE del fuego
    private void OnTriggerExit2D(Collider2D other) {
        if (other.gameObject.name == "fuego") { 
            _animator.SetBool("contacto", false); // Apagamos el estado
        }
    }
}
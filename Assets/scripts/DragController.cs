using UnityEngine;
using UnityEngine.EventSystems;


// IDragHandler detecta el toque, detectando y manejadno el arrastre, IBeginDragHandler detecta el movimiento exacto
public class DragSencillo : MonoBehaviour, IDragHandler , IBeginDragHandler
{

    // variable del lienzo
    private Canvas canvas;


//Inicializacion, similar a Star.
    void Awake()
    {
        // localizacion de la hoja
        canvas = GetComponentInParent<Canvas>();
    }


//Esta parte, coloca nuestro objeto al frente de todo, en caso de tener otro objeto despuestes y no tener esta parte del codigo, al moverlo quedaria atras.

//Agrego una imagen extre despues para hacer la prueba.
    public void OnBeginDrag(PointerEventData eventData)
    {

        transform.SetAsLastSibling();
    }


//Funcion del movimiento
    public void OnDrag(PointerEventData eventData)
    {
        // Movemos la imagen siguiendo el movimiento del ratón (delta)
        GetComponent<RectTransform>().anchoredPosition += eventData.delta / canvas.scaleFactor;
    }
}
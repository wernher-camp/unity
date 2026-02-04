using UnityEngine;
using UnityEngine.UI;

public class EnlacesDirectos : MonoBehaviour
{
    public Button boton1, boton2, boton3;

    // Se cambió "star" por "Start" (con S mayúscula)
    public void AbrirPagina(string url)
    {
        // Verificamos que los botones no estén vacíos antes de asignarles el link
        if (boton1 != null) boton1.onClick.AddListener(() => Application.OpenURL("https://www.facebook.com/?locale=es_LA"));
        if (boton2 != null) boton2.onClick.AddListener(() => Application.OpenURL("https://youtube.com"));
        if (boton3 != null) boton3.onClick.AddListener(() => Application.OpenURL("https://www.tiktok.com/es-419/"));
    }
}
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiodeEscena : MonoBehaviour
{
    public void CargarEscena(string Escena1 )
    {
          SceneManager.LoadScene(Escena1);
 
    }
    public void RegresarEscena()
    {
        SceneManager.LoadScene("Escena0");
    }
       public void Siguiente()
    {
        SceneManager.LoadScene("Escena2");
    }
}


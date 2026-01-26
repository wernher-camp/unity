using UnityEngine;

public class ScriptHolaMundo : MonoBehaviour
{

    public string saludo = "Hola mundo";
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Esto es un " + saludo);    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

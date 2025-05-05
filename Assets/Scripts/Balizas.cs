using System;
using UnityEngine;
public class Balizas : Simulator
{
    [SerializeField] private Creadores creadores;
    [SerializeField] private KeyCode teclaActivarBaliza = KeyCode.B;
    [SerializeField] private float tiempoParpadeo = 1f;
    public bool BalizaActiva => balizaActiva;
    private bool balizaActiva = false;
    private bool estadoLuz = false;
    private float timer = 0f;
    void Start()
    {
        AsignarCreador(creadores);
    }
    public override void AsignarCreador(Creadores creador)
    {
        CreadoresSimulator = creador; 
    }
    void Update()
    {
        if (Input.GetKeyDown(teclaActivarBaliza))
        {
            balizaActiva = !balizaActiva;

            if (balizaActiva)
            {
                Debug.Log("🚨 Balizas activadas");
            }
            else
            {
                Debug.Log("❌ Balizas desactivadas");
                estadoLuz = false;
                timer = 0f;
            }
        }
        if (balizaActiva)
        {
            timer += Time.deltaTime;
            if (timer >= tiempoParpadeo)
            {
                timer = 0f;
                estadoLuz = !estadoLuz;
                Debug.Log("🔁 Ciclo de baliza: " + (estadoLuz ? "ENCENDIDA" : "APAGADA"));
            }
        }
    }
    public bool PuedeActivarse()
    {
        if (!balizaActiva)
        {
            Debug.Log("Se pueden activar las luces de giro");
            return true;
        }
        else
        {
            Debug.Log("No se pueden activar las luces de giro");
            return false;
        }
    }
}

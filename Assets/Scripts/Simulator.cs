using UnityEngine;

public abstract class Simulator : MonoBehaviour
{
    private Creadores creadores;

    /// <summary>
    /// Esta propiedad devuelve la lista de creadores posibles del juego
    /// </summary>
    public Creadores CreadoresSimulator {
        get{ return creadores; }
        set { creadores = value; }
    }

    public virtual void Describir()
    {
        Debug.Log("Esta función permite definir el que hace el juego");
    }

    public abstract void AsignarCreador(Creadores creadores);

}
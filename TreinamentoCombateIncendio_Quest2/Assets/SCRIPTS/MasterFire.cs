using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum FireState
{
    Normal,
    Max,
    Min
}

public enum FireType 
{
    A,
    B,
    C,
    K
}

public class MasterFire : MonoBehaviour
{
    // public BoxCollider areaDeContato;
    ///fogo normal
    /// fogo apagado
    /// fogo aumentou
    public FireState estadoDoFogo;
    public FireType tipoDeFogo;
    
    public void OnTriggerEnter()
    {
        // if(other.Extintor)
        // {
        //     // if(other.MasterExtintor.tipoDeExtintor == tipoDeFogo)
        //     // {
        //     //     Debug.Log("Fogo e compativel com o extintor e apagou");
        //     // }

        //     // else
        //     // {
        //     //     Debug.Log("Extintor errado, fogo aumenta");
        //     // }

        //     // switch case(other.MasterExtintor.tipoDeExtintor):
        //     // case type.A:
        //     // break;

        //     // case type.B:
        //     // break;

        //     // case type.C:
            
        //     // break;

        //     // case type.K:
        //     // break;

        // }
    }
}

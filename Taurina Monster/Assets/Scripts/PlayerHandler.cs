using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerHandler : MonoBehaviour
{
    /// <summary>
    /// This onTrigger is used for when the user gets close to an enemy zombie and it will follow him until the player loses all of his health or the zomibie loses all of it's health and die.
    /// </summary>
    /// <param name="c"></param>
    void OnTriggerEnter(Collider c)
    {
        if(c.gameObject.name == "Spot Light"){
            Debug.Log("PLAYER LIGHT COLLISION WITH " + c);
            c.GetComponentInParent<navMeshController>().changeState(true);
        }
    }
}

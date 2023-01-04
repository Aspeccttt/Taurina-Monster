using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnArea : MonoBehaviour
{

    public GameObject Package;
    Vector3 Randompos;

    // Start is called before the first frame update
    void Start()
    {
        Randompos = new Vector3(
            Random.Range(gameObject.transform.position.x - 100f, gameObject.transform.position.x + 100f),
            this.gameObject.transform.position.y,
            Random.Range(gameObject.transform.position.z - 100f, gameObject.transform.position.z + 100f));
        Instantiate(Package, Randompos, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

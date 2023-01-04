using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Package : MonoBehaviour
{

    public TMPro.TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Player")
        {
            
            text.text = "You Found the Care Package. You Shold Retrun to the Safe House";

            StartCoroutine(foundCarePackage());
        }
    }

    IEnumerator foundCarePackage()
    {

        yield return new WaitForSeconds(3f);
        text.text = "";
        Destroy(this.gameObject);
    }

}

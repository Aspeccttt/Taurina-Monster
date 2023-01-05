using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flickering_Light : MonoBehaviour
{
    // Start is called before the first frame update
    Light candleLight;
    bool changeLight;
    float currentIntensity;
    float newIntensity;
    void Start()
    {
        candleLight = this.gameObject.GetComponent<Light>();
        changeLight = true;
        currentIntensity = candleLight.intensity;
    }

    // Update is called once per frame
    void Update()
    {
        if (changeLight)
        {
            changeLight = false;
            StartCoroutine(flickering());
        }
    }

    public void setnewIntensity()
    {
        float ranIntensity = Random.Range(200,400);
        newIntensity = ranIntensity/100;
    }

    IEnumerator flickering()
    {
        setnewIntensity();
        if (currentIntensity < newIntensity)
        {
            while (newIntensity > currentIntensity)
            {

                candleLight.intensity = currentIntensity;
                currentIntensity = currentIntensity + 0.1f;
                yield return new WaitForSeconds(0.05f);
            }
        }
        else
        {
            while (newIntensity < currentIntensity)
            {

                candleLight.intensity = currentIntensity;
                currentIntensity = currentIntensity - 0.1f;
                yield return new WaitForSeconds(0.05f);
            }
        }
        
        changeLight = true;
    }
}

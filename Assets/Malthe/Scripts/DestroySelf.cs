using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySelf : MonoBehaviour
{
    public GoodSoup Soup;

    /*public void Destroysself()
    {
        if (Soup.IsTomatoin == true && Soup.isCarrotin == true && Soup.isSteakin == true)
            Invoke("Destroy", 3.0f);

    }
    */

    public void FixedUpdate()
    {
        if(Soup.IsTomatoin == true && Soup.isCarrotin == true && Soup.isSteakin == true)
            Invoke("Destroy", 3.0f);
    }
    
    void Destroy()
    {
        GameObject[] clones = GameObject.FindGameObjectsWithTag("Gryde");
        Debug.Log("Im trying to destroy");
        // Destroy the original object
        Destroy(gameObject);

        // Destroy all clones
        foreach (GameObject clone in clones)
        {
            Destroy(clone);
        }
    }


}

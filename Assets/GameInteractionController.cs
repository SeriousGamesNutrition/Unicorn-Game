using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInteractionController : MonoBehaviour
{
    public int collectedValueSum;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    void OnTriggerEnter2D(Collider2D other){
        Debug.Log("character hit "+other.gameObject.name);

        if (other.gameObject.name.Contains("Coin")){
            collectedValueSum = collectedValueSum + other.gameObject.GetComponent<coinScript>().coinValue;
            Debug.Log("I hit a coin");
            Debug.Log("coin is worth: "+other.gameObject.GetComponent<coinScript>().coinValue);
            Destroy(other.gameObject);
            Debug.Log("Stored Value: "+ collectedValueSum);
        }
    }
}

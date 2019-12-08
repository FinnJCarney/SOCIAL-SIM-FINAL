using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePrice : MonoBehaviour
{

    public bool IncreasePrice;

    public CandyStorage candy;

    public float priceChange;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void OnMouseDown()
    {
        if(IncreasePrice)
        {
            candy.Price += priceChange;
        }
        else
        {
            candy.Price -= priceChange;
        }
    }
}

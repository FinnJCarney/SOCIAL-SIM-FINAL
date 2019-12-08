using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyStorage : MonoBehaviour
{

    public string Name;
    public int Amount;
    public float Price;

    public TextMesh text;

    public TextMesh tm;
    public TextMesh PriceText;

    // Start is called before the first frame update
    void Start()
    {
        tm = GetComponentInChildren<TextMesh>();
    }

    // Update is called once per frame
    void Update()
    {
        tm.text = "" + Amount;
        PriceText.text = "" + Price;
    }
}

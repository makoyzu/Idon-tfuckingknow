using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChainList : MonoBehaviour
{
    int chains = 5;

    public Image bodyImage;
    public BodyChange Chain1;
    public BodyChange Chain2;
    public BodyChange Chain3;
    public BodyChange Chain4;
    public BodyChange Freed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateChains();
    }
    
    // Update is called once per frame
    public void UpdateChains()
    {
        if (chains == 5) 
        {
            bodyImage.sprite = Chain1.body;
        }
        if (chains == 4) 
        {
            bodyImage.sprite = Chain2.body;
        }
        if (chains == 3) 
        {
            bodyImage.sprite = Chain3.body;
        }
        if (chains == 2)
        {
            bodyImage.sprite = Chain4.body;
        }
        if (chains == 1) 
        {
            bodyImage.sprite = Freed.body;
        }

    }

    public void Remove()
    {
         
        chains -= 1;
        UpdateChains();
      
    }
}

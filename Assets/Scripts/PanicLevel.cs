using UnityEngine;
using UnityEngine.UI;

public class PanicLevel : MonoBehaviour
{
    int Panic;

    public Image potraitImage;
    public IconChange neutralIcon;
    public IconChange panicIcon;
    public IconChange hystericalIcon;


    public void AddPanic()
    {
        Panic += 2;
        Debug.Log("Panic:" + Panic);
        
    }

    private void Start()
    {
        potraitImage.sprite = neutralIcon.face;
    }
    private void Update()
    {
        if (Panic < 30)
        {
            potraitImage.sprite = neutralIcon.face;
        }

        if (Panic > 30 && Panic < 70)
        {
            potraitImage.sprite = panicIcon.face;
        }
        if (Panic > 70)
        {
            potraitImage.sprite= hystericalIcon.face;
        }
                

                
                
                
        }
    }

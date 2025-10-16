using UnityEditor.UI;
using UnityEngine;
using UnityEngine.U2D.IK;

public class Enemy : MonoBehaviour
{
    public GameObject chainManager;
    [SerializeField] int hp;
    
    [SerializeField] int damageAmount = 1;
    [SerializeField] PanicLevel panic;
    [SerializeField] ChainList chain;

    public void TakeDamage()
    {
        
        hp -= damageAmount;
        panic.AddPanic();
        if (hp <= 0)
        {
            chainManager.SendMessage("Remove");
            Destroy(gameObject);
        }
    }

}
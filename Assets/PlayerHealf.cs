using UnityEngine;
using System.Collections;

public class PlayerHealf : MonoBehaviour
{
    public int MaxHealf = 3;
    public int Hp = 3; 
    public int currentHealf;

    public bool isInvincible = false;
    public float invincibilityFlashDelay = 0.5f;

    public SpriteRenderer graph; 
    public HealfBar healfbar; 

    private void Start()
    {
        currentHealf = MaxHealf;
        healfbar.SetMaxHealf(MaxHealf);
       
    }
    public void Update()
    {
        
        if ((Input.GetKeyDown(KeyCode.K)))
        {
            Takeheal(1);
        }
    }
    public void TakeDamage(int damage)
    {
        if (!isInvincible)
        {
            currentHealf -= damage;
            Hp = Hp - 1;
            healfbar.SetHealth(currentHealf);
            isInvincible = true; 
            StartCoroutine(InvincibleFalsh());
            StartCoroutine(HandINvici());
        }
        if (Hp <= 0)
        {
            Destroy(transform.gameObject);
        }

    }
    public void Takeheal(int Hpp)
    {
        if (Hp < 3)
        {
            currentHealf += Hpp;
            Hp = Hp + 1;
            healfbar.SetHealth(currentHealf);
        }
        
        
    }
    public IEnumerator InvincibleFalsh()
    {
        while (isInvincible)
        {
            graph.color = new Color(1f, 1f, 1f, 0f);
            yield return new WaitForSeconds(invincibilityFlashDelay);
            graph.color = new Color(1f, 1f, 1f, 1f);
            yield return new WaitForSeconds(invincibilityFlashDelay);
        }

    }
    public IEnumerator HandINvici()
    {
        yield return new WaitForSeconds(3f);
        isInvincible = false; 

    }

}

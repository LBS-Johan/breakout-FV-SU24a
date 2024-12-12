using UnityEngine;

public class BlockBreak : MonoBehaviour
{
    public GameObject hitPrefab;

    void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("Ball"))
        {
           
            ChangeToHitVisual();
        }
    }

    void ChangeToHitVisual()
    {
       
        GameObject hitVisual = Instantiate(hitPrefab, transform.position, transform.rotation);

       
        hitVisual.transform.localScale = transform.localScale;

        
        Destroy(gameObject);
    }
}

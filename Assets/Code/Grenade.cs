using UnityEngine;
using System.Collections;

public class Grenade : MonoBehaviour
{
    public float lifetime = 3.0f;

    public GameObject explosionPrefab;

    void Start()
    {
        StartCoroutine(Explode(lifetime));
    }

    private IEnumerator Explode(float time)
    {
        yield return new WaitForSeconds(time);

        Instantiate(explosionPrefab, transform.position, Quaternion.identity);

        Destroy(gameObject);
    }
    void OnCollisionEnter(Collision collision)
    {
        

        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("jo");
            StartCoroutine(Explode(0));
        }

    }


}

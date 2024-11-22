using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] int rotationSpeed;
    void Update()
    {
        transform.Rotate(0,rotationSpeed * Time.deltaTime,0);
    }
    private void OnTriggerEnter(Collider other) {
        FindObjectOfType<CoinManager>().addOne();
        Destroy(gameObject);
    }
}

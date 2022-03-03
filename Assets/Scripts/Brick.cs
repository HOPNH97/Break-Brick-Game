using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    public GameObject smoke;
    private void OnDestroy()
    {
        GameObject flare = Instantiate(smoke, transform.position, Quaternion.identity);
        Destroy(flare, 0.2f);
    }
}

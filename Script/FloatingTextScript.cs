using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingTextScript : MonoBehaviour
{
    public Vector3 RandomIntensity = new Vector3(0.5f, 0, 0);
    public Vector3 Offset = new Vector3(0, 1, 0);       //Y position showing text
    public float DestroyTime = 0.1f;                  //Time that the text will disappear;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, DestroyTime);
        transform.localPosition += Offset;
        transform.localPosition += new Vector3(Random.Range(-RandomIntensity.x, RandomIntensity.x),
        Random.Range(-RandomIntensity.y, RandomIntensity.y),
        Random.Range(-RandomIntensity.z, RandomIntensity.z));
    }

}

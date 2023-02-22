using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    public float Velo;
    // Start is called before the first frame update
    void Start()
    {
    }
    public void SetVelo(float velo)
    {
        Velo = velo;
    }

    // Update is called once per frame
    void Update()
    {
        if (Velo != 0f)
        {
            gameObject.transform.Translate(new Vector3(1 * Velo * Time.deltaTime, 0));
        }
    }
}

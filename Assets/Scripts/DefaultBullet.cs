using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultBullet : Bullet
{

    public override void Fire()
    {
        GameObject gameObject = Resources.Load("Prefabs/BulletDefault") as GameObject;
        var clone = GameObject.Instantiate(gameObject);
        clone.transform.position = new Vector2(1, 1);
        GameObject.Destroy(clone.gameObject, 0.5f);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultBullet : Bullet
{

    public override void Fire()
    {
        GameObject gameObject = Resources.Load("Prefabs/BulletDefault") as GameObject;
        var clone = GameObject.Instantiate(gameObject);
        clone.transform.position = new Vector2(0, 0);
        clone.GetComponent<BulletBehavior>().SetVelo(1f);
        GameObject.Destroy(clone.gameObject, 3);
    }
}

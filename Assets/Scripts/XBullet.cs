using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XBullet : BulletDecorator
{
    public XBullet( Bullet bullet) : base( bullet)
    {
    }

    public override void Fire()
    {
        GameObject gameObject = Resources.Load("Prefabs/BulletX") as GameObject;
        var clone = GameObject.Instantiate(gameObject);
        clone.transform.position = new Vector2(0, 1);
        GameObject.Destroy(clone.gameObject, 0.5f);
        base.Fire();
    }
}

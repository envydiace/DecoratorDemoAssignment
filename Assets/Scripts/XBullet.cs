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
        clone.transform.position = new Vector2(0, 0.5f);
        clone.GetComponent<BulletBehavior>().SetVelo(1.5f);
        GameObject.Destroy(clone.gameObject, 3);
        base.Fire();
    }
}

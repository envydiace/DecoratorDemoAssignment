using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class YBullet : BulletDecorator
{
    public YBullet(Bullet bullet) : base(bullet)
    {
    }

    public override void Fire()
    {
        GameObject gameObject = Resources.Load("Prefabs/BulletY") as GameObject;
        var clone = GameObject.Instantiate(gameObject);
        clone.transform.position = new Vector2(1, 0);
        GameObject.Destroy(clone.gameObject, 0.5f);
        base.Fire();
    }
}

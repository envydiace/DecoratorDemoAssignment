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
        clone.transform.position = new Vector2(0, -0.5f);
        clone.GetComponent<BulletBehavior>().SetVelo(2f);
        GameObject.Destroy(clone.gameObject, 3);
        base.Fire();
    }
}

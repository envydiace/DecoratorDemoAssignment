using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BulletDecorator : Bullet
{
    protected Bullet bullet;
    public BulletDecorator( Bullet bullet) 
    {
        this.bullet = bullet;
    }
    public override void Fire()
    {
        if (bullet != null)
        {
            bullet.Fire();
        }
    }
}

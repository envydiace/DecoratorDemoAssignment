using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunBehavior : MonoBehaviour
{
    private Timer timer;
    private bool canShot;

    public Bullet bullet;
    public void SetBullet(Bullet bullet)
    {
        this.bullet = bullet;
    }
    // Start is called before the first frame update
    void Start()
    {
        canShot = true;
        timer = gameObject.AddComponent<Timer>();   
        timer.Duration = 1f;
        timer.Run();
        bullet = new DefaultBullet();
    }

    // Update is called once per frame
    void Update()
    {
        if (!canShot && timer.Finished)
        {
            canShot = true;
        }
        if (canShot)
        {
            bullet.Fire();
            canShot = false;
            timer.Duration = 1f;
            timer.Run();
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            this.FireDefault();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            this.FireDefaultAndX();
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            this.FireDefaultAndY();
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            this.FireeDefaultAndXAndY();
        }
    }

    void FireDefault()
    {
        var defaultBullet = new DefaultBullet();
        this.SetBullet(defaultBullet);
    }

    void FireDefaultAndX()
    {
        var defaultBullet = new DefaultBullet();
        XBullet xBullet = new XBullet(defaultBullet);
        this.SetBullet(xBullet);
    }
    void FireDefaultAndY()
    {
        var defaultBullet = new DefaultBullet();
        YBullet yBullet = new YBullet(defaultBullet);
        this.SetBullet(yBullet);
    }
    void FireeDefaultAndXAndY()
    {
        var defaultBullet = new DefaultBullet();
        XBullet xBullet= new XBullet(defaultBullet);
        YBullet yBullet = new YBullet(xBullet);
        this.SetBullet(yBullet);
    }
}

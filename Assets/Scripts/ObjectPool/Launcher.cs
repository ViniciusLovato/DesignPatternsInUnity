using UnityEngine;
using UnityEngine.Pool;

public class Launcher : MonoBehaviour
{
    [SerializeField] private Bullet bulletPrefab;

    private IObjectPool<Bullet> bulletPool;

    // Start is called before the first frame update
    private void Awake()
    {
        bulletPool = new ObjectPool<Bullet>(CreateBullet, ActionOnGet, ActionOnRelease, ActionOnDestroy, maxSize:5);
    }


    private Bullet CreateBullet()
    {
        var bullet = Instantiate(bulletPrefab);
        bullet.Disable += ReleaseFromPool;

        return bullet;
    }
    
    private void ActionOnGet(Bullet bullet)
    {
        bullet.transform.position = transform.position;
        bullet.transform.rotation = transform.rotation;
        bullet.gameObject.SetActive(true);
    }
    private void ActionOnRelease(Bullet bullet)
    {
        bullet.gameObject.SetActive(false);
    }
    
    private void ActionOnDestroy(Bullet bullet)
    {
        Destroy(bullet.gameObject);
    }

    
    private void ReleaseFromPool(Bullet bullet)
    {
        bulletPool.Release(bullet);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            bulletPool.Get();
        }
    }
}

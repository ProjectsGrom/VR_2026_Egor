using UnityEngine;

public class Pistol : MonoBehaviour
{
    public GameObject Bullet;
    public Transform FirePoint;
    public float Speed = 20f;
    public float LifeTime = 6f;

    public AudioClip clip;
    public AudioSource source;

    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    public void FireBullet()
    {
        //Создаём пулю
        GameObject bullet = Instantiate(Bullet, FirePoint.position, FirePoint.rotation);
        Rigidbody rigidbody = bullet.GetComponent<Rigidbody>();
        
        //даём пуле скорость 
        rigidbody.linearVelocity = FirePoint.forward * Speed;

        //производим звук
        source.PlayOneShot(clip);

        //уничтожаем пулю через LifeTime секунд 
        Destroy(bullet, LifeTime);
    }
}

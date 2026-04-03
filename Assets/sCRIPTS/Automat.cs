using UnityEngine;

[RequireComponent(typeof(Pistol))]
public class Automat : MonoBehaviour
{
    public Pistol pistol;
    public float timer;
    public bool IsFire;
    public float Speed = 0.15f;

    void Start()
    {
        pistol = GetComponent<Pistol>();
    }

    void Update()
    {
        if (IsFire == true)
        {
            timer += Time.deltaTime;
            if (timer > Speed)
            {
                pistol.FireBullet();
                timer = 0f;
            }
        }
    }

    public void FireOn()
    {
        IsFire = true;
    }

    public void FireOff()
    {
        IsFire = false;
    }

}

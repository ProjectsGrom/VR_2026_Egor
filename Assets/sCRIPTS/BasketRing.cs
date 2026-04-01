using UnityEngine;

public class BasketRing : MonoBehaviour
{
    public GameObject FX;
    private void OnTriggerExit(Collider other)
    {
        Instantiate(FX, transform.parent);
    }
}


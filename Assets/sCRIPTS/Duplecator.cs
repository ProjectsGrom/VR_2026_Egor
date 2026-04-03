using UnityEngine;

public class Duplecator : MonoBehaviour
{
    public GameObject duplicate;
    public float cooldown = 0.3f;

    float currentTime;
    bool isReady = false;

    private void Update()
    {
        currentTime += Time.deltaTime;
        if (currentTime > cooldown) 
        {
            isReady = true;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (isReady)
        {
            Rigidbody rb = gameObject.GetComponent<Rigidbody>();
            GameObject duplicateInstance = Instantiate(duplicate);
            duplicateInstance.transform.parent = transform;
            duplicateInstance.transform.localPosition = Vector3.zero;
            duplicateInstance.transform.parent = transform.parent;
            Rigidbody duplicateRB = duplicateInstance.GetComponent<Rigidbody>();
            duplicateRB.linearVelocity = rb.linearVelocity;
            duplicateRB.angularVelocity = rb.angularVelocity;
            TimerReset();
        } 
    }

    private void TimerReset()
    {
        currentTime = 0;
        isReady = false;
    }
}

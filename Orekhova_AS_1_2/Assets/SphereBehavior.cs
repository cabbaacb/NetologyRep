using UnityEngine;

public class SphereBehavior : MonoBehaviour
{
    public bool SphereScale; //индикатор масштабирования сферы в инспекторе

    void Update()
    {
        if (SphereScale)
        {
            transform.localScale += new Vector3(1.5f, 1.5f, 1.5f) * Time.deltaTime;
        }
    }
}

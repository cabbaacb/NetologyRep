using UnityEngine;

public class CylinderBehavior : MonoBehaviour
{
    public bool CylinderAngle; //индикатор поворота цилиндра в инспекторе

    void Update()
    {
        if (CylinderAngle)
        {
            transform.eulerAngles += new Vector3(-5, 0, 0) * Time.deltaTime;
        }
    }
}

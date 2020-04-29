using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float SpeedOfSpin = 1f; 

    void Update()
    {
        transform.Rotate(0, 0, SpeedOfSpin * Time.deltaTime);
    }
}

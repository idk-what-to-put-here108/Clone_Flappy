using UnityEngine;

public class PipeMove : MonoBehaviour
{
    // Serialized Fields stating custom variables
    [SerializeField] private float _speed = 1f;

    //handles the change in the pipes opistion over Time
    //moves the pipes with a speed determined by the speed variable above
    private void Update()
    {
        transform.position += Vector3.left * _speed * Time.deltaTime;
    }
}

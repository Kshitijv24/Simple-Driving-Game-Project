using UnityEngine;

public class Car : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float speedGainEverySecond;
    [SerializeField] float turnSpeed;

    int steerValue;

    private void Update()
    {
        speed += speedGainEverySecond * Time.deltaTime;

        transform.Rotate(0f, steerValue * turnSpeed * Time.deltaTime, 0f);

        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    public void Steer(int value)
    {
        steerValue = value;
    }
}

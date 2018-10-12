using UnityEngine;

public class asteroidScript : MonoBehaviour
{
    public float asteroidSpeed;
    public float randomized_Y;
    // Use this for initialization
    void Start()
    {
        asteroidSpeed = 5;
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(asteroidSpeed * Time.deltaTime, 0, 0, Space.Self);

        Vector3 newPosition = transform.position; //gör en vector variabel som sätter värdet på variabeln till asteroidens position 
        Vector3 randomY = transform.position; //gör en randomY variabel som sätter värdet till 
        randomY.y = randomized_Y;

        if (newPosition.x > 8.5f)
        {
            randomized_Y = Random.Range(5f, -5f);
            randomY.y = randomized_Y;
            newPosition.x = -newPosition.x;
            newPosition.y = randomized_Y;
        }
        transform.position = newPosition;
    }
}

using UnityEngine;

public class BackgroundColor : MonoBehaviour
{
    public Color[] colors= { new Color(0, 1, 0, 1), new Color(1, 0, 0, 1), new Color(0, 0, 1, 1) };
    float colorChangeTime = 8.0f; // Time in seconds to switch colors
    float currentTimer = 0f;
    int currentColorIndex = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        currentTimer += Time.deltaTime;

        if (currentTimer >= colorChangeTime)
        {

            currentColorIndex = (currentColorIndex + 1) % colors.Length; 
            Camera.main.backgroundColor = colors[currentColorIndex]; 
            currentTimer = 0f;

        }
        
    }
}

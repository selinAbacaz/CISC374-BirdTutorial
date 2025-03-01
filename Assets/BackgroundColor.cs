using UnityEngine;

public class BackgroundColor : MonoBehaviour
{
    public Color[] colors= { new Color(0, 1, 0, 1), new Color(1, 0, 0, 1), new Color(0, 0, 1, 1) };
    float colorChangeTime = 8.0f;     float currentTimer = 0f;
    int currentColorIndex = 0;
    void Start()
    {
        
    }

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

using UnityEngine;

public class InteractTest : MonoBehaviour, IInteractable
{
    public Behaviour Ooutline;
    public void Interact() 
    {
        Debug.Log("Works!");
    }
    public void Outline()
    {
        Ooutline.enabled = true;
    }
    public void Outlineoff()
    {
        Ooutline.enabled = false;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickups : MonoBehaviour
{
    [SerializeField] private int maxMeth = 10;
    [SerializeField] private int numMethatStart = 0;
    [SerializeField] private int collected;
    public ProgressBar progressBar;
    public GameObject door;
    public GameObject rush;
    // Start is called before the first frame update
    void Start()
    {
        progressBar.SetMaxColletibles(numMethatStart);
    }
    // Update is called once per frame
    void Update()
    {
        progressBar.Collected(collected);

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Meth"))
        {
            collected++;
            Destroy(other.gameObject);
        }
        if (collected == 10)
        {
            AppEvents.Invoke_OnMouseCursorEnable(true);
            rush.SetActive(true);
            Destroy(door);
            //door.gameObject.SetActive(false);
            Debug.Log("YOU WIN");
        }
    }
     
    public void CloseRush()
    {
        rush.SetActive(false);
        AppEvents.Invoke_OnMouseCursorEnable(false);
        //Click.Play();
    }
    
}

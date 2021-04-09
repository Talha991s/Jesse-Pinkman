using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickups : MonoBehaviour
{
    [SerializeField] private int maxMeth = 10;
    [SerializeField] private int numMethatStart = 0;
    [SerializeField] private int collected;
    public ProgressBar progressBar;

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
            Debug.Log("YOU WIN");
        }
    }
     
    
}

using UnityEngine;

public class Test: MonoBehaviour
{
    int numeroA = 30;
    int numeroB = 20;

     
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(numeroA);
    
    
    
    }




    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(1,0,0);
    }
}

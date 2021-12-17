using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class compassButtonScript : MonoBehaviour
{
    public Button button_;
    // Start is called before the first frame update
    void Start()
    {
        button_ = GetComponent<Button>();
        button_.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TaskOnClick()
    {
       SceneManager.LoadScene("Compass");
    }
}

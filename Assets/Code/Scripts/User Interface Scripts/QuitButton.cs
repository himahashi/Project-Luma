using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitButton : MonoBehaviour
{
    // Variables
    [Header("Debugging Messages")]
    public bool isDebuggingOn = false;
    private Button button;

    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(OnTask);
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Functions
    private void OnTask()
    {
        Application.Quit();
        if (isDebuggingOn)
            Debug.Log("Quit game!");
    }
}

using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

[DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
public class InGameButton : MonoBehaviour
{
    string SceneName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    public void LoadStoryScene()
    {
        SceneManager.LoadScene("1_StoryScene");
    }
    public void LoadIngameScene()
    {
        SceneManager.LoadScene("Test1");
    }
    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}

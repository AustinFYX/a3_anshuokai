using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class page : MonoBehaviour
{

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClickMenu()
    {
        SceneManager.LoadScene("menu");
        
    }
    public void OnClickFei()
    {
        SceneManager.LoadScene("YuxiaoFei");
        
    }
    public void OnClickZhang()
    {
        SceneManager.LoadScene("zhang");
        
    }
    public void OnClickAn()
    {
        SceneManager.LoadScene("Page 1");
        
    }
    public void OnClickLu()
    {
        SceneManager.LoadScene("Lu's scene");
        
    }
    public void OnClickCredit()
    {
        SceneManager.LoadScene("credit");
    }
}

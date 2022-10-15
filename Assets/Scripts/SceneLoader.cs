
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
   [SerializeField] private string login = "test";
   [SerializeField] private string password = "test2";
   [SerializeField] private int Scene_id;
   
    
    public void Login()
    {
        if (GetUserInfo(login, password))
        {
            SceneManager.LoadScene(Scene_id);
        }
    }

    bool GetUserInfo(string login, string password)
    {
        //запрос в базу и вернуть True если он есть
        return true;
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
public class NotificationDisplay : MonoBehaviour
{
    public GameObject notificationObject;
    public string sceneToLoad = "HP";

    void Start()
    {
        StartCoroutine(ShowNotification(2)); 
    }

    IEnumerator ShowNotification(float delay)
    {
        notificationObject.SetActive(true); 
        yield return new WaitForSeconds(delay);
        notificationObject.SetActive(false); 

        
        SceneManager.LoadScene(sceneToLoad);
    }
}

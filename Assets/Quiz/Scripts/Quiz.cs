using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Quiz : MonoBehaviour
{
    public void AnatomyTopics()
    {
        SceneManager.LoadScene("AnatomyVideo");
    }

    public void ArrowBack()
    {
        SceneManager.LoadScene("Topics");
    }

    public void Anatomy()
    {
        SceneManager.LoadScene("Anatomy");
    }

    public void ArrowUP()
    {
        SceneManager.LoadScene("AnatomyUp");
    }

    public void ArrowDown()
    {
        SceneManager.LoadScene("AnatomyDown");
    }

    public void ArrowRight()
    {
        SceneManager.LoadScene("AnatomyRight");
    }

    public void ArrowLeft()
    {
        SceneManager.LoadScene("AnatomyLeft");
    }

    public void ArrowRight2()
    {
        SceneManager.LoadScene("Quiz4");
    }

    public void Left_Central_Incisor()
    {
        SceneManager.LoadScene("LeftCentralIncisor");
    }

    public void Quiz_Left_Central_Incisor()
    {
        SceneManager.LoadScene("QLeftCentralIncisor");
    }

    public void Quiz_Left_Third_Molar()
    {
        SceneManager.LoadScene("QLeftThirdMolar");
    }

    public void Left_Third_Molar()
    {
        SceneManager.LoadScene("LeftThirdMolar");
    }

    public void LeftCentralIncisorVideo()
    {
        Application.OpenURL("https://youtu.be/ttfMCOdywqA?si=hsNhKhQpFXXJhwzg");
    }

    public void LeftThirdMolarVideo()
    {
        Application.OpenURL("https://youtu.be/3KvHIxr43lQ?si=ocsEoFM6v-JfTOp0");
    }

    public void Anatomy_Left_Video()
    {
        Application.OpenURL("https://youtu.be/V7QeiIVpNac?si=XiJHrJpioXLIMoNy");
    }

    public void Anatomy_Right_Video()
    {
        Application.OpenURL("https://youtu.be/vjjy5Edfnu0?si=dxi05xlkqgyZOCzH");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Next : MonoBehaviour
{
    int sceneIndex;

    // Start is called before the first frame update
    void Start()
    {
        sceneIndex = SceneManager.GetActiveScene().buildIndex; // ���̴� ���� ����
    }

    public void NextScene()
    {
        SceneManager.LoadScene(sceneIndex + 1); // ���� ������ �Ѿ��
    }

    public void NNextScene()
    {
        SceneManager.LoadScene(sceneIndex + 2); // �ٴ��� ������ �Ѿ��
    }

    public void NNNextScene()
    {
        SceneManager.LoadScene(sceneIndex + 3); // �ٴٴ��� ������ �Ѿ��
    }

    public void NNNNextScene()
    {
        SceneManager.LoadScene(sceneIndex + 4); // �ٴٴٴ��� ������ �Ѿ��
    }

    public void NNNNNextScene()
    {
        SceneManager.LoadScene(sceneIndex + 5); // �ٴٴٴٴ��� ������ �Ѿ��
    }
    public void NNNNNNextScene()
    {
        SceneManager.LoadScene(sceneIndex + 6); // �ٴٴٴٴ��� ������ �Ѿ��
    }
    public void NowScene()
    {
        SceneManager.LoadScene(sceneIndex);
    }
    public void RunconnectScene()
    {
        SceneManager.LoadScene(sceneIndex - 6);
    }


}

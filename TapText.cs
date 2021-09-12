using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TapText : MonoBehaviour
{
    public float SpawnTime = 0.5f;
    public Text Text;

    private float _spawntime;

    private void OnEnable()
    {
        _spawntime = SpawnTime;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _spawntime -= Time.unscaledDeltaTime;
        if (_spawntime <= 0f)
        {
            gameObject.SetActive(false);
        }
        else
        {
            Text.CrossFadeAlpha(0f, 0.5f, false);
            if(Text.color.a == 0f)
            {
                gameObject.SetActive(false);
            }
        }
    }
}

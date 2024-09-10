using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorManager : MonoBehaviour
{
    public Texture2D cursorTexture;
    public GameObject particleEffect;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.SetCursor(cursorTexture, Vector2.zero, CursorMode.Auto);
        particleEffect.GetComponent<ParticleSystem>().Stop();
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        var mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPos.z = 0f;

        if (Input.GetMouseButtonDown(0))
        {
            particleEffect.transform.position = new Vector3( mouseWorldPos.x, mouseWorldPos.y, -10);
           particleEffect.GetComponent<ParticleSystem>().Play();
            Invoke("StopParticle", 0.2f);
        }
    }
    public void StopParticle()
    {
        particleEffect.GetComponent<ParticleSystem>().Stop();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class FlieLoaderSystem : MonoBehaviour
{
    private MP3Loader mp3Loader;

    private void Awake() {;
        mp3Loader = GetComponent<MP3Loader>();
    }

    public void LoadFile(FileInfo file)
    {
        OffAllPanel();

        if(file.FullName.Contains(".wav"))
        {
            mp3Loader.OnLoad(file);
        }
        else if(file.FullName.Contains(".mp3"))
        {
            mp3Loader.OnLoad(file);
        }
        else 
        {
            Debug.Log("지원하지 않는 파일 형식입니다.");
            
            return;
        }
    }
   private void OffAllPanel()
   {
        mp3Loader.OffLoad();
   }
}

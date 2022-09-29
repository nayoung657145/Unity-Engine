using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;


public class MP3Loader : MonoBehaviour
{
    [Header("MP3 Player Panel, File Name")]
    [SerializeField]
    private GameObject panelDirectory;      //음원 재생 제어를 위한 Panel
    [SerializeField]
    private Text textFileName;      //파일 이름 Text

    [Header("MP3 Play Time (Slider, Text)")]
    [SerializeField]
    private Slider sliderPlaybar;       //재생시간을 나타내는 Slider
    [SerializeField]
    private Text textCurrentPlaytime;       //현재 재생시간 Text
    [SerializeField]
    private Text textMaxPlaytime;      //총 재생시간 Text

    [Header("Play Audio")]
    [SerializeField]
    private AudioSource audioSource;        //음원 재생용 AudioSource

    private void Awake() {
        panelDirectory.SetActive(false);
    }
/// <summary>
/// 파일 찾기 버튼 클릭 시 파일 디렉토리 창이 뜨도록 하는 함수
/// </summary>
    public void OnPanelDirectory() 
    {
        //panel 활성화
        panelDirectory.SetActive(true);
    }

    public void OnLoad(System.IO.FileInfo file) 
    {
        //MP3 파일 이름 출력
        textFileName.text = file.Name;

        //재생시간 표시에 사용되는 Slider, Text 초기화
        ResetPlaytimeUI();

        //MP3 파일을 불러와서 재생
        StartCoroutine(LoadAudio(file.FullName));
    }

    private IEnumerator LoadAudio(string fileName)
    {
        AudioClip clip = null;
   
        fileName = "file://" + fileName;

        // fileName 파일을 MP3 AudioClip 형태로 받아와서 audioData에 저장
        UnityWebRequest request = UnityWebRequestMultimedia.GetAudioClip(fileName, AudioType.WAV);
        
        //request에 데이터를 정상적으로 모두 로드할 때까지 대기
        yield return request.SendWebRequest();

        // 데이터 로드에 성공했을 때
        if ( request.isNetworkError)
        {
            Debug.Log("File Load Failed");
        }
        // 데이터 로드에 실패했을 때
        else
        {
            Debug.Log($"Load Success : {fileName}");

            if(Application.platform == RuntimePlatform.WindowsEditor || Application.platform == RuntimePlatform.WindowsPlayer) 
            {
                //파일의 확장자가 Wav일 때
                if(fileName.Contains(".wav"))
                {
                    Debug.Log("Here 1");
                    clip = DownloadHandlerAudioClip.GetContent(request);
                }
                //파일의 확장자가 Mp3일 때
                else
                {
                    clip = NAudioPlayer.FromMp3Data(request.downloadHandler.data, fileName);
                    Debug.Log("Here 2");
                }
                
            }
            // 윈도우가 아닌 플랫폼에서는 UnityWebRequest를 사용
            else
            {
                Debug.Log("Here 3");
                clip = DownloadHandlerAudioClip.GetContent(request);
            }
            
            Debug.Log("Here 4");

            //MP3 재생 파일 설정
            audioSource.clip = clip; 
        }
    }
    public void OffLoad() 
    {
        Stop();

        panelDirectory.SetActive(false);
    }

    public void Play ()
    {
        //사운드 재생
        audioSource.Play();

        //Slider, Text에 재생시간 정보 업데이트
        StartCoroutine("OnPlaytimeUI");
    }
    
    public void Pause() 
    {
        audioSource.Pause();
    }
     public void Stop() 
    {
        audioSource.Stop();

        //Slider, Text에 재생시간 정보 업데이트 중지
        StartCoroutine("OnPlaytimeUI");
        // 재생시간 표시에 사용되는 Slider, Text 초기화
        ResetPlaytimeUI();
    }

    private void ResetPlaytimeUI()
    {
        sliderPlaybar.value = 0;
        textCurrentPlaytime.text = "00:00:00";
        textMaxPlaytime.text = "00:00:00";
    }
    private IEnumerator OnPlaytimeUI()
    {
        int hour = 0;
        int minutes = 0;
        int seconds = 0;

        while (true)
        {
            //현재 재생시간 표시
            hour = (int)audioSource.time/3600;
            minutes = (int)(audioSource.time%3600)/60;
            seconds = (int)(audioSource.time%3600)%60;
            textCurrentPlaytime.text = $"{hour:D2}:{minutes:D2}:{seconds:D2}";

            //총 재생시간 표시
            hour = (int)audioSource.clip.length/3600;
            minutes = (int)(audioSource.clip.length%3600)/60;
            seconds = (int)(audioSource.clip.length%3600)%60;
            textMaxPlaytime.text = $"{hour:D2}:{minutes:D2}:{seconds:D2}";

            //현재 재생시간을 슬라이더에 적용
            sliderPlaybar.value = audioSource.time / audioSource.clip.length;

            yield return new WaitForSeconds(1);
        }
    }
}

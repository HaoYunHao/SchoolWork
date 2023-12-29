//using System.Collections;
//using System.Collections.Generic;
//using UnityEditor.PackageManager.UI;
//using UnityEngine;
//using UnityEngine.EventSystems;
//using UnityEngine.UI;
//using UnityEngine.Video;

//public class VideoPlay : MonoBehaviour
//{
//    public VideoPlayer Source;
//    public SampleSlider LengthSlider;
//    public Scrollbar VolumeScrollbar;
//    public Button PlayButton;
//    public Button SetButton;
//    // Start is called before the first frame update
//    void Start()
//    {
//        LengthSlider.maxValue = (float)Source.clip.length;
//        LengthSlider.minValue = 0;

//        LengthSlider.onValueChanged.AddListener(SetSourceLength);
//        LengthSlider.OnSliderPointerDown +=OnSliderPointerDown;
//        LengthSlider.OnSliderPointerUp += OnSliderPointUp;
      

//        PlayButton.onClick.AddListener(PlayVideo);
//        SetButton.onClick.AddListener(() =>
//        {
//            SetSourceLength(0);
//        });

//        VolumeScrollbar.onValueChanged.AddListener(SetVideoVolume);
//        SetVideoVolume(1);
//        var handle = VolumeScrollbar.handleRect.AddComponent<Button>();
//        handle.onClick.AddListener(() =>
//        {
//            if(VolumeScrollbar .value == 0)
//            {
//                SetVideoVolume(1);
//            }
//            else
//            {
//                SetVideoVolume(0);
//            }
//        });
//    }

//    void SetVideoVolume(float value)
//    {
//        Source.volume = value;
//        if(VolumeScrollbar .value != value)
//        {
//            VolumeScrollbar.value = value;
//        }

//    }
//    void PlayVideo()
//    {
//        Source.Play();
//    }
//    void PauseVideo()
//    {
//        Source.Pause();
//    }
//    void OnSliderPointerDown(PointerEventData eventData)
//    {
//        PauseVideo();
//    }
//    void OnSliderPointUp(PointerEventData eventData)
//    {
//        PlayVideo();
//    }
//    //当Slider值改变时调用
//    void SetSourceLength(float value)
//    {
//        //Time是当前资源播放时间
//        Source.time = value;
//    }
//    // Update is called once per frame
//    void Update()
//    {
//        if(Source .isPlaying)
//        {
//            LengthSlider.value = (float)Source.time;
//        }
//    }
//}

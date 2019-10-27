using System;
using UnityEngine;


//custom amplitude will work on devices which support this feature
public static class VibrationHelper
{
    public static int minAmplitude = 1;
    public static int maxAmplitude = 255;
    
    private static AndroidJavaObject _javaObj;
    private static bool _init;

    /// <summary>
    /// Vibrate with Click Effect amplitude (API 29)
    /// Vibrate with Default Effect amplitude (Before API 29)
    /// </summary>
    /// <param name="milliseconds">The number of milliseconds to vibrate</param>
    public static void VibrateClick(long milliseconds)
    {
#if UNITY_EDITOR
        Debug.LogWarning("Vibration not support in Editor.");
#elif UNITY_ANDROID
        if (!_init)
        {
            _javaObj = new AndroidJavaObject("com.shf.vibrator.Vibration");
            _init = true;
        }

        _javaObj?.Call("ClickEffectVibrate", GetActivity(), milliseconds);
#elif UNITY_IOS
        Debug.LogWarning("Vibration not support in IOS.");
#endif
    }

    /// <summary>
    /// Vibrate with DoubleClick Effect amplitude (API 29)
    /// Vibrate with Default Effect amplitude (Before API 29)
    /// </summary>
    /// <param name="milliseconds">The number of milliseconds to vibrate</param>
    public static void VibrateDoubleClick(long milliseconds)
    {
#if UNITY_EDITOR
        Debug.LogWarning("Vibration not support in Editor.");
#elif UNITY_ANDROID
        if (!_init)
        {
            _javaObj = new AndroidJavaObject("com.shf.vibrator.Vibration");
            _init = true;
        }

        _javaObj?.Call("DoubleClickEffectVibrate", GetActivity(), milliseconds);
#elif UNITY_IOS
        Debug.LogWarning("Vibration not support in IOS.");
#endif
    }

    /// <summary>
    /// Vibrate with HeavyClick Effect amplitude (API 29)
    /// Vibrate with Default Effect amplitude (Before API 29)
    /// </summary>
    /// <param name="milliseconds">The number of milliseconds to vibrate</param>
    public static void VibrateHeavyClick(long milliseconds)
    {
#if UNITY_EDITOR
        Debug.LogWarning("Vibration not support in Editor.");
#elif UNITY_ANDROID
        if (!_init)
        {
            _javaObj = new AndroidJavaObject("com.shf.vibrator.Vibration");
            _init = true;
        }

        _javaObj?.Call("HeavyClickEffectVibrate", GetActivity(), milliseconds);
#elif UNITY_IOS
        Debug.LogWarning("Vibration not support in IOS.");
#endif
    }

    /// <summary>
    /// Vibrate with Tick Effect amplitude (API 29)
    /// Vibrate with Default Effect amplitude (Before API 29)
    /// </summary>
    /// <param name="milliseconds">The number of milliseconds to vibrate</param>
    public static void VibrateTick(long milliseconds)
    {
#if UNITY_EDITOR
        Debug.LogWarning("Vibration not support in Editor.");
#elif UNITY_ANDROID
        if (!_init)
        {
            _javaObj = new AndroidJavaObject("com.shf.vibrator.Vibration");
            _init = true;
        }

        _javaObj?.Call("TickEffectVibrate", GetActivity(), milliseconds);
#elif UNITY_IOS
        Debug.LogWarning("Vibration not support in IOS.");
#endif
    }

    /// <summary>
    /// Vibrate with input amplitude (API 26)
    /// Vibrate with Default Effect amplitude (Before API 29)
    /// </summary>
    /// <param name="milliseconds">The number of milliseconds to vibrate</param>
    /// <param name="amplitude">The strength of the vibration. This must be a value between 1 and 255</param>
    public static void VibrateWithAmplitude(long milliseconds, int amplitude)
    {
#if UNITY_EDITOR
        Debug.LogWarning("Vibration not support in Editor.");
#elif UNITY_ANDROID
        if (!_init)
        {
            _javaObj = new AndroidJavaObject("com.shf.vibrator.Vibration");
            _init = true;
        }

        if (amplitude < 1 || amplitude > 255)
        {
            throw new ArgumentOutOfRangeException($"amplitude must be between 1 and 255. input value is: {amplitude}");
        }

        _javaObj?.Call("AmplitudeVibrate", GetActivity(), milliseconds, amplitude);
#elif UNITY_IOS
        Debug.LogWarning("Vibration not support in IOS.");
#endif
    }
    
    private static AndroidJavaObject GetActivity()
    {
        var actClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        AndroidJavaObject act = actClass.GetStatic<AndroidJavaObject>("currentActivity");
        return act;
    }
}
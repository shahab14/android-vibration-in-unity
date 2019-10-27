using UnityEngine;

public class TestVibration : MonoBehaviour
{
    public void VibrateClick(int milliseconds)
    {
        VibrationHelper.VibrateClick(milliseconds);
    }
    
    public void VibrateDoubleClick(int milliseconds)
    {
        VibrationHelper.VibrateDoubleClick(milliseconds);
    }
    
    public void VibrateHeavyClick(int milliseconds)
    {
        VibrationHelper.VibrateHeavyClick(milliseconds);
    }
    
    public void VibrateTick(int milliseconds)
    {
        VibrationHelper.VibrateTick(milliseconds);
    }

    public void VibrateMinAmplitude(int milliseconds)
    {
        VibrationHelper.VibrateWithAmplitude(milliseconds, VibrationHelper.minAmplitude);
    }
    
    public void VibrateMaxAmplitude(int milliseconds)
    {
        VibrationHelper.VibrateWithAmplitude(milliseconds, VibrationHelper.maxAmplitude);
    }
    
    public void VibrateCustomAmplitude(int milliseconds)
    {
        VibrationHelper.VibrateWithAmplitude(milliseconds, 120);
    }
}

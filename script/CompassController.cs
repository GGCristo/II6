using System;
using UnityEngine;
using UnityEngine.UI; //required for Input.compass

public class CompassController : MonoBehaviour {
    public float compassSmooth = 3f;
    private float m_lastMagneticHeading = 0f;
  // Use this for initialization
  void Start () {
      // If you need an accurate heading to true north, 
      // start the location service so Unity can correct for local deviations:
      Input.location.Start();
      // Start the compass.
      Input.compass.enabled = true;        
  }
  // Update is called once per frame
  private void Update()
  {
      //do rotation based on compass
      float currentMagneticHeading = (float)Math.Round(Input.compass.magneticHeading, 2);
      if (m_lastMagneticHeading < currentMagneticHeading - compassSmooth || m_lastMagneticHeading > currentMagneticHeading + compassSmooth)
      {
          m_lastMagneticHeading = currentMagneticHeading;
          //transform.localRotation = Quaternion.Euler(0, m_lastMagneticHeading, 0);
          // transform.localRotation = Quaternion.Euler(m_lastMagneticHeading, 0, 0);
          transform.localRotation = Quaternion.Euler(0, 0, m_lastMagneticHeading);
      }
      print(currentMagneticHeading);
      print(Input.compass.enabled);
   }
}
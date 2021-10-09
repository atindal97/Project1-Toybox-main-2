using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{

    public Image ForegroundImage;

    public float updateSpeedSeconds = 0.5f;


    // Start is called before the first frame update
    public void Start()
    {
        GetComponentInParent<Health>().OnHealthPctChagned += HandleHealthChanged;
    }

    public void HandleHealthChanged (float pct)
    {
        foregroundImage.fillAmount - pct;
    }

    public IEnumerator ChangeToPct (float pct)
    {
        float proChangePct = ForegroundImage.fillamount;
        float elapsed = 0f;

        while (elapsed < updatedSpeedSeconds)
        {
            elapsed += Time.deltaTime;
            foregroundImage.fillAmount = Mathf.Lerp(preChangePct, pct, elapsed / updateSpeedSeconds);
            yield return null;
        }
        foregroundImage.fillAmount = pct;
    }

       
    // Update is called once per frame
    void Update()
    {
        
    }
}

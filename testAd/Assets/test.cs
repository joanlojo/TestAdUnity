using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds;
using GoogleMobileAds.Api;

public class test : MonoBehaviour {

    // private RewardBased
    // Use this for initialization
    private string ID = "ca-app-pub-3940256099942544/1033173712";
    private InterstitialAd interstitial;
    private RewardBasedVideoAd rewardBasedVideoAd;
    void Start () {
        //ca-app-pub-7496323921290459~8611361614 ID de la aplicacion
        //ca-app-pub-7496323921290459/1798186034 ID del anuncio para integrar el SDK Android inter
        //ca-app-pub-7496323921290459/6527768537 ID del anuncio para integrar el SDK Avideo 
        rewardBasedVideoAd = RewardBasedVideoAd.Instance;
        interstitial = new InterstitialAd(ID);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void pressButtonVideo()
    {
        /*if (this.interstitial.IsLoaded())
        {
            this.interstitial.Show();
            print("mostranto mensaje");
        }*/
        LoadRewardBasedAd();
        ShowRewardBasedAd();

    }
    public void pressButtonInter()
    {
        if (interstitial.IsLoaded())
        {
            interstitial.Show();
            print("mostranto mensaje");
        }
        else
        {
            print("No has cargado el anuncio");
        }
    }
    private void ShowRewardBasedAd()
    {
        if (rewardBasedVideoAd.IsLoaded())
        {
            rewardBasedVideoAd.Show();
            print("Muestras video");
        }
        else
        {
            MonoBehaviour.print("No has cargado el anuncio");
        }
    }

    private void RequestInterstitial()
     {
 #if UNITY_ANDROID
         string adUnitId = "ca-app-pub-3940256099942544/1033173712";
 #elif UNITY_IPHONE
         string adUnitId = "ca-app-pub-3940256099942544/4411468910";
 #else
         string adUnitId = "unexpected_platform";
 #endif

         // Initialize an InterstitialAd.
         this.interstitial = new InterstitialAd(adUnitId);

         // Create an empty ad request.
         AdRequest request = new AdRequest.Builder().Build();
         // Load the interstitial with the request.
         this.interstitial.LoadAd(request);


     }


    private void LoadRewardBasedAd()
    {
#if UNITY_ANDROID
        string adUnitId = "ca-app-pub-3940256099942544/5224354917";
#elif UNITY_IPHONE
        string adUnitId = "ca-app-pub-3940256099942544/4411468910";
#else
        string adUnitId = "unexpected_platform";
#endif

        rewardBasedVideoAd.LoadAd(new AdRequest.Builder().Build(), adUnitId);

    }

    /*public void HandleOnAdLoaded(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleAdLoaded event received");
    }

    public void HandleOnAdFailedToLoad(object sender, AdFailedToLoadEventArgs args)
    {
        MonoBehaviour.print("HandleFailedToReceiveAd event received with message: "
                            + args.Message);
    }

    public void HandleOnAdOpened(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleAdOpened event received");
    }

    public void HandleOnAdClosed(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleAdClosed event received");
    }

    public void HandleOnAdLeavingApplication(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleAdLeavingApplication event received");
    }*/
}

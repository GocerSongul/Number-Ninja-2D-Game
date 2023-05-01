using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mmmm : MonoBehaviour
{
    public UnityEngine.UI.Text ilkSayi,İkinciSayi,islem,cevap,sonuc;
    public UnityEngine.UI.InputField sonucinput;
    // Start is called before the first frame update
    int sayi1,sayi2,islemisareti;
    int trueresult;
    int c;
    void Start()
    {
       
        butononclicked();
    }

    // Update is called once per frame
    void Update()
    {}
    public void cevapkontrol(){
            if(int.Parse(cevap.text)==trueresult){
               sonuc.text= "Excellent!";
            }
            else{
                sonuc.text= "Try Again";

            }
        }
    public void butononclicked(){
        sonuc.text="";
        sonucinput.text="";
        
        islemisareti=Random.Range(1,5);
        switch(islemisareti)
        {
            case 1:
              islem.text="+";
              sayi1=Random.Range(1,50);
              sayi2=Random.Range(2,50);
              trueresult=sayi1+sayi2;
              break;
            case 2:
              islem.text="-";
              sayi1=Random.Range(1,50);
        sayi2=Random.Range(2,50);
              trueresult=sayi1-sayi2;
              break;
            case 3:
              islem.text="X";
                sayi1 = Random.Range(1, 15);
              sayi2 = Random.Range(2, 15);
              trueresult=sayi1*sayi2;
              break;
            case 4:
              
              islem.text="/";
              sayi1 = Random.Range(1,50);
              
                sayi2 = 1;
                for (int i = sayi1 / 2; i > 1; i--)
                {
                    if (sayi1 % i == 0)
                    {
                        sayi2 = i;
                        break;
                    }
                }
                trueresult =sayi1 / sayi2;
               


              break;
        }
        ilkSayi.text=sayi1+"";
        İkinciSayi.text=sayi2+"";

    }
        
    
}

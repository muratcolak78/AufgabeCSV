// See https://aka.ms/new-console-template for more information
using AufgabeCSV;



string path = "C:\\Users\\murat\\Downloads\\TestDaten.csv";

foreach (var kisi in liesCSV(path))
{
    Console.WriteLine(kisi);
}
Console.WriteLine("=======================");
search("Adela", path);




static List<data> liesCSV(string csvPath)
{
    
    // um data zu spreichern wird eine List ergestellt ..............................

    List<data> dateiList = new List<data>();

   
    try
    {
       // mit dem StreamReader kann alle datei aus CSV gelesen wird..............

        using (StreamReader reader = new StreamReader(csvPath))
        {
            // erstellen wir eine string Array
            
            string[] data;

            while (!reader.EndOfStream)                // lesung wird  bis ende dauern
            {
                string satir = reader.ReadLine();      // reihe wird in eine string variable hinzugefügt 
                data = satir.Split(';');               // dann  wird die variable in die array hinzugefügt
               
                if (data.Length < 15)                  // um ein data objekt zu erstellen wird array zu den parameter hinzugefügt
                {
                    string sütun1 = data[0];
                    string sütun2 = data[1];
                    string sütun3 = data[2];
                    string sütun4 = data[3];
                    string sütun5 = data[4];
                    string sütun6 = data[5];
                    string sütun7 = data[6];
                    string sütun8 = data[7];
                    string sütun9 = data[8];
                    string sütun10 = data[9];
                    string sütun11 = data[10];
                    string sütun12 = data[11];
                    string sütun13 = data[12];
                    string sütun14 = data[13];

                  
                    // dann wird ein object mit allen parametern ergestelt 
                    data yeniVeri = new data(sütun1, sütun2, sütun3, sütun4, sütun5, sütun6, sütun7, sütun8, sütun9, sütun10, sütun11, sütun12, sütun13, sütun14);
                    
                    // und objekt wird in die DataiList hinzugefügt damit diese list wieder genutz werden kann
                    dateiList.Add(yeniVeri);
                   
                }
            }
        }

        // mit der ForEach metode kann mann alle datai ausgeben.
        
    }
    catch (Exception ex)
    {
        Console.WriteLine("CSV dosyası okunurken bir hata oluştu: " + ex.Message);
    }
    return dateiList;
}

void search(string searchPerson,string csvDosyaYolu)
{
    List<data> veriListesi = liesCSV(csvDosyaYolu);
    List<data> bulunaKisiler = new List<data>();
    try
    {
        for (int i = 0; i < veriListesi.Count; i++)
        {
            if (searchPerson==(veriListesi[i].Vorname))
            {
                bulunaKisiler.Add(veriListesi[i]);
            }
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("kisi aramasinda hata meydana geldi");
    }

    if (bulunaKisiler.Count>0)
    {
        Console.WriteLine(bulunaKisiler.Count+" kisi bulundu");
        foreach (var kisi in bulunaKisiler)
        {
            Console.WriteLine(kisi);
        }
    }else Console.WriteLine(" aranan kisi listede yok");


}


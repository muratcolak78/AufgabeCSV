// See https://aka.ms/new-console-template for more information
using AufgabeCSV;




liesCSV("C:\\Users\\murat\\Downloads\\TestDaten.csv");




static List<data> liesCSV(string csvDosyaYolu)
{
    
    // Verileri depolamak için bir liste oluştur..............................

    List<data> veriListesi = new List<data>();

    Console.WriteLine("veri listesi olusturuldu");
    try
    {
        Console.WriteLine("try bloguna girildi");
        using (StreamReader reader = new StreamReader(csvDosyaYolu))
        {
            string[] veriler;
            while (!reader.EndOfStream)
            {
                string satir = reader.ReadLine();
                veriler = satir.Split(';');
               
                if (veriler.Length < 15)
                {
                    string sütun1 = veriler[0];
                    string sütun2 = veriler[1];
                    string sütun3 = veriler[2];
                    string sütun4 = veriler[3];
                    string sütun5 = veriler[4];
                    string sütun6 = veriler[5];
                    string sütun7 = veriler[6];
                    string sütun8 = veriler[7];
                    string sütun9 = veriler[8];
                    string sütun10 = veriler[9];
                    string sütun11 = veriler[10];
                    string sütun12 = veriler[11];
                    string sütun13 = veriler[12];
                    string sütun14 = veriler[13];

                  
                    // Verileri bir sınıf nesnesine yükle
                    data yeniVeri = new data(sütun1, sütun2, sütun3, sütun4, sütun5, sütun6, sütun7, sütun8, sütun9, sütun10, sütun11, sütun12, sütun13, sütun14);
                    
                    veriListesi.Add(yeniVeri);
                   
                }
            }
        }

        // Veri listesini kullanarak başka işlemler yapabilirsiniz
        foreach (var veri in veriListesi)
        {
            Console.WriteLine(veri);
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("CSV dosyası okunurken bir hata oluştu: " + ex.Message);
    }
    return veriListesi;
}

void search(string searchPerson,string csvDosyaYolu)
{
    List<data> veriListesi = liesCSV(csvDosyaYolu);
    List<data> bulunaKisiler = new List<data>();
    try
    {
        for (int i = 0; i < veriListesi.Count; i++)
        {
            if (searchPerson.Equals(veriListesi[i].Vorname))
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
        foreach (var vksi in bulunaKisiler)
        {

        }
    }else Console.WriteLine(" aranan kisi listede yok");


}


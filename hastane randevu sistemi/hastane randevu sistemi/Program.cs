using System.Diagnostics;
using System.IO;
string randevu = "randevu.txt";
if (!File.Exists(randevu))
{
    File.WriteAllText(randevu, "");
}
List<string> hastane = new List<string>(File.ReadAllLines(randevu));



başlangiç:

Console.Clear();
Console.WriteLine("HASTANELER: ");
Console.WriteLine("1. Plastik Hastanesi");
Console.WriteLine("2. Pecete Hastanesi");
Console.WriteLine("3. Tahta Hastanesi");
Console.WriteLine("4. Kapak Hastanesi");
Console.WriteLine("5. Sibop Hastanesi");
Console.WriteLine("Secmek İstediginiz Hastane:");
int klinik = Convert.ToInt32(Console.ReadLine());

switch (klinik)
{
        
    case 1:
        Console.Clear();
        Console.WriteLine("1. Nöroloji(Beyin ve Sinir Tedavisi)");
        Console.WriteLine("2. Diş Hekimligi");
        Console.WriteLine("3. Genel Cerrahi");
        Console.WriteLine("4. Göz Hastaliklari");        
        Console.WriteLine("Secmek İstediginiz Klinik: ");
        int secim1 = Convert.ToInt32(Console.ReadLine());
        switch (secim1)
        {
            case 1:               
                Console.Clear();
                Console.WriteLine("1. Ahmet Yilmaz");
                Console.WriteLine("2. Elif Demir");
                Console.WriteLine("3. Mehmet Kaya");
                Console.WriteLine("İstediginiz Noroloji Doktoru:");
                int plastik1 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (plastik1)
                {
                    case 1:
                        string [] PlastikAhmetNoroloji;
                        List<string> DoluSaatlerPlastikAhmetNoroloji = new List<string>();
                        Dictionary<int,string> SaatlerPlastikAhmetNoroloji = new Dictionary<int, string>();
                        int İndexPLastikAhmetNoroloji1 = 0;
                        foreach (string randevular in hastane)
                        {
                            PlastikAhmetNoroloji = randevular.Split('|');
                            if(PlastikAhmetNoroloji.ElementAt(0) == "Ahmet Yilmaz")
                            {
                            DoluSaatlerPlastikAhmetNoroloji.Add(PlastikAhmetNoroloji.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerPlastikAhmetNoroloji.Contains(i+":00"))
                            {
                            İndexPLastikAhmetNoroloji1++;
                            SaatlerPlastikAhmetNoroloji.Add(İndexPLastikAhmetNoroloji1 , i + ":00");
                            Console.WriteLine(İndexPLastikAhmetNoroloji1 + "- " + i +":00"); 
                            }
                        }                         
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:"); 
                            hastane.Add("Ahmet Yilmaz|"+ SaatlerPlastikAhmetNoroloji[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);
                            
                        break;
                    case 2:
                        string [] PlastikELifNoroloji;
                        List<string> DoluSaatlerPlastikElifNoroloji = new List<string>();
                        Dictionary<int,string> SaatlerPlastikElifNoroloji = new Dictionary<int, string>();
                        int İndexPLastikElifNoroloji2 = 0;
                        foreach (string randevular in hastane)
                        {
                            PlastikELifNoroloji = randevular.Split('|');
                            if(PlastikELifNoroloji.ElementAt(0) == "Elif Demir")
                            {
                            DoluSaatlerPlastikElifNoroloji.Add(PlastikELifNoroloji.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerPlastikElifNoroloji.Contains(i+":00"))
                            {
                            İndexPLastikElifNoroloji2++;
                            SaatlerPlastikElifNoroloji.Add(İndexPLastikElifNoroloji2 , i + ":00");
                            Console.WriteLine(İndexPLastikElifNoroloji2 + "- " + i +":00"); 
                            }
                        }     
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Elif Demir|"+ SaatlerPlastikElifNoroloji[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);
                        break;
                    case 3:
                        string [] PlastikMehmetNoroloji;
                        List<string> DoluSaatlerPlastikMehmetNoroloji = new List<string>();
                        Dictionary<int,string> SaatlerPlastikMehmetNoroloji = new Dictionary<int, string>();
                        int İndexPLastikMehmetNoroloji3 = 0;
                        foreach (string randevular in hastane)
                        {
                            PlastikMehmetNoroloji = randevular.Split('|');
                            if(PlastikMehmetNoroloji.ElementAt(0) == "Mehmet Kaya")
                            {
                            DoluSaatlerPlastikMehmetNoroloji.Add(PlastikMehmetNoroloji.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerPlastikMehmetNoroloji.Contains(i+":00"))
                            {
                            İndexPLastikMehmetNoroloji3++;
                            SaatlerPlastikMehmetNoroloji.Add(İndexPLastikMehmetNoroloji3 , i + ":00");
                            Console.WriteLine(İndexPLastikMehmetNoroloji3 + "- " + i +":00"); 
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Mehmet Kaya|"+ SaatlerPlastikMehmetNoroloji[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);
                        break;
                }
                break;
        
            
            
            case 2:
                Console.Clear();
                Console.WriteLine("1. Ayşe Yildiz");
                Console.WriteLine("2. Fatma Acar");
                Console.WriteLine("3. Ali Özkan");
                Console.WriteLine("İstediginiz Dİş Hekimi Doktoru:");
                int plastik2 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (plastik2)
                {
                    case 1:
                        string [] PlastikAyşeDiş;
                        List<string> DoluSaatlerPlastikAyşeDiş = new List<string>();
                        Dictionary<int,string> SaatlerPlastikAyşeDiş = new Dictionary<int, string>();
                        int İndexPLastikAyşeDiş1 = 0;
                        foreach (string randevular in hastane)
                        {
                            PlastikAyşeDiş = randevular.Split('|');
                            if(PlastikAyşeDiş.ElementAt(0) == "Ayşe Yildiz")
                            {
                            DoluSaatlerPlastikAyşeDiş.Add(PlastikAyşeDiş.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerPlastikAyşeDiş.Contains(i+":00"))
                            {
                            İndexPLastikAyşeDiş1++;
                            SaatlerPlastikAyşeDiş.Add(İndexPLastikAyşeDiş1 , i + ":00");
                            Console.WriteLine(İndexPLastikAyşeDiş1 + "- " + i +":00"); 
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Ayşe Yildiz|"+ SaatlerPlastikAyşeDiş[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);
                        break;
                    case 2:
                        string [] PlastikFatmaDiş;
                        List<string> DoluSaatlerPlastikFatmaDiş = new List<string>();
                        Dictionary<int,string> SaatlerPlastikFatmaDiş = new Dictionary<int, string>();
                        int İndexPLastikFatmaDiş2 = 0;
                        foreach (string randevular in hastane)
                        {
                            PlastikFatmaDiş = randevular.Split('|');
                            if(PlastikFatmaDiş.ElementAt(0) == "Fatma Acar")
                            {
                            DoluSaatlerPlastikFatmaDiş.Add(PlastikFatmaDiş.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerPlastikFatmaDiş.Contains(i+":00"))
                            {
                            İndexPLastikFatmaDiş2++;
                            SaatlerPlastikFatmaDiş.Add(İndexPLastikFatmaDiş2 , i + ":00");
                            Console.WriteLine(İndexPLastikFatmaDiş2 + "- " + i +":00"); 
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Fatma Acar|"+ SaatlerPlastikFatmaDiş[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);

                        break;
                    case 3:
                        string [] PlastikAliDiş;
                        List<string> DoluSaatlerPlastikAliDiş = new List<string>();
                        Dictionary<int,string> SaatlerPlastikAliDiş = new Dictionary<int, string>();
                        int İndexPLastikALiDiş3 = 0;
                        foreach (string randevular in hastane)
                        {
                            PlastikAliDiş = randevular.Split('|');
                            if(PlastikAliDiş.ElementAt(0) == "Ali Özkan")
                            {
                            DoluSaatlerPlastikAliDiş.Add(PlastikAliDiş.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerPlastikAliDiş.Contains(i+":00"))
                            {
                            İndexPLastikALiDiş3++;
                            SaatlerPlastikAliDiş.Add(İndexPLastikALiDiş3 , i + ":00");
                            Console.WriteLine(İndexPLastikALiDiş3 + "- " + i +":00"); 
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Ali Özkan|"+ SaatlerPlastikAliDiş[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);

                        break;
                }        
                    break;
            
            case 3:                
                Console.Clear();
                Console.WriteLine("1. Hatice Doğan");
                Console.WriteLine("2. Yusuf Kaplan");
                Console.WriteLine("3. Merve Polat");
                Console.WriteLine("İstediginiz Genel Cerrah doktoru:");
                int plastik3 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (plastik3)
                {
                    case 1:
                        string [] PlastikHaticeGenelCerrah;
                        List<string> DoluSaatlerPlastikHaticeGenelCerrah = new List<string>();
                        Dictionary<int,string> SaatlerPlastikHaticeGenelCerrah = new Dictionary<int, string>();
                        int İndexPLastikHaticeGenelCerrah1 = 0;
                        foreach (string randevular in hastane)
                        {
                            PlastikHaticeGenelCerrah = randevular.Split('|');
                            if(PlastikHaticeGenelCerrah.ElementAt(0) == "Hatice Doğan")
                            {
                            DoluSaatlerPlastikHaticeGenelCerrah.Add(PlastikHaticeGenelCerrah.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerPlastikHaticeGenelCerrah.Contains(i+":00"))
                            {
                            İndexPLastikHaticeGenelCerrah1++;
                            SaatlerPlastikHaticeGenelCerrah.Add(İndexPLastikHaticeGenelCerrah1 , i + ":00");
                            Console.WriteLine(İndexPLastikHaticeGenelCerrah1 + "- " + i +":00"); 
                            }
                        }   
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Hatice Doğan|"+ SaatlerPlastikHaticeGenelCerrah[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);
                        break;
                    case 2:
                        string [] PlastikYusufGenelCerrah;
                        List<string> DoluSaatlerPlastikYusufGenelCerrah = new List<string>();
                        Dictionary<int,string> SaatlerPlastikYusufGenelCerrah = new Dictionary<int, string>();
                        int İndexPLastikYusufGenelCerrah2 = 0;
                        foreach (string randevular in hastane)
                        {
                            PlastikYusufGenelCerrah = randevular.Split('|');
                            if(PlastikYusufGenelCerrah.ElementAt(0) == "Yusuf Kaplan")
                            {
                            DoluSaatlerPlastikYusufGenelCerrah.Add(PlastikYusufGenelCerrah.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerPlastikYusufGenelCerrah.Contains(i+":00"))
                            {
                            İndexPLastikYusufGenelCerrah2++;
                            SaatlerPlastikYusufGenelCerrah.Add(İndexPLastikYusufGenelCerrah2 , i + ":00");
                            Console.WriteLine(İndexPLastikYusufGenelCerrah2 + "- " + i +":00"); 
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Yusuf Kaplan|"+ SaatlerPlastikYusufGenelCerrah[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);
                        break;
                    case 3:
                        string [] PlastikMerveGenelCerrah;
                        List<string> DoluSaatlerPlastikMerveGenelCerrah = new List<string>();
                        Dictionary<int,string> SaatlerPlastikMerveGenelCerrah = new Dictionary<int, string>();
                        int İndexPLastikMerveGenelCerrah3 = 0;
                        foreach (string randevular in hastane)
                        {
                            PlastikMerveGenelCerrah = randevular.Split('|');
                            if(PlastikMerveGenelCerrah.ElementAt(0) == "Merve Polat")
                            {
                            DoluSaatlerPlastikMerveGenelCerrah.Add(PlastikMerveGenelCerrah.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerPlastikMerveGenelCerrah.Contains(i+":00"))
                            {
                            İndexPLastikMerveGenelCerrah3++;
                            SaatlerPlastikMerveGenelCerrah.Add(İndexPLastikMerveGenelCerrah3 , i + ":00");
                            Console.WriteLine(İndexPLastikMerveGenelCerrah3 + "- " + i +":00");                            
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Merve Polat|"+ SaatlerPlastikMerveGenelCerrah[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);
                        break;
                }
                break;
            case 4:
                Console.Clear();
                Console.WriteLine("1. Rabia Güneş");
                Console.WriteLine("2. İsmail Kara");
                Console.WriteLine("3. Esra Kiliç");
                Console.WriteLine("İstediginiz Göz Hastaliklari Doktoru:");
                int plastik4 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (plastik4)
                {
                    case 1:
                        string [] PlastikRabiaGöz;
                        List<string> DoluSaatlerPlastikRabiaGöz = new List<string>();
                        Dictionary<int,string> SaatlerPlastikRabiaGöz = new Dictionary<int, string>();
                        int İndexPLastikRabiaGöz1 = 0;
                        foreach (string randevular in hastane)
                        {
                            PlastikRabiaGöz = randevular.Split('|');
                            if(PlastikRabiaGöz.ElementAt(0) == "Rabia Güneş")
                            {
                            DoluSaatlerPlastikRabiaGöz.Add(PlastikRabiaGöz.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerPlastikRabiaGöz.Contains(i+":00"))
                            {
                            İndexPLastikRabiaGöz1++;
                            SaatlerPlastikRabiaGöz.Add(İndexPLastikRabiaGöz1 , i + ":00");
                            Console.WriteLine(İndexPLastikRabiaGöz1 + "- " + i +":00");                            
                            }
                        }  
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Rabia Güneş|"+ SaatlerPlastikRabiaGöz[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);
                        break;
                    case 2:
                        string [] PlastikİsmailGöz;
                        List<string> DoluSaatlerPlastikİsmailGöz = new List<string>();
                        Dictionary<int,string> SaatlerPlastikİsmailGöz = new Dictionary<int, string>();
                        int İndexPLastikİsmailGöz2 = 0;
                        foreach (string randevular in hastane)
                        {
                            PlastikİsmailGöz = randevular.Split('|');
                            if(PlastikİsmailGöz.ElementAt(0) == "İsmail Kara")
                            {
                            DoluSaatlerPlastikİsmailGöz.Add(PlastikİsmailGöz.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerPlastikİsmailGöz.Contains(i+":00"))
                            {
                            İndexPLastikİsmailGöz2++;
                            SaatlerPlastikİsmailGöz.Add(İndexPLastikİsmailGöz2 , i + ":00");
                            Console.WriteLine(İndexPLastikİsmailGöz2 + "- " + i +":00");                            
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("İsmail Kara|"+ SaatlerPlastikİsmailGöz[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);
                        break;
                    case 3:
                        string [] PlastikEsraGöz;
                        List<string> DoluSaatlerPlastikEsraGöz = new List<string>();
                        Dictionary<int,string> SaatlerPlastikEsraGöz = new Dictionary<int, string>();
                        int İndexPLastikEsraGöz3 = 0;
                        foreach (string randevular in hastane)
                        {
                            PlastikEsraGöz = randevular.Split('|');
                            if(PlastikEsraGöz.ElementAt(0) == "Esra Kiliç")
                            {
                            DoluSaatlerPlastikEsraGöz.Add(PlastikEsraGöz.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerPlastikEsraGöz.Contains(i+":00"))
                            {
                            İndexPLastikEsraGöz3++;
                            SaatlerPlastikEsraGöz.Add(İndexPLastikEsraGöz3 , i + ":00");
                            Console.WriteLine(İndexPLastikEsraGöz3 + "- " + i +":00");                            
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Esra Kiliç|"+ SaatlerPlastikEsraGöz[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);

                        break;        
                }
                break;
        
        }
        break;

        case 2:
        Console.Clear();
        Console.WriteLine("1. Nöroloji(Beyin ve Sinir Tedavisi)");
        Console.WriteLine("2. Diş Hekimligi");
        Console.WriteLine("3. Genel Cerrahi");
        Console.WriteLine("4. Göz Hastaliklari");
        Console.WriteLine("5. Üroloji");
        Console.WriteLine("6. Dahiliye");
        Console.WriteLine("Secmek İstediginiz Klinik: ");
        int secim2 = Convert.ToInt32(Console.ReadLine());
        switch (secim2)
        {
            case 1:               
                Console.Clear();
                Console.WriteLine("1. Serkan Bozkurt");
                Console.WriteLine("2. Melisa Aydin");
                Console.WriteLine("3. Enes Özdemir");
                Console.WriteLine("İstediginiz Noroloji Doktoru:");
                int pecete1 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (pecete1)
                {
                    case 1:
                        string [] PeceteSerkanNoroloji;
                        List<string> DoluSaatlerPeceteSerkanNoroloji = new List<string>();
                        Dictionary<int,string> SaatlerPeceteSerkanNoroloji = new Dictionary<int, string>();
                        int İndexPeceteSerkanNoroloji1 = 0;
                        foreach (string randevular in hastane)
                        {
                            PeceteSerkanNoroloji = randevular.Split('|');
                            if(PeceteSerkanNoroloji.ElementAt(0) == "Serkan Bozkurt")
                            {
                            DoluSaatlerPeceteSerkanNoroloji.Add(PeceteSerkanNoroloji.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerPeceteSerkanNoroloji.Contains(i+":00"))
                            {
                            İndexPeceteSerkanNoroloji1++;
                            SaatlerPeceteSerkanNoroloji.Add(İndexPeceteSerkanNoroloji1 , i + ":00");
                            Console.WriteLine(İndexPeceteSerkanNoroloji1 + "- " + i +":00");                            
                            }
                        }   
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Serkan Bozkurt|"+ SaatlerPeceteSerkanNoroloji[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);

                        break;
                    case 2:
                        string [] PeceteMelisaNoroloji;
                        List<string> DoluSaatlerPeceteMelisaNoroloji = new List<string>();
                        Dictionary<int,string> SaatlerPeceteMelisaNoroloji = new Dictionary<int, string>();
                        int İndexPeceteMelisaNoroloji2 = 0;
                        foreach (string randevular in hastane)
                        {
                            PeceteMelisaNoroloji = randevular.Split('|');
                            if(PeceteMelisaNoroloji.ElementAt(0) == "Melisa Aydin")
                            {
                            DoluSaatlerPeceteMelisaNoroloji.Add(PeceteMelisaNoroloji.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerPeceteMelisaNoroloji.Contains(i+":00"))
                            {
                            İndexPeceteMelisaNoroloji2++;
                            SaatlerPeceteMelisaNoroloji.Add(İndexPeceteMelisaNoroloji2 , i + ":00");
                            Console.WriteLine(İndexPeceteMelisaNoroloji2 + "- " + i +":00");                            
                            }
                        } 
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Melisa Aydin|"+ SaatlerPeceteMelisaNoroloji[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);

                        break;
                    case 3:
                        string [] PeceteEnesNoroloji;
                        List<string> DoluSaatlerPeceteEnesNoroloji = new List<string>();
                        Dictionary<int,string> SaatlerPeceteEnesNoroloji = new Dictionary<int, string>();
                        int İndexPeceteEnesNoroloji3 = 0;
                        foreach (string randevular in hastane)
                        {
                            PeceteEnesNoroloji = randevular.Split('|');
                            if(PeceteEnesNoroloji.ElementAt(0) == "Enes Özdemir")
                            {
                            DoluSaatlerPeceteEnesNoroloji.Add(PeceteEnesNoroloji.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerPeceteEnesNoroloji.Contains(i+":00"))
                            {
                            İndexPeceteEnesNoroloji3++;
                            SaatlerPeceteEnesNoroloji.Add(İndexPeceteEnesNoroloji3 , i + ":00");
                            Console.WriteLine(İndexPeceteEnesNoroloji3 + "- " + i +":00");                            
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Enes Özdemir|"+ SaatlerPeceteEnesNoroloji[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);

                        break;
                }   
                break;
            
            case 2:
                Console.Clear();
                Console.WriteLine("1. Cansu Bal");
                Console.WriteLine("2. Berk Yalçin");
                Console.WriteLine("3. Sibel Duman");
                Console.WriteLine("İstediginiz Diş Hekimi Doktoru:");
                int pecete2 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (pecete2)
                {
                    case 1:
                        string [] PeceteCansuDiş;
                        List<string> DoluSaatlerPeceteCansuDiş = new List<string>();
                        Dictionary<int,string> SaatlerPeceteCansuDiş = new Dictionary<int, string>();
                        int İndexPeceteCansuDiş1 = 0;
                        foreach (string randevular in hastane)
                        {
                            PeceteCansuDiş = randevular.Split('|');
                            if(PeceteCansuDiş.ElementAt(0) == "Cansu Bal")
                            {
                            DoluSaatlerPeceteCansuDiş.Add(PeceteCansuDiş.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerPeceteCansuDiş.Contains(i+":00"))
                            {
                            İndexPeceteCansuDiş1++;
                            SaatlerPeceteCansuDiş.Add(İndexPeceteCansuDiş1 , i + ":00");
                            Console.WriteLine(İndexPeceteCansuDiş1 + "- " + i +":00");                            
                            }
                        } 
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Cansu Bal|"+ SaatlerPeceteCansuDiş[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);

                        break;
                    case 2:
                        string [] PeceteBerkeDiş;
                        List<string> DoluSaatlerPeceteBerkeDiş = new List<string>();
                        Dictionary<int,string> SaatlerPeceteBerkeDiş = new Dictionary<int, string>();
                        int İndexPeceteBerkeDiş2 = 0;
                        foreach (string randevular in hastane)
                        {
                            PeceteBerkeDiş = randevular.Split('|');
                            if(PeceteBerkeDiş.ElementAt(0) == "Berk Yalçin")
                            {
                            DoluSaatlerPeceteBerkeDiş.Add(PeceteBerkeDiş.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerPeceteBerkeDiş.Contains(i+":00"))
                            {
                            İndexPeceteBerkeDiş2++;
                            SaatlerPeceteBerkeDiş.Add(İndexPeceteBerkeDiş2 , i + ":00");
                            Console.WriteLine(İndexPeceteBerkeDiş2 + "- " + i +":00");                            
                            }
                        } 
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Berk Yalçin|"+ SaatlerPeceteBerkeDiş[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);

                        break;
                    case 3:
                        string [] PeceteSibelDiş;
                        List<string> DoluSaatlerPeceteSibelDiş = new List<string>();
                        Dictionary<int,string> SaatlerPeceteSibelDiş = new Dictionary<int, string>();
                        int İndexPeceteSibelDiş3 = 0;
                        foreach (string randevular in hastane)
                        {
                            PeceteSibelDiş = randevular.Split('|');
                            if(PeceteSibelDiş.ElementAt(0) == "Sibel Duman")
                            {
                            DoluSaatlerPeceteSibelDiş.Add(PeceteSibelDiş.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerPeceteSibelDiş.Contains(i+":00"))
                            {
                            İndexPeceteSibelDiş3++;
                            SaatlerPeceteSibelDiş.Add(İndexPeceteSibelDiş3 , i + ":00");
                            Console.WriteLine(İndexPeceteSibelDiş3 + "- " + i +":00");                            
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Sibel Duman|"+ SaatlerPeceteSibelDiş[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);

                        break;
                }    
                break; 
            
              
            case 3:
                Console.Clear();
                Console.WriteLine("1. Onur Tunç");
                Console.WriteLine("2. İrem Aslan");
                Console.WriteLine("3. Ramazan Karaca");
                Console.WriteLine("İstediginiz Genel Cerrahi Doktoru:");
                int pecete3 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (pecete3)
                {
                    case 1:
                        string [] PeceteOnurGenelCerrah;
                        List<string> DoluSaatlerPeceteOnurGenelCerrah = new List<string>();
                        Dictionary<int,string> SaatlerPeceteOnurGenelCerrah = new Dictionary<int, string>();
                        int İndexPeceteOnurGenelCerrah1 = 0;
                        foreach (string randevular in hastane)
                        {
                            PeceteOnurGenelCerrah = randevular.Split('|');
                            if(PeceteOnurGenelCerrah.ElementAt(0) == "Onur Tunç")
                            {
                            DoluSaatlerPeceteOnurGenelCerrah.Add(PeceteOnurGenelCerrah.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerPeceteOnurGenelCerrah.Contains(i+":00"))
                            {
                            İndexPeceteOnurGenelCerrah1++;
                            SaatlerPeceteOnurGenelCerrah.Add(İndexPeceteOnurGenelCerrah1 , i + ":00");
                            Console.WriteLine(İndexPeceteOnurGenelCerrah1 + "- " + i +":00");                            
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Onur Tunç|"+ SaatlerPeceteOnurGenelCerrah[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);    
                        break;

                    case 2:
                        string [] PeceteİremGenelCerrah;
                        List<string> DoluSaatlerPeceteİremGenelCerrah = new List<string>();
                        Dictionary<int,string> SaatlerPeceteİremGenelCerrah = new Dictionary<int, string>();
                        int İndexPeceteİremGenelCerrah2 = 0;
                        foreach (string randevular in hastane)
                        {
                            PeceteİremGenelCerrah = randevular.Split('|');
                            if(PeceteİremGenelCerrah.ElementAt(0) == "İrem Aslan")
                            {
                            DoluSaatlerPeceteİremGenelCerrah.Add(PeceteİremGenelCerrah.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerPeceteİremGenelCerrah.Contains(i+":00"))
                            {
                            İndexPeceteİremGenelCerrah2++;
                            SaatlerPeceteİremGenelCerrah.Add(İndexPeceteİremGenelCerrah2 , i + ":00");
                            Console.WriteLine(İndexPeceteİremGenelCerrah2 + "- " + i +":00");                            
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("İrem Aslan|"+ SaatlerPeceteİremGenelCerrah[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);    

                        break;
                    case 3:
                        string [] PeceteRamazanGenelCerrah;
                        List<string> DoluSaatlerPeceteRamazanGenelCerrah = new List<string>();
                        Dictionary<int,string> SaatlerPeceteRamazanGenelCerrah = new Dictionary<int, string>();
                        int İndexPeceteRamazanGenelCerrah3 = 0;
                        foreach (string randevular in hastane)
                        {
                            PeceteRamazanGenelCerrah = randevular.Split('|');
                            if(PeceteRamazanGenelCerrah.ElementAt(0) == "Ramazan Karaca")
                            {
                            DoluSaatlerPeceteRamazanGenelCerrah.Add(PeceteRamazanGenelCerrah.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerPeceteRamazanGenelCerrah.Contains(i+":00"))
                            {
                            İndexPeceteRamazanGenelCerrah3++;
                            SaatlerPeceteRamazanGenelCerrah.Add(İndexPeceteRamazanGenelCerrah3 , i + ":00");
                            Console.WriteLine(İndexPeceteRamazanGenelCerrah3 + "- " + i +":00");                            
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Ramazan Karaca|"+ SaatlerPeceteRamazanGenelCerrah[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);    

                        break;                    
                }
                break; 
            
            case 4:
                Console.Clear();
                Console.WriteLine("1. Gizem Bulut");
                Console.WriteLine("2. Eren Çetin");
                Console.WriteLine("3. Kübra Uçar");
                Console.WriteLine("İstediginiz Göz Hastaliklari Doktoru:");
                int pecete4 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (pecete4)
                {
                    case 1:
                        string [] PeceteGizemGöz;
                        List<string> DoluSaatlerPeceteGizemGöz = new List<string>();
                        Dictionary<int,string> SaatlerPeceteGizemGöz = new Dictionary<int, string>();
                        int İndexPeceteGizemGöz1 = 0;
                        foreach (string randevular in hastane)
                        {
                            PeceteGizemGöz = randevular.Split('|');
                            if(PeceteGizemGöz.ElementAt(0) == "Gizem Bulut")
                            {
                            DoluSaatlerPeceteGizemGöz.Add(PeceteGizemGöz.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerPeceteGizemGöz.Contains(i+":00"))
                            {
                            İndexPeceteGizemGöz1++;
                            SaatlerPeceteGizemGöz.Add(İndexPeceteGizemGöz1 , i + ":00");
                            Console.WriteLine(İndexPeceteGizemGöz1 + "- " + i +":00");                            
                            }
                        }   
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Gizem Bulut|"+ SaatlerPeceteGizemGöz[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);    

                        break;
                    case 2:
                        string [] PeceteErenGöz;
                        List<string> DoluSaatlerPeceteErenGöz = new List<string>();
                        Dictionary<int,string> SaatlerPeceteErenGöz = new Dictionary<int, string>();
                        int İndexPeceteErenGöz2 = 0;
                        foreach (string randevular in hastane)
                        {
                            PeceteErenGöz = randevular.Split('|');
                            if(PeceteErenGöz.ElementAt(0) == "Eren Çetin")
                            {
                            DoluSaatlerPeceteErenGöz.Add(PeceteErenGöz.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerPeceteErenGöz.Contains(i+":00"))
                            {
                            İndexPeceteErenGöz2++;
                            SaatlerPeceteErenGöz.Add(İndexPeceteErenGöz2 , i + ":00");
                            Console.WriteLine(İndexPeceteErenGöz2 + "- " + i +":00");                            
                            }
                        } 
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Eren Çetin|"+ SaatlerPeceteErenGöz[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);    

                        break;
                    case 3:
                        string [] PeceteKübraGöz;
                        List<string> DoluSaatlerPeceteKübraGöz = new List<string>();
                        Dictionary<int,string> SaatlerPeceteKübraGöz = new Dictionary<int, string>();
                        int İndexPeceteKübraGöz3 = 0;
                        foreach (string randevular in hastane)
                        {
                            PeceteKübraGöz = randevular.Split('|');
                            if(PeceteKübraGöz.ElementAt(0) == "Kübra Uçar")
                            {
                            DoluSaatlerPeceteKübraGöz.Add(PeceteKübraGöz.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerPeceteKübraGöz.Contains(i+":00"))
                            {
                            İndexPeceteKübraGöz3++;
                            SaatlerPeceteKübraGöz.Add(İndexPeceteKübraGöz3 , i + ":00");
                            Console.WriteLine(İndexPeceteKübraGöz3 + "- " + i +":00");                            
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Kübra Uçar|"+ SaatlerPeceteKübraGöz[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);    

                        break;
                }
                break; 
            case 5:
                Console.Clear();
                Console.WriteLine("1. Furkan Erdoğan");
                Console.WriteLine("2. Selin Tuncer");
                Console.WriteLine("3. Baran Yüksel");
                Console.WriteLine("İstediginiz Üroloji Doktoru:");
                int pecete5 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (pecete5)
                {
                    case 1:
                        string [] PeceteFurkanÜroloji;
                        List<string> DoluSaatlerPeceteFurkanÜroloji = new List<string>();
                        Dictionary<int,string> SaatlerPeceteFurkanÜroloji = new Dictionary<int, string>();
                        int İndexPeceteFurkanÜroloji1 = 0;
                        foreach (string randevular in hastane)
                        {
                            PeceteFurkanÜroloji = randevular.Split('|');
                            if(PeceteFurkanÜroloji.ElementAt(0) == "Furkan Erdoğan")
                            {
                            DoluSaatlerPeceteFurkanÜroloji.Add(PeceteFurkanÜroloji.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerPeceteFurkanÜroloji.Contains(i+":00"))
                            {
                            İndexPeceteFurkanÜroloji1++;
                            SaatlerPeceteFurkanÜroloji.Add(İndexPeceteFurkanÜroloji1 , i + ":00");
                            Console.WriteLine(İndexPeceteFurkanÜroloji1 + "- " + i +":00");                            
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Furkan Erdoğan|"+ SaatlerPeceteFurkanÜroloji[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);    

                        break;
                    case 2:
                        string [] PeceteSelinÜroloji;
                        List<string> DoluSaatlerPeceteSelinÜroloji = new List<string>();
                        Dictionary<int,string> SaatlerPeceteSelinÜroloji = new Dictionary<int, string>();
                        int İndexPeceteSelinÜroloji2 = 0;
                        foreach (string randevular in hastane)
                        {
                            PeceteSelinÜroloji = randevular.Split('|');
                            if(PeceteSelinÜroloji.ElementAt(0) == "Selin Tuncer")
                            {
                            DoluSaatlerPeceteSelinÜroloji.Add(PeceteSelinÜroloji.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerPeceteSelinÜroloji.Contains(i+":00"))
                            {
                            İndexPeceteSelinÜroloji2++;
                            SaatlerPeceteSelinÜroloji.Add(İndexPeceteSelinÜroloji2 , i + ":00");
                            Console.WriteLine(İndexPeceteSelinÜroloji2 + "- " + i +":00");                            
                            }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Selin Tuncer|"+ SaatlerPeceteSelinÜroloji[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);    
                        }

                        break;
                    case 3:
                        string [] PeceteBaranÜroloji;
                        List<string> DoluSaatlerPeceteBaranÜroloji = new List<string>();
                        Dictionary<int,string> SaatlerPeceteBaranÜroloji = new Dictionary<int, string>();
                        int İndexPeceteBaranÜroloji3 = 0;
                        foreach (string randevular in hastane)
                        {
                            PeceteBaranÜroloji = randevular.Split('|');
                            if(PeceteBaranÜroloji.ElementAt(0) == "Baran Yüksel")
                            {
                            DoluSaatlerPeceteBaranÜroloji.Add(PeceteBaranÜroloji.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerPeceteBaranÜroloji.Contains(i+":00"))
                            {
                            İndexPeceteBaranÜroloji3++;
                            SaatlerPeceteBaranÜroloji.Add(İndexPeceteBaranÜroloji3 , i + ":00");
                            Console.WriteLine(İndexPeceteBaranÜroloji3 + "- " + i +":00");                            
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Baran Yüksel|"+ SaatlerPeceteBaranÜroloji[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);    

                        break;
                }
                break; 
            case 6:
                Console.Clear();
                Console.WriteLine("1. Ece Ari");
                Console.WriteLine("2. Burak Kurt");
                Console.WriteLine("3. Şeyma Vural");
                Console.WriteLine("İstedigini Dahiliye Doktoru:");
                int Pecete6 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (Pecete6)
                {
                    case 1:
                        string [] PeceteEceDahiliye;
                        List<string> DoluSaatlerPeceteEceDahiliye = new List<string>();
                        Dictionary<int,string> SaatlerPeceteEceDahiliye = new Dictionary<int, string>();
                        int İndexPeceteEceDahiliye1 = 0;
                        foreach (string randevular in hastane)
                        {
                            PeceteEceDahiliye = randevular.Split('|');
                            if(PeceteEceDahiliye.ElementAt(0) == "Ece Ari")
                            {
                            DoluSaatlerPeceteEceDahiliye.Add(PeceteEceDahiliye.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerPeceteEceDahiliye.Contains(i+":00"))
                            {
                            İndexPeceteEceDahiliye1++;
                            SaatlerPeceteEceDahiliye.Add(İndexPeceteEceDahiliye1 , i + ":00");
                            Console.WriteLine(İndexPeceteEceDahiliye1 + "- " + i +":00");                            
                            }
                        }  
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Ece Ari|"+ SaatlerPeceteEceDahiliye[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);    

                        break;
                    case 2:
                        string [] PeceteBurakDahiliye;
                        List<string> DoluSaatlerPeceteBurakDahiliye = new List<string>();
                        Dictionary<int,string> SaatlerPeceteBurakDahiliye = new Dictionary<int, string>();
                        int İndexPeceteBurakDahiliye2 = 0;
                        foreach (string randevular in hastane)
                        {
                            PeceteBurakDahiliye = randevular.Split('|');
                            if(PeceteBurakDahiliye.ElementAt(0) == "Burak Kurt")
                            {
                            DoluSaatlerPeceteBurakDahiliye.Add(PeceteBurakDahiliye.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerPeceteBurakDahiliye.Contains(i+":00"))
                            {
                            İndexPeceteBurakDahiliye2++;
                            SaatlerPeceteBurakDahiliye.Add(İndexPeceteBurakDahiliye2 , i + ":00");
                            Console.WriteLine(İndexPeceteBurakDahiliye2 + "- " + i +":00");                            
                            }
                        }  
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Burak Kurt|"+ SaatlerPeceteBurakDahiliye[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);    


                        break;
                    case 3:
                        string [] PeceteŞeymaDahiliye;
                        List<string> DoluSaatlerPeceteŞeymaDahiliye = new List<string>();
                        Dictionary<int,string> SaatlerPeceteŞeymaDahiliye = new Dictionary<int, string>();
                        int İndexPeceteŞeymaDahiliye3 = 0;
                        foreach (string randevular in hastane)
                        {
                            PeceteŞeymaDahiliye = randevular.Split('|');
                            if(PeceteŞeymaDahiliye.ElementAt(0) == "Şeyma Vural")
                            {
                            DoluSaatlerPeceteŞeymaDahiliye.Add(PeceteŞeymaDahiliye.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerPeceteŞeymaDahiliye.Contains(i+":00"))
                            {
                            İndexPeceteŞeymaDahiliye3++;
                            SaatlerPeceteŞeymaDahiliye.Add(İndexPeceteŞeymaDahiliye3 , i + ":00");
                            Console.WriteLine(İndexPeceteŞeymaDahiliye3 + "- " + i +":00");                            
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Şeyma Vural|"+ SaatlerPeceteŞeymaDahiliye[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);    
                        break;
                }
                break;
        }
        break;


    case 3:
        Console.Clear();
        Console.WriteLine("1. Göz Hastaliklari");
        Console.WriteLine("2. Diş Hekimligi");
        Console.WriteLine("3. Genel Cerrahi");
        Console.WriteLine("4. Nöroloji(Beyin ve Sinir Tedavisi)");
        Console.WriteLine("5. Gögus Hastaliklari ");
        Console.WriteLine("6. Onkoloji(Kanser Tedavi)");
        Console.WriteLine("Secmek İstediginiz Klinik: ");
        int secim3 = Convert.ToInt32(Console.ReadLine());
        switch (secim3)
        {
            case 1:
                Console.Clear();
                Console.WriteLine("1. Hakan Demirtaş");
                Console.WriteLine("2. Dilara Sezer");
                Console.WriteLine("3. Tolga Alkan");
                Console.WriteLine("İstediginiz Göz Hastaliklari Doktoru:");
                int  tahta1 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (tahta1)
                {
                    case 1:
                        string [] TahtaHakanGöz;
                        List<string> DoluSaatlerTahtaHakanGöz = new List<string>();
                        Dictionary<int,string> SaatlerTahtaHakanGöz = new Dictionary<int, string>();
                        int İndexTahtaHakanGöz1 = 0;
                        foreach (string randevular in hastane)
                        {
                            TahtaHakanGöz = randevular.Split('|');
                            if(TahtaHakanGöz.ElementAt(0) == "Hakan Demirtaş")
                            {
                            DoluSaatlerTahtaHakanGöz.Add(TahtaHakanGöz.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerTahtaHakanGöz.Contains(i+":00"))
                            {
                            İndexTahtaHakanGöz1++;
                            SaatlerTahtaHakanGöz.Add(İndexTahtaHakanGöz1 , i + ":00");
                            Console.WriteLine(İndexTahtaHakanGöz1 + "- " + i +":00");                            
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Hakan Demirtaş|"+ SaatlerTahtaHakanGöz[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);      

                        break;
                    case 2:
                        string [] TahtaDilaraGöz;
                        List<string> DoluSaatlerTahtaDilaraGöz = new List<string>();
                        Dictionary<int,string> SaatlerTahtaDilaraGöz = new Dictionary<int, string>();
                        int İndexTahtaDilaraGöz2 = 0;
                        foreach (string randevular in hastane)
                        {
                            TahtaDilaraGöz = randevular.Split('|');
                            if(TahtaDilaraGöz.ElementAt(0) == "Dilara Sezer")
                            {
                            DoluSaatlerTahtaDilaraGöz.Add(TahtaDilaraGöz.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerTahtaDilaraGöz.Contains(i+":00"))
                            {
                            İndexTahtaDilaraGöz2++;
                            SaatlerTahtaDilaraGöz.Add(İndexTahtaDilaraGöz2 , i + ":00");
                            Console.WriteLine(İndexTahtaDilaraGöz2 + "- " + i +":00");                            
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Dilara Sezer|"+ SaatlerTahtaDilaraGöz[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);  

                        break;
                    case 3:
                        string [] TahtaTolgaGöz;
                        List<string> DoluSaatlerTahtaTolgaGöz = new List<string>();
                        Dictionary<int,string> SaatlerTahtaTolgaGöz = new Dictionary<int, string>();
                        int İndexTahtaTolgaGöz3 = 0;
                        foreach (string randevular in hastane)
                        {
                            TahtaTolgaGöz = randevular.Split('|');
                            if(TahtaTolgaGöz.ElementAt(0) == "Tolga Alkan")
                            {
                            DoluSaatlerTahtaTolgaGöz.Add(TahtaTolgaGöz.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerTahtaTolgaGöz.Contains(i+":00"))
                            {
                            İndexTahtaTolgaGöz3++;
                            SaatlerTahtaTolgaGöz.Add(İndexTahtaTolgaGöz3 , i + ":00");
                            Console.WriteLine(İndexTahtaTolgaGöz3 + "- " + i +":00");                            
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Tolga Alkan|"+ SaatlerTahtaTolgaGöz[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);  

                        break;
                }
                break;                 
            case 2:
                Console.Clear();
                Console.WriteLine("1. Betül Güler");
                Console.WriteLine("2. Kadir Sari");
                Console.WriteLine("3. Asli Erdem");
                Console.WriteLine("İstediginiz Diş Doktoru:");
                int tahta2 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (tahta2)
                {
                    case 1:
                        string [] TahtaBetülDiş;
                        List<string> DoluSaatlerTahtaBetülDiş = new List<string>();
                        Dictionary<int,string> SaatlerTahtaBetülDiş = new Dictionary<int, string>();
                        int İndexTahtaBetülDiş1 = 0;
                        foreach (string randevular in hastane)
                        {
                            TahtaBetülDiş = randevular.Split('|');
                            if(TahtaBetülDiş.ElementAt(0) == "Betül Güler")
                            {
                            DoluSaatlerTahtaBetülDiş.Add(TahtaBetülDiş.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerTahtaBetülDiş.Contains(i+":00"))
                            {
                            İndexTahtaBetülDiş1++;
                            SaatlerTahtaBetülDiş.Add(İndexTahtaBetülDiş1 , i + ":00");
                            Console.WriteLine(İndexTahtaBetülDiş1 + "- " + i +":00");                            
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Betül Güler|"+ SaatlerTahtaBetülDiş[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);

                        break;
                    case 2:
                        string [] TahtaKadirDiş;
                        List<string> DoluSaatlerTahtaKadirDiş = new List<string>();
                        Dictionary<int,string> SaatlerTahtaKadirDiş = new Dictionary<int, string>();
                        int İndexTahtaKadirDiş2 = 0;
                        foreach (string randevular in hastane)
                        {
                            TahtaKadirDiş = randevular.Split('|');
                            if(TahtaKadirDiş.ElementAt(0) == "Kadir Sari")
                            {
                            DoluSaatlerTahtaKadirDiş.Add(TahtaKadirDiş.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerTahtaKadirDiş.Contains(i+":00"))
                            {
                            İndexTahtaKadirDiş2++;
                            SaatlerTahtaKadirDiş.Add(İndexTahtaKadirDiş2 , i + ":00");
                            Console.WriteLine(İndexTahtaKadirDiş2 + "- " + i +":00");                            
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Kadir Sari|"+ SaatlerTahtaKadirDiş[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);

                        break;
                    case 3:
                        string [] TahtaAsliDiş;
                        List<string> DoluSaatlerTahtaAsliDiş = new List<string>();
                        Dictionary<int,string> SaatlerTahtaAsliDiş = new Dictionary<int, string>();
                        int İndexTahtaAsliDiş3 = 0;
                        foreach (string randevular in hastane)
                        {
                            TahtaAsliDiş = randevular.Split('|');
                            if(TahtaAsliDiş.ElementAt(0) == "Asli Erdem")
                            {
                            DoluSaatlerTahtaAsliDiş.Add(TahtaAsliDiş.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerTahtaAsliDiş.Contains(i+":00"))
                            {
                            İndexTahtaAsliDiş3++;
                            SaatlerTahtaAsliDiş.Add(İndexTahtaAsliDiş3 , i + ":00");
                            Console.WriteLine(İndexTahtaAsliDiş3 + "- " + i +":00");                            
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Asli Erdem|"+ SaatlerTahtaAsliDiş[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);

                        break;
                }
                break; 
            case 3:
                Console.Clear();
                Console.WriteLine("1. Arda Yilmazer");
                Console.WriteLine("2. Gözde Şen");
                Console.WriteLine("3. Sinan Bayrak");
                Console.WriteLine("İstediginiz Genel Cerrahi Doktoru:");
                int tahta3 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (tahta3)
                {
                    case 1:
                        string [] TahtaArdaGenelCerrah;
                        List<string> DoluSaatlerTahtaArdaGenelCerrah = new List<string>();
                        Dictionary<int,string> SaatlerTahtaArdaGenelCerrah = new Dictionary<int, string>();
                        int İndexTahtaArdaGenelCerrah1 = 0;
                        foreach (string randevular in hastane)
                        {
                            TahtaArdaGenelCerrah = randevular.Split('|');
                            if(TahtaArdaGenelCerrah.ElementAt(0) == "Arda Yilmazer")
                            {
                            DoluSaatlerTahtaArdaGenelCerrah.Add(TahtaArdaGenelCerrah.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerTahtaArdaGenelCerrah.Contains(i+":00"))
                            {
                            İndexTahtaArdaGenelCerrah1++;
                            SaatlerTahtaArdaGenelCerrah.Add(İndexTahtaArdaGenelCerrah1 , i + ":00");
                            Console.WriteLine(İndexTahtaArdaGenelCerrah1 + "- " + i +":00");                            
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Arda Yilmazer|"+ SaatlerTahtaArdaGenelCerrah[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);   

                        break;
                    case 2:
                        string [] TahtaGözdeGenelCerrah;
                        List<string> DoluSaatlerTahtaGözdeGenelCerrah = new List<string>();
                        Dictionary<int,string> SaatlerTahtaGözdeGenelCerrah = new Dictionary<int, string>();
                        int İndexTahtaGözdeGenelCerrah2 = 0;
                        foreach (string randevular in hastane)
                        {
                            TahtaGözdeGenelCerrah = randevular.Split('|');
                            if(TahtaGözdeGenelCerrah.ElementAt(0) == "Gözde Şen")
                            {
                            DoluSaatlerTahtaGözdeGenelCerrah.Add(TahtaGözdeGenelCerrah.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerTahtaGözdeGenelCerrah.Contains(i+":00"))
                            {
                            İndexTahtaGözdeGenelCerrah2++;
                            SaatlerTahtaGözdeGenelCerrah.Add(İndexTahtaGözdeGenelCerrah2 , i + ":00");
                            Console.WriteLine(İndexTahtaGözdeGenelCerrah2 + "- " + i +":00");                            
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Gözde Şen|"+ SaatlerTahtaGözdeGenelCerrah[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);   


                        break;
                    case 3:
                        string [] TahtaSinanGenelCerrah;
                        List<string> DoluSaatlerTahtaSinanGenelCerrah = new List<string>();
                        Dictionary<int,string> SaatlerTahtaSinanGenelCerrah = new Dictionary<int, string>();
                        int İndexTahtaSinanGenelCerrah3 = 0;
                        foreach (string randevular in hastane)
                        {
                            TahtaSinanGenelCerrah = randevular.Split('|');
                            if(TahtaSinanGenelCerrah.ElementAt(0) == "Sinan Bayrak")
                            {
                            DoluSaatlerTahtaSinanGenelCerrah.Add(TahtaSinanGenelCerrah.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerTahtaSinanGenelCerrah.Contains(i+":00"))
                            {
                            İndexTahtaSinanGenelCerrah3++;
                            SaatlerTahtaSinanGenelCerrah.Add(İndexTahtaSinanGenelCerrah3 , i + ":00");
                            Console.WriteLine(İndexTahtaSinanGenelCerrah3 + "- " + i +":00");                            
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Sinan Bayrak|"+ SaatlerTahtaSinanGenelCerrah[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);   


                        break;
                }
                break; 
            case 4:
                Console.Clear();
                Console.WriteLine("1. Elvan Çakir ");
                Console.WriteLine("2. Halil Özcan");
                Console.WriteLine("3. Damla Peker");
                Console.WriteLine("İstediginiz Noroloji Doktoru:");
                int tahta4 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (tahta4)
                {
                    case 1:
                        string [] TahtaElvanNoroloji;
                        List<string> DoluSaatlerTahtaElvanNoroloji = new List<string>();
                        Dictionary<int,string> SaatlerTahtaElvanNoroloji = new Dictionary<int, string>();
                        int İndexTahtaElvanNoroloji1 = 0;
                        foreach (string randevular in hastane)
                        {
                            TahtaElvanNoroloji = randevular.Split('|');
                            if(TahtaElvanNoroloji.ElementAt(0) == "Elvan Çakir")
                            {
                            DoluSaatlerTahtaElvanNoroloji.Add(TahtaElvanNoroloji.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerTahtaElvanNoroloji.Contains(i+":00"))
                            {
                            İndexTahtaElvanNoroloji1++;
                            SaatlerTahtaElvanNoroloji.Add(İndexTahtaElvanNoroloji1 , i + ":00");
                            Console.WriteLine(İndexTahtaElvanNoroloji1 + "- " + i +":00");                            
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Elvan Çakir|"+ SaatlerTahtaElvanNoroloji[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);   

                        break;
                    case 2:
                        string [] TahtaHalilNoroloji;
                        List<string> DoluSaatlerTahtaHalilNoroloji = new List<string>();
                        Dictionary<int,string> SaatlerTahtaHalilNoroloji = new Dictionary<int, string>();
                        int İndexTahtaHalilNoroloji2 = 0;
                        foreach (string randevular in hastane)
                        {
                            TahtaHalilNoroloji = randevular.Split('|');
                            if(TahtaHalilNoroloji.ElementAt(0) == "Halil Özcan")
                            {
                            DoluSaatlerTahtaHalilNoroloji.Add(TahtaHalilNoroloji.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerTahtaHalilNoroloji.Contains(i+":00"))
                            {
                            İndexTahtaHalilNoroloji2++;
                            SaatlerTahtaHalilNoroloji.Add(İndexTahtaHalilNoroloji2 , i + ":00");
                            Console.WriteLine(İndexTahtaHalilNoroloji2 + "- " + i +":00");                            
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Halil Özcan|"+ SaatlerTahtaHalilNoroloji[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);   


                        break;
                    case 3:
                        string [] TahtaDamlaNoroloji;
                        List<string> DoluSaatlerTahtaDamlaNoroloji = new List<string>();
                        Dictionary<int,string> SaatlerTahtaDamlaNoroloji = new Dictionary<int, string>();
                        int İndexTahtaDamlaNoroloji3 = 0;
                        foreach (string randevular in hastane)
                        {
                            TahtaDamlaNoroloji = randevular.Split('|');
                            if(TahtaDamlaNoroloji.ElementAt(0) == "Damla Peker")
                            {
                            DoluSaatlerTahtaDamlaNoroloji.Add(TahtaDamlaNoroloji.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerTahtaDamlaNoroloji.Contains(i+":00"))
                            {
                            İndexTahtaDamlaNoroloji3++;
                            SaatlerTahtaDamlaNoroloji.Add(İndexTahtaDamlaNoroloji3 , i + ":00");
                            Console.WriteLine(İndexTahtaDamlaNoroloji3 + "- " + i +":00");                            
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Damla Peker|"+ SaatlerTahtaDamlaNoroloji[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);   

                        break;
                }    
                break; 
            case 5:
                Console.Clear();
                Console.WriteLine("1. Orhan Yiğit");
                Console.WriteLine("2. Meryem Ay");
                Console.WriteLine("3. Uğur Şentürk");
                Console.WriteLine("İstediginiz Gögüs Hastaliklari  Doktoru:");
                int tahta5 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (tahta5)
                {
                    case 1:
                        string [] TahtaOrhanGögüs;
                        List<string> DoluSaatlerTahtaOrhanGögüs = new List<string>();
                        Dictionary<int,string> SaatlerTahtaOrhanGögüs = new Dictionary<int, string>();
                        int İndexTahtaOrhanGögüs1 = 0;
                        foreach (string randevular in hastane)
                        {
                            TahtaOrhanGögüs = randevular.Split('|');
                            if(TahtaOrhanGögüs.ElementAt(0) == "Orhan Yiğit")
                            {
                            DoluSaatlerTahtaOrhanGögüs.Add(TahtaOrhanGögüs.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerTahtaOrhanGögüs.Contains(i+":00"))
                            {
                            İndexTahtaOrhanGögüs1++;
                            SaatlerTahtaOrhanGögüs.Add(İndexTahtaOrhanGögüs1 , i + ":00");
                            Console.WriteLine(İndexTahtaOrhanGögüs1 + "- " + i +":00");                            
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Orhan Yiğit|"+ SaatlerTahtaOrhanGögüs[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);    

                        break;
                    case 2:
                        string [] TahtaMeryemGögüs;
                        List<string> DoluSaatlerTahtaMeryemGögüs = new List<string>();
                        Dictionary<int,string> SaatlerTahtaMeryemGögüs = new Dictionary<int, string>();
                        int İndexTahtaMeryemGögüs2 = 0;
                        foreach (string randevular in hastane)
                        {
                            TahtaMeryemGögüs = randevular.Split('|');
                            if(TahtaMeryemGögüs.ElementAt(0) == "Meryem Ay")
                            {
                            DoluSaatlerTahtaMeryemGögüs.Add(TahtaMeryemGögüs.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerTahtaMeryemGögüs.Contains(i+":00"))
                            {
                            İndexTahtaMeryemGögüs2++;
                            SaatlerTahtaMeryemGögüs.Add(İndexTahtaMeryemGögüs2 , i + ":00");
                            Console.WriteLine(İndexTahtaMeryemGögüs2 + "- " + i +":00");                            
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Meryem Ay|"+ SaatlerTahtaMeryemGögüs[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);    


                        break;
                    case 3:
                        string [] TahtaUgurGögüs;
                        List<string> DoluSaatlerTahtaUgurGögüs = new List<string>();
                        Dictionary<int,string> SaatlerTahtaUgurGögüs = new Dictionary<int, string>();
                        int İndexTahtaUgurGögüs3 = 0;
                        foreach (string randevular in hastane)
                        {
                            TahtaUgurGögüs = randevular.Split('|');
                            if(TahtaUgurGögüs.ElementAt(0) == "Uğur Şentürk")
                            {
                            DoluSaatlerTahtaUgurGögüs.Add(TahtaUgurGögüs.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerTahtaUgurGögüs.Contains(i+":00"))
                            {
                            İndexTahtaUgurGögüs3++;
                            SaatlerTahtaUgurGögüs.Add(İndexTahtaUgurGögüs3 , i + ":00");
                            Console.WriteLine(İndexTahtaUgurGögüs3 + "- " + i +":00");                            
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Uğur Şentürk|"+ SaatlerTahtaUgurGögüs[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);    


                        break;
                    
                }
                break; 
            case 6:
                Console.Clear();
                Console.WriteLine("1. Yasemin Aras");
                Console.WriteLine("2. Caner Boz");
                Console.WriteLine("3. Tuğçe Korkmaz");
                Console.WriteLine("İstediginiz Onkoloji Doktoru:");
                int tahta6 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (tahta6)
                {
                    case 1:
                        string [] TahtaYaseminOnkoloji;
                        List<string> DoluSaatlerTahtaYaseminOnkoloji = new List<string>();
                        Dictionary<int,string> SaatlerTahtaYaseminOnkoloji = new Dictionary<int, string>();
                        int İndexTahtaYaseminOnkoloji1 = 0;
                        foreach (string randevular in hastane)
                        {
                            TahtaYaseminOnkoloji = randevular.Split('|');
                            if(TahtaYaseminOnkoloji.ElementAt(0) == "Yasemin Aras")
                            {
                            DoluSaatlerTahtaYaseminOnkoloji.Add(TahtaYaseminOnkoloji.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerTahtaYaseminOnkoloji.Contains(i+":00"))
                            {
                            İndexTahtaYaseminOnkoloji1++;
                            SaatlerTahtaYaseminOnkoloji.Add(İndexTahtaYaseminOnkoloji1 , i + ":00");
                            Console.WriteLine(İndexTahtaYaseminOnkoloji1 + "- " + i +":00");                            
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Yasemin Aras|"+ SaatlerTahtaYaseminOnkoloji[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);    
   

                        break;
                    case 2:
                        string [] TahtaCanerOnkoloji;
                        List<string> DoluSaatlerTahtaCanerOnkoloji = new List<string>();
                        Dictionary<int,string> SaatlerTahtaCanerOnkoloji = new Dictionary<int, string>();
                        int İndexTahtaCanerOnkoloji2 = 0;
                        foreach (string randevular in hastane)
                        {
                            TahtaCanerOnkoloji = randevular.Split('|');
                            if(TahtaCanerOnkoloji.ElementAt(0) == "Caner Boz")
                            {
                            DoluSaatlerTahtaCanerOnkoloji.Add(TahtaCanerOnkoloji.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerTahtaCanerOnkoloji.Contains(i+":00"))
                            {
                            İndexTahtaCanerOnkoloji2++;
                            SaatlerTahtaCanerOnkoloji.Add(İndexTahtaCanerOnkoloji2 , i + ":00");
                            Console.WriteLine(İndexTahtaCanerOnkoloji2 + "- " + i +":00");                            
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Caner Boz|"+ SaatlerTahtaCanerOnkoloji[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);   

                        break;
                    case 3:
                        string [] TahtaTugceOnkoloji;
                        List<string> DoluSaatlerTahtatugceOnkoloji = new List<string>();
                        Dictionary<int,string> SaatlerTahtaTugceOnkoloji = new Dictionary<int, string>();
                        int İndexTahtaTugceOnkoloji3 = 0;
                        foreach (string randevular in hastane)
                        {
                            TahtaTugceOnkoloji = randevular.Split('|');
                            if(TahtaTugceOnkoloji.ElementAt(0) == "Tuğçe Korkmaz")
                            {
                            DoluSaatlerTahtatugceOnkoloji.Add(TahtaTugceOnkoloji.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerTahtatugceOnkoloji.Contains(i+":00"))
                            {
                            İndexTahtaTugceOnkoloji3++;
                            SaatlerTahtaTugceOnkoloji.Add(İndexTahtaTugceOnkoloji3 , i + ":00");
                            Console.WriteLine(İndexTahtaTugceOnkoloji3 + "- " + i +":00");                            
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Tuğçe Korkmaz|"+ SaatlerTahtaTugceOnkoloji[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);   

                        break;
                }
            break;
        }
        break;    
                 
                    
                 

    case 4:
        Console.Clear();
        Console.WriteLine("1. Göz Hastaliklari");
        Console.WriteLine("2. Diş Hekimligi");
        Console.WriteLine("3. Genel Cerrahi");
        Console.WriteLine("4. Nöroloji(Beyin ve Sinir Tedavisi)");
        Console.WriteLine("5. Kardiyoloji");
        Console.WriteLine("6. Fizyoloji");
        Console.WriteLine("Secmek İstediginiz Klinik: ");
        int secim4 = Convert.ToInt32(Console.ReadLine()); 
              
        switch (secim4)
        {
            case 1:               
                Console.Clear();
                Console.WriteLine("1. Volkan Taşkin");
                Console.WriteLine("2. Naz Yildirim");
                Console.WriteLine("3. Okan Aydin");
                Console.WriteLine("İstediginiz Göz Hastaliklari Doktoru:");
                int kapak1 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (kapak1)
                {
                    case 1:
                        string [] KapakVolkanGöz;
                        List<string> DoluSaatlerKapakVolkanGöz = new List<string>();
                        Dictionary<int,string> SaatlerKapakVolkanGöz = new Dictionary<int, string>();
                        int İndexKapakVolkanGöz1 = 0;
                        foreach (string randevular in hastane)
                        {
                            KapakVolkanGöz = randevular.Split('|');
                            if(KapakVolkanGöz.ElementAt(0) == "Volkan Taşkin")
                            {
                            DoluSaatlerKapakVolkanGöz.Add(KapakVolkanGöz.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerKapakVolkanGöz.Contains(i+":00"))
                            {
                            İndexKapakVolkanGöz1++;
                            SaatlerKapakVolkanGöz.Add(İndexKapakVolkanGöz1 , i + ":00");
                            Console.WriteLine(İndexKapakVolkanGöz1 + "- " + i +":00");                            
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Volkan Taşkin|"+ SaatlerKapakVolkanGöz[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);      

                        break;
                    case 2:
                        string [] KapakNazGöz;
                        List<string> DoluSaatlerKapakNazGöz = new List<string>();
                        Dictionary<int,string> SaatlerKapakNazGöz = new Dictionary<int, string>();
                        int İndexKapakNazGöz2 = 0;
                        foreach (string randevular in hastane)
                        {
                            KapakNazGöz = randevular.Split('|');
                            if(KapakNazGöz.ElementAt(0) == "Naz Yildirim")
                            {
                            DoluSaatlerKapakNazGöz.Add(KapakNazGöz.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerKapakNazGöz.Contains(i+":00"))
                            {
                            İndexKapakNazGöz2++;
                            SaatlerKapakNazGöz.Add(İndexKapakNazGöz2 , i + ":00");
                            Console.WriteLine(İndexKapakNazGöz2 + "- " + i +":00");                            
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Naz Yildirim|"+ SaatlerKapakNazGöz[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);      


                        break;
                    case 3:
                        string [] KapakOkanGöz;
                        List<string> DoluSaatlerKapakOkanGöz = new List<string>();
                        Dictionary<int,string> SaatlerKapakOkanGöz = new Dictionary<int, string>();
                        int İndexKapakOkanGöz3 = 0;
                        foreach (string randevular in hastane)
                        {
                            KapakOkanGöz = randevular.Split('|');
                            if(KapakOkanGöz.ElementAt(0) == "Okan Aydin")
                            {
                            DoluSaatlerKapakOkanGöz.Add(KapakOkanGöz.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerKapakOkanGöz.Contains(i+":00"))
                            {
                            İndexKapakOkanGöz3++;
                            SaatlerKapakOkanGöz.Add(İndexKapakOkanGöz3 , i + ":00");
                            Console.WriteLine(İndexKapakOkanGöz3 + "- " + i +":00");                            
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Okan Aydin|"+ SaatlerKapakOkanGöz[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);      


                        break;
                    
                }
                break; 
            case 2:                
                Console.Clear();
                Console.WriteLine("1. Dilan Akin");
                Console.WriteLine("2. Kenan Güzel");
                Console.WriteLine("3. Meltem Çetin");
                Console.WriteLine("İstediginiz Diş Doktoru:");
                int kapak2 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (kapak2)
                {
                    case 1:
                        string [] KapakDilanDiş;
                        List<string> DoluSaatlerKapakDilanDiş = new List<string>();
                        Dictionary<int,string> SaatlerKapakDilanDiş = new Dictionary<int, string>();
                        int İndexKapakDilanDiş1 = 0;
                        foreach (string randevular in hastane)
                        {
                            KapakDilanDiş = randevular.Split('|');
                            if(KapakDilanDiş.ElementAt(0) == "Dilan Akin")
                            {
                            DoluSaatlerKapakDilanDiş.Add(KapakDilanDiş.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerKapakDilanDiş.Contains(i+":00"))
                            {
                            İndexKapakDilanDiş1++;
                            SaatlerKapakDilanDiş.Add(İndexKapakDilanDiş1 , i + ":00");
                            Console.WriteLine(İndexKapakDilanDiş1 + "- " + i +":00");                            
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Dilan Akin|"+ SaatlerKapakDilanDiş[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);   

                        break;
                    case 2:
                        string [] KapakKenanDiş;
                        List<string> DoluSaatlerKapakKenanDiş = new List<string>();
                        Dictionary<int,string> SaatlerKapakKenanDiş = new Dictionary<int, string>();
                        int İndexKapakKenanDiş2 = 0;
                        foreach (string randevular in hastane)
                        {
                            KapakKenanDiş = randevular.Split('|');
                            if(KapakKenanDiş.ElementAt(0) == "Kenan Güzel")
                            {
                            DoluSaatlerKapakKenanDiş.Add(KapakKenanDiş.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerKapakKenanDiş.Contains(i+":00"))
                            {
                            İndexKapakKenanDiş2++;
                            SaatlerKapakKenanDiş.Add(İndexKapakKenanDiş2 , i + ":00");
                            Console.WriteLine(İndexKapakKenanDiş2 + "- " + i +":00");                            
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Kenan Güzel|"+ SaatlerKapakKenanDiş[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);   

                        break;
                    case 3:
                        string [] KapakMeltemDiş;
                        List<string> DoluSaatlerKapakMeltemDiş = new List<string>();
                        Dictionary<int,string> SaatlerKapakMeltemDiş = new Dictionary<int, string>();
                        int İndexKapakMeltemDiş3 = 0;
                        foreach (string randevular in hastane)
                        {
                            KapakMeltemDiş = randevular.Split('|');
                            if(KapakMeltemDiş.ElementAt(0) == "Meltem Çetin")
                            {
                            DoluSaatlerKapakMeltemDiş.Add(KapakMeltemDiş.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerKapakMeltemDiş.Contains(i+":00"))
                            {
                            İndexKapakMeltemDiş3++;
                            SaatlerKapakMeltemDiş.Add(İndexKapakMeltemDiş3 , i + ":00");
                            Console.WriteLine(İndexKapakMeltemDiş3 + "- " + i +":00");                            
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Meltem Çetin|"+ SaatlerKapakMeltemDiş[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);   

                        break;
                    
                }
                break; 
            case 3:                
                Console.Clear();
                Console.WriteLine("1. Ridvan Duru");
                Console.WriteLine("2. Ceren Uslu");
                Console.WriteLine("3. Cemal Tunçel");
                Console.WriteLine("İstediginiz Genel Cerrahi Doktoru:");
                int kapak3 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (kapak3)
                {
                    case 1:
                        string [] KapakRidvanGenelCerrahi;
                        List<string> DoluSaatlerKapakRidvanGenelCerrahi = new List<string>();
                        Dictionary<int,string> SaatlerKapakRidvanGenelCerrahi = new Dictionary<int, string>();
                        int İndexKapakRidvanGenelCerrahi1 = 0;
                        foreach (string randevular in hastane)
                        {
                            KapakRidvanGenelCerrahi = randevular.Split('|');
                            if(KapakRidvanGenelCerrahi.ElementAt(0) == "Ridvan Duru")
                            {
                            DoluSaatlerKapakRidvanGenelCerrahi.Add(KapakRidvanGenelCerrahi.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerKapakRidvanGenelCerrahi.Contains(i+":00"))
                            {
                            İndexKapakRidvanGenelCerrahi1++;
                            SaatlerKapakRidvanGenelCerrahi.Add(İndexKapakRidvanGenelCerrahi1 , i + ":00");
                            Console.WriteLine(İndexKapakRidvanGenelCerrahi1 + "- " + i +":00");                            
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Ridvan Duru|"+ SaatlerKapakRidvanGenelCerrahi[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);   
   

                        break;
                    case 2:
                        string [] KapakCerenGenelCerrahi;
                        List<string> DoluSaatlerKapakCerenGenelCerrahi = new List<string>();
                        Dictionary<int,string> SaatlerKapakCerenGenelCerrahi = new Dictionary<int, string>();
                        int İndexKapakCerenGenelCerrahi2     = 0;
                        foreach (string randevular in hastane)
                        {
                            KapakCerenGenelCerrahi = randevular.Split('|');
                            if(KapakCerenGenelCerrahi.ElementAt(0) == "Ceren Uslu")
                            {
                            DoluSaatlerKapakCerenGenelCerrahi.Add(KapakCerenGenelCerrahi.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerKapakCerenGenelCerrahi.Contains(i+":00"))
                            {
                            İndexKapakCerenGenelCerrahi2++;
                            SaatlerKapakCerenGenelCerrahi.Add(İndexKapakCerenGenelCerrahi2 , i + ":00");
                            Console.WriteLine(İndexKapakCerenGenelCerrahi2 + "- " + i +":00");                            
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Ceren Uslu|"+ SaatlerKapakCerenGenelCerrahi[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);

                        break;
                    case 3:
                        string [] KapakCemalGenelCerrahi;
                        List<string> DoluSaatlerKapakCemalGenelCerrahi = new List<string>();
                        Dictionary<int,string> SaatlerKapakCemalGenelCerrahi = new Dictionary<int, string>();
                        int İndexKapakCemalGenelCerrahi3    = 0;
                        foreach (string randevular in hastane)
                        {
                            KapakCemalGenelCerrahi = randevular.Split('|');
                            if(KapakCemalGenelCerrahi.ElementAt(0) == "Cemal Tunçel")
                            {
                            DoluSaatlerKapakCemalGenelCerrahi.Add(KapakCemalGenelCerrahi.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerKapakCemalGenelCerrahi.Contains(i+":00"))
                            {
                            İndexKapakCemalGenelCerrahi3++;
                            SaatlerKapakCemalGenelCerrahi.Add(İndexKapakCemalGenelCerrahi3 , i + ":00");
                            Console.WriteLine(İndexKapakCemalGenelCerrahi3 + "- " + i +":00");                            
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Cemal Tunçel|"+ SaatlerKapakCemalGenelCerrahi[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);


                        break;
                }
                break; 
            case 4:               
                Console.Clear();
                Console.WriteLine("1. Pinar Öztürk");
                Console.WriteLine("2. Gökhan Altun");
                Console.WriteLine("3. Sevgi Avci");
                Console.WriteLine("İstediginiz Nöroloji(Beyin ve Sinir Tedavisi) Doktoru:");
                int kapak4 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (kapak4)
                {
                    case 1:
                        string [] KapakPinarNöroloji;
                        List<string> DoluSaatlerKapakPinarNöroloji = new List<string>();
                        Dictionary<int,string> SaatlerKapakPinarNoroloji = new Dictionary<int, string>();
                        int İndexKapakPinarNöroloji1    = 0;
                        foreach (string randevular in hastane)
                        {
                            KapakPinarNöroloji = randevular.Split('|');
                            if(KapakPinarNöroloji.ElementAt(0) == "Pinar Öztürk")
                            {
                            DoluSaatlerKapakPinarNöroloji.Add(KapakPinarNöroloji.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerKapakPinarNöroloji.Contains(i+":00"))
                            {
                            İndexKapakPinarNöroloji1++;
                            SaatlerKapakPinarNoroloji.Add(İndexKapakPinarNöroloji1 , i + ":00");
                            Console.WriteLine(İndexKapakPinarNöroloji1 + "- " + i +":00");                            
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Pinar Öztürk|"+ SaatlerKapakPinarNoroloji[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);   

                        break;
                    case 2:
                        string [] KapakGökhanNöroloji;
                        List<string> DoluSaatlerKapakGökanNöroloji = new List<string>();
                        Dictionary<int,string> SaatlerKapakGökhanNoroloji = new Dictionary<int, string>();
                        int İndexKapakGökhanNöroloji2    = 0;
                        foreach (string randevular in hastane)
                        {
                            KapakGökhanNöroloji = randevular.Split('|');
                            if(KapakGökhanNöroloji.ElementAt(0) == "Gökhan Altun")
                            {
                            DoluSaatlerKapakGökanNöroloji.Add(KapakGökhanNöroloji.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerKapakGökanNöroloji.Contains(i+":00"))
                            {
                            İndexKapakGökhanNöroloji2++;
                            SaatlerKapakGökhanNoroloji.Add(İndexKapakGökhanNöroloji2 , i + ":00");
                            Console.WriteLine(İndexKapakGökhanNöroloji2 + "- " + i +":00");                            
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Gökhan Altun|"+ SaatlerKapakGökhanNoroloji[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);   


                        break;
                    case 3:
                        string [] KapakSevgiNöroloji;
                        List<string> DoluSaatlerKapakSevgiNöroloji = new List<string>();
                        Dictionary<int,string> SaatlerKapakSevgiNoroloji = new Dictionary<int, string>();
                        int İndexKapakSevgiNöroloji3    = 0;
                        foreach (string randevular in hastane)
                        {
                            KapakSevgiNöroloji = randevular.Split('|');
                            if(KapakSevgiNöroloji.ElementAt(0) == "Sevgi Avci")
                            {
                            DoluSaatlerKapakSevgiNöroloji.Add(KapakSevgiNöroloji.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerKapakSevgiNöroloji.Contains(i+":00"))
                            {
                            İndexKapakSevgiNöroloji3++;
                            SaatlerKapakSevgiNoroloji.Add(İndexKapakSevgiNöroloji3 , i + ":00");
                            Console.WriteLine(İndexKapakSevgiNöroloji3 + "- " + i +":00");                            
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Sevgi Avci|"+ SaatlerKapakSevgiNoroloji[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);   

                        break;
                }
                break; 
            case 5:
                Console.Clear();
                Console.WriteLine("1. Kaan Şeker");
                Console.WriteLine("2. Büşra Kurtuluş");
                Console.WriteLine("3. Alper Gündüz");
                Console.WriteLine("İstediginiz Kardiyoloji Doktoru:");
                int kapak5 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (kapak5)
                {
                    case 1:
                        string [] KapakKaanKardiyoloji;
                        List<string> DoluSaatlerKapakKaanKardiyoloji = new List<string>();
                        Dictionary<int,string> SaatlerKapakKaanKardiyoloji = new Dictionary<int, string>();
                        int İndexKapakKaanKardiyoloji1    = 0;
                        foreach (string randevular in hastane)
                        {
                            KapakKaanKardiyoloji = randevular.Split('|');
                            if(KapakKaanKardiyoloji.ElementAt(0) == "Kaan Şeker")
                            {
                            DoluSaatlerKapakKaanKardiyoloji.Add(KapakKaanKardiyoloji.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerKapakKaanKardiyoloji.Contains(i+":00"))
                            {
                            İndexKapakKaanKardiyoloji1++;
                            SaatlerKapakKaanKardiyoloji.Add(İndexKapakKaanKardiyoloji1 , i + ":00");
                            Console.WriteLine(İndexKapakKaanKardiyoloji1 + "- " + i +":00");                            
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Kaan Şeker|"+ SaatlerKapakKaanKardiyoloji[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);     

                        break;
                    case 2:
                        string [] KapakBüşraKardiyoloji;
                        List<string> DoluSaatlerKapakBüşraKardiyoloji = new List<string>();
                        Dictionary<int,string> SaatlerKapakBüşraKardiyoloji = new Dictionary<int, string>();
                        int İndexKapakBüşraKardiyoloji2    = 0;
                        foreach (string randevular in hastane)
                        {
                            KapakBüşraKardiyoloji = randevular.Split('|');
                            if(KapakBüşraKardiyoloji.ElementAt(0) == "Büşra Kurtuluş")
                            {
                            DoluSaatlerKapakBüşraKardiyoloji.Add(KapakBüşraKardiyoloji.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerKapakBüşraKardiyoloji.Contains(i+":00"))
                            {
                            İndexKapakBüşraKardiyoloji2++;
                            SaatlerKapakBüşraKardiyoloji.Add(İndexKapakBüşraKardiyoloji2 , i + ":00");
                            Console.WriteLine(İndexKapakBüşraKardiyoloji2 + "- " + i +":00");                            
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Büşra Kurtuluş|"+ SaatlerKapakBüşraKardiyoloji[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);

                        break;
                    case 3:
                        string [] KapakAlperKardiyoloji;
                        List<string> DoluSaatlerKapakAlperKardiyoloji = new List<string>();
                        Dictionary<int,string> SaatlerKapakAlperKardiyoloji = new Dictionary<int, string>();
                        int İndexKapakAlperKardiyoloji3    = 0;
                        foreach (string randevular in hastane)
                        {
                            KapakAlperKardiyoloji = randevular.Split('|');
                            if(KapakAlperKardiyoloji.ElementAt(0) == "Alper Gündüz")
                            {
                            DoluSaatlerKapakAlperKardiyoloji.Add(KapakAlperKardiyoloji.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerKapakAlperKardiyoloji.Contains(i+":00"))
                            {
                            İndexKapakAlperKardiyoloji3++;
                            SaatlerKapakAlperKardiyoloji.Add(İndexKapakAlperKardiyoloji3 , i + ":00");
                            Console.WriteLine(İndexKapakAlperKardiyoloji3 + "- " + i +":00");                            
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Alper Gündüz|"+ SaatlerKapakAlperKardiyoloji[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);

                        break;
                }
                break; 
            case 6:
                Console.Clear();
                Console.WriteLine("1. Sude Demirtaş");
                Console.WriteLine("2. Eray Kalkan");
                Console.WriteLine("3. Nehir Aksoy");
                Console.WriteLine("İstediginiz Fizyoloji Doktoru:");
                int kapak6 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (kapak6)
                {
                    case 1:
                        string [] KapakSudeFizyoloji;
                        List<string> DoluSaatlerKapakSudeFizyoloji = new List<string>();
                        Dictionary<int,string> SaatlerKapakSudeFizyoloji = new Dictionary<int, string>();
                        int İndexKapakSudeFizyoloji1    = 0;
                        foreach (string randevular in hastane)
                        {
                            KapakSudeFizyoloji = randevular.Split('|');
                            if(KapakSudeFizyoloji.ElementAt(0) == "Sude Demirtaş")
                            {
                            DoluSaatlerKapakSudeFizyoloji.Add(KapakSudeFizyoloji.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerKapakSudeFizyoloji.Contains(i+":00"))
                            {
                            İndexKapakSudeFizyoloji1++;
                            SaatlerKapakSudeFizyoloji.Add(İndexKapakSudeFizyoloji1 , i + ":00");
                            Console.WriteLine(İndexKapakSudeFizyoloji1 + "- " + i +":00");                            
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Sude Demirtaş|"+ SaatlerKapakSudeFizyoloji[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);

                        break;
                    case 2:
                        string [] KapakErayFizyoloji;
                        List<string> DoluSaatlerKapakErayFizyoloji = new List<string>();
                        Dictionary<int,string> SaatlerKapakErayFizyoloji = new Dictionary<int, string>();
                        int İndexKapakErayFizyoloji2    = 0;
                        foreach (string randevular in hastane)
                        {
                            KapakErayFizyoloji = randevular.Split('|');
                            if(KapakErayFizyoloji.ElementAt(0) == "Eray Kalkan")
                            {
                            DoluSaatlerKapakErayFizyoloji.Add(KapakErayFizyoloji.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerKapakErayFizyoloji.Contains(i+":00"))
                            {
                            İndexKapakErayFizyoloji2++;
                            SaatlerKapakErayFizyoloji.Add(İndexKapakErayFizyoloji2 , i + ":00");
                            Console.WriteLine(İndexKapakErayFizyoloji2 + "- " + i +":00");                            
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Eray Kalkan|"+ SaatlerKapakErayFizyoloji[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);


                        break;
                    case 3:
                        
                        string [] KapakNehirFizyoloji;
                        List<string> DoluSaatlerKapakNehirFizyoloji = new List<string>();
                        Dictionary<int,string> SaatlerKapakNehirFizyoloji = new Dictionary<int, string>();
                        int İndexKapakNehirFizyoloji3    = 0;
                        foreach (string randevular in hastane)
                        {
                            KapakNehirFizyoloji = randevular.Split('|');
                            if(KapakNehirFizyoloji.ElementAt(0) == "Nehir Aksoy")
                            {
                            DoluSaatlerKapakNehirFizyoloji.Add(KapakNehirFizyoloji.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerKapakNehirFizyoloji.Contains(i+":00"))
                            {
                            İndexKapakNehirFizyoloji3++;
                            SaatlerKapakNehirFizyoloji.Add(İndexKapakNehirFizyoloji3 , i + ":00");
                            Console.WriteLine(İndexKapakNehirFizyoloji3 + "- " + i +":00");                            
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Nehir Aksoy|"+ SaatlerKapakNehirFizyoloji[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);

                        break;
                }
                break; 
            
        }
        break;
        

    case 5:
        
        Console.Clear();
        Console.WriteLine("1. Nöroloji(Beyin ve Sinir Tedavisi)");
        Console.WriteLine("2. Onkoloji(Kanser Tedavi)");
        Console.WriteLine("3. Diş Hekimligi");
        Console.WriteLine("4. Gögus Hastaliklari");
        Console.WriteLine("5. Kardiyoloji(Kalp Tedavisi)");
        Console.WriteLine("6. Üroloji");
        Console.WriteLine("7. Dahiliye(İç Organlar)");
        Console.WriteLine("8. Fizyoloji");
        Console.WriteLine("9. Genel Cerrahi");
        Console.WriteLine("10. Göz Hastaliklari");
        Console.WriteLine("11. Kulak Burun Bogaz");
        Console.WriteLine("Secmek İstediginiz Klinik: ");
        int secim5 = Convert.ToInt32(Console.ReadLine());
        switch (secim5)
        {
            case 1:
                
                Console.Clear();
                Console.WriteLine("1. Prof. Dr.Kaan Erdogan");
                Console.WriteLine("2. Sila Gün");
                Console.WriteLine("3. Ömer Önder");
                Console.WriteLine("İstediginiz Noroloji Doktoru:");
                int sibop1 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (sibop1)
                {
                    case 1:
                        string [] KapakKaanNoroloji;
                        List<string> DoluSaatlerSibopKaanNoroloji = new List<string>();
                        Dictionary<int,string> SaatlerSibopKaanNoroloji = new Dictionary<int, string>();
                        int İndexSibopKaanNoroloji1    = 0;
                        foreach (string randevular in hastane)
                        {
                            KapakKaanNoroloji = randevular.Split('|');
                            if(KapakKaanNoroloji.ElementAt(0) == "Prof. Dr. Kaan Erdogan")
                            {
                            DoluSaatlerSibopKaanNoroloji.Add(KapakKaanNoroloji.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerSibopKaanNoroloji.Contains(i+":00"))
                            {
                            İndexSibopKaanNoroloji1++;
                            SaatlerSibopKaanNoroloji.Add(İndexSibopKaanNoroloji1 , i + ":00");
                            Console.WriteLine(İndexSibopKaanNoroloji1 + "- " + i +":00");                            
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Prof. Dr. Kaan Erdogan|"+ SaatlerSibopKaanNoroloji[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);  

                        break;
                    case 2:
                        string [] SibopSilaNoroloji;
                        List<string> DoluSaatlerSibopSilaNoroloji = new List<string>();
                        Dictionary<int,string> SaatlerSibopSilaNoroloji = new Dictionary<int, string>();
                        int İndexSibopSilaNoroloji2    = 0;
                        foreach (string randevular in hastane)
                        {
                            SibopSilaNoroloji = randevular.Split('|');
                            if(SibopSilaNoroloji.ElementAt(0) == "Sila Gün")
                            {
                            DoluSaatlerSibopSilaNoroloji.Add(SibopSilaNoroloji.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerSibopSilaNoroloji.Contains(i+":00"))
                            {
                            İndexSibopSilaNoroloji2++;
                            SaatlerSibopSilaNoroloji.Add(İndexSibopSilaNoroloji2 , i + ":00");
                            Console.WriteLine(İndexSibopSilaNoroloji2 + "- " + i +":00");                            
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Sila Gün|"+ SaatlerSibopSilaNoroloji[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane); 

                        break;
                    case 3:
                        string [] SibopÖmerNoroloji;
                        List<string> DoluSaatlerSibopÖmerNoroloji = new List<string>();
                        Dictionary<int,string> SaatlerSibopÖmerNoroloji = new Dictionary<int, string>();
                        int İndexSibopÖmerNoroloji3    = 0;
                        foreach (string randevular in hastane)
                        {
                            SibopÖmerNoroloji = randevular.Split('|');
                            if(SibopÖmerNoroloji.ElementAt(0) == "Ömer Önder")
                            {
                            DoluSaatlerSibopÖmerNoroloji.Add(SibopÖmerNoroloji.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerSibopÖmerNoroloji.Contains(i+":00"))
                            {
                            İndexSibopÖmerNoroloji3++;
                            SaatlerSibopÖmerNoroloji.Add(İndexSibopÖmerNoroloji3 , i + ":00");
                            Console.WriteLine(İndexSibopÖmerNoroloji3 + "- " + i +":00");                            
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Ömer Önder|"+ SaatlerSibopÖmerNoroloji[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane); 

                        break;

                }
                break;         
            case 2:
                
                Console.Clear();
                Console.WriteLine("1. Prof. Dr. Ersin Kizildag");
                Console.WriteLine("2. Hira Bozkurt");
                Console.WriteLine("3. Atakan Sevim");
                Console.WriteLine("İstediginiz Onkoloji Doktoru:");
                int sibop2 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (sibop2)
                {
                    case 1:
                        string [] SibopErsinOnkoloji;
                        List<string> DoluSaatlerSibopErsinOnkoloji = new List<string>();
                        Dictionary<int,string> SaatlerSibopErsinOnkoloji = new Dictionary<int, string>();
                        int İndexSibopErsinOnkoloji1    = 0;
                        foreach (string randevular in hastane)
                        {
                            SibopErsinOnkoloji = randevular.Split('|');
                            if(SibopErsinOnkoloji.ElementAt(0) == "Prof. Dr. Ersin Kizildag")
                            {
                            DoluSaatlerSibopErsinOnkoloji.Add(SibopErsinOnkoloji.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerSibopErsinOnkoloji.Contains(i+":00"))
                            {
                            İndexSibopErsinOnkoloji1++;
                            SaatlerSibopErsinOnkoloji.Add(İndexSibopErsinOnkoloji1 , i + ":00");
                            Console.WriteLine(İndexSibopErsinOnkoloji1 + "- " + i +":00");                            
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Prof. Dr. Ersin Kizildag|"+ SaatlerSibopErsinOnkoloji[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);    

                        break;
                    case 2:
                        string [] SibopHiraOnkoloji;
                        List<string> DoluSaatlerSibopHiraOnkoloji = new List<string>();
                        Dictionary<int,string> SaatlerSibopHiraOnkoloji = new Dictionary<int, string>();
                        int İndexSibopHiraOnkoloji2    = 0;
                        foreach (string randevular in hastane)
                        {
                            SibopHiraOnkoloji = randevular.Split('|');
                            if(SibopHiraOnkoloji.ElementAt(0) == "Hira Bozkurt")
                            {
                            DoluSaatlerSibopHiraOnkoloji.Add(SibopHiraOnkoloji.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerSibopHiraOnkoloji.Contains(i+":00"))
                            {
                            İndexSibopHiraOnkoloji2++;
                            SaatlerSibopHiraOnkoloji.Add(İndexSibopHiraOnkoloji2 , i + ":00");
                            Console.WriteLine(İndexSibopHiraOnkoloji2 + "- " + i +":00");                            
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Hira Bozkurt|"+ SaatlerSibopHiraOnkoloji[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);    

                        break;
                    case 3:
                        string [] SibopAtakanOnkoloji;
                        List<string> DoluSaatlerSibopAtakanOnkoloji = new List<string>();
                        Dictionary<int,string> SaatlerSibopAtakanOnkoloji = new Dictionary<int, string>();
                        int İndexSibopAtakanOnkoloji3    = 0;
                        foreach (string randevular in hastane)
                        {
                            SibopAtakanOnkoloji = randevular.Split('|');
                            if(SibopAtakanOnkoloji.ElementAt(0) == "Atakan Sevim")
                            {
                            DoluSaatlerSibopAtakanOnkoloji.Add(SibopAtakanOnkoloji.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerSibopAtakanOnkoloji.Contains(i+":00"))
                            {
                            İndexSibopAtakanOnkoloji3++;
                            SaatlerSibopAtakanOnkoloji.Add(İndexSibopAtakanOnkoloji3 , i + ":00");
                            Console.WriteLine(İndexSibopAtakanOnkoloji3 + "- " + i +":00");                            
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Atakan Sevim|"+ SaatlerSibopAtakanOnkoloji[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);    


                        break;
                    
                }
                break;
            case 3:
                
                Console.Clear();
                Console.WriteLine("1. Prof. Dr. Hasan Hüseyin Kideyş");
                Console.WriteLine("2. Azra Yiğen");
                Console.WriteLine("3. Cem Kara");
                Console.WriteLine("İstediginiz Diş Doktoru:");
                int sibop3 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (sibop3)
                {
                    case 1:
                        string [] SibopHasanDiş;
                        List<string> DoluSaatlerSibopHasanDiş = new List<string>();
                        Dictionary<int,string> SaatlerSibopHasanDiş = new Dictionary<int, string>();
                        int İndexSibopHasanDiş1    = 0;
                        foreach (string randevular in hastane)
                        {
                            SibopHasanDiş = randevular.Split('|');
                            if(SibopHasanDiş.ElementAt(0) == "Prof. Dr. Hasan Hüseyin Kideyş")
                            {
                            DoluSaatlerSibopHasanDiş.Add(SibopHasanDiş.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerSibopHasanDiş.Contains(i+":00"))
                            {
                            İndexSibopHasanDiş1++;
                            SaatlerSibopHasanDiş.Add(İndexSibopHasanDiş1 , i + ":00");
                            Console.WriteLine(İndexSibopHasanDiş1 + "- " + i +":00");                            
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Prof. Dr. Hasan Hüseyin Kideyş|"+ SaatlerSibopHasanDiş[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);    


                        break;
                    case 2:
                        string [] SibopAzraDiş;
                        List<string> DoluSaatlerSibopAzraDiş = new List<string>();
                        Dictionary<int,string> SaatlerSibopAzraDiş = new Dictionary<int, string>();
                        int İndexSibopAzraDiş2    = 0;
                        foreach (string randevular in hastane)
                        {
                            SibopAzraDiş = randevular.Split('|');
                            if(SibopAzraDiş.ElementAt(0) == "Azra Yiğen")
                            {
                            DoluSaatlerSibopAzraDiş.Add(SibopAzraDiş.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerSibopAzraDiş.Contains(i+":00"))
                            {
                            İndexSibopAzraDiş2++;
                            SaatlerSibopAzraDiş.Add(İndexSibopAzraDiş2 , i + ":00");
                            Console.WriteLine(İndexSibopAzraDiş2 + "- " + i +":00");                            
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Azra Yiğen|"+ SaatlerSibopAzraDiş[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);    


                        break;
                    case 3:
                        string [] SibopCemDiş;
                        List<string> DoluSaatlerSibopCemDiş = new List<string>();
                        Dictionary<int,string> SaatlerSibopCemDiş = new Dictionary<int, string>();
                        int İndexSibopCemDiş3    = 0;
                        foreach (string randevular in hastane)
                        {
                            SibopCemDiş = randevular.Split('|');
                            if(SibopCemDiş.ElementAt(0) == "Cem Kara")
                            {
                            DoluSaatlerSibopCemDiş.Add(SibopCemDiş.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerSibopCemDiş.Contains(i+":00"))
                            {
                            İndexSibopCemDiş3++;
                            SaatlerSibopCemDiş.Add(İndexSibopCemDiş3 , i + ":00");
                            Console.WriteLine(İndexSibopCemDiş3 + "- " + i +":00");                            
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Cem Kara|"+ SaatlerSibopCemDiş[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);    

                        break;
                    
                }
                break;
            case 4:
                
                Console.Clear();
                Console.WriteLine("1. Prof. Dr. Burak Efe Kideys");
                Console.WriteLine("2. Mina Kuru");
                Console.WriteLine("3. Gökhan Tokatli");
                Console.WriteLine("İstediginiz Kardiyoloji Doktoru:");
                int sibop4 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (sibop4)
                {
                    case 1:
                        string [] SibopBurakGögüs;
                        List<string> DoluSaatlerSibopBurakGögüs = new List<string>();
                        Dictionary<int,string> SaatlerSibopBurakGögüs = new Dictionary<int, string>();
                        int İndexSibopBurakGögüs1    = 0;
                        foreach (string randevular in hastane)
                        {
                            SibopBurakGögüs = randevular.Split('|');
                            if(SibopBurakGögüs.ElementAt(0) == "Prof. Dr. Burak Efe Kideys")
                            {
                            DoluSaatlerSibopBurakGögüs.Add(SibopBurakGögüs.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerSibopBurakGögüs.Contains(i+":00"))
                            {
                            İndexSibopBurakGögüs1++;
                            SaatlerSibopBurakGögüs.Add(İndexSibopBurakGögüs1 , i + ":00");
                            Console.WriteLine(İndexSibopBurakGögüs1 + "- " + i +":00");                            
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Prof. Dr. Burak Efe Kideys|"+ SaatlerSibopBurakGögüs[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);    


                        break;
                    case 2:
                        Console.Clear();

                        break;
                    case 3:
                        Console.Clear();

                        break;
                    
                }
                break;
            case 5:

                Console.Clear();
                Console.WriteLine("1. Prof. Dr. Eyüp İlmi Kideyş");
                Console.WriteLine("2. Sena Gürbüz");
                Console.WriteLine("3. Tuna Karahan");
                Console.WriteLine("İstediginiz Gögus Hastaliklari Doktoru:");
                int sibop5 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (sibop5)
                {
                    case 1:
                        string [] SibopEyüpGögüs;
                        List<string> DoluSaatlerSibopEyüpGögüs = new List<string>();
                        Dictionary<int,string> SaatlerSibopEyüpGögüs = new Dictionary<int, string>();
                        int İndexSibopEyüpGögüs1    = 0;
                        foreach (string randevular in hastane)
                        {
                            SibopEyüpGögüs = randevular.Split('|');
                            if(SibopEyüpGögüs.ElementAt(0) == "Prof. Dr. Eyüp İlmi Kideyş")
                            {
                            DoluSaatlerSibopEyüpGögüs.Add(SibopEyüpGögüs.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerSibopEyüpGögüs.Contains(i+":00"))
                            {
                            İndexSibopEyüpGögüs1++;
                            SaatlerSibopEyüpGögüs.Add(İndexSibopEyüpGögüs1 , i + ":00");
                            Console.WriteLine(İndexSibopEyüpGögüs1 + "- " + i +":00");                            
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Prof. Dr. Eyüp İlmi Kideyş|"+ SaatlerSibopEyüpGögüs[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);    
 

                        break;
                    case 2:
                        string [] SibopSenaGögüs;
                        List<string> DoluSaatlerSibopSenaGögüs = new List<string>();
                        Dictionary<int,string> SaatlerSibopSenaGögüs = new Dictionary<int, string>();
                        int İndexSibopSenaGögüs2    = 0;
                        foreach (string randevular in hastane)
                        {
                            SibopSenaGögüs = randevular.Split('|');
                            if(SibopSenaGögüs.ElementAt(0) == "Sena Gürbüz")
                            {
                            DoluSaatlerSibopSenaGögüs.Add(SibopSenaGögüs.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerSibopSenaGögüs.Contains(i+":00"))
                            {
                            İndexSibopSenaGögüs2++;
                            SaatlerSibopSenaGögüs.Add(İndexSibopSenaGögüs2 , i + ":00");
                            Console.WriteLine(İndexSibopSenaGögüs2 + "- " + i +":00");                            
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Sena Gürbüz|"+ SaatlerSibopSenaGögüs[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);    
 

                        break;
                    case 3:
                        string [] SibopTunaGögüs;
                        List<string> DoluSaatlerSibopTunaGögüs = new List<string>();
                        Dictionary<int,string> SaatlerSibopTunaGögüs = new Dictionary<int, string>();
                        int İndexSibopTunaGögüs3    = 0;
                        foreach (string randevular in hastane)
                        {
                            SibopTunaGögüs = randevular.Split('|');
                            if(SibopTunaGögüs.ElementAt(0) == "Tuna Karahan")
                            {
                            DoluSaatlerSibopTunaGögüs.Add(SibopTunaGögüs.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerSibopTunaGögüs.Contains(i+":00"))
                            {
                            İndexSibopTunaGögüs3++;
                            SaatlerSibopTunaGögüs.Add(İndexSibopTunaGögüs3 , i + ":00");
                            Console.WriteLine(İndexSibopTunaGögüs3 + "- " + i +":00");                            
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Tuna Karahan|"+ SaatlerSibopTunaGögüs[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);    

                        break;
                    
                }
                break;
            case 6:

                Console.Clear();
                Console.WriteLine("1. Prof. Dr. Mehmet Reşit Orak");
                Console.WriteLine("2. Rabia Dede");
                Console.WriteLine("3. Eray Sağlam");
                Console.WriteLine("İstediginiz Üroloji Doktoru:");
                int sibop6 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (sibop6)
                {
                    case 1:
                        string [] SibopMehmetÜroloji;
                        List<string> DoluSaatlerSibopMehmetÜroloji = new List<string>();
                        Dictionary<int,string> SaatlerSibopMehmetÜroloji = new Dictionary<int, string>();
                        int İndexSibopMehmetÜroloji1    = 0;
                        foreach (string randevular in hastane)
                        {
                            SibopMehmetÜroloji = randevular.Split('|');
                            if(SibopMehmetÜroloji.ElementAt(0) == "Prof. Dr. Mehmet Reşit Orak")
                            {
                            DoluSaatlerSibopMehmetÜroloji.Add(SibopMehmetÜroloji.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerSibopMehmetÜroloji.Contains(i+":00"))
                            {
                            İndexSibopMehmetÜroloji1++;
                            SaatlerSibopMehmetÜroloji.Add(İndexSibopMehmetÜroloji1 , i + ":00");
                            Console.WriteLine(İndexSibopMehmetÜroloji1 + "- " + i +":00");                            
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Prof. Dr. Mehmet Reşit Orak|"+ SaatlerSibopMehmetÜroloji[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);        

                        break;
                    case 2:
                        string [] SiboprabiaÜroloji;
                        List<string> DoluSaatlerSibopRabiaÜroloji = new List<string>();
                        Dictionary<int,string> SaatlerSibopRabiaÜroloji = new Dictionary<int, string>();
                        int İndexSibopRabiaÜroloji2    = 0;
                        foreach (string randevular in hastane)
                        {
                            SiboprabiaÜroloji = randevular.Split('|');
                            if(SiboprabiaÜroloji.ElementAt(0) == "Rabia Dede")
                            {
                            DoluSaatlerSibopRabiaÜroloji.Add(SiboprabiaÜroloji.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerSibopRabiaÜroloji.Contains(i+":00"))
                            {
                            İndexSibopRabiaÜroloji2++;
                            SaatlerSibopRabiaÜroloji.Add(İndexSibopRabiaÜroloji2 , i + ":00");
                            Console.WriteLine(İndexSibopRabiaÜroloji2 + "- " + i +":00");                            
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Rabia Dede|"+ SaatlerSibopRabiaÜroloji[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);        

                        break;
                    case 3:
                        string [] SibopErayÜroloji;
                        List<string> DoluSaatlerSibopErayÜroloji = new List<string>();
                        Dictionary<int,string> SaatlerSibopErayÜroloji = new Dictionary<int, string>();
                        int İndexSibopErayÜroloji3    = 0;
                        foreach (string randevular in hastane)
                        {
                            SibopErayÜroloji = randevular.Split('|');
                            if(SibopErayÜroloji.ElementAt(0) == "Eray Sağlam")
                            {
                            DoluSaatlerSibopErayÜroloji.Add(SibopErayÜroloji.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerSibopErayÜroloji.Contains(i+":00"))
                            {
                            İndexSibopErayÜroloji3++;
                            SaatlerSibopErayÜroloji.Add(İndexSibopErayÜroloji3 , i + ":00");
                            Console.WriteLine(İndexSibopErayÜroloji3 + "- " + i +":00");                            
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Eray Sağlam|"+ SaatlerSibopErayÜroloji[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane); 

                        break;
                    

                }
                break;
            case 7:

                Console.Clear();
                Console.WriteLine("1. Prof. Dr. Enes Kideyş");
                Console.WriteLine("2. Aylin Gören");
                Console.WriteLine("3. Bariş Uçar");
                Console.WriteLine("İstediginiz Dahiliye Doktoru:");
                int sibop7 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (sibop7)
                {
                    case 1:
                        string [] SibopEnesDahiliye;
                        List<string> DoluSaatlerSibopEnesDahiliye = new List<string>();
                        Dictionary<int,string> SaatlerSibopEnesdahiliye = new Dictionary<int, string>();
                        int İndexSibopEnesDahiliye1    = 0;
                        foreach (string randevular in hastane)
                        {
                            SibopEnesDahiliye = randevular.Split('|');
                            if(SibopEnesDahiliye.ElementAt(0) == "Prof. Dr. Enes Kideyş")
                            {
                            DoluSaatlerSibopEnesDahiliye.Add(SibopEnesDahiliye.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerSibopEnesDahiliye.Contains(i+":00"))
                            {
                            İndexSibopEnesDahiliye1++;
                            SaatlerSibopEnesdahiliye.Add(İndexSibopEnesDahiliye1 , i + ":00");
                            Console.WriteLine(İndexSibopEnesDahiliye1 + "- " + i +":00");                            
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Prof. Dr. Enes Kideyş|"+ SaatlerSibopEnesdahiliye[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);    

                        break;
                    case 2:
                        string [] SibopAylinDahiliye;
                        List<string> DoluSaatlerSibopAylinDahiliye = new List<string>();
                        Dictionary<int,string> SaatlerSibopAylinDahiliye = new Dictionary<int, string>();
                        int İndexSibopAylinDahiliye2    = 0;
                        foreach (string randevular in hastane)
                        {
                            SibopAylinDahiliye = randevular.Split('|');
                            if(SibopAylinDahiliye.ElementAt(0) == "Aylin Gören")
                            {
                            DoluSaatlerSibopAylinDahiliye.Add(SibopAylinDahiliye.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerSibopAylinDahiliye.Contains(i+":00"))
                            {
                            İndexSibopAylinDahiliye2++;
                            SaatlerSibopAylinDahiliye.Add(İndexSibopAylinDahiliye2 , i + ":00");
                            Console.WriteLine(İndexSibopAylinDahiliye2 + "- " + i +":00");                            
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Aylin Gören|"+ SaatlerSibopAylinDahiliye[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);  

                        break;
                    case 3:
                        string [] SibopBarişDahiliye;
                        List<string> DoluSaatlerSibopBarişDahiliye = new List<string>();
                        Dictionary<int,string> SaatlerSibopBarişDahiliye = new Dictionary<int, string>();
                        int İndexSibopBarişDahiliye3    = 0;
                        foreach (string randevular in hastane)
                        {
                            SibopBarişDahiliye = randevular.Split('|');
                            if(SibopBarişDahiliye.ElementAt(0) == "Bariş Uçar")
                            {
                            DoluSaatlerSibopBarişDahiliye.Add(SibopBarişDahiliye.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerSibopBarişDahiliye.Contains(i+":00"))
                            {
                            İndexSibopBarişDahiliye3++;
                            SaatlerSibopBarişDahiliye.Add(İndexSibopBarişDahiliye3 , i + ":00");
                            Console.WriteLine(İndexSibopBarişDahiliye3 + "- " + i +":00");                            
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Bariş Uçar|"+ SaatlerSibopBarişDahiliye[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);

                        break;
                    
                }
                break;
            case 8:

                Console.Clear();
                Console.WriteLine("1. Prof. Dr. Melex Kideyş");
                Console.WriteLine("2. Emir Soydan");
                Console.WriteLine("3. Kübra Yücel");
                Console.WriteLine("İstediginiz Fizyoloji Doktoru:");
                int sibop8 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (sibop8)
                {
                    case 1:
                        string [] SibopMelexFizyoloji;
                        List<string> DoluSaatlerSibopMelexFizyoloji = new List<string>();
                        Dictionary<int,string> SaatlerSibopMelexFizyoloji = new Dictionary<int, string>();
                        int İndexSibopMelexFizyoloji1    = 0;
                        foreach (string randevular in hastane)
                        {
                            SibopMelexFizyoloji = randevular.Split('|');
                            if(SibopMelexFizyoloji.ElementAt(0) == "Prof. Dr. Melex Kideyş")
                            {
                            DoluSaatlerSibopMelexFizyoloji.Add(SibopMelexFizyoloji.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerSibopMelexFizyoloji.Contains(i+":00"))
                            {
                            İndexSibopMelexFizyoloji1++;
                            SaatlerSibopMelexFizyoloji.Add(İndexSibopMelexFizyoloji1 , i + ":00");
                            Console.WriteLine(İndexSibopMelexFizyoloji1 + "- " + i +":00");                            
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Prof. Dr. Melex Kideyş|"+ SaatlerSibopMelexFizyoloji[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);      

                        break;
                    case 2:
                        string [] SibopEmirFizyoloji;
                        List<string> DoluSaatlerSibopEmirFizyoloji = new List<string>();
                        Dictionary<int,string> SaatlerSibopEmirFizyoloji = new Dictionary<int, string>();
                        int İndexSibopEmirFizyoloji2    = 0;
                        foreach (string randevular in hastane)
                        {
                            SibopEmirFizyoloji = randevular.Split('|');
                            if(SibopEmirFizyoloji.ElementAt(0) == "Emir Soydan")
                            {
                            DoluSaatlerSibopEmirFizyoloji.Add(SibopEmirFizyoloji.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerSibopEmirFizyoloji.Contains(i+":00"))
                            {
                            İndexSibopEmirFizyoloji2++;
                            SaatlerSibopEmirFizyoloji.Add(İndexSibopEmirFizyoloji2 , i + ":00");
                            Console.WriteLine(İndexSibopEmirFizyoloji2 + "- " + i +":00");                            
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Emir Soydan|"+ SaatlerSibopEmirFizyoloji[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane); 

                        break;
                    case 3:
                        string [] SibopKübraFizyoloji;
                        List<string> DoluSaatlerSibopKübraFizyoloji = new List<string>();
                        Dictionary<int,string> SaatlerSibopKübraFizyoloji = new Dictionary<int, string>();
                        int İndexSibopKübraFizyoloji3    = 0;
                        foreach (string randevular in hastane)
                        {
                            SibopKübraFizyoloji = randevular.Split('|');
                            if(SibopKübraFizyoloji.ElementAt(0) == "Kübra Yücel")
                            {
                            DoluSaatlerSibopKübraFizyoloji.Add(SibopKübraFizyoloji.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerSibopKübraFizyoloji.Contains(i+":00"))
                            {
                            İndexSibopKübraFizyoloji3++;
                            SaatlerSibopKübraFizyoloji.Add(İndexSibopKübraFizyoloji3 , i + ":00");
                            Console.WriteLine(İndexSibopKübraFizyoloji3 + "- " + i +":00");                            
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Kübra Yücel|"+ SaatlerSibopKübraFizyoloji[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane); 

                        break;
                }    
                break;
            case 9:
                
                Console.Clear();
                Console.WriteLine("1. Prof. Dr. Dedeskus");
                Console.WriteLine("2. Esra Kalkan");
                Console.WriteLine("3. Rüzgar Bilir");
                Console.WriteLine("İstediginiz Genel Cerrahi Doktoru:");
                int sibop9 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (sibop9)
                {
                    case 1:
                        string [] SibopDedeGenelCerrahi;
                        List<string> DoluSaatlerSibopDedeGenelCerrahi = new List<string>();
                        Dictionary<int,string> SaatlerSibopDedeGenelCerrahi = new Dictionary<int, string>();
                        int İndexSibopDedeGenelCerrahi1    = 0;
                        foreach (string randevular in hastane)
                        {
                            SibopDedeGenelCerrahi = randevular.Split('|');
                            if(SibopDedeGenelCerrahi.ElementAt(0) == "Prof. Dr. Dedeskus")
                            {
                            DoluSaatlerSibopDedeGenelCerrahi.Add(SibopDedeGenelCerrahi.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerSibopDedeGenelCerrahi.Contains(i+":00"))
                            {
                            İndexSibopDedeGenelCerrahi1++;
                            SaatlerSibopDedeGenelCerrahi.Add(İndexSibopDedeGenelCerrahi1 , i + ":00");
                            Console.WriteLine(İndexSibopDedeGenelCerrahi1 + "- " + i +":00");                            
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Prof. Dr. Dedeskus|"+ SaatlerSibopDedeGenelCerrahi[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);    

                        break;
                    case 2:
                        string [] SibopEsraGenelCerrahi;
                        List<string> DoluSaatlerSibopEsraGenelCerrahi = new List<string>();
                        Dictionary<int,string> SaatlerSibopEsraGenelCerrahi = new Dictionary<int, string>();
                        int İndexSibopEsraGenelCerrahi2    = 0;
                        foreach (string randevular in hastane)
                        {
                            SibopEsraGenelCerrahi = randevular.Split('|');
                            if(SibopEsraGenelCerrahi.ElementAt(0) == "Esra Kalkan")
                            {
                            DoluSaatlerSibopEsraGenelCerrahi.Add(SibopEsraGenelCerrahi.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerSibopEsraGenelCerrahi.Contains(i+":00"))
                            {
                            İndexSibopEsraGenelCerrahi2++;
                            SaatlerSibopEsraGenelCerrahi.Add(İndexSibopEsraGenelCerrahi2 , i + ":00");
                            Console.WriteLine(İndexSibopEsraGenelCerrahi2 + "- " + i +":00");                            
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Esra Kalkan|"+ SaatlerSibopEsraGenelCerrahi[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);    

                        break;
                    case 3:
                        string [] SibopRüzgarGenelCerrahi;
                        List<string> DoluSaatlerSibopRüzgarGenelCerrahi = new List<string>();
                        Dictionary<int,string> SaatlerSibopRüzgarGenelCerrahi = new Dictionary<int, string>();
                        int İndexSibopRüzgarGenelCerrahi3    = 0;
                        foreach (string randevular in hastane)
                        {
                            SibopRüzgarGenelCerrahi = randevular.Split('|');
                            if(SibopRüzgarGenelCerrahi.ElementAt(0) == "Rüzgar Bilir")
                            {
                            DoluSaatlerSibopRüzgarGenelCerrahi.Add(SibopRüzgarGenelCerrahi.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerSibopRüzgarGenelCerrahi.Contains(i+":00"))
                            {
                            İndexSibopRüzgarGenelCerrahi3++;
                            SaatlerSibopRüzgarGenelCerrahi.Add(İndexSibopRüzgarGenelCerrahi3 , i + ":00");
                            Console.WriteLine(İndexSibopRüzgarGenelCerrahi3 + "- " + i +":00");                            
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Rüzgar Bilir|"+ SaatlerSibopRüzgarGenelCerrahi[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);    

                        break;
                    
                }
                break;    
            case 10:
                
                Console.Clear();
                Console.WriteLine("1. Prof. Dr. Paşa");
                Console.WriteLine("2. Nehir Şeker");
                Console.WriteLine("3. Doğukan Ateş");
                Console.WriteLine("İstediginiz Göz Hastaliklari Doktoru:");
                int sibop10 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (sibop10)
                {
                    case 1:
                        string [] SibopPaşaGöz;
                        List<string> DoluSaatlerSibopPaşaGöz = new List<string>();
                        Dictionary<int,string> SaatlerSibopPaşaGöz = new Dictionary<int, string>();
                        int İndexSibopPaşaGöz1    = 0;
                        foreach (string randevular in hastane)
                        {
                            SibopPaşaGöz = randevular.Split('|');
                            if(SibopPaşaGöz.ElementAt(0) == "Prof. Dr. Dedeskus")
                            {
                            DoluSaatlerSibopPaşaGöz.Add(SibopPaşaGöz.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerSibopPaşaGöz.Contains(i+":00"))
                            {
                            İndexSibopPaşaGöz1++;
                            SaatlerSibopPaşaGöz.Add(İndexSibopPaşaGöz1 , i + ":00");
                            Console.WriteLine(İndexSibopPaşaGöz1 + "- " + i +":00");                            
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Prof. Dr. Dedeskus|"+ SaatlerSibopPaşaGöz[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);      

                        break;
                    case 2:
                        string [] SibopNehirGöz;
                        List<string> DoluSaatlerSibopNehirGöz = new List<string>();
                        Dictionary<int,string> SaatlerSibopNehirGöz = new Dictionary<int, string>();
                        int İndexSibopNehirGöz2    = 0;
                        foreach (string randevular in hastane)
                        {
                            SibopNehirGöz = randevular.Split('|');
                            if(SibopNehirGöz.ElementAt(0) == "Nehir Şeker")
                            {
                            DoluSaatlerSibopNehirGöz.Add(SibopNehirGöz.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerSibopNehirGöz.Contains(i+":00"))
                            {
                            İndexSibopNehirGöz2++;
                            SaatlerSibopNehirGöz.Add(İndexSibopNehirGöz2 , i + ":00");
                            Console.WriteLine(İndexSibopNehirGöz2 + "- " + i +":00");                            
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Nehir Şeker|"+ SaatlerSibopNehirGöz[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);  

                        break;
                    case 3:
                        string [] SibopDogukanGöz;
                        List<string> DoluSaatlerSibopDogukanGöz = new List<string>();
                        Dictionary<int,string> SaatlerSibopDogukanGöz = new Dictionary<int, string>();
                        int İndexSibopDogukanGöz3    = 0;
                        foreach (string randevular in hastane)
                        {
                            SibopDogukanGöz = randevular.Split('|');
                            if(SibopDogukanGöz.ElementAt(0) == "Doğukan Ateş")
                            {
                            DoluSaatlerSibopDogukanGöz.Add(SibopDogukanGöz.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerSibopDogukanGöz.Contains(i+":00"))
                            {
                            İndexSibopDogukanGöz3++;
                            SaatlerSibopDogukanGöz.Add(İndexSibopDogukanGöz3 , i + ":00");
                            Console.WriteLine(İndexSibopDogukanGöz3 + "- " + i +":00");                            
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Doğukan Ateş|"+ SaatlerSibopDogukanGöz[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);  

                        break;
                    
                }
                break; 
            case 11:
                Console.Clear();
                Console.WriteLine("1. Prof. Dr. Ayşe Kideyş");
                Console.WriteLine("2. Hira Uyanik");
                Console.WriteLine("3. Alper Dinler");
                Console.WriteLine("İstediginiz Kulak Burun Bogaz Doktoru:");
                int sibop11 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (sibop11)
                {
                    case 1:
                        string [] SibopAyşeKBB;
                        List<string> DoluSaatlerSibopAyşeKBB = new List<string>();
                        Dictionary<int,string> SaatlerSibopAyşeKBB = new Dictionary<int, string>();
                        int İndexSibopAyşeKBB1    = 0;
                        foreach (string randevular in hastane)
                        {
                            SibopAyşeKBB = randevular.Split('|');
                            if(SibopAyşeKBB.ElementAt(0) == "Prof. Dr. Ayşe Kideyş")
                            {
                            DoluSaatlerSibopAyşeKBB.Add(SibopAyşeKBB.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerSibopAyşeKBB.Contains(i+":00"))
                            {
                            İndexSibopAyşeKBB1++;
                            SaatlerSibopAyşeKBB.Add(İndexSibopAyşeKBB1 , i + ":00");
                            Console.WriteLine(İndexSibopAyşeKBB1 + "- " + i +":00");                            
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Prof. Dr. Ayşe Kideyş|"+ SaatlerSibopAyşeKBB[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);      

                        break;
                    case 2:
                        string [] SibopHiraKBB;
                        List<string> DoluSaatlerSibopHiraKBB = new List<string>();
                        Dictionary<int,string> SaatlerSibopHiraKBB = new Dictionary<int, string>();
                        int İndexSibopHiraKBB2    = 0;
                        foreach (string randevular in hastane)
                        {
                            SibopHiraKBB = randevular.Split('|');
                            if(SibopHiraKBB.ElementAt(0) == "Hira Uyanik")
                            {
                            DoluSaatlerSibopHiraKBB.Add(SibopHiraKBB.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerSibopHiraKBB.Contains(i+":00"))
                            {
                            İndexSibopHiraKBB2++;
                            SaatlerSibopHiraKBB.Add(İndexSibopHiraKBB2 , i + ":00");
                            Console.WriteLine(İndexSibopHiraKBB2 + "- " + i +":00");                            
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Hira Uyanik|"+ SaatlerSibopHiraKBB[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);

                        break;
                    case 3:
                        string [] SibopAlperKBB;
                        List<string> DoluSaatlerSibopAlperKBB = new List<string>();
                        Dictionary<int,string> SaatlerSibopAlperKBB = new Dictionary<int, string>();
                        int İndexSibopAlperKBB3    = 0;
                        foreach (string randevular in hastane)
                        {
                            SibopAlperKBB = randevular.Split('|');
                            if(SibopAlperKBB.ElementAt(0) == "Alper Dinler")
                            {
                            DoluSaatlerSibopAlperKBB.Add(SibopAlperKBB.ElementAt(1));
                            }
                        }   
                        for (int i = 9; i < 18; i++)
                        {
                            if(!DoluSaatlerSibopAlperKBB.Contains(i+":00"))
                            {
                            İndexSibopAlperKBB3++;
                            SaatlerSibopAlperKBB.Add(İndexSibopAlperKBB3 , i + ":00");
                            Console.WriteLine(İndexSibopAlperKBB3 + "- " + i +":00");                            
                            }
                        }
                            Console.WriteLine("Almak istediğiniz randevu saatini seçiniz:");
                            hastane.Add("Alper Dinler|"+ SaatlerSibopAlperKBB[Convert.ToInt32(Console.ReadLine())]); 
                            File.WriteAllLines(randevu,hastane);

                        break;
                    
                }
                break;         
        }
        break;
}
Console.Clear();   
Console.WriteLine("________________________________█████_____█████");
Console.WriteLine("______İYİ GÜNLER DİLERİZ 8)____███____██_██_____███");
Console.WriteLine("_____________________________██________██__________██");
Console.WriteLine("____________________________██__________█____________██");
Console.WriteLine("________██████____________██________________________██");
Console.WriteLine("_____███████████________██________________________██");
Console.WriteLine("____█████████████_______██_______________________██");
Console.WriteLine("___███████████████______██______________________██");
Console.WriteLine("___████████████████______██___________________██");
Console.WriteLine("___████████████████_______██_________________██");
Console.WriteLine("____███████████████_______███_______________██");
Console.WriteLine("_______███████████_______██__██_____________██");
Console.WriteLine("_______███████████_______██__██_____________██");
Console.WriteLine("___________███████______████___██__________██");
Console.WriteLine("____██████__██████████████_____██_____██");
Console.WriteLine("__██████████████████████________██__██");
Console.WriteLine("_████████████████████_____________████");
Console.WriteLine("██_█████_████████████_______________█");
Console.WriteLine("█__█_██__████████████");
Console.WriteLine("_____█__████████████");
Console.WriteLine("_______█████████████");
Console.WriteLine("_______██████████████");
Console.WriteLine("________███████████████");
Console.WriteLine("_______███████__████████");
Console.WriteLine("______███████_____███████");
Console.WriteLine("____█████████________██████");










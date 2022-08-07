internal class Program
{
    private static void Main(string[] args)
    {
        //dizi tanımlama
        string[] renkler=new string[5];
        string[] hayvanlar={"kedi", "köpek", "kuş", "maymun"};
        int[] dizi;
        dizi=new int[5];
        renkler[0]="mavi";
        dizi[3]=10;
        Console.WriteLine(hayvanlar[0]);
        Console.WriteLine(dizi[3]);
        Console.WriteLine(renkler[0]);
        
        //döngülerle dizi kullanımı
        Console.Write("Lütfen dizinin eleman sayısını giriniz");
        int diziUzunlugu=int.Parse(Console.ReadLine());
        int[] sayiDizisi=new int[diziUzunlugu];
        for(int i=0; i<diziUzunlugu; i++)
        {
            Console.Write("Lütfen {0}. sayıyı giriniz", i+1);
            sayiDizisi[i]=int.Parse(Console.ReadLine());
        }
        int toplam=0;
        foreach(var sayi in sayiDizisi)
        {
            toplam+=sayi;
        }
        Console.WriteLine("Ortalama :" + toplam/diziUzunlugu);
    }
}
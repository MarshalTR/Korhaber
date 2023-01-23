using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Haberler.Any())
            {
                context.Haberler.AddRange(
                    new Haber
                    {
                        Baslik = "Dolar/TL 2023'te Rekor Tazeledi!",
                        Metin = "Dolar, ABD enflasyon verisi sonrasında Fed'in parasal sıkılaştırmanın dozunu artıracağına dair beklentilerle güçlenirken dolar/TL yükselişini sürdürerek rekor tazeledi. Yurtiçinde yoğun dış borç takvimi de dolara olan talebi artıran faktörler arasında yer alıyor.",
                        Kategori = "Ekonomi",
                        ResimYolu = "https://trthaberstatic.cdn.wp.trt.com.tr/resimler/1536000/dolardoviz-1537318.jpg"
                    },
                    new Haber
                    {
                        Baslik = "ABD: Rusya'yı Ukrayna'dan bu yıl çıkarmak zor",
                        Metin = "ABD Genelkurmay Başkanı Mark Milley, 24 Şubat 2022'den beri devam eden Rusya-Ukrayna Savaşı'nın bu yıl da sürmesini beklediklerini bildirdi. Milley, \"Tabii ki Rusya'yı işgal ettiği topraklardan çıkarmak imkansız değil ama öncelik cepheleri istikrarlı bir şekilde savunmak\" açıklamasını yaptı.",
                        Kategori = "Dünya",
                        ResimYolu = "https://www.ankasam.org/wp-content/uploads/2022/07/Untitled-design-5-1920x1080.png"
                    },
                    new Haber
                    {
                        Baslik = "Deyrizor'da Halk Rerör Örgütü PKK/YPG'yi Protesto Etti",
                        Metin = "Suriye'nin doğusundaki Deyrizor ilinde terör örgütü PKK/YPG işgalindeki bölgelerde yaşayan Araplar, kötüleşen yaşam koşulları ve bölgede giderek yaygınlaşan yolsuzluğu protesto etti.",
                        Kategori = "Dünya",
                        ResimYolu = "https://i20.haber7.net/resize/1280x720//haber/haber7/photos/2019/38/deyrizorda_esed_gucleri_ile_pkkypg_arasinda_gerginlik_1569059427_5579.jpg"
                    },
                    new Haber
                    {
                        Baslik = "Beşiktaş'ın yeni transferi Vincent Aboubakar İstanbul'a geldi!",
                        Metin = "Cuma günü saat 22.00'de İstanbul'a gelmesi beklenen Aboubakar, Al-Nassr'ın belge göndermemesi nedeniyle seyahat engeliyle karşılaşmıştı. Yıldız futbolcu, evrak sorununun çözülmesi sonrası İstanbul'a ayak bastı.",
                        Kategori = "Spor",
                        ResimYolu = "https://trthaberstatic.cdn.wp.trt.com.tr/resimler/1536000/dolardoviz-1537318.jpg"
                    },
                    new Haber
                    {
                        Baslik = "NASA yaşama elverişli bir gezegen keşfetti",
                        Metin = "NASA, dünyadan 100 ışık yılı mesafede yaşama elverişli bir gezegen keşfetti. NASA araştırmacısı Emily Gilbert, \"Bu, bildiğimiz çoklu, küçük, yaşanabilir bölge gezegenlerine sahip birkaç sistemden biridir.\" açıklamasında bulundu.",
                        Kategori = "Dünya",
                        ResimYolu = "https://www.newsnationnow.com/wp-content/uploads/sites/108/2023/01/700D.jpg?strip=1"
                    },
                    new Haber
                    {
                        Baslik = "Galatasaray, Antalyaspor karşısında hata yapmadı",
                        Metin = "Spor Toto Süper Lig'in 20. haftasında Galatasaray, Fraport TAV Antalyaspor'u konuk etti. Sarı kırmızılılar, Antalyaspor karşısında hata yapmadı. Maç 2-1 Galatasaray'ın üstünlüğüyle sona erdi.",
                        Kategori = "Spor",
                        ResimYolu = "https://img.superhaber.tv/storage/files/images/2023/01/21/633x358-galatasaray-2-1-antalyas-wnW4_cover.jpg"
                    }
                    

                    );
                context.SaveChanges();
            }
        }
    }
}

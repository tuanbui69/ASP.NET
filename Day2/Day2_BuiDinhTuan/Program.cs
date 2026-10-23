namespace Day2_BuiDinhTuan
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthorization();

            app.MapStaticAssets();

            // 1. DEMO CONVENTIONAL ROUTING:
            app.MapControllerRoute(
                name: "custom_welcome",
                pattern: "chao-mung/{name}/{id:int?}",
                defaults: new { controller = "Hello", action = "Welcome" });

            app.MapControllerRoute(
                name: "gioi_thieu",
                pattern: "gioi-thieu",
                defaults: new { controller = "Home", action = "Privacy" });

            // 2. CONVENTIONAL ROUTING MẶC ĐỊNH (Default):
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();

            app.Run();
        }
    }
}

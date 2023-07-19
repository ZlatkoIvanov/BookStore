namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder    = WebApplication.CreateBuilder(args);
            // Add
            // Add services to the container.
<<<<<<< HEAD


=======
            //build
>>>>>>> f68cb63bf8adb2686c864fb3e5818cf772f71aee
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
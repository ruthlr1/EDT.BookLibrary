using EDT.AuthorLibrary.Application.Features.Authors;
using EDT.BookLibrary.Application.Features.Books;
using EDT.BookLibrary.Persistence.Repo;
using EDT.GenreLibrary.Application.Features.Genres;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace EDT.BookLibrary.API
{
    public static class Registry
    {
        public static void RegisterContext(WebApplicationBuilder builder)
        {
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
            builder.Services.AddDbContext<LibraryContext>(options => options.UseSqlServer(connectionString), ServiceLifetime.Transient);
        }


        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped(typeof(IBookService), typeof(BookService));
            services.AddScoped(typeof(IAuthorService), typeof(AuthorService));
            services.AddScoped(typeof(IGenreService), typeof(GenreService));
        }
    }
}

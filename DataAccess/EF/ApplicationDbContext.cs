using DataAccess.Booking;
using DataAccess.Image;
using DataAccess.Workspace;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccess.EF;

public class ApplicationDbContext : DbContext
{
    public DbSet<WorkspaceDao> Workspaces { get; set; }
    public DbSet<BookingDao> Bookings { get; set; }
    public DbSet<ImageDao> Images { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<WorkspaceDao>().ToTable("Workspaces");
        modelBuilder.Entity<ImageDao>().ToTable("Images");
        modelBuilder.Entity<BookingDao>().ToTable("Bookings");

        modelBuilder.Entity<WorkspaceDao>()
            .Property(d => d.Type)
            .HasConversion(new EnumToStringConverter<WorkspaceType>());

        modelBuilder.Entity<WorkspaceDao>()
            .HasData(
                new WorkspaceDao { Id = 1, Capacity = 10, Type = WorkspaceType.OpenSpace },
                new WorkspaceDao { Id = 2, Capacity = 5, Type = WorkspaceType.PrivateRoom },
                new WorkspaceDao { Id = 3, Capacity = 20, Type = WorkspaceType.MeetingRoom }
            );

        modelBuilder.Entity<ImageDao>()
            .HasData(
                new ImageDao { Id = 1, Url = "https://cdn-jdbmd.nitrocdn.com/yEMHtyTSADNOgebFqynalakIQNihDGqu/assets/images/optimized/rev-80fa023/www.officernd.com/wp-content/uploads/2024/07/word-image-34624-2", WorkspaceId = 1 },
                new ImageDao { Id = 2, Url = "https://content.instantoffices.com/sc/Prod/images/centres/1600width/47176/47176-428809", WorkspaceId = 2 },
                new ImageDao { Id = 3, Url = "https://aticco.com/wp-content/uploads/2024/07/que-es-coworking-1", WorkspaceId = 3 },
                new ImageDao { Id = 4, Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRwO67LL1AF8SOl89ImJauhzQWmX9zcT5x30A&s", WorkspaceId = 1 },
                new ImageDao { Id = 5, Url = "https://spaces-wp.imgix.net/2018/08/LochrinSquare_839x474.png?auto=compress,format&q=50", WorkspaceId = 2 },
                new ImageDao { Id = 6, Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS8MYQytEm9aEhoY58aEibJAo8Uh8xvgGBSAw&s", WorkspaceId = 3 },
                new ImageDao { Id = 7, Url = "https://coworkingmag.com/wp-content/uploads/sites/76/2018/01/a-tech-stop-hang-out-room.jpg", WorkspaceId = 1 },
                new ImageDao { Id = 8, Url = "https://s5.cdn.ventureburn.com/wp-content/uploads/sites/2/2022/12/1-10.jpg", WorkspaceId = 2 },
                new ImageDao { Id = 9, Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQO8ytvVSigHK0MXeck4XYOPurAdJqTpfeH7w&s", WorkspaceId = 3 }
            );

        base.OnModelCreating(modelBuilder);
    }
}

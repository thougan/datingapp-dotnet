using System;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class DataContext(DbContextOptions options) : DbContext(options)
{
    internal object id;

    //اسم الجدول في قاعده البيانات 
    // بحاجه الى تسحيلها !!  
    public DbSet<AppUser> User { get; set; }
}

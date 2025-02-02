using System;

namespace API.Entities;

public class AppUser
{ 
    //the primery key in our data base
    //تلقائيا راح يعرف انه عداد تلقائي ويزيد واحد على كل عنصر جديد 
    
public int Id { get; set; }
public required string UserName { get; set; }
}

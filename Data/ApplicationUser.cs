using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.StaticFiles;

namespace Shlykovich.Data
{
    public class ApplicationUser:IdentityUser
    {
        public byte[] Avatar { get; set; }    
    }
    public class FileExtensionContentTypeProvider 
    {
      var extProvider = new FileExtensionContentTypeProvider();
      var MimeType = extProvider.Mappings[".png"];
    
    }




    

}

using AlısverisSepetiMvc.Models.Dto;
using Microsoft.AspNetCore.Http;

namespace AlısverisSepetiMvc.Shared
{
    public static class ImageUpload
    {
        public static async Task<ImageUploadDto> ImageUploadExtensions(IFormFile formFile)
        {
            var extensions = Path.GetExtension(formFile.FileName);
            var filename = Guid.NewGuid().ToString() + extensions;
            var combine = Path.Combine(EnvorinmentClass._environment.WebRootPath+"/image/", filename);

            using(var file = new FileStream(combine,FileMode.Create)) 
            {
                await formFile.CopyToAsync(file);            
            }


            return new ImageUploadDto
            {
                Name = filename,
                Path = combine,
                Size = formFile.Length
            };
        }
    }
}

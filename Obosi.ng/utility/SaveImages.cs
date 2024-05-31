namespace Obosi.ng.Presentation.utility
{
    public static class SaveImages
    {
        //private static readonly IHostEnvironment _hostingEnvironment;
      
        public static async Task<string> SaveImage(IFormFile file, IHostEnvironment _hostingEnvironment)
        {
            var directory = Path.Combine("Images", "Pictures");
            var filePath = Path.Combine(_hostingEnvironment.ContentRootPath, directory);
            var noteUrl = string.Empty;
            string givenFileName = Guid.NewGuid().ToString();
           //Define allowed property of the uploaded file

           var validFileSize = 5 * (20 * (1024 * 1024));//1mb
            List<string> validFileExtension = new List<string>();

            validFileExtension.Add(".jpg");
            validFileExtension.Add(".png");
            validFileExtension.Add(".jpeg");
            validFileExtension.Add(".pdf");
            validFileExtension.Add(".PDF");
            validFileExtension.Add(".JPG");
            validFileExtension.Add(".PNG");
            validFileExtension.Add(".JPEG");



            if (file?.Length > 0)
            {

                var extType = Path.GetExtension(file.FileName);
                var fileSize = file.Length;
                if (fileSize <= validFileSize)
                {

                    if (validFileExtension.Contains(extType))
                    {
                        string fileName = string.Format("{0}{1}", givenFileName + "_" + DateTime.Now.Millisecond, extType);
                        //create file path if it doesnt exist
                        if (!Directory.Exists(filePath))
                        {
                            Directory.CreateDirectory(filePath);
                        }
                        var fullPath = Path.Combine(filePath, fileName);
                        noteUrl = Path.Combine(directory, fileName);
                        //Delete if file exist
                        FileInfo fileExists = new FileInfo(fullPath);
                        if (fileExists.Exists)
                        {
                            fileExists.Delete();
                        }

                        using (var stream = new FileStream(fullPath, FileMode.Create))
                        {
                            await file.CopyToAsync(stream);
                        }

                        return noteUrl = noteUrl.Replace('\\', '/');
                    }
                    else
                    {
                        // throw new BadImageFormatException("Invalid file type...Accepted formats are jpg,png,gif");
                    }
                }
            }
            return noteUrl;
        }
        public static async Task<List<string>> SavePostImages(List<IFormFile> files, IHostEnvironment _hostingEnvironment)
        {
            List<string> Images = new List<string>();
            if (files != null)
            {
                foreach (var file in files)
                {
                    var directory = Path.Combine("Images", "PostPictures");
                    var filePath = Path.Combine(_hostingEnvironment.ContentRootPath, directory);
                    var noteUrl = string.Empty;
                    string givenFileName = Guid.NewGuid().ToString();
                    //Define allowed property of the uploaded file

                    var validFileSize = 5 * (1024 * 1024);//5mb
                    List<string> validFileExtension = new List<string>();

                    validFileExtension.Add(".jpg");
                    validFileExtension.Add(".png");
                    validFileExtension.Add(".jpeg");
                    validFileExtension.Add(".pdf");
                    validFileExtension.Add(".PDF");
                    validFileExtension.Add(".JPG");
                    validFileExtension.Add(".PNG");
                    validFileExtension.Add(".JPEG");



                    if (file?.Length > 0)
                    {

                        var extType = Path.GetExtension(file.FileName);
                        var fileSize = file.Length;
                        if (fileSize <= validFileSize)
                        {

                            if (validFileExtension.Contains(extType))
                            {
                                string fileName = string.Format("{0}{1}", givenFileName + "_" + DateTime.Now.Millisecond, extType);
                                //create file path if it doesnt exist
                                if (!Directory.Exists(filePath))
                                {
                                    Directory.CreateDirectory(filePath);
                                }
                                var fullPath = Path.Combine(filePath, fileName);
                                noteUrl = Path.Combine(directory, fileName);
                                //Delete if file exist
                                FileInfo fileExists = new FileInfo(fullPath);
                                if (fileExists.Exists)
                                {
                                    fileExists.Delete();
                                }

                                using (var stream = new FileStream(fullPath, FileMode.Create))
                                {
                                    await file.CopyToAsync(stream);
                                }

                                Images.Add(noteUrl.Replace('\\', '/'));
                            }
                            else
                            {
                                // throw new BadImageFormatException("Invalid file type...Accepted formats are jpg,png,gif");
                            }
                        }
                    }

                }
                return Images;
            }
            return null;
        }

        public static async Task<string> SavePostVideo(IFormFile file, IHostEnvironment _hostingEnvironment)
        {
            var directory = Path.Combine("Images", "PostVideos");
            var filePath = Path.Combine(_hostingEnvironment.ContentRootPath, directory);
            var noteUrl = string.Empty;
            string givenFileName = Guid.NewGuid().ToString();
            //Define allowed property of the uploaded file

            var validFileSize = 5*10 * (1024 * 1024);//50mb
            List<string> validFileExtension = new List<string>();

            validFileExtension.Add(".mp4");
            validFileExtension.Add(".3gp");
           


            if (file?.Length > 0)
            {

                var extType = Path.GetExtension(file.FileName);
                var fileSize = file.Length;
                if (fileSize <= validFileSize)
                {

                    if (validFileExtension.Contains(extType))
                    {
                        string fileName = string.Format("{0}{1}", givenFileName + "_" + DateTime.Now.Millisecond, extType);
                        //create file path if it doesnt exist
                        if (!Directory.Exists(filePath))
                        {
                            Directory.CreateDirectory(filePath);
                        }
                        var fullPath = Path.Combine(filePath, fileName);
                        noteUrl = Path.Combine(directory, fileName);
                        //Delete if file exist
                        FileInfo fileExists = new FileInfo(fullPath);
                        if (fileExists.Exists)
                        {
                            fileExists.Delete();
                        }

                        using (var stream = new FileStream(fullPath, FileMode.Create))
                        {
                            await file.CopyToAsync(stream);
                        }

                        return noteUrl = noteUrl.Replace('\\', '/');
                    }
                    else
                    {
                        // throw new BadImageFormatException("Invalid file type...Accepted formats are jpg,png,gif");
                    }
                }
            }
            return noteUrl;
        }

    }
}

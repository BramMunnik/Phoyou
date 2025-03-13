using Firebase.Storage;
using System.IO;
using System.Threading.Tasks;

namespace Phoyou.Services;

public class PhotoService
{
    private readonly FirebaseStorage _firebaseStorage;

    public PhotoService()
    {
        _firebaseStorage = new FirebaseStorage("jouw-firebase-url.appspot.com");
    }

    public async Task<string> UploadPhoto(Stream imageStream, string fileName)
    {
        var uploadTask = await _firebaseStorage
            .Child("photos")
            .Child(fileName)
            .PutAsync(imageStream);

        return uploadTask; // URL van de geüploade afbeelding
    }
}
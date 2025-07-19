using System.Security.Cryptography;
using Microsoft.AspNetCore.DataProtection;

namespace backend.Helper;

public class HashHelper(IDataProtector dataProtector)
{
    public string Hash(string input)
    {
        return dataProtector.Protect(input);   
    }

    public string GetData(string input)
    {
        return dataProtector.Unprotect(input);
    }
}
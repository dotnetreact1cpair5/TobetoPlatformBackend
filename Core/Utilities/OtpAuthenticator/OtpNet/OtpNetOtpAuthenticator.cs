using Core.Utilities.OtpAuthenticator;
using Microsoft.AspNetCore.Components.Web;
using OtpNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.OtpAuthenticator.OtpNet
{
    public class OtpNetOtpAuthenticator : IOtpAuthenticatorHelper
    {
        public Task<byte[]> AGenerateSecretKey()
        {
            byte[] key = KeyGeneration.GenerateRandomKey(28);
            string base32String = Base32Encoding.ToString(key);
            byte[] base32Bytes = Base32Encoding.ToBytes(base32String);
            return Task.FromResult(base32Bytes);

        }

        public Task<string> ConvertStringKeyToString(byte[] secretKey)
        {
            string base32String = Base32Encoding.ToString(secretKey);
            return Task.FromResult(base32String);
        }

        public Task<bool> VerifyCode(byte[] secretKey, string code)
        {
            Totp totp = new(secretKey);
            string totpCode = totp.ComputeTotp(DateTime.UtcNow);
            bool result = totpCode == code;
            return Task.FromResult(result);
        }
    }
}

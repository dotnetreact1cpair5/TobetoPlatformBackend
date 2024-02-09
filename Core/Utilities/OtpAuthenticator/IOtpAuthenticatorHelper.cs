using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.OtpAuthenticator
{
    public interface IOtpAuthenticatorHelper
    {
        public Task<byte[]> AGenerateSecretKey();
        public Task<string> ConvertStringKeyToString(byte[] secretKey);
        public Task<bool> VerifyCode(byte[] secretKey, string code);
    }
}

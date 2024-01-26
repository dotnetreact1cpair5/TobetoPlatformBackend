using Business.Abstract;
using Business.Dtos.Request;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountCertificateController : ControllerBase
    {
        IAccountCertificateService _accountCertificateService;
        public AccountCertificateController(IAccountCertificateService certificate)
        {
            _accountCertificateService = certificate;
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _accountCertificateService.GetListAccountCertificate(pageRequest);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateAccountCertificateRequest createCertificateRequest)
        {
            var result = await _accountCertificateService.Add(createCertificateRequest);
            return Ok(result);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateAccountCertificateRequest updateCertificateRequest)
        {
            var result = await _accountCertificateService.Update(updateCertificateRequest);
            return Ok(result);
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteAccountCertificateRequest deleteCertificateRequest)
        {
            var result = await _accountCertificateService.Delete(deleteCertificateRequest);
            return Ok(result);
        }
    }
}

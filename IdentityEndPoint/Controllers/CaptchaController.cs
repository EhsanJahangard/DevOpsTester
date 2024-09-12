using IdentityApplication.DTOs;
using IdentityApplication.Utilities;
using Microsoft.AspNetCore.Mvc;
using TestApplication.DTOs.Common;

namespace IdentityEndPoint.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CaptchaController : ControllerBase
{
    [HttpPost("GenerateCaptcha")]
    public async Task<ActionResult<BaseResponseDto>> GenerateCaptcha()
    {

        var res = new BaseResponseDto();

        int width = 130;
        int height = 60;
        var captchaCode = Captcha.GenerateCaptchaCode();
        var image = Captcha.GenerateCaptchaImage(width, height, captchaCode);

        res.IsSuccess = true;
        res.Data = new CaptchaDto
        {
            CaptchaImage = image.ImageToBase64(),
            CaptchaCodeEncode = PasswordHelper.EncodePasswordMd5(captchaCode)
        };
        return Ok(res);
    }
}
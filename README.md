# iMouse.WeiXin
Encapsulates WeChat-related API operations to provide a simple, easy-to-use solution.

# Notes
- 在调用接口时会自动获取AccessToken，无需手动调用 CredentialService.GetAccessTokenAsync。

# How to use
1. Add settings in your `appsettings.json`, like this:
    ```
    "WeiXinOptions": {
        "RequestTimeout": 1,
        "MaxRetryTimes": 60,
      	"Apps": [
      	    {
              "Name": "公众号",
              "AppId": "WeiXinOptions-AppId-123abc",
              "AppSecret": "WeiXinOptions-AppSecret-123abc"
            },
            {
              "Name": "小程序",
              "AppId": "WeiXinOptions-AppId-123abc",
              "AppSecret": "WeiXinOptions-AppSecret-123abc"
            }
        ]
    }
    ```

2. Add services inject in `Program.cs`:
    ```
    builder.Services.AddWeiXinServices().AddWeiXinDefaultCacheProviders();
    ...
    Or:
    builder.Services.AddWeiXinServices().AddWeiXinCacheProviders<TYouCacheProvider implement from iMouse.WeiXin.Cache.ICacheProvider>();
    ```
    And then:
    ```
    app.UseWeiXinInject();
    ```

3. Use `iMouse.WeiXin`:
    ```
    [ApiController]
    [Route("api/[controller]")]
    public class WeiXinTestController : ControllerBase
    {

        public WeiXinTestController(ICredentialService credentialService)
        {
            CredentialService = credentialService;
        }

        public ICredentialService CredentialService { get; }

        public async Task GetAccessToken()
        {
        	var appName = "公众号";
            var response = await CredentialService.GetAccessTokenAsync(appName);
            if (response != null && response.ErrCode == 0)
            {
                var accessToken = response.AccessToken;
                var expiresIn = response.ExpiresIn;

            
                // TODO: your business
            }
        }
    }
    ```

4. Project `Namespace`:
    - iMouse.WeiXin.Global  全局接口
    - iMouse.WeiXin.MiniProgram 小程序相关接口
    - iMouse.WeiXin.Offical 公众号相关接口
    - iMouse.WeiXin.OpenApi 开发Api接口
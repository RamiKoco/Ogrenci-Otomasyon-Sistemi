using Microsoft.AspNetCore.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using OOS.OgrenciOtomasyonSistemi.Blazor.Components;
using OpenIddict.Validation.AspNetCore;
using Volo.Abp.AspNetCore.Components.Web;
using Volo.Abp.AspNetCore.Components.Server.LeptonXLiteTheme;
using Volo.Abp.AspNetCore.Components.Server.LeptonXLiteTheme.Bundling;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.LeptonXLite;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.LeptonXLite.Bundling;
using Volo.Abp.Security.Claims;
using Volo.Abp.OpenIddict;

namespace OOS.OgrenciOtomasyonSistemi.Blazor;

[DependsOn(
    typeof(OgrenciOtomasyonSistemiApplicationModule),
    typeof(OgrenciOtomasyonSistemiEntityFrameworkCoreModule),
    typeof(OgrenciOtomasyonSistemiHttpApiModule),
    typeof(AbpAutofacModule),
    typeof(AbpSwashbuckleModule),
    typeof(AbpAspNetCoreSerilogModule),
    typeof(AbpAccountWebOpenIddictModule),
    typeof(AbpAspNetCoreComponentsServerLeptonXLiteThemeModule),
    typeof(AbpAspNetCoreMvcUiLeptonXLiteThemeModule),
    typeof(AbpIdentityBlazorServerModule),
    typeof(AbpTenantManagementBlazorServerModule),
    typeof(AbpSettingManagementBlazorServerModule)
   )]
public class OgrenciOtomasyonSistemiBlazorModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        var hostingEnvironment = context.Services.GetHostingEnvironment();
        var configuration = context.Services.GetConfiguration();

        context.Services.PreConfigure<AbpMvcDataAnnotationsLocalizationOptions>(options =>
        {
            options.AddAssemblyResource(
                typeof(OgrenciOtomasyonSistemiResource),
                typeof(OgrenciOtomasyonSistemiDomainModule).Assembly,
                typeof(OgrenciOtomasyonSistemiDomainSharedModule).Assembly,
                typeof(OgrenciOtomasyonSistemiApplicationModule).Assembly,
                typeof(OgrenciOtomasyonSistemiApplicationContractsModule).Assembly,
                typeof(OgrenciOtomasyonSistemiBlazorModule).Assembly
            );
        });

        PreConfigure<OpenIddictBuilder>(builder =>
        {
            builder.AddValidation(options =>
            {
                options.AddAudiences("OgrenciOtomasyonSistemi");
                options.UseLocalServer();
                options.UseAspNetCore();
            });
        });

        if (!hostingEnvironment.IsDevelopment())
        {
            PreConfigure<AbpOpenIddictAspNetCoreOptions>(options =>
            {
                options.AddDevelopmentEncryptionAndSigningCertificate = false;
            });

            PreConfigure<OpenIddictServerBuilder>(serverBuilder =>
            {
                serverBuilder.AddProductionEncryptionAndSigningCertificate("openiddict.pfx", "617a062a-0613-4c58-882f-af152be5c52b");
            });
        }

        PreConfigure<AbpAspNetCoreComponentsWebOptions>(options =>
        {
            options.IsBlazorWebApp = true;
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        var hostingEnvironment = context.Services.GetHostingEnvironment();
        var configuration = context.Services.GetConfiguration();

        // Add services to the container.
        context.Services.AddRazorComponents()
            .AddInteractiveServerComponents();

        ConfigureAuthentication(context);
        ConfigureUrls(configuration);
        ConfigureBundles();
        ConfigureAutoMapper();
        ConfigureVirtualFileSystem(hostingEnvironment);
        ConfigureSwaggerServices(context.Services);
        ConfigureAutoApiControllers();
        ConfigureBlazorise(context);
        ConfigureDevExpress(context);
        ConfigureDevExpressReport(context);
        ConfigureRouter(context);
        ConfigureMenu(context);
    }

    private void ConfigureAuthentication(ServiceConfigurationContext context)
    {
        context.Services.ForwardIdentityAuthenticationForBearer(OpenIddictValidationAspNetCoreDefaults.AuthenticationScheme);
        context.Services.Configure<AbpClaimsPrincipalFactoryOptions>(options =>
        {
            options.IsDynamicClaimsEnabled = true;
        });
    }

    private void ConfigureUrls(IConfiguration configuration)
    {
        Configure<AppUrlOptions>(options =>
        {
            options.Applications["MVC"].RootUrl = configuration["App:SelfUrl"];
            options.RedirectAllowedUrls.AddRange(configuration["App:RedirectAllowedUrls"]?.Split(',') ?? Array.Empty<string>());
        });
    }

    private void ConfigureBundles()
    {
        Configure<AbpBundlingOptions>(options =>
        {
            // MVC UI
            options.StyleBundles.Configure(
                LeptonXLiteThemeBundles.Styles.Global,
                bundle =>
                {
                    bundle.AddFiles("/global-styles.css");
                }
            );

            //BLAZOR UI
            options.StyleBundles.Configure(
                BlazorLeptonXLiteThemeBundles.Styles.Global,
                bundle =>
                {
                    //bundle.AddFiles(new BundleFile("/OOS.OgrenciOtomasyonSistemi.Blazor.styles.css", true));

                    bundle.AddFiles(new BundleFile("/css/site.css", true));
                    bundle.AddFiles(new BundleFile("/OOS.OgrenciOtomasyonSistemi.Blazor.styles.css", true));
                    bundle.AddFiles(new BundleFile("/blazor-global-styles.css"));
                    bundle.AddFiles(new BundleFile("/_content/DevExpress.Blazor.Themes/blazing-berry.bs5.min.css", true));
                    bundle.AddFiles(new BundleFile("/_content/DevExpress.Blazor.Themes/blazing-berry.bs5.css", true));
                    bundle.AddFiles(new BundleFile("/_content/DevExpress.Blazor.Reporting.Viewer/css/dx-blazor-reporting-components.css", true));
                    bundle.AddFiles(new BundleFile("/_content/OOS.OgrenciOtomasyonSistemi.Core/css/component.css", true));
                }
            );
        });
    }

    private void ConfigureVirtualFileSystem(IWebHostEnvironment hostingEnvironment)
    {
        if (hostingEnvironment.IsDevelopment())
        {
            Configure<AbpVirtualFileSystemOptions>(options =>
            {
                options.FileSets.ReplaceEmbeddedByPhysical<OgrenciOtomasyonSistemiDomainSharedModule>(Path.Combine(hostingEnvironment.ContentRootPath, $"..{Path.DirectorySeparatorChar}OOS.OgrenciOtomasyonSistemi.Domain.Shared"));
                options.FileSets.ReplaceEmbeddedByPhysical<OgrenciOtomasyonSistemiDomainModule>(Path.Combine(hostingEnvironment.ContentRootPath, $"..{Path.DirectorySeparatorChar}OOS.OgrenciOtomasyonSistemi.Domain"));
                options.FileSets.ReplaceEmbeddedByPhysical<OgrenciOtomasyonSistemiApplicationContractsModule>(Path.Combine(hostingEnvironment.ContentRootPath, $"..{Path.DirectorySeparatorChar}OOS.OgrenciOtomasyonSistemi.Application.Contracts"));
                options.FileSets.ReplaceEmbeddedByPhysical<OgrenciOtomasyonSistemiApplicationModule>(Path.Combine(hostingEnvironment.ContentRootPath, $"..{Path.DirectorySeparatorChar}OOS.OgrenciOtomasyonSistemi.Application"));
                options.FileSets.ReplaceEmbeddedByPhysical<OgrenciOtomasyonSistemiBlazorModule>(hostingEnvironment.ContentRootPath);
            });
        }
    }

    private void ConfigureSwaggerServices(IServiceCollection services)
    {
        services.AddAbpSwaggerGen(
            options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo { Title = "OgrenciOtomasyonSistemi API", Version = "v1" });
                options.DocInclusionPredicate((docName, description) => true);
                options.CustomSchemaIds(type => type.FullName);
            }
        );
    }

    private void ConfigureBlazorise(ServiceConfigurationContext context)
    {
        context.Services
            .AddBootstrap5Providers()
            .AddFontAwesomeIcons();
    }

    private void ConfigureMenu(ServiceConfigurationContext context)
    {
        Configure<AbpNavigationOptions>(options =>
        {
            options.MenuContributors.Add(new OgrenciOtomasyonSistemiMenuContributor());
        });
    }

    private void ConfigureRouter(ServiceConfigurationContext context)
    {
        Configure<AbpRouterOptions>(options =>
        {
            options.AppAssembly = typeof(OgrenciOtomasyonSistemiBlazorModule).Assembly;
        });
    }

    private void ConfigureAutoApiControllers()
    {
        Configure<AbpAspNetCoreMvcOptions>(options =>
        {
            options.ConventionalControllers.Create(typeof(OgrenciOtomasyonSistemiApplicationModule).Assembly);
        });
    }
    private void ConfigureAutoMapper()
    {
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<OgrenciOtomasyonSistemiBlazorModule>();
        });
    }

    private void ConfigureDevExpress(ServiceConfigurationContext context)
    {
        context.Services.AddDevExpressBlazor();
        context.Services.Configure<GlobalOptions>(options =>
        {
            options.BootstrapVersion = BootstrapVersion.v5;
        });
    }

    private void ConfigureDevExpressReport(ServiceConfigurationContext context)
    {
        context.Services.AddDevExpressServerSideBlazorReportViewer();
    }
    public override void OnApplicationInitialization(ApplicationInitializationContext context)
    {
        var env = context.GetEnvironment();
        var app = context.GetApplicationBuilder();

        app.UseAbpRequestLocalization();

        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
        else
        {
            app.UseExceptionHandler("/Error");
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseCorrelationId();
        app.MapAbpStaticAssets();
        app.UseRouting();
        app.UseAuthentication();
        app.UseAbpOpenIddictValidation();

        if (MultiTenancyConsts.IsEnabled)
        {
            app.UseMultiTenancy();
        }
        app.UseUnitOfWork();
        app.UseDynamicClaims();
        app.UseAntiforgery();
        app.UseAuthorization();

        app.UseSwagger();
        app.UseAbpSwaggerUI(options =>
        {
            options.SwaggerEndpoint("/swagger/v1/swagger.json", "OgrenciOtomasyonSistemi API");
        });

        app.UseConfiguredEndpoints(builder =>
        {
            builder.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode()
                .AddAdditionalAssemblies(builder.ServiceProvider.GetRequiredService<IOptions<AbpRouterOptions>>().Value.AdditionalAssemblies.ToArray());
        });
    }
}

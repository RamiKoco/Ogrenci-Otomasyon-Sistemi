
using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace OOS.OgrenciOtomasyonSistemi.Blazor
{
    [DependsOn(
        typeof(OgrenciOtomasyonSistemiApplicationModule),
        typeof(OgrenciOtomasyonSistemiEntityFrameworkCoreModule),
        typeof(OgrenciOtomasyonSistemiHttpApiModule),
        typeof(AbpAspNetCoreMvcUiBasicThemeModule),
        typeof(AbpAutofacModule),
        typeof(AbpSwashbuckleModule),
        typeof(AbpAspNetCoreAuthenticationJwtBearerModule),
        typeof(AbpAspNetCoreSerilogModule),
        typeof(AbpAccountWebIdentityServerModule),
        typeof(AbpAspNetCoreComponentsServerBasicThemeModule),
        typeof(AbpIdentityBlazorServerModule),
        typeof(AbpTenantManagementBlazorServerModule),
        typeof(AbpSettingManagementBlazorServerModule)
       )]
    public class OgrenciOtomasyonSistemiBlazorModule : AbpModule
    {
        public string MyProperty { get; set; }
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
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
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            var hostingEnvironment = context.Services.GetHostingEnvironment();
            var configuration = context.Services.GetConfiguration();
            
            ConfigureUrls(configuration);
            ConfigureBundles();
            ConfigureAuthentication(context, configuration);
            ConfigureAutoMapper();
            ConfigureVirtualFileSystem(hostingEnvironment);
            ConfigureLocalizationServices();
            ConfigureSwaggerServices(context.Services);
            ConfigureAutoApiControllers();
            ConfigureBlazorise(context);
            ConfigureRouter(context);
            ConfigureMenu(context);
            ConfigureDevExpress(context);
            ConfigureDevExpressReport(context);
            ConfigureAntiForgery();

            Configure<AbpDbContextOptions>(options =>
            {
                options.Configure<OgrenciOtomasyonSistemiDbContext>(dbContextOptions =>
                {
                    dbContextOptions.DbContextOptions.UseNpgsql(
                        configuration.GetConnectionString("Default")
                    );
                });
            });
        }

        private void ConfigureUrls(IConfiguration configuration)
        {
            Configure<AppUrlOptions>(options =>
            {
                options.Applications["MVC"].RootUrl = configuration["App:SelfUrl"];
                options.RedirectAllowedUrls.AddRange(configuration["App:RedirectAllowedUrls"].Split(','));
            });
        }

        private void ConfigureBundles()
        {
            Configure<AbpBundlingOptions>(options =>
            {
                // MVC UI
                options.StyleBundles.Configure(
                    BasicThemeBundles.Styles.Global,
                    bundle =>
                    {
                        bundle.AddFiles("/global-styles.css");
                    }
                );

                //BLAZOR UI
                options.StyleBundles.Configure(
                    BlazorBasicThemeBundles.Styles.Global,
                    bundle =>
                    {
                        bundle.AddFiles("/css/site.css");
                        //bundle.AddFiles("/css/scheduler.css");
                        bundle.AddFiles("/OOS.OgrenciOtomasyonSistemi.Blazor.styles.css");
                        bundle.AddFiles("/blazor-global-styles.css");
                        bundle.AddFiles("/_content/DevExpress.Blazor.Themes/blazing-berry.bs5.min.css");
                        bundle.AddFiles("/_content/DevExpress.Blazor.Themes/blazing-berry.bs5.css");
                        bundle.AddFiles("/_content/DevExpress.Blazor.Reporting.Viewer/css/dx-blazor-reporting-components.css");
                        bundle.AddFiles("/_content/OOS.Blazor.Core/css/component.css");

                    }
                );

                options.ScriptBundles.Configure(
                    BlazorBasicThemeBundles.Scripts.Global,
                    bundle =>
                    {
                        //Varsa js dosya yolları buraya eklenecek.
                        bundle.AddFiles("/js/javascript.js");
                    }
                );
            });
        }

        private void ConfigureAuthentication(ServiceConfigurationContext context, IConfiguration configuration)
        {
            context.Services.AddAuthentication()
                .AddJwtBearer(options =>
                {
                    options.Authority = configuration["AuthServer:Authority"];
                    options.RequireHttpsMetadata = Convert.ToBoolean(configuration["AuthServer:RequireHttpsMetadata"]);
                    options.Audience = "OgrenciOtomasyonSistemi";
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

        private void ConfigureLocalizationServices()
        {
            Configure<AbpLocalizationOptions>(options =>
            {
                options.Languages.Add(new LanguageInfo("ar", "ar", "العربية"));
                options.Languages.Add(new LanguageInfo("cs", "cs", "Čeština"));
                options.Languages.Add(new LanguageInfo("en", "en", "English"));
                options.Languages.Add(new LanguageInfo("en-GB", "en-GB", "English (UK)"));
                options.Languages.Add(new LanguageInfo("hu", "hu", "Magyar"));
                options.Languages.Add(new LanguageInfo("fi", "fi", "Finnish"));
                options.Languages.Add(new LanguageInfo("fr", "fr", "Français"));
                options.Languages.Add(new LanguageInfo("hi", "hi", "Hindi", "in"));
                options.Languages.Add(new LanguageInfo("is", "is", "Icelandic", "is"));
                options.Languages.Add(new LanguageInfo("it", "it", "Italiano", "it"));
                options.Languages.Add(new LanguageInfo("pt-BR", "pt-BR", "Português"));
                options.Languages.Add(new LanguageInfo("ro-RO", "ro-RO", "Română"));
                options.Languages.Add(new LanguageInfo("ru", "ru", "Русский"));
                options.Languages.Add(new LanguageInfo("sk", "sk", "Slovak"));
                options.Languages.Add(new LanguageInfo("tr", "tr", "Türkçe"));
                options.Languages.Add(new LanguageInfo("zh-Hans", "zh-Hans", "简体中文"));
                options.Languages.Add(new LanguageInfo("zh-Hant", "zh-Hant", "繁體中文"));
                options.Languages.Add(new LanguageInfo("de-DE", "de-DE", "Deutsch", "de"));
                options.Languages.Add(new LanguageInfo("es", "es", "Español"));
            });
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
                options.BootstrapVersion = DevExpress.Blazor.BootstrapVersion.v5;
            });
        }

        private void ConfigureDevExpressReport(ServiceConfigurationContext context)
        {
            context.Services.AddDevExpressServerSideBlazorReportViewer();
        }
        private void ConfigureAntiForgery()
        {
            Configure<AbpAntiForgeryOptions>(options =>
            {
                options.AutoValidateFilter = type => type == typeof(DownloadExportResultControllerBase);
            });
        }

        public override void OnApplicationInitialization(ApplicationInitializationContext context)
        {
            var env = context.GetEnvironment();
            var app = context.GetApplicationBuilder();

            //app.UseDevExpressServerSideBlazorReportViewer();
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
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication();
            app.UseJwtTokenMiddleware();

            if (MultiTenancyConsts.IsEnabled)
            {
                app.UseMultiTenancy();
            }

            app.UseUnitOfWork();
            app.UseIdentityServer();
            app.UseAuthorization();
            app.UseSwagger();
            app.UseAbpSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "OgrenciOtomasyonSistemi API");
            });
            app.UseConfiguredEndpoints();
        }
    }
}